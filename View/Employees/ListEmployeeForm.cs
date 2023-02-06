using Salary_management.Controller.Infrastructure;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
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
            LoadFamily();
            LoadQualification();
            AuthorizationButton(mng.Role);
        }

        private void LoadQualification()
        {
            var repoQ = new RepositoryQualification();
            var result = repoQ.GetQualifications("");
            foreach(Model.Qualification qualification in result)
            {
                qualificationComboBox.Items.Add(qualification.Id + "-" + qualification.Name);
            }
            if(result.Count!=0)
            {
                var qualification = result[0];
                qualificationComboBox.Text = qualification.Id + "-" + qualification.Name;
                GetQualification(qualification.Id,0);
            }
        }

        private void GetQualification(int qualificationID,float score)
        {
            qualificationTable.Rows.Clear();
            var repo = new RepositoryEmployeeQualification();
            var result = repo.GetEmployeesAboveScoreOf(qualificationID, score).Payload;
            foreach(Model.EmployeeQualification item in result)
            {
                qualificationTable.Rows.Add(item.EmployeeId,item.EmployeeName,item.QualificationName,item.IssueDate,item.PlaceOfIssue,item.Score);          
            }
            
        }
        private void LoadFamily()
        {
            relativeComboBox.Text = "Wife";
            GetFamily("", RelativeType.Wife);
        }

        private void GetFamily(string search, RelativeType relative)
        {
            familyTable.Rows.Clear();
            var repo = new RepositoryFamily();
            var result = repo.GetFamilies(search, relative);

            foreach(Model.Family family in result)
            {
                familyTable.Rows.Add(family.EmployeeId, family.EmployeeName, family.Name, family.DateOfBirth, family.Occupation, family.RelativeType);
            }
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
            mng.OpenChildForm(new AddNewEmployeeForm(this.mng));
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



        private void nameFamilyText_TextChanged(object sender, EventArgs e)
        {
            GetChangeFamily();
        }

        private void GetChangeFamily()
        {
            if (relativeComboBox.Text == "Wife") GetFamily(nameFamilyText.Text, RelativeType.Wife);
            else if (relativeComboBox.Text == "Husband") GetFamily(nameFamilyText.Text, RelativeType.Husband);
            else if (relativeComboBox.Text == "Child") GetFamily(nameFamilyText.Text, RelativeType.Child);
        }
        private void relativeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetChangeFamily();
        }

        private void scoreText_TextChanged(object sender, EventArgs e)
        {
            float score = 0;
            if (scoreText.Text != "") score=float.Parse(scoreText.Text) ;
            int id = int.Parse(qualificationComboBox.Text.Trim().Split("-")[0]);
            GetQualification(id, score);
        }

        private void qualificationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float score = 0;
            if (scoreText.Text != "") score = float.Parse(scoreText.Text);
            int id = int.Parse(qualificationComboBox.Text.Trim().Split("-")[0]);
            GetQualification(id, score);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportAll();
        }
    }
}
