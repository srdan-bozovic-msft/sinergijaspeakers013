using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Model
{
    interface ISlot
    {
        int Id { get; set; }
        int TimeLine { get; set; }
        int DayId { get; set; }
        string Type { get; set; }
        byte StartHour { get; set; }
        byte StartMinute { get; set; }
        byte EndHour { get; set; }
        byte EndMinute { get; set; }
    }
}
