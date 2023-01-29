using Salary_management.Controller.Infrastructure.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class AddUnion : Form
    {
        private Management mng;       
        private string idEmploye;
        public AddUnion(Management mng, string idEmploye)
        {
            InitializeComponent();
            this.mng = mng;         
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
  
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
          
            if (unionJoinBox.SelectedIndex  == -1)
            {
                MessageBox.Show("Please select union");
            }
            else if (checkBox1.Checked)
            {
                var repo = new RepositoryUnionHistory();

                DateOnly startDate = DateOnly.FromDateTime(startDayBox.Value);
                string indexU = unionJoinBox.Items[unionJoinBox.SelectedIndex].ToString();
                string[] splitsU = (indexU.ToString()).Split(':');
                string idU = splitsU[0];

                // if have endDay
                DateOnly enddate = DateOnly.FromDateTime(endDayBox.Value);
                var result = repo.InsertUnionHistory( new InputUnionHistory()
                {
                    UnionId = idU,
                    StartDate = startDate,
                    EndDate = enddate,
                    EmployeeId = idEmploye ,
                });
                if (result.Success)
                {
                    MessageBox.Show("Add new Union history success");
                    mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmploye, 3));
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
            else
            {
                var repo = new RepositoryUnionHistory();

                DateOnly startDate = DateOnly.FromDateTime(startDayBox.Value);
                string indexU = unionJoinBox.Items[unionJoinBox.SelectedIndex].ToString();
                string[] splitsU = (indexU.ToString()).Split(':');
                string idU = splitsU[0];
                // if don't have endDay
                var result = repo.InsertUnionHistory( new InputUnionHistory()
                {
                    UnionId = idU,
                    StartDate = startDate,
                    EmployeeId = idEmploye,
                   // EndDate = null ,
                });
                if (result.Success)
                {
                    MessageBox.Show("Add new Union history success");
                    mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmploye, 3));
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmploye,3));
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
