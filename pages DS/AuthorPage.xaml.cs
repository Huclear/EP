using Practice4.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Practice4.pages_DS
{
    /// <summary>
    /// Interaction logic for AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public AuthorPage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            AuthorsDGr.ItemsSource = dbViewModel.Authors.GetData();
        }

        private void OnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            NameInput.Text = SurnameInput.Text = PatronymicInput.Text = NicknameInput.Text = AgeInput.Text = string.Empty;
            AuthorsDGr.ItemsSource = dbViewModel.Authors.GetData();
        }

        private void OnSortingString_Changed(object sender, TextChangedEventArgs e)
        {
            int age;
            if (sender is TextBox txt)
            {
                if (txt.Text != string.Empty)
                {
                    if (txt.Name.ToLower().Contains("surname"))
                        AuthorsDGr.ItemsSource = dbViewModel.Authors.GetDataBySurname(txt.Text);
                    else if (txt.Name.ToLower().Contains("nickname"))
                        AuthorsDGr.ItemsSource = dbViewModel.Authors.GetDataByNickname(txt.Text);
                    else if (txt.Name.ToLower().Contains("name"))
                        AuthorsDGr.ItemsSource = dbViewModel.Authors.GetDataByName(txt.Text);
                    else if (txt.Name.ToLower().Contains("patronymic"))
                        AuthorsDGr.ItemsSource = dbViewModel.Authors.GetDataByPatronymic(txt.Text);
                    else if (txt.Name.ToLower().Contains("age"))
                        if (int.TryParse(txt.Text, out age))
                            AuthorsDGr.ItemsSource = dbViewModel.Authors.GetDataByAge(age);
                }
            }
        }
    }
}
