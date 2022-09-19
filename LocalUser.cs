using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_management
{
    internal class LocalUser
    {
        int mark = 0;
        List<User> _users;

        public LocalUser(int mark, List<User> users)
        {
            this.mark = mark;
            _users = users;
        }

        public void createNewUser(string username,string password)
        {
            mark++;
            User newUser = new User(mark,username, password);
            _users.Add(newUser);
        }

        public bool checkUserExist(string username,string password)
        {
            foreach(User user in _users)
            {
                if ((user.GetUserName() == username) && (user.GetPassWord() == password)) return true;
            }
            return false;
        }


    }
}
