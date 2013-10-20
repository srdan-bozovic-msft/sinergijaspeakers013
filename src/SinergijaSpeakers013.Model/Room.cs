using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class Room : IRoom
    {
        public int Id
        {
            get;
            set;
        }

        public string Code
        {
            get;
            set;
        }
    }
}
