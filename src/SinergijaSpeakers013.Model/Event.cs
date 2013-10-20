using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class Event : IEvent
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public DateTime TimeBegin
        {
            get;
            set;
        }

        public DateTime TimeEnd
        {
            get;
            set;
        }

        public string Place
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Note
        {
            get;
            set;
        }

        public double Longitude
        {
            get;
            set;
        }

        public double Latitude
        {
            get;
            set;
        }

        public bool Visibility
        {
            get;
            set;
        }
    }
}
