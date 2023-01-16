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

namespace Salary_management.View.Forms.RewardOrDiscipline
{
    public partial class RewardOrNot : Form
    {
        Management mng;
        public RewardOrNot(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void RewardOrNot_Load(object sender, EventArgs e)
        {
            //Employee
            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                EmployeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }




            //TableReward
            var repoReward = new RepositoryRewardOrDiscipline();
            var listEmployeeInReward = repoReward.GetRewardsByKeyword("");
            foreach (var employeeInReward in listEmployeeInReward)
            {
                RewardTable.Rows.Add(employeeInReward.EmployeeId, employeeInReward.EmployeeName, employeeInReward.Level, employeeInReward.Date, employeeInReward.Content);
            }

            //TableDiscipLine
            var repoReward2 = new RepositoryRewardOrDiscipline();
            var listEmployeeInDiscipline = repoReward2.GetDisciplinesByKeyword("");
            foreach (var employeeDiscipLine in listEmployeeInDiscipline)
            {
                DisciplineTable.Rows.Add(employeeDiscipLine.EmployeeId, employeeDiscipLine.EmployeeName, employeeDiscipLine.Level, employeeDiscipLine.Date, employeeDiscipLine.Content);
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryRewardOrDiscipline();
            string NameAndId = EmployeeComboBox.Text;
            string idEmployee = NameAndId.Trim().Split(":")[0];
            bool isReward = (TypeComboBox.Text == "Reward");
            DateOnly Day = DateOnly.FromDateTime(DateText.Value);
            string content = ContentText.Text;
            string level = LevelText.Text;

            var result = repo.InsertRewardOrDiscipline(new InputRewardOrDiscipline()
            {
                EmployeeId = idEmployee,
                IsReward = isReward,
                Date=Day,
                Content = content,
                Level = level,
            });

            if (result.Success)
            {
                MessageBox.Show("Insert RewardOrDiscipline success");
                mng.OpenChildForm(new View.Forms.RewardOrDiscipline.RewardOrNot(this.mng), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }
    }
}
