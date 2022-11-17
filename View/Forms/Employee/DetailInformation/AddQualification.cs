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
    public partial class AddQualification : Form
    {
        private Management mng;
        private string id;
        public AddQualification(Management mng, string id)
        {
            InitializeComponent();
            this.mng = mng;
            this.id = id;
        }

        private void AddQualification_Load(object sender, EventArgs e)
        {
            if (id == "0")
            {
                // add


            }
            else
            {
                // fix
                var repo = new RepositoryEmployee();
                var employee = repo.GetEmployeeDetail(id);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
