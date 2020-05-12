using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class UserViewModel
    {
        private IList<User> _userList;

        public UserViewModel()
        {
            _userList = new List<User>()
            {
                new User() { Login = "login1", Password = "password1"},
                new User() { Login = "login2", Password = "password2" },
                new User() { Login = "login3", Password = "password3" }
            };
        }

        public IList<User> Users
        {
            get { return _userList; }
            set { _userList = value; }
        }

    }
}
