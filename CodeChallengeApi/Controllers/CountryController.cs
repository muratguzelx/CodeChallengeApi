using CodeChallengeApi.Domain;
using CodeChallengeApi.DTOs;
using CodeChallengeApi.Infrastructure.Base;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfAdesso _unitOfAdesso;

        public CountryController(IUnitOfAdesso unitOfAdesso)
        {
            _unitOfAdesso = unitOfAdesso;
        }

        [HttpGet]
        public IEnumerable<GetCountriesDto> GetAllCountries()
        {
            var query = from a in _unitOfAdesso.Countries.GetAll()
                        select new GetCountriesDto
                        { 
                            Id = a.Id,
                            Name = a.Name, 
                        };
            return query.ToList();
        }

        [HttpGet]
        public GetCountriesDto GetCountryById(int id)
        {
            var query = from a in _unitOfAdesso.Countries.GetAll()
                        where a.Id == id
                        select new GetCountriesDto
                        { 
                            Id = a.Id,
                            Name = a.Name, 
                        };
            return query.FirstOrDefault();
        }
         
    }
}
