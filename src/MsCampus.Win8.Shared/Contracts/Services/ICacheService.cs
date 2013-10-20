using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCampus.Win8.Shared.Contracts.Services
{
    public interface ICacheService
    {
        Task<bool> Exists(string key);
        Task Put(string key, object value);
        Task<ICacheItem> Get(string key);
    }
}
