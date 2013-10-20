using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Models
{
    public interface IDay
    {
        int Id { get; set; }
        DateTime Date { get; set; }
    }
}
