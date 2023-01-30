using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Salary_management.Controller.Infrastructure.Entities.Enums;
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

namespace Salary_management.View.Users
{
    public partial class AddUserForm : BaseForm
    {
        public AddUserForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        Role convertRole(string role)
        {
            switch (role) {
                case "Admin":
                    return Role.Admin;
                case "Accountant":
                    return Role.Accountant;
                case "Viewer":
                    return Role.Viewer;
                default: return Role.Viewer;
            }
            
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            var username = usernameText.Text;
            var password = passwordText.Text;
            var role = roleCombobox.Text;
            if (username == "") MessageBox.Show("Plz input username");
            else if (password == "") MessageBox.Show("Plz input password");
            if (role == "") MessageBox.Show("Plz select role");
            else
            {
                var repo = new RepositoryAuth();
                var result = repo.InsertUser(username, password, convertRole(role));
                if (result.Success)
                {
                    MessageBox.Show("Insert new Employee success");
                    mng.OpenChildForm(new UsersForm(this.mng));
                }
                else
                {
                    MessageBox.Show("Error insert new user");
                }
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UsersForm(this.mng));
        }
    }
}
