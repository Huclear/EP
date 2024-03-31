using Practice2.database;
using System;
using System.Collections.Generic;
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

namespace Practice2.pages
{
    /// <summary>
    /// Interaction logic for PodcastsAlbumsPage.xaml
    /// </summary>
    public partial class PodcastsAlbumsPage : Page
    {
        public PodcastsVM podcastsVM { get; set; }

        public PodcastsAlbumsPage(PodcastsVM _podcastsVM)
        {
            podcastsVM = _podcastsVM;
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (PodcastID_Selection.SelectedItem != null && PodcastID_Selection.SelectedItem is Podcast podcast
                && AlbumID_Selection.SelectedItem != null && AlbumID_Selection.SelectedItem is Album album)
                    podcastsVM.AddAlbumsPodcasts(podcast.ID_Podcast, album.ID_Album);
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.SaveChanges();
        }
    }
}
