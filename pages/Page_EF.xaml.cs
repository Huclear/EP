using Practice3.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Page_EF.xaml
    /// </summary>
    public partial class Page_EF : Page
    {
        private PodcastDBContext dbContext;
        public ObservableCollection<AllDataView> allDataViews { get; set; }
        public Page_EF()
        {
            dbContext = new PodcastDBContext();
            allDataViews = new ObservableCollection<AllDataView>(dbContext.AllDataView.ToList());
            InitializeComponent();
        }
    }
}
