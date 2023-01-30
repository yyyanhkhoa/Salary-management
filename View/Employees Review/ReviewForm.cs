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

namespace Salary_management.View.Employees_Review
{
    public partial class ReviewForm : BaseForm
    {
        public ReviewForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;

        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            LoadRewardTable();
            LoadDisciplineTable();
        }

        private void LoadRewardTable()
        {
            var repoReward = new RepositoryRewardOrDiscipline();
            var listEmployeeInReward = repoReward.GetRewardsByKeyword("");
            foreach (var employeeInReward in listEmployeeInReward)
            {
                rewardTable.Rows.Add(employeeInReward.EmployeeId, employeeInReward.EmployeeName, employeeInReward.Level, employeeInReward.Date, employeeInReward.Content);
            }
        }

        private void LoadDisciplineTable()
        {
            var repoReward = new RepositoryRewardOrDiscipline();
            var listEmployeeInDiscipline = repoReward.GetDisciplinesByKeyword("");
            foreach (var employeeDiscipLine in listEmployeeInDiscipline)
            {
                disciplineTable.Rows.Add(employeeDiscipLine.EmployeeId, employeeDiscipLine.EmployeeName, employeeDiscipLine.Level, employeeDiscipLine.Date, employeeDiscipLine.Content);
            }
        }

        private void addRewardBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddReviewForm(this.mng, true));
        }


        private void searchRewardText_TextChanged(object sender, EventArgs e)
        {
            rewardTable.Rows.Clear();
            var repoReward = new RepositoryRewardOrDiscipline();
            var listEmployeeInReward = repoReward.GetRewardsByKeyword(searchRewardText.Text);
            foreach (var employeeInReward in listEmployeeInReward)
            {
                rewardTable.Rows.Add(employeeInReward.EmployeeId, employeeInReward.EmployeeName, employeeInReward.Level, employeeInReward.Date, employeeInReward.Content);
            }
        }

        private void searchDisciplineText_TextChanged(object sender, EventArgs e)
        {
            disciplineTable.Rows.Clear();
            var repoReward = new RepositoryRewardOrDiscipline();
            var listEmployeeInDiscipline = repoReward.GetDisciplinesByKeyword(searchDisciplineText.Text);
            foreach (var employeeDiscipLine in listEmployeeInDiscipline)
            {
                disciplineTable.Rows.Add(employeeDiscipLine.EmployeeId, employeeDiscipLine.EmployeeName, employeeDiscipLine.Level, employeeDiscipLine.Date, employeeDiscipLine.Content);
            }
        }

        private void addDisciplineBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddReviewForm(this.mng, false));

        }

        private void disciplineTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
