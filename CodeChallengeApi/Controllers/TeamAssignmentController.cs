using CodeChallengeApi.Domain;
using CodeChallengeApi.DTOs;
using CodeChallengeApi.Infrastructure.Base;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CodeChallengeApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TeamAssignmentController : ControllerBase
    {
        private readonly IUnitOfAdesso _unitOfAdesso;

        public TeamAssignmentController(IUnitOfAdesso unitOfAdesso)
        {
            _unitOfAdesso = unitOfAdesso;
        }

        [HttpPost]
        public async Task CreateTeamAssignment(int groupCount, string fullName)
        {
            if (groupCount != 4 && groupCount != 8)
            {
                throw new Exception("Grup sayısı 4 veya 8 olmalıdır.");
            }

            if (fullName.Trim() == string.Empty)
            {
                throw new Exception("Ad ve soyad zorunludur.");
            }

            _unitOfAdesso.GroupTeams.RemoveRange(_unitOfAdesso.GroupTeams.GetAll());
            await _unitOfAdesso.Complete();

            // Assuming you have a list of countries and teams
            List<Country> countries = _unitOfAdesso.Countries.GetAll().ToList();
            List<Team> teams = _unitOfAdesso.Teams.GetAll().ToList();

            // Shuffle the teams randomly
            Random random = new();
            List<Team> shuffledTeams = teams.OrderBy(t => random.Next()).ToList();

            int teamPerGroup = groupCount == 4 ? 8 : 4;

            // Create groups
            int grpCnt = groupCount;
            List<List<Team>> groups = new();
            for (int i = 0; i < grpCnt; i++)
            {
                groups.Add(new List<Team>());
            }

            // Assign teams to groups ensuring each country is represented
            foreach (Country country in countries)
            {
                List<Team> countryTeams = shuffledTeams.Where(t => t.Country == country).ToList();

                for (int i = 0; i < grpCnt; i++)
                {
                    if (grpCnt == 4)
                    {
                        // Check if the country is not already represented in the group
                        if (!groups[i].Any(t => t.Country == country))
                        {
                            // Add a team from the country to the group
                            groups[i].Add(countryTeams.First());
                            countryTeams.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Team team = countryTeams.FirstOrDefault(t => !groups.Any(gt => gt.Where(x => x.CountryId == t.CountryId && x.Id == t.Id).Any()));
                        if (team != null && groups[i].Count < teamPerGroup)
                        {
                            groups[i].Add(team);
                        }
                    }
                }
            }

            for (int i = 0; i < groups.Count; i++)
            {
                for (int j = 0; j < groups[i].Count; j++)
                {

                    var e = groups[i][j];
                    _unitOfAdesso.GroupTeams.Add(new GroupTeam { GroupId = i + 1, TeamId = groups[i][j].Id, FullName = fullName });
                }
            }
            await _unitOfAdesso.Complete();

        }

        [HttpGet]
        public async Task<List<GetGroupDto>> GetGroupTeams()
        {
            var query = from a in _unitOfAdesso.GroupTeams.GetAll()
                        join b in _unitOfAdesso.Teams.GetAll() on a.TeamId equals b.Id
                        join c in _unitOfAdesso.Groups.GetAll() on a.GroupId equals c.Id
                        select new
                        {
                            Group = c.Name,
                            TeamName = b.Name
                        };

            var result = query.GroupBy(p => p.Group);

            var resultList = new List<GetGroupDto>(); ;
            foreach (var group in result)
            {
                var groupDto = new GetGroupDto
                {
                    GroupName = group.Key,
                    Teams = group.Select(item => new GetTeamDto { Name = item.TeamName }).ToList()
                };

                resultList.Add(groupDto);
            }

            return resultList;
        }


    }
}
