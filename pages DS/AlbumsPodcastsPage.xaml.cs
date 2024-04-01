using Practice4.database;
using Practice4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice4.pages_DS
{
    /// <summary>
    /// Interaction logic for AlbumsPodcastsPage.xaml
    /// </summary>
    public partial class AlbumsPodcastsPage : Page
    {
        private DataSetDBViewModel dbViewModel;

        public AlbumsPodcastsPage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            this.AlbumID_Selection.ItemsSource = dbViewModel.Albums.GetData().ToList();
            this.PodcastID_Selection.ItemsSource = dbViewModel.Podcasts.GetData().ToList();
            AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetData();
        }

        private void OnSelectedSortingItem_Changed(object sender, SelectionChangedEventArgs e)
        {
            if(sender != null &&
                sender is ComboBox selection)
            {
                if(selection.SelectedItem != null)
                {
                    if (selection.Name.ToLower().Contains("podcast"))
                        AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetDataByPodcast((selection.SelectedItem as PodcastDBDataSet.PodcastRow).ID_Podcast);
                    else if (selection.Name.ToLower().Contains("album"))
                        AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetDataByAlbum((selection.SelectedItem as PodcastDBDataSet.AlbumRow).ID_Album);
                }
            }
        }

        private void OnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            AlbumID_Selection.SelectedItem = PodcastID_Selection.SelectedItem = null;
        }
    }
}
