using MsCampus.Win8.Shared.Contracts.Services;
using SinergijaSpeakers013.Contracts.Models;
using SinergijaSpeakers013.Contracts.Repositories;
using SinergijaSpeakers013.Contracts.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        private const string ConferenceDataKey = "conferenceData";

        private IConferenceDataService _conferenceDataService;
        private ICacheService _cacheService;

        public ConferenceRepository(
            IConferenceDataService conferenceDataService,
            ICacheService cacheService)
        {
            _conferenceDataService = conferenceDataService;
            _cacheService = cacheService;
        }
        public async Task<List<Speaker>> GetSpeakers()
        {
            var item = await _cacheService.Get<ConferenceDataModel>(ConferenceDataKey);
            if (item.HasValue)
            {
                var versionId = item.Value.Version;
                var latestVersionId = await _conferenceDataService.GetVersion();
                if (versionId >= latestVersionId)
                {
                    return item.Value.Speakers;
                }
            }
            var data = await _conferenceDataService.GetConfData();
            await _cacheService.Put(ConferenceDataKey, data);
            return data.Speakers;
        }
    }
}
