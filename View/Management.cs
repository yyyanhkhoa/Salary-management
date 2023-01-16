using FontAwesome.Sharp;
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
        //Fields
        private Form currentChildForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Role Role { get; set; }


        public Management(Role role)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);  
            panelMenu.Controls.Add(leftBorderBtn);
            this.Role = role;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods

        private void Management_Load(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new Salary_management.View.Home.HomeForm());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //title button
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this));

        }

        private void positionBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Salary_management.View.Positions.ListPositionForm(this));


        }

        private void unitBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void unionBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

        }

        private void qualificationBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
