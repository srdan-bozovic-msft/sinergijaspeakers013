using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.ViewModels
{
    public interface ISpeakerGroupTileInfo
    {
        string GroupName { get; set; }
        List<ISpeakerTileInfo> Speakers { get; set; }
    }
}
