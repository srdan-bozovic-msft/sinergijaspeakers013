using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class ConferenceDataModel : IConferenceDataModel
    {
        public int Version
        {
            get;
            set;
        }

        public List<IDay> Days
        {
            get;
            set;
        }

        public List<IRoom> Rooms
        {
            get;
            set;
        }

        public List<ISpeaker> Speakers
        {
            get;
            set;
        }

        public List<ISession> Sessions
        {
            get;
            set;
        }

        public List<ISessionSpeakerRelation> SessionSpeakerRelations
        {
            get;
            set;
        }

        public List<ISlot> Slots
        {
            get;
            set;
        }

        public List<IEvent> Events
        {
            get;
            set;
        }

        public string Test
        {
            get;
            set;
        }

        public string PicturesLocation
        {
            get;
            set;
        }
    }
}
