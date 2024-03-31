using Practice2.pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Practice2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PodcastsVM podcastsVM;

        private PodcastsAlbumsPage podcastsAlbumsPage;
        private EpisodePage episodePage;
        private PodcastsPage podcastsPage;
        private AuthorPage authorPage;
        private AlbumPage albumPage;

        public MainWindow()
        {
            podcastsVM = new PodcastsVM();
            podcastsAlbumsPage = new PodcastsAlbumsPage(podcastsVM);
            episodePage = new EpisodePage(podcastsVM);
            podcastsPage = new PodcastsPage(podcastsVM);
            authorPage = new AuthorPage(podcastsVM);
            albumPage = new AlbumPage(podcastsVM);
            InitializeComponent();
            PageSelection.ItemsSource = new object[]
            {
                Tables.Author,
                Tables.Albums_Podcasts,
                Tables.Album,
                Tables.Podcast,
                Tables.Episodes,
            };
        }

        private void onSelectedPageChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PageSelection.SelectedItem != null && PageSelection.SelectedItem is Tables)
            {
                switch (PageSelection.SelectedItem)
                {
                    case Tables.Author:
                        Pages.Content = authorPage;
                        break;
                    case Tables.Albums_Podcasts:
                        Pages.Content = podcastsAlbumsPage;
                        break;
                    case Tables.Album:
                        Pages.Content = albumPage;
                        break;
                    case Tables.Podcast:
                        Pages.Content = podcastsPage;
                        break;
                    case Tables.Episodes:
                        Pages.Content = episodePage;
                        break;
                }
            }
        }

        private void onGoToDataSets_Click(object sender, RoutedEventArgs e)
        {
            MainWindow_DS_ mainWDS = new MainWindow_DS_();
            mainWDS.Show();
            Close();
        }
    }
}
