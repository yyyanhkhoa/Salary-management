using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Model.EmployeeList;
using Salary_management.View.Forms;
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
    public partial class ListInformation : Form
    {
        private Management mng;

        public ListInformation(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        public ListInformation()
        {

            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ListViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                mng.OpenChildForm(new View.Forms.Employee.FormEmployeeDetail(), sender);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.Add(this.mng), sender);

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ListViewEmployee.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees(SearchTextBox.Text);
            foreach(Model.Employee employee in list)
            {
                ListViewEmployee.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }

        private void ListInformation_Load(object sender, EventArgs e)
        {
            this.ListViewEmployee.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees("");
            foreach (Model.Employee employee in list)
            {
                ListViewEmployee.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }
    }
}
