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

        public ListPosition()
        {

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
            mng.OpenChildForm(new View.Forms.Position.AddRank(), sender);

        }

        private void AddPositionBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Position.AddPosition(), sender);

        }
    }
}
