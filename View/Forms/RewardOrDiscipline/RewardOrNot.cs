using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Forms.RewardOrDiscipline
{
    public partial class RewardOrNot : Form
    {
        Management mng;
        public RewardOrNot(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }
    }
}
