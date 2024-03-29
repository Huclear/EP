using Practice1.database;
using Practice1.database.PodcastsPlaylistsDataSetTableAdapters;
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
namespace Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        private PodcastsPlaylistsEntities1 ctx = new PodcastsPlaylistsEntities1();
        public MainWindow2()
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
            if (TableSwitcher.SelectedItem is Tables)
            {
                switch (TableSwitcher.SelectedItem)
                {
                    case Tables.Podcast:
                        TableGrid.ItemsSource = ctx.Podcast.ToList();
                        break;
                    case Tables.Episodes:
                        TableGrid.ItemsSource = ctx.Episode.ToList();
                        break;
                    case Tables.Album:
                        TableGrid.ItemsSource = ctx.Album.ToList();
                        break;
                    case Tables.Author:
                        TableGrid.ItemsSource = ctx.Author.ToList();
                        break;
                    case Tables.Albums_Podcasts:
                        TableGrid.ItemsSource = ctx.AlbumsPodcasts.ToList();
                        break;

                }
            }
        }
    }
}
