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

        private void onDelete_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorsDGr.SelectedItem != null && AuthorsDGr.SelectedItem is DataRowView author)
            {
                try
                {
                    var id = Convert.ToInt32(author[0]);
                    dbViewModel.DeleteFrom(Tables.Author, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    AuthorsDGr.ItemsSource = dbViewModel.Authors.GetData();
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var age = Convert.ToInt32(AgeInput.Text);
                dbViewModel.AddAuthor(NameInput.Text, SurnameInput.Text, PatronymicInput.Text, NicknameInput.Text, age);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                AuthorsDGr.ItemsSource = dbViewModel.Authors.GetData();
            }
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorsDGr.SelectedItem != null && AuthorsDGr.SelectedItem is DataRowView author)
            {
                try
                {
                    var id = Convert.ToInt32(author[0]);
                    var age = Convert.ToInt32(AgeInput.Text);
                    dbViewModel.UpdateAuthor(NameInput.Text, SurnameInput.Text, PatronymicInput.Text, NicknameInput.Text, age, id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    AuthorsDGr.ItemsSource = dbViewModel.Authors.GetData();
                }
            }
        }

        private void onSelectedItemsChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorsDGr.SelectedItem is DataRowView author)
            {
                try
                {
                    NameInput.Text = author[1] as string;
                    SurnameInput.Text = author[2] as string;
                    PatronymicInput.Text = author[3] as string;
                    NicknameInput.Text = author[4] as string;
                    AgeInput.Text = Convert.ToInt32(author[5]).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
