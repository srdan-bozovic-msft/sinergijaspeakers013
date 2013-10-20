using GalaSoft.MvvmLight.Command;
using MsCampus.Win8.Shared.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.Contracts.ViewModels
{
    public interface ISpeakersPageViewModel : IPageViewModel
    {
        ObservableCollection<ISpeakerGroupTileInfo> SpeakerGroupTileInfos { get; set; }
        RelayCommand<ISpeakerTileInfo> SpeakerSelectedCommand { get; set; }
    }
}
