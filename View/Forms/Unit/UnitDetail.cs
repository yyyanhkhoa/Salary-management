using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
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
using System.Xml.Linq;

namespace Salary_management.View.Forms.Unit
{
    public partial class UnitDetailForm : Form
    {
        string idUnit;
        Management mng;
        public UnitDetailForm(Management mng,string idUnit)
        {
            InitializeComponent();
            this.idUnit = idUnit;
            this.mng = mng;
        }

        private void UnitDetailForm_Load(object sender, EventArgs e)
        {

            //Unit detail
            var repo = new RepositoryUnit();
            var unit = repo.GetUnitDetail(idUnit);
   
            NameText.Text = unit.Name;
            AddressText.Text = unit.Address;
            PhoneText.Text = unit.PhoneNumber;
            DateText.Text = unit.DateFounded.ToString();

            StartDateInput.Value = unit.DateFounded.ToDateTime(new TimeOnly(0,0,0),DateTimeKind.Utc);
            //Employee in ComboBox
            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                EmployeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }


            //Table
            /*
            var ahihi1 = DateOnly.FromDateTime(StartDateInput.Value);
            var ahihi2 = DateOnly.FromDateTime(EndDateInput.Value);
            var repoTable = new RepositoryUnit();
            var table = repoTable.GetTimeline(ahihi1,ahihi2);
            foreach (var employee in table)
            {
                ListEmployeeTable.Rows.Add(employee.EmployeeId, employee.EmployeeName,"","");
            }*/
        }

        private void WorkRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WorkRecentlyCheckBox.Checked) EndDatePanel.Visible = false;
            else EndDatePanel.Visible = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryEmployee();
            string NameAndId = EmployeeComboBox.Text;
            string id = NameAndId.Trim().Split(":")[0];
            DateOnly startDay = DateOnly.FromDateTime(StartDateInput.Value);
            DateOnly endDate ;
            
            if (!WorkRecentlyCheckBox.Checked) endDate = DateOnly.FromDateTime(EndDateInput.Value);
            MessageBox.Show(endDate.ToString());
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

                mng.OpenChildForm(new View.Forms.Unit.UnitDetailForm(this.mng,this.idUnit), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Unit.Unit(this.mng), sender);
        }
    }
}
