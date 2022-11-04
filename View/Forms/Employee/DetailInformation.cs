using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
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
    public partial class FormEmployeeDetail : Form
    {
        private Management mng;
        public FormEmployeeDetail(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
            AddEmployeeGroupBox.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImagePicture_Click(object sender, EventArgs e)
        {

        }

        private void FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }
    }
}
