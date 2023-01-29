using Salary_management.Controller.Infrastructure.Data.Input;
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
    public partial class AddAllowanceInQualificationForm : BaseForm
    {
        int idQualification;
        public AddAllowanceInQualificationForm(Management mng, int idQualification)
        {
            InitializeComponent();
            this.mng = mng;
            this.idQualification = idQualification;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryQualificationAllowanceHistory();
            if (allowanceText.Text == "") MessageBox.Show("Please input allowance");
            else
            {

                var result = repo.InsertQualificationAllowanceHistory(new InputQualificationAllowanceHistory()
                {
                    Year = Int32.Parse(dateTimePicker.Text),
                    Allowance = Int32.Parse(allowanceText.Text),
                    QualificationId = this.idQualification,
                });

                if (result.Success)
                {
                    MessageBox.Show("Insert Qualification history Success");
                    mng.OpenChildForm(new AllowanceQualificationForm(mng, idQualification));
                }
                else MessageBox.Show(result.ErrorMessage);
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AllowanceQualificationForm(mng, idQualification));
        }

        private void AddAllowanceInQualificationForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy";
            dateTimePicker.ShowUpDown = true;
        }
    }
}
