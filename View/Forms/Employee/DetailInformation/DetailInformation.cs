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
            enableInfo(false);
            enableQualification(false);

            MessageBox.Show(employee.Name);

            //get Infomation detail
            NameText.Text = employee.Name;
            AddressText.Text = employee.Address;
            //DateOfBirth.Value = employee.DateOfBirth.ToString();
            // StartDate.Value = employee.StartDate;
            EthnicText.Text = employee.Ethnic;
            IdentityText.Text = employee.IdentityCardNumber;
            CoefficientAllowanceText.Text = employee.CoefficientAllowance.ToString();
           
            if (employee.Gender == Gender.Male)
            {
                MaleBtn.Checked = true;
                FemaleBtn.Checked = false;
            }
            else
            {
                FemaleBtn.Checked = true;
                MaleBtn.Checked = false;
            }
          
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
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, "0"), sender);
        }

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string idFamily = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();      
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng, idFamily), sender);
        }

        private void RemoveFamilyBtn_Click(object sender, EventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string idFamily = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();
           //xoa = id family
        }

        private void addQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng, "0"), sender);
        }

        private void addUnion_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng,"0"), sender);

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fixQualificationBtn_Click(object sender, EventArgs e)
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

        private void backQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void backFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void backUnionBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void removeUnion_Click(object sender, EventArgs e)
        {

        }

        private void fixUnion_Click(object sender, EventArgs e)
        {

        }

        private void FamilyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string id = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng, id), sender);
            }
        }

      
    }
}
