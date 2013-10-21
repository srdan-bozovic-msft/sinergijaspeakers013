using MsCampus.Win8.Shared.Contracts.Services;
using SinergijaSpeakers013.Contracts.Models;
using SinergijaSpeakers013.Contracts.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Services
{
    public class ConferenceDataService : IConferenceDataService
    {
        private const string ServiceUriString = "https://www.mssinergija.net:5567/Agenda.ashx";

        private IHttpClientService _httpClientService;
        public ConferenceDataService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<ConferenceDataModel> GetConfData()
        {
           var data = await _httpClientService.GetJson<ConferenceDataModel>(ServiceUriString + "?op=Agenda");
           foreach (var speaker in data.Speakers)
           {
               speaker.PictureUrl = string.Format("{0}/{1}", data.PicturesLocation, speaker.PictureUrl);
           }
           return data;
        }

        public async Task<int> GetVersion()
        {
            return await _httpClientService.GetJson<int>(ServiceUriString + "?op=Version");
        }
    }
}
