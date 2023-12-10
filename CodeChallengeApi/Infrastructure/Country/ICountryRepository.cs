using CodeChallengeApi.Domain;
using CodeChallengeApi.Infrastructure.Base;
using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure
{
    public interface ICountryRepository : IRepository<Country>
    { 
    }
}
