using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab11
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {

        public UserViewModel vm { get; set; }
        public User CurrentUser = new User();



        public LoginControl()
        {
            InitializeComponent();
            vm = new UserViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Log(UserName.Text, Password.Password);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }


        private void Log(string login, string password)
        {

            var user = vm.Users.Where(u => u.Login == login).FirstOrDefault();
            if (user != null)
            {
                if (user.Password == password)
                {
                    CurrentUser.Login = user.Login;
                    CurrentUser.Password = user.Password;
                }else
                    MessageBox.Show("Wrong password");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void LogOut()
        {
            CurrentUser.Login = null;
            CurrentUser.Password = null;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogOut();
            UserName.Clear();
            Password.Clear();
        }
    }
}
