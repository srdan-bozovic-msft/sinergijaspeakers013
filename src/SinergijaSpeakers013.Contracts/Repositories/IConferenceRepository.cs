using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Repositories
{
    public interface IConferenceRepository
    {
        Task<List<Speaker>> GetSpeakersAsync();
        Task<List<Speaker>> GetSpeakersAsync(CancellationToken cancellationToken);
    }
}
