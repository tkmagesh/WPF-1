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
    /// Interaction logic for SalaryCalculatorUI.xaml
    /// </summary>
    public partial class SalaryCalculatorUI : Window
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
            //AlterBtnCalculateState();
        }


        /*private void TxtBasic_TextChanged(object sender, TextChangedEventArgs e)
        {
            AlterBtnCalculateState();
        }

        private void AlterBtnCalculateState()
        {
            this.BtnCalculate.IsEnabled = this.TxtBasic.Text != string.Empty 
                && this.TxtDa.Text != string.Empty 
                && this.TxtHra.Text != string.Empty;
        }

        private void TxtHra_TextChanged(object sender, TextChangedEventArgs e)
        {
            AlterBtnCalculateState();
        }

        private void TxtDa_TextChanged(object sender, TextChangedEventArgs e)
        {
            AlterBtnCalculateState();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double basic = double.Parse(this.TxtBasic.Text),
                   hra = double.Parse(this.TxtHra.Text),
                   da = double.Parse(this.TxtDa.Text),
                   tax = SliderTax.Value;
            var gross = basic + hra + da;
            var net = gross - (gross*(tax/100));
            this.TbSalary.Text = string.Format("{0:c}", net);
        }
*/
        /*private void SliderTax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (TbTax != null)
                TbTax.Foreground = e.NewValue < 25 ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
        }*/

        private void BtnCalculate_OnClick(object sender, RoutedEventArgs e)
        {
            var salaryCalculator = (SalaryCalculator) this.Resources["salaryCalculator"];
            salaryCalculator.CalculateSalary();
        }
    }
}
