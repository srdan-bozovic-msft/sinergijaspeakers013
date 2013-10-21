using MsCampus.Win8.Shared.Implementation.Services;
using SinergijaSpeakers013.Contracts.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Services
{
    public class NavigationService : NavigationServiceBase
    {
        public class PageNames
        {
            public const string SpeakersPageView = "SinergijaSpeakers013.App.Views.SpeakersPageView";
        }
        public override void Navigate(string type, object parameter)
        {
            switch (type)
            {
                case PageNames.SpeakersPageView:
                    Navigate<ISpeakersPageView>(parameter); break;

            }            
        }
    }
}
