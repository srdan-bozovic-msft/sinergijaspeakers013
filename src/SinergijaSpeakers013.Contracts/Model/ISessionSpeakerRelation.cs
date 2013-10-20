using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Model
{
    public interface ISessionSpeakerRelation
    {
        int SpeakerId { get; set; }
        int SessionId { get; set; }
    }
}
