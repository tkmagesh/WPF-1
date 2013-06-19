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

namespace CollectionBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> employees;

        public MainWindow()
        {
            InitializeComponent();
            employees = new ObservableCollection<Employee>()
                {
                    new Employee() {EmpId = 101, FirstName = "Magesh", LastName = "Kuppan", Salary = 10000}
                    , new Employee() {EmpId = 102, FirstName = "Suresh", LastName = "Kannan", Salary = 20000}
                    , new Employee() {EmpId = 103, FirstName = "Ganesan", LastName = "Eswaran", Salary = 30000}
                    , new Employee() {EmpId = 104, FirstName = "Mahesh", LastName = "Ganesan", Salary = 40000}
                };
            LstEmployees.DataContext = employees;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            employees.Add(new Employee() { EmpId = 105, FirstName = "Rajesh", LastName = "Pandit", Salary = 60000 });
            MessageBox.Show("New Employee is added - Current Employee Count = " + employees.Count);
        }
    }
}
