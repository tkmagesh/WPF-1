using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MyWPFApp.Annotations;

namespace MyWPFApp
{
    public class SalaryCalculatorViewModel : INotifyPropertyChanged
    {
        private double _basic;
        private double _hra;
        private double _da;
        private double _tax;
        private double _salary;
        private SalaryCalculator salaryCalculator;

        public double Basic
        {
            get { return _basic; }
            set {
                _basic = value; 
                OnPropertyChanged("Basic");
                OnPropertyChanged("IsSalaryCalculatable");
            }
        }

        public double Hra
        {
            get { return _hra; }
            set
            {
                _hra = value;
                OnPropertyChanged("Hra");
                OnPropertyChanged("IsSalaryCalculatable");
            }
        }

        public double Da
        {
            get { return _da; }
            set
            {
                _da = value;
                OnPropertyChanged("Da");
                OnPropertyChanged("IsSalaryCalculatable");
            }
        }

        public double Tax
        {
            get { return _tax; }
            set { 
                _tax = value;
            OnPropertyChanged("Tax");
            }

        }

        public bool IsSalaryCalculatable
        {
            get { return Math.Abs(this.Basic - 0) > 0.001 && Math.Abs(this.Hra - 0) > 0.001 && Math.Abs(this.Da - 0) > 0.001; }
        }

        
        public double Salary
        {
            get
            {
                return _salary;
            }
            private set
            {
                _salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public MyCommand CalculateSalaryCommand { get; set; }

        public SalaryCalculatorViewModel()
        {
            salaryCalculator = new SalaryCalculator();
            CalculateSalaryCommand = new MyCommand(() =>
                {
                    Salary = salaryCalculator.CalculateSalary(Basic, Hra, Da, Tax);
                }, () => true);
        }
    }
}
