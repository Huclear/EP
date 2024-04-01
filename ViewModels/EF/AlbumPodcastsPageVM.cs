using Practice4.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using Practice4.Commands;

namespace Practice4.ViewModels.EF
{
    public class AlbumPodcastsPageVM
    {

        private RelayCommand<ObservableCollection<AlbumsPodcasts>> _clearFilterCommand = null;
        public RelayCommand<ObservableCollection<AlbumsPodcasts>> clearFilterCommand => _clearFilterCommand ?? (new RelayCommand<ObservableCollection<AlbumsPodcasts>>(ClearFilters));

        private RelayCommand<bool> _changeEnableAlbumSortCommand = null;
        public RelayCommand<bool> changeEnableAlbumSortCommand => _changeEnableAlbumSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortByAlbum));

        private RelayCommand<bool> _changeEnablePodcastSortCommand = null;
        public RelayCommand<bool> changeEnablePodcastSortCommand => _changeEnablePodcastSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortByPodcast));

        public Podcast CurrentPodcastSorting { get; set; } = null;
        public Album CurrentAlbumSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<AlbumsPodcasts> AlbumsPodcasts { get; set; }
        public ObservableCollection<Podcast> Podcasts { get; set; }
        public ObservableCollection<Album> Albums { get; set; }

        public AlbumPodcastsPageVM()
        {
            dbContext = new PodcastDBContext();
            AlbumsPodcasts = new ObservableCollection<AlbumsPodcasts>(dbContext.AlbumsPodcasts.ToList());
            Podcasts = new ObservableCollection<Podcast>(dbContext.Podcast.ToList());
            Albums = new ObservableCollection<Album>(dbContext.Album.ToList());
        }

        public void ClearFilters(ObservableCollection<AlbumsPodcasts> albumsPodcasts)
        {
            if (albumsPodcasts != null)
            {
                var collection = CollectionViewSource.GetDefaultView(albumsPodcasts);
                collection.Filter = null;
            }
        }

        private bool SortByAlbum(object albumsPodcasts)
        {
            if (albumsPodcasts == null || !(albumsPodcasts is AlbumsPodcasts) || (albumsPodcasts as AlbumsPodcasts).Album == null || CurrentAlbumSorting == null) return false;
            return ((AlbumsPodcasts)albumsPodcasts).Album_ID == CurrentAlbumSorting.ID_Album;
        }
        public void ChangeEnableSortByAlbum(bool isEnable)
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            if (isEnable)
                collection.Filter += SortByAlbum;
            else
            {
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
        }


        private bool SortByPodcast(object albumsPodcasts)
        {
            if (albumsPodcasts == null || !(albumsPodcasts is AlbumsPodcasts) || (albumsPodcasts as AlbumsPodcasts).Podcast == null || CurrentPodcastSorting == null) return false;
            return ((AlbumsPodcasts)albumsPodcasts).Podcast_ID == CurrentPodcastSorting.ID_Podcast;
        }
        public void ChangeEnableSortByPodcast(bool isEnable)
        {
            var collection = CollectionViewSource.GetDefaultView(AlbumsPodcasts);
            if (isEnable)
                collection.Filter += SortByPodcast;
            else
            {
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
}
