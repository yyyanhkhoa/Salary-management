using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class DetailInformation : Form
    {
        private Management mng;
        public DetailInformation(Management mng)
        {
            InitializeComponent();
            this.mng = mng;    
        }
        private void DetailInformation_Load(object sender, EventArgs e)
        {
            AddEmployeeGroupBox.Enabled = false;
            FamilyGridView.Enabled = false;
            FamilyGridView.Columns[0].ReadOnly = true;

            BackBtn.Enabled = true;
            FixBtn.Enabled = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void FixBtn_Click(object sender, EventArgs e)
        {
            if (FixBtn.Text == "Fix")
            {
                AddEmployeeGroupBox.Enabled = true;
                FixBtn.Text = "Save";
            }
            else
            {
                AddEmployeeGroupBox.Enabled = false;
                FixBtn.Text = "Fix";
            }
        }

        private void AddFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng), sender);

        }
    }
}
