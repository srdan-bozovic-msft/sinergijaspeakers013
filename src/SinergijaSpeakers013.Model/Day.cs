using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class Day : IDay
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }
    }
}
