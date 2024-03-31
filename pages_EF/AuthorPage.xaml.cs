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
    /// Interaction logic for AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public PodcastsVM podcastsVM { get; set; }

        public AuthorPage(PodcastsVM _podcastsVM)
        {
            podcastsVM = _podcastsVM;
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.AddAuthor();
        }

        private void OnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            podcastsVM.SaveChanges();
        }
    }
}
