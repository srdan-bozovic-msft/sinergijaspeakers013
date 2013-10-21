using MsCampus.Win8.Shared.Contracts.Services;
using MsCampus.Win8.Shared.DI;
using MsCampus.Win8.Shared.Implementation.Services;
using SinergijaSpeakers013.App.Views;
using SinergijaSpeakers013.Contracts.Repositories;
using SinergijaSpeakers013.Contracts.Services.Data;
using SinergijaSpeakers013.Contracts.ViewModels;
using SinergijaSpeakers013.Contracts.Views;
using SinergijaSpeakers013.Repositories;
using SinergijaSpeakers013.Services;
using SinergijaSpeakers013.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.App.Common
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            //ViewModel registration
            InstanceFactory.RegisterType<ISpeakersPageViewModel, SpeakersPageViewModel>();

            //View registration
            InstanceFactory.RegisterType<ISpeakersPageView, SpeakersPageView>();

            //Repositories registration
            InstanceFactory.RegisterType<IConferenceRepository, ConferenceRepository>();

            //Services registration
            InstanceFactory.RegisterType<IHttpClientService, HttpClientService>();
            InstanceFactory.RegisterType<IConferenceDataService, ConferenceDataService>();
            InstanceFactory.RegisterType<
                MsCampus.Win8.Shared.Contracts.Services.INavigationService, 
                SinergijaSpeakers013.Services.NavigationService>();
            InstanceFactory.RegisterType<IToastService, ToastService>();
            InstanceFactory.RegisterType<IStateService, StateService>();
            InstanceFactory.RegisterType<ICacheService, WindowsStorageCacheService>();
        }


        public ISpeakersPageViewModel SpeakersPageViewModel
        {
            get
            {
                return InstanceFactory.GetInstance<ISpeakersPageViewModel>();
            }
        }
    }
}
