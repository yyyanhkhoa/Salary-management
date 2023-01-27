using Salary_management.Controller.Infrastructure.Entities.Enums;
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

namespace Salary_management.View.Qualifications
{
    public partial class AllowanceQualificationForm : BaseForm
    {
        int idQualification;
        public AllowanceQualificationForm(Management mng, int idQualification)
        {
            InitializeComponent();
            this.idQualification = idQualification;
            this.mng = mng;
        }

        private void AllowanceQualificationForm_Load(object sender, EventArgs e)
        {
            loadAllowanceInQualification();
            AuthorizationButton(mng.Role);
        }
        private void AuthorizationButton(Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Accountant:
                    deleteBtn.Visible = false;
                    break;
                case Role.Viewer:
                    deleteBtn.Visible = false;
                    addBtn.Visible = false;
                    break;
            }
        }
        private void loadAllowanceInQualification()
        {
            this.allowanceInQualificationTable.Rows.Clear();
            var repo = new RepositoryQualification();
            var list = repo.GetQualificationAllowanceTimeline(idQualification).Payload;
            foreach (var item in list)
            {
                allowanceInQualificationTable.Rows.Add(item.Id, item.Year, item.Allowance);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddAllowanceInQualificationForm(this.mng,idQualification));
        }

        private void allowanceInQualificationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.allowanceInQualificationTable.Rows[e.RowIndex];
                if (allowanceInQualificationTable.CurrentRow.Index == allowanceInQualificationTable.Rows.Count - 1)
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
            int id = Convert.ToInt32(allowanceInQualificationTable.Rows[allowanceInQualificationTable.CurrentRow.Index].Cells[0].Value);
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this Allowance ??", "Confirm delete", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryQualificationAllowanceHistory();
                repo.DeleteQualificationAllowanceHistory(id);
                MessageBox.Show("Delete Success");
                loadAllowanceInQualification();
            }
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteBtn.BackColor = deleteBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteBtn.ForeColor = deleteBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new QualificationsForm(this.mng));
        }
    }
}
