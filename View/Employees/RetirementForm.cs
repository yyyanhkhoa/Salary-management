using Salary_management.Controller.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Salary_management.View.Employees
{
    public partial class RetirementForm : BaseForm
    {
        public RetirementForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ListEmployeeForm(this.mng));
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

        private void retirementDate_ValueChanged(object sender, EventArgs e)
        {
            listEmployeeTable.Rows.Clear();
            loadRetirement();

        }

        private void RetirementForm_Load(object sender, EventArgs e)
        {
            loadRetirement();
        }

        private void loadRetirement()
        {
            DateOnly dateOfRetirement = DateOnly.FromDateTime(retirementDate.Value);

            var repo = new RepositoryEmployee();
            var result = repo.GetRetiredEmployeesAt(dateOfRetirement);
            foreach (Model.Employee employee in result)
            {
                listEmployeeTable.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }
        }
    }
}
