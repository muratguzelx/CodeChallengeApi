using CodeChallengeApi.Domain;
using CodeChallengeApi.Infrastructure.Base;
using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure
{
    public class GroupTeamRepository : Repository<GroupTeam>, IGroupTeamRepository
    {
        public GroupTeamRepository(AppDbContext context) : base(context)
        {

        }
         
        public AppDbContext CFDB
        {
            get { return _context as AppDbContext; }
        }
    }
}
