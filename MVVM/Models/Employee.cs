using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace MVVM.Models
{
    public class Employee :INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string name;
        public string Name
        {
            get { return Name; }
            set { Name = value; OnPropertyChanged("Name");}
        }

        private int age;
        public int Age
        {
            get { return Age; }
            set { Age = value; OnPropertyChanged("Age");}
        }



    }
}
