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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class AddUnion : Form
    {
        private Management mng;
        private int idUnion;
        private string idEmploye;
        public AddUnion(Management mng, int idUnion, string idEmploye)
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnion = idUnion;
            this.idEmploye = idEmploye;
        }

        private void AddUnion_Load(object sender, EventArgs e)
        {
            var repoUnion = new RepositoryUnion();
            var listUnion = repoUnion.GetUnions("");
            foreach (var union in listUnion)
            {
                unionJoinBox.Items.Add(union.Id + ":" + union.Name);
            }
            if (idUnion == 0)
            {
                // add


            }
            else
            {
                // fix
                var repo = new RepositoryUnionHistory();
                var union = repo.GetUnionHistory(idUnion);
                AddBtn.Text = "Save";
                NameText.Text = union.UnionName;
                startDay.Value = new DateTime(union.StartDate.Year, union.StartDate.Month, union.StartDate.Day);
                if (union.EndDate != null)
                {
                    checkBox1.Checked = true;
                    panel6.Visible = true;
                    endDay.Value = new DateTime(union.EndDate.Value.Year, union.EndDate.Value.Month, union.EndDate.Value.Day);
                }
                unionJoinBox.SelectedIndex = unionJoinBox.FindString(union.UnionId);

            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (idUnion == 0)
            {
                // add


            }
            else
            {
                // fix
                          
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng, idEmploye,3), sender);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                panel6.Visible = false;
            }
            else panel6.Visible = true;
        }


    }
}
