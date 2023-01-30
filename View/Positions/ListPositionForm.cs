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

namespace Salary_management.View.Positions
{
    public partial class ListPositionForm : BaseForm
    {

        public ListPositionForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void ListPositionForm_Load(object sender, EventArgs e)
        {
            LoadPosition();
            LoadRank();
            AuthorizationButton(mng.Role);

        }
        private void AuthorizationButton(Role Role)
        {
            switch (Role)
            {
                case Role.Viewer:
                    addBtn.Visible = false;
                    addRankBtn.Visible = false;
                    deleteBtn.Visible = false;
                    break;
                case Role.Accountant:
                    deleteBtn.Visible = false;
                    break;
                case Role.Admin:
                    break;
                default: throw new ArgumentException();
            }
        }
        private void LoadPosition()
        {
            this.listPositionsTable.Rows.Clear();
            RepositoryPosition repo1 = new RepositoryPosition();
            List<Model.Position> listPosition = repo1.GetPositions("");
            foreach (Model.Position position in listPosition)
            {
                listPositionsTable.Rows.Add(position.Id, position.Name, position.BaseSalary, position.Description, position.Rank.Name);
            }
        }

        private void LoadRank()
        {
            this.listRankTable.Rows.Clear();
            RepositoryRank repo = new RepositoryRank();
            List<Model.Rank> list = repo.GetRank("");
            foreach (Model.Rank rank in list)
            {
                listRankTable.Rows.Add(rank.Id, rank.Name, rank.Milestone, rank.Coefficient);
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            this.listPositionsTable.Rows.Clear();
            RepositoryPosition repo1 = new RepositoryPosition();
            List<Model.Position> listPosition = repo1.GetPositions(searchText.Text);
            foreach (Model.Position position in listPosition)
            {
                listPositionsTable.Rows.Add(position.Id, position.Name, position.BaseSalary, position.Description, position.Rank.Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Positions.AddNewPositionForm(this.mng));

        }

        private void listPositionsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string id = listPositionsTable.Rows[listPositionsTable.CurrentRow.Index].Cells[0].Value.ToString();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                mng.OpenChildForm(new View.Positions.PositionDetailForm(this.mng,id));
            }
        }

        private void searchRankText_TextChanged(object sender, EventArgs e)
        {
            this.listRankTable.Rows.Clear();
            RepositoryRank repo = new RepositoryRank();
            List<Model.Rank> list = repo.GetRank(searchRankText.Text);
            foreach (Model.Rank rank in list)
            {
                listRankTable.Rows.Add(rank.Id, rank.Name, rank.Milestone, rank.Coefficient);
            }
        }

        private void addRankBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Positions.AddNewRankForm(this.mng));

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
