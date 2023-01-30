using Microsoft.Reporting.Map.WebForms.BingMaps;
using Salary_management.Controller.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;

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
            int id = Convert.ToInt32(userTable.Rows[userTable.CurrentRow.Index].Cells[0].Value);
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this User ??", "Delete success", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryAuth();
                repo.DeleteUser(id);
                MessageBox.Show("Delete Success");
                mng.OpenChildForm(new UsersForm(this.mng));
            }

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.userTable.Rows.Clear();
            var repo = new RepositoryAuth();
            List<Model.Auth> auths = repo.GetUsers(searchText.Text);
            foreach (Model.Auth auth in auths)
            {
                userTable.Rows.Add(auth.Id, auth.Username, auth.Role);
            }
        }

        private void userTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userTable.Rows[e.RowIndex];
                if (userTable.CurrentRow.Index == userTable.Rows.Count - 1)
                {
                    deleteBtn.Enabled = false;
                }
                else
                {
                    deleteBtn.Enabled = true;
                }

            }
        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
