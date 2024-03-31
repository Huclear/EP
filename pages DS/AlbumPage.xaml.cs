using Practice2.database;
using Practice2.ViewModels;
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

namespace Practice2.pages_DS
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
        }

        private void onSelectedAlbumChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (AlbumsDGr.SelectedItem != null && AlbumsDGr.SelectedItem is DataRowView album)
                {
                    NameInput.Text = album[1] as string;
                    DescriptionInput.Text = album[2] as string;
                    AuthorID_Selection.SelectedItem = (AuthorID_Selection.ItemsSource as List<PodcastDBDataSet.AuthorRow>).FirstOrDefault(row => row.ID_Author == Convert.ToInt32(album[3]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                AlbumsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
            }
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AlbumsDGr.SelectedItem != null && AlbumsDGr.SelectedItem is DataRowView album
                    && AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                {
                    var id = Convert.ToInt32(album[0]);
                    dbViewModel.UpdateAlbum(NameInput.Text, DescriptionInput.Text, author.ID_Author, id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();
            }
        }

        private void onDeleteAlbum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AlbumsDGr.SelectedItem != null && AlbumsDGr.SelectedItem is DataRowView album)
                {
                    var id = Convert.ToInt32(album[0]);
                    dbViewModel.DeleteFrom(Tables.Album, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                {
                    dbViewModel.AddAlbum(NameInput.Text, DescriptionInput.Text, author.ID_Author);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                AlbumsDGr.ItemsSource = dbViewModel.Albums.GetData();
            }
        }
    }
}
