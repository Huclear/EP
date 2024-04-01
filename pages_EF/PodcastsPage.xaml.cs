using Practice4.database;
using Practice4.ViewModels.EF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PodcastsPage.xaml
    /// </summary>
    public partial class PodcastsPage : Page
    {
        public PodcastPageVM podcastsVM { get; set; }
        public PodcastsPage()
        {
            podcastsVM = new PodcastPageVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = DescriptionSortEnable.IsChecked = AuthorSortEnable.IsChecked = false;
        }


        private void AuthorID_Selection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            podcastsVM.RefreshCollection();
        }
    }
}
