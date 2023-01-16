using Salary_management.Controller.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management
{
    public partial class Management : Form
    {
        private Form activeForm;
        public Role Role { get; set; }


        public Management(Role role)
        {
            this.Role = role;
            InitializeComponent();
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void SettingBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSetting(), sender);

        }
		//private void Management_FormClosed(object sender, FormClosedEventArgs e){ Application.Exit(); }
        //private void ListEmployeeBtn_Click(object sender, EventArgs e){ OpenChildForm(new View.Forms.Employee.ListInformation(this), sender); }
        //private void PositionBtn_Click(object sender, EventArgs e) { OpenChildForm(new View.Forms.Position.ListPosition(this), sender); }
        //private void UnitBtn_Click(object sender, EventArgs e) { OpenChildForm(new View.Forms.Unit.Unit(this), sender); }
        //private void RewardOrNotBtn_Click(object sender, EventArgs e) { OpenChildForm(new View.Forms.RewardOrDiscipline.RewardOrNot(this), sender); }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        //private void OtherTabBtn_Click(object sender, EventArgs e) { OpenChildForm(new View.Forms.OtherTab.OtherTab(this), sender); }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Forms.Employee.ListInformation(this), sender);
        }

        private void PositionBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Forms.Position.ListPosition(this), sender);
            //OpenChildForm(new View.Forms.Position.DetailPosition(this,"GV111"), sender);
        }

        private void UnitBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Forms.Unit.Unit(this), sender);
        }

        private void RewardOrNotBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Forms.RewardOrDiscipline.RewardOrNot(this), sender);
        }

        private void OtherTabBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Forms.OtherTab.OtherTab(this), sender);
        }
    }
}
