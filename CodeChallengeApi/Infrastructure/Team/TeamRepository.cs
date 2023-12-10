using CodeChallengeApi.Domain;
using CodeChallengeApi.DTOs;
using CodeChallengeApi.Infrastructure.Base;
using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(AppDbContext context) : base(context)
        {

        }
         
        public AppDbContext CFDB
        {
            get { return _context as AppDbContext; }
        }
         
    }
}
