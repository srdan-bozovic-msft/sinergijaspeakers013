using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.Model
{
    public interface IDay
    {
        int Id { get; set; }
        DateTime Date { get; set; }
    }
}
