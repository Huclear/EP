using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for PodcastPage.xaml
    /// </summary>
    public partial class PodcastPage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public PodcastPage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            AuthorID_Selection.ItemsSource = dbViewModel.Authors.GetData().ToList();
            PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(PodcastsDGr.SelectedItem != null && PodcastsDGr.SelectedItem is DataRowView podcast
                    && AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                {
                    var id = Convert.ToInt32(podcast[0]);
                    dbViewModel.UpdatePodcast(NameInput.Text, DescriptionInput.Text, author.ID_Author, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
            }
        }

        private void onSelectedPodcast_Changed(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (PodcastsDGr.SelectedItem != null && PodcastsDGr.SelectedItem is DataRowView podcast)
                {
                    NameInput.Text = podcast[1] as string;
                    DescriptionInput.Text = podcast[2] as string;
                    AuthorID_Selection.SelectedItem = (AuthorID_Selection.ItemsSource as List<PodcastDBDataSet.AuthorRow>).FirstOrDefault(row => row.ID_Author == Convert.ToInt32(podcast[3]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
            }
        }

        private void onDeletePodcast_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PodcastsDGr.SelectedItem != null && PodcastsDGr.SelectedItem is DataRowView podcast)
                {
                    var id = Convert.ToInt32(podcast[0]);
                    dbViewModel.DeleteFrom(Tables.Podcast, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                {
                    dbViewModel.AddPodcast(NameInput.Text, DescriptionInput.Text, author.ID_Author);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
            }
        }
    }
}
