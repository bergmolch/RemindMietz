using System;
using System.ComponentModel;
using System.Diagnostics;

namespace RemindMietz.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime _date;
        private bool _food1;
        private bool _food2;
        private bool _shit;

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }
            }
        }

        public bool Food1
        {
            get
            {
                return _food1;
            }
            set
            {
                _food1 = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Food1"));
                }
                UpdateValues();
            }
        }

        public bool Food2
        {
            get
            {
                return _food2;
            }
            set
            {
                _food2 = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Food2"));
                }
                UpdateValues();
            }
        }

        public bool Shit
        {
            get
            {
                return _shit;
            }
            set
            {
                _shit = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Shit"));
                }
                UpdateValues();
            }
        }

        public MainViewModel()
        {
            Date = DateTime.Now;
        }

        private void UpdateValues()
        {
            if (_food1 && _food2 && _shit)
            {
                Date = DateTime.Now;
                Console.WriteLine("ALL DONE!");
            }
        }
    }
}
