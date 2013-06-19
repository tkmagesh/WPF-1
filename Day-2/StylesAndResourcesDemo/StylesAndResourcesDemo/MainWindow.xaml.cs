using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StylesAndResourcesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var resourceDictionaries = Application.Current.Resources.MergedDictionaries;
            resourceDictionaries.Remove(resourceDictionaries.First());
            resourceDictionaries.Add( new ResourceDictionary(){Source = new Uri(uriString: @"E:\Schneider\WPF-1\Day-2\StylesAndResourcesDemo\StylesAndResourcesDemo\NewBase.xaml")});

        }
    }
}
