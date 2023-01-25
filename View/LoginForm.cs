using Salary_management.Controller.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            checkLogin(userText.Text, passwordText.Text);

        }
        private void checkLogin(string username, string password)
        {
            var authRepo = new RepositoryAuth();
            if(username == "") MessageBox.Show("Plz input username");
            else if(password=="") MessageBox.Show("Plz input password");
            else if (!authRepo.CheckUserExist(username, password))MessageBox.Show("Incorrect Information");
            else
            {
                var result = authRepo.Login(username, password);
                var user = result.Payload;
                Management mng = new Management(user.Role);
                this.Hide();
                mng.Show();
            }
        }
    }
}
