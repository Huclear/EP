using MaterialDesignThemes.Wpf;
using Practice3.ViewModels;
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

namespace Practice3.pages_DS
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
            PodcastsDGr.ItemsSource = dbViewModel.Podcasts.GetFullInfo();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PodcastsDGr.Columns[0].Visibility = Visibility.Hidden;
            PodcastsDGr.Columns[3].Visibility = Visibility.Hidden;
        }
    }
}
