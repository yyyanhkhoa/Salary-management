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

namespace Salary_management.View.Employees_Review
{
    public partial class AddReviewForm : BaseForm
    {
        bool isReward;
        public AddReviewForm(Management mng, bool isReward)
        {
            InitializeComponent();
            this.mng = mng;
            this.isReward = isReward;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeInComboBox();
        }

        private void LoadEmployeeInComboBox()
        {
            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                employeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ReviewForm(mng));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryRewardOrDiscipline();
            string NameAndId = employeeComboBox.Text;
            string idEmployee = NameAndId.Trim().Split(":")[0];
            DateOnly Day = DateOnly.FromDateTime(dateTimePicker.Value);
            string content = contentText.Text;
            string level = levelText.Text;

            var result = repo.InsertRewardOrDiscipline(new InputRewardOrDiscipline()
            {
                EmployeeId = idEmployee,
                IsReward = isReward,
                Date = Day,
                Content = content,
                Level = level,
            });

            if (result.Success)
            {
                if(isReward) MessageBox.Show("Insert Reward for Employee success");
                else MessageBox.Show("Insert Discipline for Employee success");
                mng.OpenChildForm(new ReviewForm(this.mng));
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
