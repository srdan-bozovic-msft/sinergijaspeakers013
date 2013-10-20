﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCampus.Win8.Shared.Contracts.Services
{
    public interface ICacheItem
    {
        T GetValue<T>();
        DateTime LastSync { get; }
    }
}
