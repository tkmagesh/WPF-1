using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyWPFApp
{
    public class NameFormatter : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                TriggerPropertyChanged("FirstName");
                TriggerPropertyChanged("FullName");
            }
        }

        private void TriggerPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string LastName
        {
            get { return _lastName; }
            set { 
                _lastName = value; 
                TriggerPropertyChanged("LastName");
                TriggerPropertyChanged("FullName");
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

       
    }
}
