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
    /// Interaction logic for EpisodePage.xaml
    /// </summary>
    public partial class EpisodePage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public EpisodePage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            PodcastIDSelector.ItemsSource = dbViewModel.Podcasts.GetData().ToList();
            EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
        }

        private void onSelectedEpisodeChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(EpisodesDGr.SelectedItem != null && EpisodesDGr.SelectedItem is DataRowView episode)
                {
                    NameInput.Text = episode[1] as string;
                    DescriptionInput.Text = episode[2] as string;
                    DurationInput.Text = Convert.ToDecimal(episode[3]).ToString();
                    PodcastIDSelector.SelectedItem = (PodcastIDSelector.ItemsSource as List<PodcastDBDataSet.PodcastRow>).FirstOrDefault(row => row.ID_Podcast == Convert.ToInt32(episode[4]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
        }

        private void onDeleteEpisode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EpisodesDGr.SelectedItem != null && EpisodesDGr.SelectedItem is DataRowView episode)
                {
                    var id = Convert.ToInt32(episode[0]);
                    dbViewModel.DeleteFrom(Tables.Episodes, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
            finally
            {
                EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PodcastIDSelector.SelectedItem != null && PodcastIDSelector.SelectedItem is PodcastDBDataSet.PodcastRow podcast)
                {
                    var duration = Convert.ToDecimal(DurationInput.Text);
                    dbViewModel.AddEpisode(NameInput.Text, DescriptionInput.Text, duration, podcast.ID_Podcast);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); ;
            }
            finally
            {
                EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
            }
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EpisodesDGr.SelectedItem != null && EpisodesDGr.SelectedItem is DataRowView episode
                    && PodcastIDSelector.SelectedItem != null && PodcastIDSelector.SelectedItem is PodcastDBDataSet.PodcastRow podcast)
                {
                    var id = Convert.ToInt32(episode[0]);
                    var duration = Convert.ToDecimal(DurationInput.Text);
                    dbViewModel.UpdateEpisode(NameInput.Text, DescriptionInput.Text, duration, podcast.ID_Podcast, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
            }
        }
    }
}
