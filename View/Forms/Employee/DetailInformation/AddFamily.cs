using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
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
    public partial class AddFamily : Form
    {
        private Management mng;
        private string idFamily;
        public AddFamily(Management mng, string id)
        {
            InitializeComponent();
            this.mng = mng;
            this.idFamily = id;
        }
        private void AddFamily_Load(object sender, EventArgs e)
        {
            if (idFamily == "0")
            {
                // add
              

            }
            else
            {
                // fix
                var repo = new RepositoryEmployee();
                var employee = repo.GetEmployeeDetail(idFamily);
            }
        }

        private void AddFamilyGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng,"0"), sender);
        }

      

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
