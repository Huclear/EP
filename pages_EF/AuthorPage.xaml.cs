﻿using Practice4.ViewModels.EF;
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
    /// Interaction logic for AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPageVM authorsVM { get; set; }

        public AuthorPage()
        {
            authorsVM = new AuthorPageVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameSortEnable.IsChecked = SurnameSortEnable.IsChecked = PatronymicSortEnable.IsChecked = NicknameSortEnable.IsChecked = AgeSortEnable.IsChecked = false;
        }
    }
}
