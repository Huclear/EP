using Practice4.ViewModels.EF;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice4.pages
{
    /// <summary>
    /// Interaction logic for AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPageVM authorsVM { get; set; }

        public AuthorPage()
        {
            authorsVM = new AuthorPageVM();
            InitializeComponent();
            NameSelection.ItemsSource = authorsVM.GetNameEntries();
            SurnameSelection.ItemsSource = authorsVM.GetSurnameEntries();
            PatronymicSelection.ItemsSource = authorsVM.GetPatronymicEntries();
            NicknameSelection.ItemsSource = authorsVM.GetNicknameEntries();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = SurnameSortEnable.IsChecked = PatronymicSortEnable.IsChecked = NicknameSortEnable.IsChecked = AgeSortEnable.IsChecked = false;
        }

        private void OnSelectedFilter_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    if (cb.Name.ToLower().Contains("nickname"))
                        authorsVM.FilterByNickname();
                    else if (cb.Name.ToLower().Contains("surname"))
                        authorsVM.FilterBySurname();
                    else if (cb.Name.ToLower().Contains("name"))
                        authorsVM.FilterByName();
                    else if (cb.Name.ToLower().Contains("patronymic"))
                        authorsVM.FilterByPatronymic();
                }
            }
        }

        private void OnSortingString_Changed(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(AuthorsDGr.ItemsSource).Refresh();
        }
    }
}
