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
    /// Interaction logic for EpisodePage.xaml
    /// </summary>
    public partial class EpisodePage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public EpisodePage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            EpisodesDGr.ItemsSource = dbViewModel.Episodes.GetFullInfo();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EpisodesDGr.Columns[0].Visibility = Visibility.Hidden;
            EpisodesDGr.Columns[4].Visibility = Visibility.Hidden;
        }
    }
}
