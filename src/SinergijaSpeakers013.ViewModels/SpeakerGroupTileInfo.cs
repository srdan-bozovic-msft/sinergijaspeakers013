using SinergijaSpeakers013.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.ViewModels
{
    public class SpeakerGroupTileInfo : ISpeakerGroupTileInfo
    {
        public SpeakerGroupTileInfo(string groupName)
        {
            GroupName = groupName;
            Speakers = new List<ISpeakerTileInfo>();
        }
        public string GroupName
        {
            get;
            private set;
        }

        public List<ISpeakerTileInfo> Speakers
        {
            get;
            private set;
        }
    }
}
