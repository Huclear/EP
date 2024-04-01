using Practice4.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Practice4.ViewModels.EF
{
    public class EpisodePageVM
    {

        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentDescriptionSorting { get; set; } = string.Empty;
        public decimal CurrentDurationSorting { get; set; } = 0;
        public Podcast CurrentPodcastSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Episode> Episodes { get; set; }

        public EpisodePageVM()
        {
            dbContext = new PodcastDBContext();
            Episodes = new ObservableCollection<Episode>(dbContext.Episode.ToList());
        }


        private bool SortByName(object episode)
        {
            if (episode == null || !(episode is Podcast)) return false;
            return ((Episode)episode).Episode_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void EnableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter += SortByName;
        }
        public void DisableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private bool SortByDescription(object episode)
        {
            if (episode == null || !(episode is Episode) || (episode as Episode).Episode_Description == null) return false;
            return ((Episode)episode).Episode_Description.ToLower().Contains(CurrentDescriptionSorting.ToLower());
        }

        public void EnableSortByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter += SortByDescription;
        }
        public void DisableSortByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool SortByPodcast(object podcast)
        {
            if (podcast == null || !(podcast is Episode) || (podcast as Episode).Podcast == null || CurrentPodcastSorting == null) return false;
            return ((Episode)podcast).Podcast_ID == CurrentPodcastSorting.ID_Podcast;
        }

        public void EnableSortByPodcast()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter += SortByPodcast;
        }
        public void DisableSortByPodcast()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
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

        private bool SortByDuration(object episode)
        {
            if (episode == null || !(episode is Episode) || (episode as Episode).Episode_Duration == null) return false;
            return ((Episode)episode).Episode_Duration == CurrentDurationSorting;
        }
        public void EnableSortByDuration()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter += SortByDuration;
        }
        public void DisableSortByDuration()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByDuration;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
