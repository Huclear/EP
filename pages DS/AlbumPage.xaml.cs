using Practice4.database;
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
    /// Interaction logic for AlbumPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public AlbumPage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            AuthorID_Selection.ItemsSource = dbViewModel.Authors.GetData().ToList();
            AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();

            NameSelection.ItemsSource = dbViewModel.Albums.GetData().ToList();
            DescriptionSelection.ItemsSource = dbViewModel.GetAlbumsDescriptionEntries().ToList();
        }

        private void OnSorting_Changed(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (txt.Text != string.Empty)
                {
                    if (txt.Name.ToLower().Contains("name"))
                        AlbumsDGr.ItemsSource = dbViewModel.Albums.GetDataByName(txt.Text);
                    else if (txt.Name.ToLower().Contains("description"))
                        AlbumsDGr.ItemsSource = dbViewModel.Albums.GetDataByDescription(txt.Text);
                }
            }
        }

        private void OnSelectedAuthor_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                AlbumsDGr.ItemsSource = dbViewModel.Albums.GetDataByAuthor(author.ID_Author);
            else
                AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();
        }

        private void OnClearFilter_Click(object sender, RoutedEventArgs e)
        {
            NameInput.Text = string.Empty;
            DescriptionInput.Text = string.Empty;
            AuthorID_Selection.SelectedItem = null;
            AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();
        }

        private void OnSelectedFilter_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    if (cb.Name.ToLower().Contains("name"))
                        AlbumsDGr.ItemsSource = dbViewModel.Albums.SearchByName((cb.SelectedItem as PodcastDBDataSet.AlbumRow).Album_Name);
                    else if (cb.Name.ToLower().Contains("description"))
                        AlbumsDGr.ItemsSource = dbViewModel.Albums.SearchByDescription((cb.SelectedItem as PodcastDBDataSet.AlbumRow).Album_Description);
                }
            }
        }
    }
}
