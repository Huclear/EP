using Practice4.database;
using Practice4.ViewModels.EF;
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

namespace Practice4.pages
{
    /// <summary>
    /// Interaction logic for PodcastsAlbumsPage.xaml
    /// </summary>
    public partial class PodcastsAlbumsPage : Page
    {
        public AlbumPodcastsPageVM albumsPodcastsVM { get; set; }

        public PodcastsAlbumsPage()
        {
            albumsPodcastsVM = new AlbumPodcastsPageVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlbumSortEnable.IsChecked = PodcastSortEnable.IsChecked = false;
        }
    }
}
