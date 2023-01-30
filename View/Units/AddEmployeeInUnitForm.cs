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
using System.Windows.Interop;

namespace Salary_management.View.Units
{
    public partial class AddEmployeeInUnitForm : BaseForm
    {
        string idUnit;
        public AddEmployeeInUnitForm(Management mng,string idUnit )
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnit = idUnit;
        }

        private void addEmployeeInUnitBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryUnitHistory();
            string NameAndId = employeeComboBox.Text;
            string id = NameAndId.Trim().Split(":")[0];
            DateOnly startDay = DateOnly.FromDateTime(startDateTimePicker.Value);
            DateOnly? endDate;

            if (!workRecentlyCheckBox.Checked) endDate = DateOnly.FromDateTime(endDateTimePicker.Value);
            else endDate = null;
            var result = repo.InsertUnitHistory(new InputUnitHistory()
            {
                EmployeeId = id,
                UnitId = idUnit,
                StartDate = startDay,
                EndDate = endDate,
            });
            if (result.Success)
            {
                MessageBox.Show("Insert new Employee in Unit success");
                mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));

            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void AddEmployeeInUnitForm_Load(object sender, EventArgs e)
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

        private void workRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (workRecentlyCheckBox.Checked) endDatePanel.Visible = false;
            else endDatePanel.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));
        }
    }
}
