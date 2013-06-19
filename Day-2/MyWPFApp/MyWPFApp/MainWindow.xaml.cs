using System;
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

namespace MyWPFApp
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

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (this.TxtUsername.Text == "magesh" && this.TxtPassword.Password == "magesh")
            {
                this.TbStatus.Foreground = new SolidColorBrush(Colors.Green);
                this.TbStatus.Text = "Login successful!!";
            }
            else
            {
                this.TbStatus.Foreground = new SolidColorBrush(Colors.Red);
                this.TbStatus.Text = "Login failure!!!";
                TxtPassword.Password = string.Empty;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.TxtUsername.Text = this.TxtPassword.Password = string.Empty;
        }
    }
}
