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
using System.Windows.Interop;

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
                    mng.OpenChildForm(new UnionsForm(this.mng));
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteBtn.BackColor = deleteBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteBtn.ForeColor = deleteBtn.Enabled ? Color.Gainsboro : Color.Black;
        }
    }
}
