using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Models
{
    public interface IEvent
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime TimeBegin { get; set; }
        DateTime TimeEnd { get; set; }
        string Place { get; set; }
        string Address { get; set; }
        string Description { get; set; }
        string Note { get; set; }
        double Longitude { get; set; }
        double Latitude { get; set; }
        bool Visibility { get; set; }
    }
}
