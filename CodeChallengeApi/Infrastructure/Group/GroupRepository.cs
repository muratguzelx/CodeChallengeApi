using CodeChallengeApi.Domain;
using CodeChallengeApi.Infrastructure.Base;
using System.Linq.Expressions;

namespace CodeChallengeApi.Infrastructure
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {

        }
         
        public AppDbContext CFDB
        {
            get { return _context as AppDbContext; }
        }
    }
}
