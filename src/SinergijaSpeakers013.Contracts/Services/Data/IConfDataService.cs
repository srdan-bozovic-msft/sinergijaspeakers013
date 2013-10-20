using SinergijaSpeakers013.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Services.Data
{
    public interface IConfDataService
    {
        Task<IConferenceDataModel> GetConfData();
        Task<int> GetVersion();
    }
}
