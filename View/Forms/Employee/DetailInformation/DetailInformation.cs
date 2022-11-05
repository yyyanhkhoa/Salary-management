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

namespace Salary_management.View.Forms.Employee
{
    public partial class FormEmployeeDetail : Form
    {
        private Management mng;
        public FormEmployeeDetail(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
            AddEmployeeGroupBox.Enabled = false;
            FamilyGridView.Enabled = false;
            FamilyGridView.Columns[0].ReadOnly = true;
         
            BackBtn.Enabled = true;
            FixBtn.Enabled = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FixBtn_Click(object sender, EventArgs e)
        {
       
        }

        private void ImagePicture_Click(object sender, EventArgs e)
        {

        }

        private void FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CoefficientAllowanceGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CoefficientAllowanceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartDateGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IdentityGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void IdentityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EthnicGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EthnicText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddressGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MaleBtn_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void FemaleBtn_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImagePicture_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void FormEmployeeDetail_Load(object sender, EventArgs e)
        {
        
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }
        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void AddFamilyBtn_Click(object sender, EventArgs e)
        {

        }

        private void FixBtn_Click_1(object sender, EventArgs e)
        {
            if (FixBtn.Text == "Fix")
            {
                AddEmployeeGroupBox.Enabled = true;
                FixBtn.Text = "Save";
            }
            else
            {
                AddEmployeeGroupBox.Enabled = false;
                FixBtn.Text = "Fix";
            }
        }

        private void FamilyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            if (FixFamilyBtn.Text == "Fix")
            {
               FamilyGridView.Enabled = true;
                FixFamilyBtn.Text = "Save";
            }
            else
            {
                FamilyGridView.Enabled = false;
                FixFamilyBtn.Text = "Fix";
            }
        }
    }
}
