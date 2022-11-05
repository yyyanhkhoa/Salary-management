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

namespace Salary_management.View.Forms.Position
{
    public partial class ListPosition : Form
    {
        private Management mng;

        public ListPosition(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void ListViewPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                mng.OpenChildForm(new View.Forms.Position.DetailPosition(), sender);
            }
        }

        private void AddRankBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Position.AddRank(this.mng), sender);

        }

        private void AddPositionBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Position.AddPosition(this.mng), sender);

        }

        private void ListPosition_Load(object sender, EventArgs e)
        {
            this.PositionGridView.Rows.Clear();
            RepositoryPosition repo1 = new RepositoryPosition();
            List<Model.Position> listPosition = repo1.GetPositions("");
            foreach(Model.Position position in listPosition)
            {
                PositionGridView.Rows.Add(position.Id, position.Name, position.BaseSalary, position.Description, position.Rank.Name);
            }



            this.RankGridView.Rows.Clear();
            RepositoryRank repo = new RepositoryRank();
            List<Model.Rank> list = repo.GetRank("");
            foreach (Model.Rank rank in list)
            {
                RankGridView.Rows.Add(rank.Id, rank.Name, rank.Milestone,rank.Coefficient );
            }
            /*
            this.ListViewEmployee.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            List<Model.Employee> list = repo.GetEmployees("");
            foreach (Model.Employee employee in list)
            {
                ListViewEmployee.Rows.Add(employee.Id, employee.Name, employee.DateOfBirth, employee.IdentityCardNumber, employee.CoefficientAllowance);
            }*/
        }
    }
}
