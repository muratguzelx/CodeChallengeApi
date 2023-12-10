using CodeChallengeApi.Domain;
using CodeChallengeApi.DTOs;
using CodeChallengeApi.Infrastructure.Base;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GroupController : ControllerBase
    {
        private readonly IUnitOfAdesso _unitOfAdesso;

        public GroupController(IUnitOfAdesso unitOfAdesso)
        {
            _unitOfAdesso = unitOfAdesso;
        }

        [HttpGet]
        public IEnumerable<GetGroupsDto> GetAllGroups()
        {
            var query = from a in _unitOfAdesso.Groups.GetAll()
                        select new GetGroupsDto
                        { 
                            Id = a.Id,
                            Name = a.Name, 
                        };
            return query.ToList();
        }

        [HttpGet]
        public GetGroupsDto GetGroupById(int id)
        {
            var query = from a in _unitOfAdesso.Groups.GetAll()
                        where a.Id == id
                        select new GetGroupsDto
                        { 
                            Id = a.Id,
                            Name = a.Name, 
                        };
            return query.FirstOrDefault();
        }
         
    }
}
