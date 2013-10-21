using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Models
{
    public class SessionSpeakerRelation
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
