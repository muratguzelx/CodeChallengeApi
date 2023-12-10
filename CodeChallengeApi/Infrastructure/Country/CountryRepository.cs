using CodeChallengeApi.Domain;
using CodeChallengeApi.Infrastructure.Base;
using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(AppDbContext context) : base(context)
        {

        }
         
        public AppDbContext CFDB
        {
            get { return _context as AppDbContext; }
        }
    }
}
