using Practice4.Commands;
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


        private RelayCommand<ObservableCollection<Author>> _clearAuthorsFilterCommand = null;
        public RelayCommand<ObservableCollection<Author>> clearAuthorsFilterCommand => _clearAuthorsFilterCommand ?? (new RelayCommand<ObservableCollection<Author>>(ClearFilters));

        private RelayCommand<bool> _changeEnableNameSortCommand = null;
        public RelayCommand<bool> changeEnableNameSortCommand => _changeEnableNameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortName));

        private RelayCommand<bool> _changeEnableSurnameSortCommand = null;
        public RelayCommand<bool> changeEnableSurnameSortCommand => _changeEnableSurnameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortSurname));
        
        private RelayCommand<bool> _changeEnablePatronymicSortCommand = null;
        public RelayCommand<bool> changeEnablePatronymicSortCommand => _changeEnablePatronymicSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortPatronymic));

        private RelayCommand<bool> _changeEnableNicknameSortCommand = null;
        public RelayCommand<bool> changeEnableNicknameSortCommand => _changeEnableNicknameSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortNickname));

        private RelayCommand<bool> _changeEnableAgeSortCommand = null;
        public RelayCommand<bool> changeEnableAgeSortCommand => _changeEnableAgeSortCommand ?? (new RelayCommand<bool>(ChangeEnableSortAge));



        public PodcastDBContext dbContext { get; private set; }
        public ObservableCollection<Author> Authors { get; set; }

        public AuthorPageVM()
        {
            dbContext = new PodcastDBContext();
            Authors = new ObservableCollection<Author>(dbContext.Author.ToList());
        }

        public void ClearFilters(ObservableCollection<Author> authors)
        {
            if (authors != null)
            {
                var collection = CollectionViewSource.GetDefaultView(authors);
                collection.Filter = null;
            }
        }


        private bool SortByName(object author)
        {
            if(author == null || !(author is Author)) return false;
            return ((Author)author).Author_Name.ToLower().Contains(CurrentNameSorting.ToLower());
        }

        public void ChangeEnableSortName(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
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


        private bool SortBySurname(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_SurName.ToLower().Contains(CurrentSurnameSorting.ToLower());
        }

        public void ChangeEnableSortSurname(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            if (isEnabled)
                collection.Filter += SortBySurname;
            else
            {

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
        }

        private bool SortByPatronymic(object author)
        {
            if (author == null || !(author is Author) || (author as Author).Author_Patronymic == null) return false;
            return ((Author)author).Author_Patronymic.ToLower().Contains(CurrentPatronymicSorting.ToLower());
        }

        public void ChangeEnableSortPatronymic(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            if (isEnabled)
                collection.Filter += SortByPatronymic;
            else
            {

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
        }


        private bool SortByNickname(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_Nickname.ToLower().Contains(CurrentNicknameSorting.ToLower());
        }

        public void ChangeEnableSortNickname(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            if (isEnabled)
                collection.Filter += SortByNickname;
            else
            {

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
        }


        private bool SortByAge(object author)
        {
            if (author == null || !(author is Author)) return false;
            return ((Author)author).Author_Age == CurrentAgeSorting;
        }

        public void ChangeEnableSortAge(bool isEnabled)
        {
            var collection = CollectionViewSource.GetDefaultView(Authors);
            if (isEnabled)
                collection.Filter += SortByAge;
            else
            {

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
}
