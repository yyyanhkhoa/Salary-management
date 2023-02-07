using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using Salary_management.View.Positions;
using ScottPlot.Ticks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;
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
            AuthorizationButton(mng.Role);
            SetUI();
        }
        private void AuthorizationButton(Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Viewer:
                    addBtn.Visible = false;
                    fixDetailBtn.Visible = false;
                    deleteDetailBtn.Visible = false;

                    fixUnitBtn.Visible = false;
                    break;
                case Role.Accountant:
                    deleteDetailBtn.Visible = false;

                    break;
                default:
                    return;
            }
        }
        private void SetUI()
        {
            fixUnitBtn.Enabled = false;
            
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
                unitDetailTable.Rows.Add(employee.Id,employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }

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
            filterEmployeeInUnionTable.Rows.Clear();
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



        private void fixUnitBtn_Click(object sender, EventArgs e)
        {
            DateOnly dateOfFounded = DateOnly.FromDateTime(dateFoundedDatePicker.Value);

            if (nameText.Text == "") MessageBox.Show("Name empty");
            else if (addressText.Text == "") MessageBox.Show("Address Empty");
            else if (phoneText.Text == "") MessageBox.Show("Phone Empty");
            else
            {
                MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to update this Unit ??", "Confirm Update!!", MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    var repo = new RepositoryUnit();
                    var result = repo.FixUnit(idUnit, new InputUnit()
                    {
                        Name = nameText.Text,
                        Address = addressText.Text,
                        DateFounded = dateOfFounded,
                        PhoneNumber = phoneText.Text,
                    });

                    if (result.Success)
                    {

                        MessageBox.Show("Update Unit success");
                        mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
            }
        }

        private void fixUnitBtn_EnabledChanged(object sender, EventArgs e)
        {
            fixUnitBtn.BackColor = fixUnitBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            fixUnitBtn.ForeColor = fixUnitBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            fixUnitBtn.Enabled = true;
        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            fixUnitBtn.Enabled = true;
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            fixUnitBtn.Enabled = true;
        }

        private void dateFoundedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            fixUnitBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddEmployeeInUnitForm(this.mng, idUnit));
        }

        private void deleteDetailBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(unitDetailTable.Rows[unitDetailTable.CurrentRow.Index].Cells[0].Value);

            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this History ??", "Confirm Delete!!", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryUnitHistory();
                repo.DeleteUnitHistory(id);
                MessageBox.Show("Delete Success");
                mng.OpenChildForm(new UnitDetailForm(this.mng, this.idUnit));
            }
        }

        private void fixDetailBtn_Click(object sender, EventArgs e)
        {
            int idUnitHistory = Convert.ToInt32(unitDetailTable.Rows[unitDetailTable.CurrentRow.Index].Cells[0].Value);
            string idEmployee = unitDetailTable.Rows[unitDetailTable.CurrentRow.Index].Cells[1].Value.ToString();
            mng.OpenChildForm(new FixUnitDetailForm(this.mng,idUnitHistory, idUnit, idEmployee));

        }

        private void deleteDetailBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteDetailBtn.BackColor = deleteDetailBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteDetailBtn.ForeColor = deleteDetailBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void fixDetailBtn_EnabledChanged(object sender, EventArgs e)
        {
            fixDetailBtn.BackColor = fixDetailBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            fixDetailBtn.ForeColor = fixDetailBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void unitDetailTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = unitDetailTable.Rows[e.RowIndex];
                if (unitDetailTable.CurrentRow.Index == unitDetailTable.Rows.Count - 1)
                {
                    fixDetailBtn.Enabled = false;
                    deleteDetailBtn.Enabled = false;
                }
                else
                {
                    fixDetailBtn.Enabled = true;
                    deleteDetailBtn.Enabled = true;
                }

            }
        }
    }
    
}
