using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeApi.Infrastructure.Base
{
    public interface IUnitOfAdesso : IDisposable
    {
        ICountryRepository Countries { get; }
        IGroupRepository Groups { get; }
        IGroupTeamRepository GroupTeams { get; }
        ITeamRepository Teams { get; }

        Task<int> Complete();
    }
}
