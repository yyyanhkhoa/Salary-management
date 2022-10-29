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
    public partial class AddRank : Form
    {
        private Management mng;
        public AddRank(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Position.ListPosition(this.mng), sender);
        }
    }
}
