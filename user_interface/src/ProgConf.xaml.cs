﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPINACH_UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProgConf : Window
    {
        public ProgConf()
        {
            InitializeComponent();
            mnuProg.Visibility = Visibility.Visible;
        }

        private void mnuFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
