using Practice2.database;
using Practice2.ViewModels;
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

namespace Practice2.pages_DS
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

        private void onDeleteAlbumPodcasts(object sender, RoutedEventArgs e)
        {
            if (AlbumsPodcastsDGr.SelectedItem != null && AlbumsPodcastsDGr.SelectedItem is DataRowView albumPodcast)
            {
                try
                {
                    var id = Convert.ToInt32(albumPodcast[0]);
                    dbViewModel.DeleteFrom(Tables.Author, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetData();
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (AlbumID_Selection.SelectedItem != null && AlbumID_Selection.SelectedItem is PodcastDBDataSet.AlbumRow album
                && PodcastID_Selection.SelectedItem != null && PodcastID_Selection.SelectedItem is PodcastDBDataSet.PodcastRow podcast)
            {
                try
                {
                    dbViewModel.AddAlbumsPodcasts(album.ID_Album, podcast.ID_Podcast);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetData();
                }
            }
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (AlbumsPodcastsDGr.SelectedItem != null && AlbumsPodcastsDGr.SelectedItem is DataRowView albumPodcast
                && AlbumID_Selection.SelectedItem != null && AlbumID_Selection.SelectedItem is PodcastDBDataSet.AlbumRow album
                && PodcastID_Selection.SelectedItem != null && PodcastID_Selection.SelectedItem is PodcastDBDataSet.PodcastRow podcast)
            {
                try
                {
                    var id = Convert.ToInt32(albumPodcast[0]);
                    dbViewModel.UpdateAlbumsPodcasts(album.ID_Album, podcast.ID_Podcast, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    AlbumsPodcastsDGr.ItemsSource = dbViewModel.AlbumsPodcasts.GetData();
                }
            }
        }

        private void onSelectedAlbumPodcast_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (AlbumsPodcastsDGr.SelectedItem != null && AlbumsPodcastsDGr.SelectedItem is DataRowView albumPodcast)
            {
                try
                {
                    AlbumID_Selection.SelectedItem = (AlbumID_Selection.ItemsSource as List<PodcastDBDataSet.AlbumRow>).FirstOrDefault(row => row.ID_Album == Convert.ToInt32(albumPodcast[1]));
                    PodcastID_Selection.SelectedItem = (PodcastID_Selection.ItemsSource as List<PodcastDBDataSet.PodcastRow>).FirstOrDefault(row => row.ID_Podcast == Convert.ToInt32(albumPodcast[1]));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
    }
}
