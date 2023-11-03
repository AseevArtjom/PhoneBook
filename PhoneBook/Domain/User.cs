using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PhoneBook.Domain
{
    public class User : INotifyPropertyChanged
    {
        private string? _photo;
        private string? _fio;
        private string? _adress;
        private string? _number;

        public User(string photo,string fio,string adress,string number)
        {
            Photo = photo;
            FIO = fio;
            Adress = adress;
            Number = number;
        }

        public string? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public string? FIO
        {
            get { return _fio; }
            set
            {
                _fio = value;
                OnPropertyChanged("FIO");
            }
        }

        public string? Adress
        {
            get { return _adress; }
            set
            {
                _adress = value;
                OnPropertyChanged("Adress");
            }
        }

        public string? Number
        {
            get {return _number; }
            set
            {
                _number = value;
                OnPropertyChanged("Number");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
