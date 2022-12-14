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

namespace Salary_management.View.Forms.Position
{
    public partial class AddRank : Form
    {
        private Management mng;
        public AddRank(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Position.ListPosition(this.mng), sender);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            var RepoRank = new RepositoryRank();
            string name = NameText.Text;
            string milestone = MilestoneComboBox.Text;
            string Coefficient = CoefficientText.Text;
            var result = RepoRank.InsertRank(new InputRank() 
            {
                Name = name, 
                Milestone = int.Parse(milestone),
                Coefficient = float.Parse(Coefficient),
            });
            if (result.Success)
            {
                MessageBox.Show("Insert Rank success");
                mng.OpenChildForm(new View.Forms.Position.ListPosition(this.mng), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

            /*
            if (NameText.Text == "") MessageBox.Show("Pls input name");
            else if ((!MaleBtn.Checked) && (!FemaleBtn.Checked)) MessageBox.Show("Pls select gender");
            else if (AddressText.Text == "") MessageBox.Show("Hay nhap dia chi");
            else if (EthnicText.Text == "") MessageBox.Show("Hay nhap dan toc");
            else if (CoefficientAllowanceText.Text == "") MessageBox.Show("Hay nhap he so phu cap");
            else if (IdentityText.Text == "") MessageBox.Show("Hay nhap cmnd");
            else
            {
                var RepoEmployee = new RepositoryEmployee();
                Gender gender;
                if (MaleBtn.Checked) gender = Gender.Male;
                else gender = Gender.Female;
                DateOnly dateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value);
                DateOnly startDate = DateOnly.FromDateTime(StartDate.Value);
                //MessageBox.Show(name + " " + gender + " " + dateOfBirth + " " + ethnic + " " + address + " " + startDate + " " + identity + " " + coefficientAllowance);
                var result = RepoEmployee.InsertEmployee(new EmployeeInput()
                {
                    Name = NameText.Text,
                    Gender = gender,
                    DateOfBirth = dateOfBirth,
                    Ethnic = EthnicText.Text,
                    Address = AddressText.Text,
                    StartDate = startDate,
                    IdentityCardNumber = IdentityText.Text,
                    CoefficientAllowance = float.Parse(CoefficientAllowanceText.Text),
                });
                if (result.Success)
                {
                    MessageBox.Show("Insert Employee success");
                    mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }

            }*/
        }
    }
}
