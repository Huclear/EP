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
            NameSelection.ItemsSource = albumsVM.GetNameEntries();
            DescriptionSelection.ItemsSource = albumsVM.GetDescriptionEntries();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = DescriptionSortEnable.IsChecked = AuthorSortEnable.IsChecked = false;
        }

        private void OnSelectedFilter_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem != null)
                {
                    if (cb.Name.ToLower().Contains("name"))
                        albumsVM.FilterByName();
                    else if (cb.Name.ToLower().Contains("description"))
                        albumsVM.FilterByDescription();
                }
            }
        }

        private void OnSortingString_Changed(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(AlbumsDGr.ItemsSource).Refresh();
        }
    }
}
