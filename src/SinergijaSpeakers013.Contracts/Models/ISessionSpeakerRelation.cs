using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Models
{
    public interface ISessionSpeakerRelation
    {
        int SpeakerId { get; set; }
        int SessionId { get; set; }
    }
}
