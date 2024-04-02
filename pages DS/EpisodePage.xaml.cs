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

            NameSelection.ItemsSource = dbViewModel.Episodes.GetData().ToList();
            DescriptionSelection.ItemsSource = dbViewModel.GetEpisodesDescriptionEntries().ToList();
        }

        private void OnClearFilter_Click(object sender, RoutedEventArgs e)
        {   
            DurationInput.Text = NameInput.Text = DescriptionInput.Text = string.Empty;
            PodcastIDSelector.SelectedItem = null;
            EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
        }

        private void OnSelectedPodcast_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (PodcastIDSelector.SelectedItem != null && PodcastIDSelector.SelectedItem is PodcastDBDataSet.PodcastRow author)
                EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetDataByPodcast(author.ID_Podcast);
            else
                EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetData();
        }

        private void OnSortingText_Changed(object sender, TextChangedEventArgs e)
        {
            decimal dur;
            if (sender is TextBox txt)
            {
                if (txt.Text != string.Empty)
                {
                    if (txt.Name.ToLower().Contains("name"))
                        EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetDataByName(txt.Text);
                    else if (txt.Name.ToLower().Contains("description"))
                        EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetDataByDescription(txt.Text);
                    else if(txt.Name.ToLower().Contains("duration"))
                        if(decimal.TryParse(txt.Text, out dur))
                            EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetDataByDuration(dur);
                }
            }
        }

        private void OnSelectedFilter_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    if (cb.Name.ToLower().Contains("name"))
                        EpisodesDGr.ItemsSource = dbViewModel.Episodes.SearchByName((cb.SelectedItem as PodcastDBDataSet.EpisodeRow).Episode_Name);
                    else if (cb.Name.ToLower().Contains("description"))
                        EpisodesDGr.ItemsSource = dbViewModel.Episodes.SearchByDescription((cb.SelectedItem as PodcastDBDataSet.EpisodeRow).Episode_Description);
                }
            }
        }
    }
}
