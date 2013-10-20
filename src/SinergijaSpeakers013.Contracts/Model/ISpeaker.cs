using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Model
{
    public interface ISpeaker
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Bio { get; set; }
        string PictureUrl { get; set; }
        string Company { get; set; }
    }
}
