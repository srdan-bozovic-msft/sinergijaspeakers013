using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class SessionSpeakerRelation : ISessionSpeakerRelation
    {
        public int SpeakerId
        {
            get;
            set;
        }

        public int SessionId
        {
            get;
            set;
        }
    }
}
