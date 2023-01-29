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
    public partial class AddQualificationForm : BaseForm
    {
        public AddQualificationForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new QualificationsForm(this.mng));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryQualification();
            if (expertiseComboBox.Text == "") MessageBox.Show("Please select Expertise");
            else if (nameText.Text == "") MessageBox.Show("Please input name");
            else
            {
                string index = expertiseComboBox.Items[expertiseComboBox.SelectedIndex].ToString();
                string[] splits = (index.ToString()).Split('-');
                string idEx = splits[0];

                var result = repo.InsertQualification(new InputQualification()
                {
                    ExpertiseId = Int16.Parse(idEx),
                    Name = nameText.Text
                });

                if (result.Success)
                {
                    MessageBox.Show("Insert Qualification Success");
                    mng.OpenChildForm(new QualificationsForm(this.mng));
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }

        private void AddQualificationForm_Load(object sender, EventArgs e)
        {
            loadExpertiseInComboBox();
        }

        private void loadExpertiseInComboBox()
        {
            var repoEx = new RepositoryExpertise();
            var listEx = repoEx.GetExpertises("");
            foreach (var ex in listEx)
            {
                expertiseComboBox.Items.Add(ex.Id + "-" + ex.Name);
            }
        }
    }
}
