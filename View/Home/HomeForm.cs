using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UITimer = System.Windows.Forms.Timer;



namespace Salary_management.View.Home
{
    public partial class HomeForm : Form
    {

        UITimer timer = new UITimer();

        public HomeForm()
        {
            InitializeComponent();

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }

        void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
