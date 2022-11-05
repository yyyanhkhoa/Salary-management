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
    public partial class AddPosition : Form
    {
        private Management mng;
        public AddPosition(Management mng)
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
            var RepoPosition = new RepositoryPosition();
            string ID = IDText.Text;
            string name = NameText.Text;
            string baseSalary = BaseSalaryText.Text;
            string rank = RankComboBox.Text;
            string[] id = rank.Trim().Split(":");
            string description = DescriptionText.Text;

            var result = RepoPosition.InsertPosition(new InputPosition()
            {
                Id = ID,
                Name = name,
                BaseSalary = int.Parse(baseSalary),
                RankId = int.Parse(id[0]),
                Description = description,
            });
            if (result.Success)
            {
                MessageBox.Show("Insert Position success");
                mng.OpenChildForm(new View.Forms.Position.ListPosition(this.mng), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            /*
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
            }*/


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPosition_Load(object sender, EventArgs e)
        {
            RepositoryRank repo = new RepositoryRank();
            List<Model.Rank> list = repo.GetRank("");
            foreach (Model.Rank rank in list)
            {
                RankComboBox.Items.Add(rank.Id + ":" + rank.Name);
            }
        }

      
    }
}
