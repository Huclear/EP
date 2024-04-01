using Practice4.ViewModels.EF;
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

namespace Practice4.pages
{
    /// <summary>
    /// Interaction logic for EpisodePage.xaml
    /// </summary>
    public partial class EpisodePage : Page
    {
        public EpisodePageVM episodesVM { get; set; }

        public EpisodePage()
        {
            episodesVM = new EpisodePageVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = DescriptionSortEnable.IsChecked = PodcastSortEnable.IsChecked = DurationSortEnable.IsChecked = false;
        }
    }
}
