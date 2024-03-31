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

namespace Practice2.pages
{
    /// <summary>
    /// Interaction logic for EpisodePage.xaml
    /// </summary>
    public partial class EpisodePage : Page
    {
        public PodcastsVM podcastsVM { get; set; }

        public EpisodePage(PodcastsVM _podcastsVM)
        {
            podcastsVM = _podcastsVM;
            InitializeComponent();
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.SaveChanges();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.AddEpisode();
        }
    }
}
