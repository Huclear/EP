using Practice4.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Practice4.ViewModels.EF
{
    public class AuthorPageVM
    {
        public string CurrentNameSorting { get; set; } = string.Empty;
        public string CurrentSurnameSorting { get; set; } = string.Empty;
        public string CurrentPatronymicSorting { get; set; } = string.Empty;
        public string CurrentNicknameSorting { get; set; } = string.Empty;
        public int CurrentAgeSorting { get; set; } = 0;

        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Author> Authors { get; set; }

        public AuthorPageVM()
        {
            dbContext = new PodcastDBContext();
            Authors = new ObservableCollection<Author>(dbContext.Author.ToList());
        }


        private bool SortByName(object author)
        {
            if(author == null || !(author is Author)) return false;
            return ((Author)author).Author_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void EnableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            collection.Filter = SortByName;
        }
        public void DisableSortByName()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
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


        private bool SortBySurname(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_SurName.ToLower().Contains(CurrentSurnameSorting.ToLower());
        }

        public void EnableSortBySurname()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            collection.Filter = SortBySurname;
        }
        public void DisableSortBySurname()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortBySurname;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool SortByPatronymic(object author)
        {
            if (author == null || !(author is Author) || (author as Author).Author_Patronymic == null) return false;
            return ((Author)author).Author_Patronymic.ToLower().Contains(CurrentPatronymicSorting.ToLower());
        }

        public void EnableSortByPatronymic()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            collection.Filter = SortByPatronymic;
        }
        public void DisableSortByPatronymic()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByPatronymic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private bool SortByNickname(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_Nickname.ToLower().Contains(CurrentNicknameSorting.ToLower());
        }

        public void EnableSortByNickname()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            collection.Filter = SortByNickname;
        }
        public void DisableSortByNickname()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByNickname;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private bool SortByAge(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_Age == CurrentAgeSorting;
        }

        public void EnableSortByAge()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            collection.Filter = SortByAge;
        }
        public void DisableSortByAge()
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            try
            {
                if (collection.Filter != null)
                    collection.Filter -= SortByAge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
