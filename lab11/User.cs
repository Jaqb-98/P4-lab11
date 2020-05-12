using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class User : INotifyPropertyChanged
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (_login != value)
                {
                    _login = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));

                }
            }
        }

        private string _password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }


    }
}
