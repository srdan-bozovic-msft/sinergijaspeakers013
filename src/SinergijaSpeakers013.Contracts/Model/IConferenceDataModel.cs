using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Model
{
    public interface IConferenceDataModel
    {
        int Version { get; set; }
        List<IDay> Days { get; set; }
        List<IRoom> Rooms { get; set; }
        List<ISpeaker> Speakers { get; set; }
        List<ISession> Sessions { get; set; }
        List<ISessionSpeakerRelation> SessionSpeakerRelations { get; set; }
        List<ISlot> Slots { get; set; }
        List<IEvent> Events { get; set; }
        string Test { get; set; }
        string PicturesLocation { get; set; }
    }
}
