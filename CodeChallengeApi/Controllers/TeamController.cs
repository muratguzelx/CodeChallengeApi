using CodeChallengeApi.Domain;
using CodeChallengeApi.DTOs;
using CodeChallengeApi.Infrastructure.Base;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TeamController : ControllerBase
    {
        private readonly IUnitOfAdesso _unitOfAdesso;

        public TeamController(IUnitOfAdesso unitOfAdesso)
        {
            _unitOfAdesso = unitOfAdesso;
        }

        [HttpGet]
        public IEnumerable<GetTeamsDto> GetAllTeams()
        {
            var query = from a in _unitOfAdesso.Teams.GetAll()
                        join b in _unitOfAdesso.Countries.GetAll() on a.CountryId equals b.Id
                        select new GetTeamsDto
                        {
                            CountryId = a.CountryId,
                            Id = a.Id,
                            Name = a.Name,
                            CountryName = b.Name,
                        };
            return query.ToList();
        }

        [HttpGet]
        public GetTeamsDto GetTeamById(int id)
        {
            var query = from a in _unitOfAdesso.Teams.GetAll()
                        join b in _unitOfAdesso.Countries.GetAll() on a.CountryId equals b.Id
                        where a.Id == id
                        select new GetTeamsDto
                        {
                            CountryId = a.CountryId,
                            Id = a.Id,
                            Name = a.Name,
                            CountryName = b.Name,
                        };
            return query.FirstOrDefault();
        }

        [HttpGet]
        public IEnumerable<GetTeamsDto> GetTeamsByCountryName(string country)
        {
            var query = from a in _unitOfAdesso.Teams.GetAll()
                        join b in _unitOfAdesso.Countries.GetAll() on a.CountryId equals b.Id
                        where b.Name.Trim().ToLower() == country.Trim().ToLower()
                        select new GetTeamsDto
                        {
                            CountryId = a.CountryId,
                            Id = a.Id,
                            Name = a.Name,
                            CountryName = b.Name,
                        };
            return query.ToList();
        } 
    }
}
