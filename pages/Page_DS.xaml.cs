using Practice3.database.PodcastDBDataSetTableAdapters;
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

namespace Practice3.pages
{
    /// <summary>
    /// Interaction logic for Page_DS.xaml
    /// </summary>
    public partial class Page_DS : Page
    {
        private AllDataViewTableAdapter allDataTA;
        public Page_DS()
        {
            allDataTA = new AllDataViewTableAdapter();
            InfoDGr.ItemsSource = allDataTA.GetData();
            InitializeComponent();
        }
    }
}
