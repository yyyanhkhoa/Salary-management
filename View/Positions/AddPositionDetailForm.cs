using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Positions
{
    public partial class AddPositionDetailForm : BaseForm
    {
        private string idPosition; 
        public AddPositionDetailForm(Management mng,string idPosition)
        {
            InitializeComponent();
            this.idPosition = idPosition;
            this.mng = mng;
        }

        private void workRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (workRecentlyCheckBox.Checked) endDatePanel.Visible = false;
            else endDatePanel.Visible = true;
        }

   

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new PositionDetailForm(this.mng, idPosition));
        }

        private void addEmployeeInPositionBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryPositionHistory();
            string NameAndId = employeeComboBox.Text;
            string id = NameAndId.Trim().Split(":")[0];
            DateOnly startDay = DateOnly.FromDateTime(startDateTimePicker.Value);
            DateOnly? endDate;

            if (!workRecentlyCheckBox.Checked) endDate = DateOnly.FromDateTime(endDateTimePicker.Value);
            else endDate = null;
            var result = repo.InsertPositionHistory(new InputPositionHistory()
            {
                EmployeeId = id,
                PositionId = idPosition,
                StartDate = startDay,
                EndDate = endDate,
            });
            if (result.Success)
            {
                MessageBox.Show("Insert new Employee in Position success");
                mng.OpenChildForm(new PositionDetailForm(this.mng, idPosition));

            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void AddPositionDetailForm_Load(object sender, EventArgs e)
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
    }
}
