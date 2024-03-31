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
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        public PodcastsVM podcastsVM { get; set; }
        public AlbumPage(PodcastsVM _podcastsVm)
        {
            podcastsVM = _podcastsVm;
            InitializeComponent();
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.SaveChanges();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.AddAlbum();
        }
    }
}
