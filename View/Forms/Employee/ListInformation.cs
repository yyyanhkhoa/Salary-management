using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Model.EmployeeList;
using Salary_management.View.Forms;
using System;
using System.Collections;
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
            string id = (ListViewEmployee.Rows[ListViewEmployee.CurrentRow.Index].Cells[0].Value).ToString();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {                
                mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng,id), sender);
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

            dateSalary.CustomFormat = "MM/yyyy";
            dateSalary.ShowUpDown = true;

            //get salary info
            dateSalary.MaxDate = DateTime.Now; 
            getSalaryInfo();

        }

        private void getSalaryInfo()
        {
            this.salaryGridView.Rows.Clear();
            RepositorySalary repoSalary = new RepositorySalary();
            //DateOnly.FromDateTime(DateTime.Now)
            List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalaries(null).Payload;
            foreach (Model.EmployeeSalary salary in list)
            {              
                long BHXH = salary.Salary / 20;
                long BHYT = salary.Salary / 100;
                long BHTN = salary.Salary / 100;
                long allSalary = salary.Salary - BHXH - BHYT - BHTN;
                salaryGridView.Rows.Add(salary.EmployeeName, salary.UnitName, salary.RankCoefficient, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, allSalary);
            }
            
        }
        private void searchSalaryBtn_Click(object sender, EventArgs e)
        {
            this.salaryGridView.Rows.Clear();
            if (searchSalaryByBox.SelectedIndex != 1)
            {  //Search Date only 
                RepositorySalary repoSalary = new RepositorySalary();
                // DateOnly date = new DateOnly(month: dateSalary.Value.Month, year: dateSalary.Value.Year);
                List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalaries(DateOnly.FromDateTime(dateSalary.Value)).Payload;
                foreach (Model.EmployeeSalary salary in list)
                {
                    long BHXH = salary.Salary / 20;
                    long BHYT = salary.Salary / 100;
                    long BHTN = salary.Salary / 100;
                    salaryGridView.Rows.Add(salary.EmployeeName, salary.UnitName, salary.RankCoefficient, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, salary.Salary);
                }
            }
            else
            {
                //Search Date vs Unit
                if (searchSalaryBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Unit");
                    return;
                }
                RepositorySalary repoSalary = new RepositorySalary();
                string indexU = searchSalaryBox.Items[searchSalaryBox.SelectedIndex].ToString();
                string[] splitsU = (indexU.ToString()).Split('-');
                string idU = splitsU[0];

                List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalariesAtUnit(idU,DateOnly.FromDateTime(dateSalary.Value)).Payload;
                foreach (Model.EmployeeSalary salary in list)
                {
                    long BHXH = salary.Salary / 20;
                    long BHYT = salary.Salary / 100;
                    long BHTN = salary.Salary / 100;
                    salaryGridView.Rows.Add(salary.EmployeeName, salary.UnitName, salary.RankCoefficient, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, salary.Salary);
                }
            }
        }


        private void searchSalaryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchSalaryBox.Items.Clear();
            if (searchSalaryByBox.SelectedIndex == 1)
            {
                RepositoryUnit repoUnit = new RepositoryUnit();
                var listUnit = repoUnit.GetUnits("");
                foreach (var unit in listUnit)
                {
                    searchSalaryBox.Items.Add(unit.Id + "-" + unit.Name);
                }
            }
        }
    }
}
