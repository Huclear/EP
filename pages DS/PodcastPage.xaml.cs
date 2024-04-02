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

            NameSelection.ItemsSource = dbViewModel.Podcasts.GetData().ToList();
            DescriptionSelection.ItemsSource = dbViewModel.GetPodcastsDescriptionEntries().ToList();
        }

        private void ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            NameInput.Text = string.Empty;
            DescriptionInput.Text = string.Empty;
            AuthorID_Selection.SelectedItem = null;
            PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
        }

        private void OnSelectedAuthor_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorID_Selection.SelectedItem != null && AuthorID_Selection.SelectedItem is PodcastDBDataSet.AuthorRow author)
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetDataByAuthor(author.ID_Author);
            else
                PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetData();
        }

        private void OnSelectedFilter_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    if (cb.Name.ToLower().Contains("name"))
                        PodcastsDGr.ItemsSource = dbViewModel.Podcasts.SearchByName((cb.SelectedItem as PodcastDBDataSet.PodcastRow).Podcast_Name);
                    else if (cb.Name.ToLower().Contains("description"))
                        PodcastsDGr.ItemsSource = dbViewModel.Podcasts.SearchByDescription((cb.SelectedItem as PodcastDBDataSet.PodcastRow).Podcast_Description);
                }
            }
        }

        private void OnSorting_Changed(object sender, TextChangedEventArgs e)
        {
            if(sender is TextBox txt)
            {
                if (txt.Text != string.Empty)
                {
                    if (txt.Name.ToLower().Contains("name"))
                        PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetDataByName(txt.Text);
                    else if (txt.Name.ToLower().Contains("description"))
                        PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetDataByDescription(txt.Text);
                }
            }
        }
    }
}
