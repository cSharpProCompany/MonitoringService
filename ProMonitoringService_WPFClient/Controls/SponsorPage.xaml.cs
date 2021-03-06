﻿using System;
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
using System.Windows.Shapes;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for SponsorPage.xaml
    /// </summary>
    public partial class SponsorPage : Window
    {
        public SponsorPage()
        {
            InitializeComponent();
        }

        private void CloseWhindow_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();

            e.Handled = true;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Enter email/name/tag_id to search customer")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}
