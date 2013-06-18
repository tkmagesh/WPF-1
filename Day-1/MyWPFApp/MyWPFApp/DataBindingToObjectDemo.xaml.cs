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
using System.Windows.Shapes;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for DataBindingToObjectDemo.xaml
    /// </summary>
    public partial class DataBindingToObjectDemo : Window
    {
        /*NameFormatter formatter = new NameFormatter()
            {
                FirstName = "Magesh",
                LastName = "K"
            };
*/
        public DataBindingToObjectDemo()
        {
            InitializeComponent();
            /*this.TxtFirstName.DataContext = formatter;
            this.TxtLastName.DataContext = formatter;
            this.TbFormattedName.DataContext = formatter;*/
            
            //this.GridRoot.DataContext = formatter;

/*            this.DataContext = formatter;*/
        }

        private void BtnFormat_Click(object sender, RoutedEventArgs e)
        {
            //formatter.FirstName = "Some name";
        }
    }
}
