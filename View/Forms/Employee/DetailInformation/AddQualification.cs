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
        private string idEmploye;
        public AddQualification(Management mng, string id, string idEmploye)
        {
            InitializeComponent();
            this.mng = mng;
            this.id = id;
            this.idEmploye = idEmploye;
        }

        private void AddQualification_Load(object sender, EventArgs e)
        {

            var repoEX = new RepositoryExpertise();
            var listEX = repoEX.GetExpertises("");
            foreach (var ex in listEX)
            {
                exBox.Items.Add(ex.Id + ":" + ex.Name);

            }
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
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng, idEmploye), sender);
        }

        private void placeText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
