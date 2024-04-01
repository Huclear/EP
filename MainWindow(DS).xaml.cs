using Practice3.database.PodcastsDBDataSetTableAdapters;
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
using System.Windows.Shapes;
using Practice3.pages_DS;
using Practice3.ViewModels;
namespace Practice3
{
    /// <summary>
    /// Interaction logic for MainWindow_DS_.xaml
    /// </summary>
    public partial class MainWindow_DS_ : Window
    {
        private DataSetDBViewModel dbViewModel { get; set; }

        private AlbumsPodcastsPage podcastsAlbumsPage;
        private EpisodePage episodePage;
        private PodcastPage podcastsPage;
        private AuthorPage authorPage;
        private AlbumPage albumPage;

        public MainWindow_DS_()
        {
            dbViewModel = new DataSetDBViewModel();

            podcastsAlbumsPage = new AlbumsPodcastsPage(dbViewModel);
            episodePage = new EpisodePage(dbViewModel);
            podcastsPage = new PodcastPage(dbViewModel);
            authorPage = new AuthorPage(dbViewModel);
            albumPage = new AlbumPage(dbViewModel);
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
                        pages_EF.Content = authorPage;
                        break;
                    case Tables.Albums_Podcasts:
                        pages_EF.Content = podcastsAlbumsPage;
                        break;
                    case Tables.Album:
                        pages_EF.Content = albumPage;
                        break;
                    case Tables.Podcast:
                        pages_EF.Content = podcastsPage;
                        break;
                    case Tables.Episodes:
                        pages_EF.Content = episodePage;
                        break;
                }
            }
        }

        private void onGoToEntities_Click(object sender, RoutedEventArgs e)
        {
            var mainW = new MainWindow();
            mainW.Show();
            Close();
        }
    }
}
