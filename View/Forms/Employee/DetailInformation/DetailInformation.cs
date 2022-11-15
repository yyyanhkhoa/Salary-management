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

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class DetailInformation : Form
    {
        private Management mng;
        private string idEmployee;
        public DetailInformation(Management mng,string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idEmployee = idEmployee;
        }
        void enableInfo (bool check)
        {
            if (check == true)
            {
                NameText.Enabled = true;
                AddressText.Enabled = true;
                DateOfBirth.Enabled = true;
                EthnicText.Enabled = true;  
                IdentityText.Enabled = true;
                CoefficientAllowanceText.Enabled = true;
                StartDate.Enabled = true;
                MaleBtn.Enabled = true;
                FemaleBtn.Enabled =true;
            } else
            {
                NameText.Enabled = false;
                AddressText.Enabled = false;
                DateOfBirth.Enabled = false;
                EthnicText.Enabled = false;
                IdentityText.Enabled = false;
                CoefficientAllowanceText.Enabled = false;
                StartDate.Enabled = false;
                MaleBtn.Enabled = false;
                FemaleBtn.Enabled = false;
            }           
                
        }
        void enableQualification(bool check)
        {
            if (check == true)
            {
                namecallQualificationTB.Enabled = true;
                nameQualificationTB.Enabled = true;
                dateQualification.Enabled = true;
                placeQualificationTB.Enabled = true;
                exQualificationTB.Enabled = true;                  
            }
            else
            {
                namecallQualificationTB.Enabled = false;
                nameQualificationTB.Enabled = false;
                dateQualification.Enabled = false;
                placeQualificationTB.Enabled = false;
                exQualificationTB.Enabled = false;

            }
        }
        private void DetailInformation_Load(object sender, EventArgs e)
        {

            var repo = new RepositoryEmployee();

            var employee = repo.GetEmployeeDetail(idEmployee);

            MessageBox.Show(employee.Name);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void FixBtn_Click(object sender, EventArgs e)
        {
            if (FixBtn.Text == "Fix")
            {
                enableInfo(true);              
                FixBtn.Text = "Save";
            }
            else
            {
                enableInfo(false);               
                FixBtn.Text = "Fix";
            }
        }

        private void AddFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng), sender);

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (fixQualificationBtn.Text == "Fix")
            {
                fixQualificationBtn.Text = "Save";
                enableQualification(true);
            }
            else
            {
                fixQualificationBtn.Text = "Fix";
                enableQualification(false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }
    }
}
