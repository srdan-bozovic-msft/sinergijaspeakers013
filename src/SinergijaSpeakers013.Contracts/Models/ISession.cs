using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Models
{
    public interface ISession
    {
        int Id { get; set; }
        string Track { get; set; }
        int DayId { get; set; }
        int TimeLine { get; set; }
        string Lang { get; set; }
        int Level { get; set; }
        int RoomId { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}
