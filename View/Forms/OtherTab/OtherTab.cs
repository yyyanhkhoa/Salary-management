using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Forms.OtherTab
{
    public partial class OtherTab : Form
    {
        Management mng;
        public OtherTab(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void OtherTab_Load(object sender, EventArgs e)
        {

        }
    }
}
