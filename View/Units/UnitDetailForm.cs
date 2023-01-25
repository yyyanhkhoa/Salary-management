using Salary_management.Controller.Infrastructure.Repositories;
using ScottPlot.Ticks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Units
{
    public partial class UnitDetailForm : BaseForm
    {
        string idUnit;
        public UnitDetailForm(Management mng, string idUnit)
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnit = idUnit;
        }

        private void UnitDetailForm_Load(object sender, EventArgs e)
        {
            LoadUnitDetail();
            LoadUnionInComboBox();
        }

        private void LoadUnionInComboBox()
        {
            var repoUnion = new RepositoryUnion();
            var listUnion = repoUnion.GetUnions("");
            foreach (var union in listUnion)
            {
                unionComboBox.Items.Add(union.Id + ":" + union.Name);

            }
        }

        private void LoadUnitDetail()
        {
            var repo = new RepositoryUnit();
            var unit = repo.GetUnitDetail(idUnit);

            nameText.Text = unit.Name;
            addressText.Text = unit.Address;
            phoneText.Text = unit.PhoneNumber;
            dateFoundedDatePicker.Value = new DateTime(unit.DateFounded.Year, unit.DateFounded.Month, unit.DateFounded.Day);
            var repoTable = new RepositoryUnit();
            var table = repoTable.GetTimeline(idUnit).Payload;
            foreach (var employee in table)
            {
                unitDetailTable.Rows.Add(employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }

        }

        private void addEmployeeInUnitBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddEmployeeInUnitForm(this.mng, idUnit));
        }

        private void backUnitBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitsForm(this.mng));

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitsForm(this.mng));

        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitsForm(this.mng));

        }

        private void unionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectText = unionComboBox.Text;
            var repoUnion = new RepositoryEmployee();
            var idUnion = selectText.Trim().Split(":")[0];
            var result = repoUnion.GetEmployeeOfUnitAndUnion(this.idUnit, idUnion);

            if (result.Success)
            {
                var getListInformation = result.Payload;
                foreach (var item in getListInformation)
                {
                    filterEmployeeInUnionTable.Rows.Add(item.EmployeeId, item.EmployeeName, item.UnionName, item.UnionStartDate);
                }
            }
            else
            {

                MessageBox.Show("Union unit id:" + idUnion + " " + idUnit + "Message :" + result.ErrorMessage);
            }
        }
    }
    
}
