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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinDeployQT_GUI.UserControls
{
    /// <summary>
    /// Логика взаимодействия для WinDeployQtUserControl.xaml
    /// </summary>
    public partial class WinDeployQtUserControl : UserControl
    {
        public WinDeployQtUserControl()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WinDeployQt_status.ScrollToEnd();
        }
    }
}
