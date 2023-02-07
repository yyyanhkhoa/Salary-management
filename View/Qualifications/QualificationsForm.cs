using Microsoft.Reporting.Map.WebForms.BingMaps;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View.Users;
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
    public partial class QualificationsForm : BaseForm
    {
        public QualificationsForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void QualificationsForm_Load(object sender, EventArgs e)
        {
            loadExpertise();
            loadQualification();
            AuthorizationButton(mng.Role);
        }

        private void AuthorizationButton(Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Accountant:
                    deleteQualificationBtn.Visible = false;
                    deleteExpertiseBtn.Visible = false;
                    break;
                case Role.Viewer:
                    deleteQualificationBtn.Visible = false;
                    actionGroupBox.Visible = false;
                    addQualificationBtn.Visible = false;
                    break;
                default: return;

            }
        }
        private void loadQualification()
        {
            qualificationTable.Rows.Clear();
            var repoQ = new RepositoryQualification();
            var listQualification = repoQ.GetQualifications("");
            foreach (var item in listQualification)
            {
                qualificationTable.Rows.Add(item.Id, item.Name, item.Expertise.Name);
            }
        }
        private void loadExpertise()
        {
            expertiseTable.Rows.Clear();
            var repoEx = new RepositoryExpertise();
            var listEx = repoEx.GetExpertises("");
            foreach (var ex in listEx)
            {
                expertiseTable.Rows.Add(ex.Id, ex.Name);
            }
        }
        private void expertiseTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.expertiseTable.Rows[e.RowIndex];
                if (expertiseTable.CurrentRow.Index == expertiseTable.Rows.Count - 1)
                {
                    deleteExpertiseBtn.Enabled = false;
                }
                else
                {
                    deleteExpertiseBtn.Enabled = true;
                }

            }
        }
        private void deleteExpertiseBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteExpertiseBtn.BackColor = deleteExpertiseBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteExpertiseBtn.ForeColor = deleteExpertiseBtn.Enabled ? Color.Gainsboro : Color.Black;
        }
        private void addNewExpertise()
        {
            var repo = new RepositoryExpertise();
            if (nameExpertiseText.Text == "") MessageBox.Show("Please input name");
            else
            {
                var result = repo.InsertExpertise(nameExpertiseText.Text);
                if (result.Success)
                {
                    MessageBox.Show("Insert Expertise Success");
                    mng.OpenChildForm(new QualificationsForm(this.mng));
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }
        private void deleteExpertise(int id)
        {
            var repo = new RepositoryExpertise();
            repo.DeleteExpertise(id);

        }
        private void addExpertiseBtn_Click(object sender, EventArgs e)
        {
            addNewExpertise();
        }
        private void deleteExpertiseBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(expertiseTable.Rows[expertiseTable.CurrentRow.Index].Cells[0].Value);
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this Expertise ??", "Delete success", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                deleteExpertise(id);
                MessageBox.Show("Delete success");
                loadExpertise();
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.qualificationTable.Rows.Clear();
            var repoQ = new RepositoryQualification();
            var listQualification = repoQ.GetQualifications(searchText.Text);
            foreach (var item in listQualification)
            {
                qualificationTable.Rows.Add(item.Id, item.Name, item.Expertise.Name);
            }
        }

        private void allowanceBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(qualificationTable.Rows[qualificationTable.CurrentRow.Index].Cells[0].Value);
            mng.OpenChildForm(new AllowanceQualificationForm(this.mng,id));
        }

        private void qualificationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.qualificationTable.Rows[e.RowIndex];
                if (qualificationTable.CurrentRow.Index == qualificationTable.Rows.Count - 1)
                {
                    deleteQualificationBtn.Enabled = false;
                    allowanceBtn.Enabled = false;
                }
                else
                {
                    deleteQualificationBtn.Enabled = true;
                    allowanceBtn.Enabled = true;
                }
            }
        }

        private void addQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddQualificationForm(this.mng));
        }

        private void deleteQualificationBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(qualificationTable.Rows[qualificationTable.CurrentRow.Index].Cells[0].Value);
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this Qualification ??", "Confirm delete", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryQualification();
                repo.DeleteQualification(id);
                MessageBox.Show("Delete Success");
                loadQualification();
            }
        }
    }

}

