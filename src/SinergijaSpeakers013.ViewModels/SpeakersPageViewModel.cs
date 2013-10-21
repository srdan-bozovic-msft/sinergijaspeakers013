using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MsCampus.Win8.Shared.Contracts.Services;
using SinergijaSpeakers013.Contracts.Models;
using SinergijaSpeakers013.Contracts.Repositories;
using SinergijaSpeakers013.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinergijaSpeakers013.ViewModels
{
    public class SpeakersPageViewModel : ViewModelBase, ISpeakersPageViewModel
    {
        private ObservableCollection<ISpeakerGroupTileInfo> _speakerGroupTileInfos;
        public ObservableCollection<ISpeakerGroupTileInfo> SpeakerGroupTileInfos
        {
            get
            {
                return _speakerGroupTileInfos;
            }
            set
            {
                _speakerGroupTileInfos = value;
                RaisePropertyChanged("SpeakerGroupTileInfos");
            }
        }

        public RelayCommand<ISpeakerTileInfo> SpeakerSelectedCommand
        {
            get;
            set;
        }

        private INavigationService _navigationService;
        private IConferenceRepository _conferenceRepository;
        private IToastService _toastService;

        public SpeakersPageViewModel(
            INavigationService navigationService,
            IConferenceRepository conferenceRepository,
            IToastService toastService)
        {
            _navigationService = navigationService;
            _conferenceRepository = conferenceRepository;
            _toastService = toastService;
        }

        private void InitializeCommands()
        {
            SpeakerSelectedCommand = new RelayCommand<ISpeakerTileInfo>((speakerTileInfo) =>
            {
                //_navigationService.Navigate("SpeakerDetails", speakerTileInfo.SpeakerId);
                _toastService.SendSimpleTextToast("//TODO Navigate to speaker " + speakerTileInfo.SpeakerName);
            });
        }

        public async void Initialize(object parameter)
        {
            var speakers = await _conferenceRepository.GetSpeakers();
            SpeakerGroupTileInfos = GroupSpeakers(speakers);
        }

        private static ObservableCollection<ISpeakerGroupTileInfo> GroupSpeakers(List<Speaker> speakers)
        {
            var speakerGroupTileInfoList = new List<SpeakerGroupTileInfo>();
            var groupHeaders = new string[] { "a", "b", "c", "č", "ć", "d", "đ", "e", "f", "g", "h", "i", "j", "k", "l", "lj", "m", "n", "nj", "o", "p", "q", "r", "s", "š", "t", "u", "v", "w", "x", "y", "z", "ž" };
            var speakerInfos = speakers.OrderBy(s => s.LastName).Select(s => new SpeakerTileInfo(s));
            var groups = new Dictionary<string, SpeakerGroupTileInfo>();

            foreach (string header in groupHeaders)
            {
                var group = new SpeakerGroupTileInfo(header);
                speakerGroupTileInfoList.Add(group);
                groups[header] = group;
            }

            foreach (var speakerInfo in speakerInfos)
            {
                var lastName = speakerInfo.SpeakerName.Trim().ToLower();
                var groupName = lastName.Substring(0, 2);
                if (groupName == "lj" || groupName == "nj")
                {
                    groups[groupName].Speakers.Add(speakerInfo);
                }
                else
                {
                    groups[lastName.Substring(0, 1)].Speakers.Add(speakerInfo);
                }
            }

            var speakerGroupTileInfos = new ObservableCollection<ISpeakerGroupTileInfo>();
            foreach (var speakerGroup in speakerGroupTileInfoList)
            {
                if (speakerGroup.Speakers.Count > 0)
                {
                    speakerGroupTileInfos.Add(speakerGroup);
                }
            }
            return speakerGroupTileInfos;
        }
    }
}
