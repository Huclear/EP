using Practice4.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace Practice4.ViewModels.EF
{
    public class AlbumPodcastsPageVM
    {

        public Podcast CurrentPodcastSorting { get; set; } = null;
        public Album CurrentAlbumSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<AlbumsPodcasts> AlbumsPodcasts { get; set; }

        public AlbumPodcastsPageVM()
        {
            dbContext = new PodcastDBContext();
            AlbumsPodcasts = new ObservableCollection<AlbumsPodcasts>(dbContext.AlbumsPodcasts.ToList());
        }
        private bool SortByAlbum(object albumsPodcasts)
        {
            if (albumsPodcasts == null || !(albumsPodcasts is AlbumsPodcasts) || (albumsPodcasts as AlbumsPodcasts).Album == null || CurrentAlbumSorting == null) return false;
            return ((AlbumsPodcasts)albumsPodcasts).Album_ID == CurrentAlbumSorting.ID_Album;
        }
        public void EnableSortByAlbum()
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            collection.Filter += SortByAlbum;
        }
        public void DisableSortByAlbum()
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByAlbum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private bool SortByPodcast(object albumsPodcasts)
        {
            if (albumsPodcasts == null || !(albumsPodcasts is AlbumsPodcasts) || (albumsPodcasts as AlbumsPodcasts).Podcast == null || CurrentPodcastSorting == null) return false;
            return ((AlbumsPodcasts)albumsPodcasts).Podcast_ID == CurrentPodcastSorting.ID_Podcast;
        }
        public void EnableSortByPodcast()
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            collection.Filter += SortByPodcast;
        }
        public void DisableSortByPodcast()
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByPodcast;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
