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
    public class AlbumPageVM
    {
        private RelayCommand<ObservableCollection<Album>> _clearAlbumsFilterCommand = null;
        public RelayCommand<ObservableCollection<Album>> clearAlbumsFilterCommand => _clearAlbumsFilterCommand ?? (new RelayCommand<ObservableCollection<Album>>(ClearFilters));

        private RelayCommand<bool> _changeEnableNameSortCommand = null;
        public RelayCommand<bool> changeEnableNameSortCommand => _changeEnableNameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortName));

        private RelayCommand<bool> _changeEnableDescriptionSortCommand = null;
        public RelayCommand<bool> changeEnableDescriptionSortCommand => _changeEnableDescriptionSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortDescription));

        private RelayCommand<bool> _changeEnableAuthorSortCommand = null;
        public RelayCommand<bool> changeEnableAuthorSortCommand => _changeEnableAuthorSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortAuthor));

        public string CurrentNameFilter { get; set; } = string.Empty;
        public string CurrentDescriptionFilter { get; set; } = string.Empty;

        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentDescriptionSorting { get; set; } = string.Empty;
        public Author CurrentAuthorSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Album> Albums { get; set; }
        public ObservableCollection<Author> Authors { get; set; }

        public AlbumPageVM()
        {
            dbContext = new PodcastDBContext();
            Authors = new ObservableCollection<Author>(dbContext.Author.ToList());
            Albums = new ObservableCollection<Album>(dbContext.Album.ToList());
        }

        public ICollection<string> GetNameEntries()
        {
            List<string> names = new List<string>();
            foreach (var item in Albums)
                names.Add(item.Album_Name);
            return names;
        }
        public ICollection<string> GetDescriptionEntries()
        {
            List<string> names = new List<string>();
            foreach (var item in Albums)
                names.Add(item.Album_Description);
            return names;
        }


        private bool FilterByName(object podcast)
        {
            if (podcast == null || !(podcast is Album)) return false;
            return ((Album)podcast).Album_Name.Equals(CurrentNameFilter);
        }
        public void FilterByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Albums);
            collection.Filter = FilterByName;
        }

        private bool FilterByDescription(object podcast)
        {
            if (podcast == null || !(podcast is Album) || ((Album)podcast).Album_Description == null) return false;
            return ((Album)podcast).Album_Description.Equals(CurrentDescriptionFilter);
        }
        public void FilterByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Albums);
            collection.Filter = FilterByDescription;
        }

        public void ClearFilters(ObservableCollection<Album> albums)
        {
            if (albums != null)
            {
                var collection = CollectionViewSource.GetDefaultView(albums);
                collection.Filter = null;
            }
        }

        private bool SortByName(object album)
        {
            if (album == null || !(album is Album)) return false;
            return ((Album)album).Album_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void ChangeEnableSortName(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Albums);
            if (isEnabled)
            {
                collection.Filter = SortByName;
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


        private bool SortByDescription(object album)
        {
            if (album == null || !(album is Album) || (album as Album).Album_Description == null) return false;
            return ((Album)album).Album_Description.ToLower().Contains(CurrentDescriptionSorting.ToLower());
        }
        public void ChangeEnableSortDescription(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Albums);
            if (isEnabled)
            {
                collection.Filter = SortByDescription;
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

        private bool SortByAuthor(object author)
        {
            if (author == null || !(author is Author) || (author as Album).Author == null || CurrentAuthorSorting == null) return false;
            return ((Album)author).Author.ID_Author == CurrentAuthorSorting.ID_Author;
        }
        public void ChangeEnableSortAuthor(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Albums);
            if (isEnabled)
            {
                collection.Filter = SortByAuthor;
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
