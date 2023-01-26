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
    public partial class UsersForm : BaseForm
    {
        public UsersForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            loadUser();
        }

        private void loadUser()
        {
            this.userTable.Rows.Clear();
            var repo = new RepositoryAuth();
            List<Model.Auth> auths = repo.GetUsers("");
            foreach (Model.Auth auth in auths)
            {
                userTable.Rows.Add(auth.Id,auth.Username,auth.Role);
            }
        }
    
        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddUserForm(this.mng));
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteBtn.BackColor = deleteBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteBtn.ForeColor = deleteBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
