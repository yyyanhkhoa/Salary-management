using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class AddQualification : Form
    {
        private Management mng;
        private string id;
        private string idEmploye;
        public AddQualification(Management mng, string id, string idEmploye)
        {
            InitializeComponent();
            this.mng = mng;
            this.id = id;
            this.idEmploye = idEmploye;
        }

        private void AddQualification_Load(object sender, EventArgs e)
        {
            var repoEX = new RepositoryExpertise();
            var listEX = repoEX.GetExpertises("");

            var repoQualifi = new RepositoryQualification();
            var list = repoQualifi.GetQualifications("");
            foreach (var quali in list)
            {
                nameQualificationBox.Items.Add(quali.Id + "-" + quali.Name + "-" + quali.Expertise.Name);
            }  
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (nameQualificationBox.SelectedIndex.ToString() == "") MessageBox.Show("Pls chosse qualification");
            else if (placeText.Text == "") MessageBox.Show("Pls input place of issue");
            else if (scoreText.Text == "") MessageBox.Show("Pls input score");         
            else
            {
                var repo = new RepositoryEmployeeQualification();
                DateOnly dateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value);

                string index = nameQualificationBox.Items[nameQualificationBox.SelectedIndex].ToString();
                string[] splits = (index.ToString()).Split('-');
                string idQuali = splits[0];
             
                var result = repo.InsertEmployeeQualification(new InputEmployeeQualification()
                {
                    EmployeeId = idEmploye,
                    Score = float.Parse(scoreText.Text),
                    IssueDate = dateOfBirth,
                    PlaceOfIssue = placeText.Text,
                    QualificationId = Int16.Parse(idQuali),                   
                });

                if (result.Success)
                {
                    MessageBox.Show("Insert Qualification of employee success" );
                    mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmploye, 2));
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }          
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmploye,2));
        }

        private void placeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoreText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }      
    }
}
