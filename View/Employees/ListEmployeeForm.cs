using Salary_management.Controller.Infrastructure.Entities.Enums;
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

namespace Salary_management.View.Employees
{
    public partial class ListEmployeeForm : BaseForm
    {
        public ListEmployeeForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.listEmployeeTable.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees(searchText.Text);
            foreach (Model.Employee employee in list)
            {
                listEmployeeTable.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }

        private void ListEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadListEmployee();
            AuthorizationButton(mng.Role);
        }

        private void AuthorizationButton(Role Role)
        {
            switch (Role)
            {
                case Role.Viewer:
                    addBtn.Visible = false;
                    break;
                case Role.Accountant:
                    break;
                case Role.Admin:
                    break;
                default: throw new ArgumentException();
            }
        }

        private void LoadListEmployee()
        {
            this.listEmployeeTable.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees("");
            foreach (Model.Employee employee in list)
            {
                listEmployeeTable.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.AddNewEmployeeForm(this.mng));
        }

        private void listEmployeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string id = (listEmployeeTable.Rows[listEmployeeTable.CurrentRow.Index].Cells[0].Value).ToString();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
             e.RowIndex >= 0)
            {
                mng.OpenChildForm(new Detail.InformationDetailAboutEmployeeForm(this.mng, id));
            }

        }

        private void employeeTab_Click(object sender, EventArgs e)
        {

        }

        private void retirementBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new RetirementForm(this.mng));
        }
    }
}
