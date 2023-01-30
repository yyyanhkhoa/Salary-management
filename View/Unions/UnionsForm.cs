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
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;

namespace Salary_management.View.Unions
{
    public partial class UnionsForm : BaseForm
    {
        public UnionsForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
           
        }

        private void unionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UnionsForm_Load(object sender, EventArgs e)
        {
            LoadUnion();
            AuthorizationButton(mng.Role);

        }

        private void AuthorizationButton(Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Viewer:
                    actionGroupBox.Visible = false;
                    break;
                case Role.Accountant:
                    deleteBtn.Visible = false;
                    break;
                default: 
                    return;
            }
        }

        private void LoadUnion()
        {
            var repo = new RepositoryUnion();
            var listUnion = repo.GetUnions("");
            foreach (var item in listUnion)
            {
                unionTable.Rows.Add(item.Id, item.Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryUnion();
            if (idText.Text == "") MessageBox.Show("Please input id");
            else if (nameText.Text == "") MessageBox.Show("Please input name");
            else
            {
                var result = repo.InsertUnion(idText.Text, nameText.Text);
                if (result.Success)
                {
                    MessageBox.Show("Insert Union Success");
                    LoadUnion();
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteBtn.BackColor = deleteBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteBtn.ForeColor = deleteBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void unionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.unionTable.Rows[e.RowIndex];
                if (unionTable.CurrentRow.Index == unionTable.Rows.Count - 1)
                {
                    deleteBtn.Enabled = false;
                }
                else
                {
                    deleteBtn.Enabled = true;
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var id = unionTable.Rows[unionTable.CurrentRow.Index].Cells[0].Value.ToString();
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this Union ??", "Confirm delete", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryUnion();
                repo.DeleteUnion(id);
                MessageBox.Show("Delete Success");
                LoadUnion();
            }
        }
    }
}
