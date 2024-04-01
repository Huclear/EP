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
    public class PodcastPageVM
    {

        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentDescriptionSorting { get; set; } = string.Empty;
        public Author CurrentAuthorSorting { get; set; } = null;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Podcast> Podcasts { get; set; }

        public PodcastPageVM()
        {
            dbContext = new PodcastDBContext();
            Podcasts = new ObservableCollection<Podcast>(dbContext.Podcast.ToList());
        }


        private bool SortByName(object podcast)
        {
            if (podcast == null || !(podcast is Podcast)) return false;
            return ((Podcast)podcast).Podcast_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void EnableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            collection.Filter += SortByName;
        }
        public void DisableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
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


        private bool SortByDescription(object podcast)
        {
            if (podcast == null || !(podcast is Podcast) || (podcast as Podcast).Podcast_Description == null) return false;
            return ((Podcast)podcast).Podcast_Description.ToLower().Contains(CurrentDescriptionSorting.ToLower());
        }

        public void EnableSortByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            collection.Filter += SortByDescription;
        }
        public void DisableSortByDescription()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
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

        private bool SortByAuthor(object podcast)
        {
            if (podcast == null || !(podcast is Podcast) || (podcast as Podcast).Author == null || CurrentAuthorSorting == null) return false;
            return ((Podcast)podcast).Author.ID_Author == CurrentAuthorSorting.ID_Author;
        }

        public void EnableSortByAuthor()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
            collection.Filter += SortByAuthor;
        }
        public void DisableSortByAuthor()
        {
            var collection = CollectionViewSource.GetDefaultView(Podcasts);
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
