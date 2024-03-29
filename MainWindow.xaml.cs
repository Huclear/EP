using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
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
using Practice1.database;
using Practice1.database.PodcastsPlaylistsDataSetTableAdapters;

namespace Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PodcastTableAdapter podcastTableAdapter = new PodcastTableAdapter();
        private AlbumsPodcastsTableAdapter albumsPodcastsTableAdapter = new AlbumsPodcastsTableAdapter();
        private AuthorTableAdapter authorTableAdapter = new AuthorTableAdapter();
        private AlbumTableAdapter albumTableAdapter = new AlbumTableAdapter();
        private EpisodeTableAdapter episodeTableAdapter = new EpisodeTableAdapter();
        
        public MainWindow()
        {
            InitializeComponent();
            this.TableSwitcher.ItemsSource = new object[] {
                Tables.Podcast,
                Tables.Album,
                Tables.Author,
                Tables.Albums_Podcasts,
                Tables.Episodes,
            };
            TableSwitcher.SelectedIndex = 0;
        }

        private void OnSelectedTableChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TableSwitcher.SelectedItem is Tables)
            {
                switch(TableSwitcher.SelectedItem)
                {
                    case Tables.Podcast:
                        TableGrid.ItemsSource = podcastTableAdapter.GetData();
                        break;
                    case Tables.Episodes:
                        TableGrid.ItemsSource = episodeTableAdapter.GetData();
                        break;
                    case Tables.Album:
                        TableGrid.ItemsSource = albumTableAdapter.GetData();
                        break;
                    case Tables.Author:
                        TableGrid.ItemsSource = authorTableAdapter.GetData();
                        break;
                    case Tables.Albums_Podcasts:
                        TableGrid.ItemsSource = albumsPodcastsTableAdapter.GetData();
                        break;

                }
            }
        }
    }
}
