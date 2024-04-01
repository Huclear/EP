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
    /// Interaction logic for AlbumPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        private DataSetDBViewModel dbViewModel;
        public AlbumPage(DataSetDBViewModel _dbViewModel)
        {
            dbViewModel = _dbViewModel;
            InitializeComponent();
            AlbumsDGr.ItemsSource = dbViewModel.Albums.GetFullInfo();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AlbumsDGr.Columns[0].Visibility = Visibility.Hidden;
            AlbumsDGr.Columns[3].Visibility = Visibility.Hidden;
        }
    }
}
