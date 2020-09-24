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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            randomLable(new Random(), lbl1, lbl2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            randomLable(new Random(), lbl1, lbl2);
        }
        private void randomLable(Random randomizer,params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Background = new SolidColorBrush(Color.FromArgb(255, (byte)randomizer.Next(256), (byte)randomizer.Next(256), (byte)randomizer.Next(256)));
                label.Content = randomizer.Next();
            }
        }
    }
}
