using CodeChallengeApi.Domain;

namespace CodeChallengeApi.Infrastructure.Base
{
    public class UnitOfAdesso : IUnitOfAdesso
    {
        private readonly AppDbContext _context;
        public UnitOfAdesso(AppDbContext context)
        {
            _context = context;
            Countries = new CountryRepository(_context);
            Groups = new GroupRepository(_context);
            GroupTeams = new GroupTeamRepository(_context);
            Teams = new TeamRepository(_context); 
        }

        public ICountryRepository Countries { get; private set; }

        public IGroupRepository Groups { get; private set; }

        public IGroupTeamRepository GroupTeams { get; private set; }

        public ITeamRepository Teams { get; private set; }
         
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
