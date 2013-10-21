using MsCampus.Win8.Shared.Contracts.ViewModels;
using SinergijaSpeakers013.Contracts.Views;
using SinergijaSpeakers013.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SinergijaSpeakers013.App.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeakersPageView : Page, ISpeakersPageView
    {
        public SpeakersPageView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var vm = this.DataContext as SpeakersPageViewModel;
            vm.PropertyChanged += vm_PropertyChanged;
        }

        void vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals("SpeakerGroupTileInfos"))
                this.groupGridView.ItemsSource = 
                    this.groupedItemsViewSource.View.CollectionGroups;
        }

        public IPageViewModel ViewModel
        {
            get 
            { 
                return this.DataContext as IPageViewModel; 
            }
        }

        private void SemanticZoom_ViewChangeStarted_1(object sender, SemanticZoomViewChangedEventArgs e)
        {
           
        }
    }
}
