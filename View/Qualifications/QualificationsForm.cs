using Microsoft.Reporting.Map.WebForms.BingMaps;
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
        }

        private void loadExpertise()
        {
            var repoEx = new RepositoryExpertise();
            var listEx = repoEx.GetExpertises("");
            foreach (var ex in listEx)
            {
                expertiseTable.Rows.Add(ex.Id, ex.Name);
            }
        }


        private void deleteExpertiseBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(expertiseTable.Rows[expertiseTable.CurrentRow.Index].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }

        private void addExpertiseBtn_Click(object sender, EventArgs e)
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

        private void expertiseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
