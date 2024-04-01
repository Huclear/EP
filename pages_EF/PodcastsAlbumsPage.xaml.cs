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

namespace Practice3.pages_EF
{
    /// <summary>
    /// Interaction logic for PodcastsAlbumsPage.xaml
    /// </summary>
    public partial class PodcastsAlbumsPage : Page
    {
        public PodcastsVM podcastsVM { get; set; }

        public PodcastsAlbumsPage(PodcastsVM _podcastsVM)
        {
            podcastsVM = _podcastsVM;
            InitializeComponent();
        }
    }
}
