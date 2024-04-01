using Practice3.pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Practice3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page_EF efPage;
        private Page_DS dsPage;

        public MainWindow()
        {
            efPage = new Page_EF();
            dsPage = new Page_DS();

            InitializeComponent();
            PageSelection.ItemsSource = new object[]
            {
                Realizations.Entities,
                Realizations.DataSets,
            };
        }

        private void onSelectedPageChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PageSelection.SelectedItem != null && PageSelection.SelectedItem is Realizations)
            {
                switch (PageSelection.SelectedItem)
                {
                    case Realizations.Entities:
                        pages_EF.Content = efPage;
                        break;
                    case Realizations.DataSets:
                        pages_EF.Content = dsPage;
                        break;
                }
            }
        }
    }
}
