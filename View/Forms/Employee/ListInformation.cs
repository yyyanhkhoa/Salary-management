using Salary_management.View.Forms;
using System;
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

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                mng.OpenChildForm(new View.Forms.Employee.FormEmployeeDetail(), sender);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.Add(this.mng), sender);

        }
    }
}
