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
using Practice4.Commands;
using System.Globalization;

namespace Practice4.ViewModels.EF
{
    public class EpisodePageVM
    {

        private RelayCommand<ObservableCollection<Episode>> _clearFiltersCommand = null;
        public RelayCommand<ObservableCollection<Episode>> clearFiltersCommand => _clearFiltersCommand ?? (new RelayCommand<ObservableCollection<Episode>>(ClearFilter));

        private RelayCommand<bool> _changeEnableNameSortCommand = null;
        public RelayCommand<bool> changeEnableNameSortCommand => _changeEnableNameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortName));

        private RelayCommand<bool> _changeEnableDescriptionSortCommand = null;
        public RelayCommand<bool> changeEnableDescriptionSortCommand => _changeEnableDescriptionSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortDescription));

        private RelayCommand<bool> _changeEnableDurationSortCommand = null;
        public RelayCommand<bool> changeEnableDurationSortCommand => _changeEnableDurationSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortDuration));

        private RelayCommand<bool> _changeEnablePodcastSortCommand = null;
        public RelayCommand<bool> changeEnablePodcastSortCommand => _changeEnablePodcastSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortPodcast));

        public string CurrentNameFilter { get; set; } = string.Empty;
        public string CurrentDescriptionFilter { get; set; } = string.Empty;
        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentDescriptionSorting { get; set; } = string.Empty;
        public decimal CurrentDurationSorting { get; set; } = 0;
        public Podcast CurrentPodcastSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Episode> Episodes { get; set; }
        public ObservableCollection<Podcast> Podcasts { get; set; }

        public EpisodePageVM()
        {
            dbContext = new PodcastDBContext();
            Episodes = new ObservableCollection<Episode>(dbContext.Episode.ToList());
            Podcasts = new ObservableCollection<Podcast>(dbContext.Podcast.ToList());
        }

        public ICollection<string> GetNameEntries()
        {
            List<string> entries = new List<string>();
            foreach (var item in Episodes)
                entries.Add(item.Episode_Name);
            return entries;
        }
        public ICollection<string> GetDescriptionEntries()
        {
            List<string> entries = new List<string>();
            foreach (var item in Episodes)
                entries.Add(item.Episode_Description);
            return entries;
        }

        private bool FilterByDescription(object podcast)
        {
            if (podcast == null || !(podcast is Episode) || ((Episode)podcast).Episode_Description == null) return false;
            return ((Episode)podcast).Episode_Description.Equals(CurrentDescriptionFilter);
        }
        public void FilterByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter = FilterByDescription;
            collection.Refresh();
        }

        private bool FilterByName(object podcast)
        {
            if (podcast == null || !(podcast is Episode)) return false;
            return ((Episode)podcast).Episode_Name.Equals(CurrentNameFilter);
        }
        public void FilterByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            collection.Filter = FilterByName;
        }

        public void ClearFilter(ICollection<Episode> episodes)
        {
            var collection = CollectionViewSource.GetDefaultView(episodes);
            collection.Filter = null;
        }


        private bool SortByName(object episode)
        {
            if (episode == null || !(episode is Episode)) return false;
            return ((Episode)episode).Episode_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void ChangeEnableSortName(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            if (isEnabled)
                collection.Filter += SortByName;
            else
            {
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
        }


        private bool SortByDescription(object episode)
        {
            if (episode == null || !(episode is Episode) || (episode as Episode).Episode_Description == null) return false;
            return ((Episode)episode).Episode_Description.ToLower().Contains(CurrentDescriptionSorting.ToLower());
        }

        public void ChangeEnableSortDescription(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            if (isEnabled)
                collection.Filter += SortByDescription;
            else
            {
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
        }

        private bool SortByPodcast(object podcast)
        {
            if (podcast == null || !(podcast is Episode) || (podcast as Episode).Podcast == null || CurrentPodcastSorting == null) return false;
            return ((Episode)podcast).Podcast_ID == CurrentPodcastSorting.ID_Podcast;
        }

        public void ChangeEnableSortPodcast(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            if (isEnabled)
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

        private bool SortByDuration(object episode)
        {
            if (episode == null || !(episode is Episode) || (episode as Episode).Episode_Duration == null) return false;
            return ((Episode)episode).Episode_Duration == CurrentDurationSorting;
        }
        public void ChangeEnableSortDuration(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Episodes);
            if (isEnabled)
                collection.Filter += SortByDuration;
            else
            {
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
}
