using SinergijaSpeakers013.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Models
{
    public class Speaker : ISpeaker
    {
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Bio
        {
            get;
            set;
        }

        public string PictureUrl
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }
    }
}
