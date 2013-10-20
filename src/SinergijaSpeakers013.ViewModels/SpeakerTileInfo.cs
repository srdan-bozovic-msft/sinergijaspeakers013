using SinergijaSpeakers013.Contracts.Models;
using SinergijaSpeakers013.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.ViewModels
{
    public class SpeakerTileInfo : ISpeakerTileInfo
    {
        public SpeakerTileInfo(ISpeaker speaker)
        {
            SpeakerId = speaker.Id;
            SpeakerName = string.Format("{0} {1}", speaker.LastName, speaker.FirstName);
            ImageUrl = speaker.PictureUrl;
        }

        public int SpeakerId
        {
            get;
            private set;
        }

        public string SpeakerName
        {
            get;
            private set;
        }

        public string ImageUrl
        {
            get;
            private set;
        }
    }
}
