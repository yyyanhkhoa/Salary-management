using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View.Users;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;
namespace Salary_management.View.Units
{
    public partial class UnitsForm : BaseForm
    {
        public UnitsForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            LoadUnits();
            AuthorizationButton(mng.Role);
        }
        private void AuthorizationButton(Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    break;
                case Role.Accountant:
                    deleteBtn.Visible = false;
                    break;
                case Role.Viewer:
                    deleteBtn.Visible = false;
                    addBtn.Visible = false;
                    break;
                default: return;
            }
        }

        private void LoadUnits()
        {
            this.listUnitsTable.Rows.Clear();
            RepositoryUnit repo = new RepositoryUnit();
            List<Model.Unit> list = repo.GetUnits("");
            foreach (Model.Unit unit in list)
            {
                listUnitsTable.Rows.Add(unit.Id, unit.Name, unit.Address, unit.PhoneNumber, unit.DateFounded);
            }
        }
        private void listUnitsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string id = (listUnitsTable.Rows[listUnitsTable.CurrentRow.Index].Cells[0].Value).ToString();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
             e.RowIndex >= 0)
            {
                mng.OpenChildForm(new UnitDetailForm(this.mng, id));
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddUnitForm(this.mng));

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.listUnitsTable.Rows.Clear();
            RepositoryUnit repo = new RepositoryUnit();
            List<Model.Unit> list = repo.GetUnits(searchText.Text);
            foreach (Model.Unit unit in list)
            {
                listUnitsTable.Rows.Add(unit.Id, unit.Name, unit.Address, unit.PhoneNumber, unit.DateFounded);
            }
        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteBtn.BackColor = deleteBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteBtn.ForeColor = deleteBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void listUnitsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listUnitsTable.Rows[e.RowIndex];
                if (listUnitsTable.CurrentRow.Index == listUnitsTable.Rows.Count - 1)
                {
                    deleteBtn.Enabled = false;
                }
                else
                {
                    deleteBtn.Enabled = true;
                }

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = listUnitsTable.Rows[listUnitsTable.CurrentRow.Index].Cells[0].Value.ToString();
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this Unit ??", "Delete success", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo = new RepositoryUnit();
                repo.DeleteUnit(id);
                MessageBox.Show("Delete Success");
                LoadUnits();
            }
        }
    }
}
