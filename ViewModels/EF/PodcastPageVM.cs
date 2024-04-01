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
    public class PodcastPageVM
    {
        private RelayCommand<ObservableCollection<Podcast>> _clearAlbumsFilterCommand = null;
        public RelayCommand<ObservableCollection<Podcast>> clearAlbumsFilterCommand => _clearAlbumsFilterCommand ?? (new RelayCommand<ObservableCollection<Podcast>>(ClearFilters));

        private RelayCommand<bool> _changeEnableNameSortCommand = null;
        public RelayCommand<bool> changeEnableNameSortCommand => _changeEnableNameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortName));

        private RelayCommand<bool> _changeEnableDescriptionSortCommand = null;
        public RelayCommand<bool> changeEnableDescriptionSortCommand => _changeEnableDescriptionSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortDescription));

        private RelayCommand<bool> _changeEnableAuthorSortCommand = null;
        public RelayCommand<bool> changeEnableAuthorSortCommand => _changeEnableAuthorSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortAuthor));


        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentDescriptionSorting { get; set; } = string.Empty;
        public Author CurrentAuthorSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Podcast> Podcasts { get; set; }
        public ObservableCollection<Author> Authors { get; set; }

        public PodcastPageVM()
        {
            dbContext = new PodcastDBContext();
            Podcasts = new ObservableCollection<Podcast>(dbContext.Podcast.ToList());
            Authors = new ObservableCollection<Author>(dbContext.Author.ToList());
        }

        public void RefreshCollection()
        {
            CollectionViewSource.GetDefaultView(Podcasts).Refresh();
        }

        public void ClearFilters(ObservableCollection<Podcast> podcasts)
        {
            if (podcasts != null)
            {
                var collection = CollectionViewSource.GetDefaultView(podcasts);
                collection.Filter = null;
            }
        }

        private bool SortByName(object podcast)
        {
            if (podcast == null || !(podcast is Podcast)) return false;
            return ((Podcast)podcast).Podcast_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void ChangeEnableSortName(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            if (isEnabled)
            {
                collection.Filter += SortByName;
            }
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


        private bool SortByDescription(object podcast)
        {
            if (podcast == null || !(podcast is Podcast) || (podcast as Podcast).Podcast_Description == null) return false;
            return ((Podcast)podcast).Podcast_Description.ToLower().Contains(CurrentDescriptionSorting.ToLower());
        }
        public void ChangeEnableSortDescription(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            if (isEnabled)
            {
                collection.Filter += SortByDescription;
            }
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

        private bool SortByAuthor(object podcast)
        {
            if (podcast == null || !(podcast is Podcast) || (podcast as Podcast).Author == null || CurrentAuthorSorting == null) return false;
            return ((Podcast)podcast).Author.ID_Author == CurrentAuthorSorting.ID_Author;
        }
        public void ChangeEnableSortAuthor(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            if (isEnabled)
            {
                collection.Filter += SortByAuthor;
            }
            else
            {
                try
                {
                    if (collection.Filter != null)
                        collection.Filter -= SortByAuthor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
