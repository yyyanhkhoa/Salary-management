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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ImagePicture_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var RepoEmployee = new RepositoryEmployee();
            string name = NameText.Text;
            Gender gender;
            if (MaleBtn.Checked) gender = Gender.Male;
            else gender = Gender.Female;
            DateOnly dateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value);
            string ethnic = EthnicText.Text;
            DateOnly startDate = DateOnly.FromDateTime(StartDate.Value);
            string address = AddressText.Text;
            string identity = IdentityText.Text;
            float coefficientAllowance = float.Parse(CoefficientAllowanceText.Text);
            //MessageBox.Show(name + " " + gender + " " + dateOfBirth + " " + ethnic + " " + address + " " + startDate + " " + identity + " " + coefficientAllowance);
            RepoEmployee.InsertEmployee(new EmployeeInput()
            {
                Name = name,
                Gender = gender,
                DateOfBirth = dateOfBirth,
                Ethnic = ethnic,
                Address = address,
                StartDate = startDate,
                IdentityCardNumber = identity,
                CoefficientAllowance = coefficientAllowance,
            }) ;
        }

        private void MaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            FemaleBtn.Checked = false;
        }

        private void FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {
            MaleBtn.Checked = false;
        }
    }
}
