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
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumPage : Page
    {
        public AlbumPageVM albumsVM { get; set; }
        public AlbumPage()
        {
            albumsVM = new AlbumPageVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = DescriptionSortEnable.IsChecked = AuthorSortEnable.IsChecked = false;
        }
    }
}
