using MsCampus.Win8.Shared.Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCampus.Win8.Shared.Contracts.View
{
    public interface IPageView
    {
        IPageViewModel ViewModel { get; }
    }
}
