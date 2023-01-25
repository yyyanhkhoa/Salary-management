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
    }
}
