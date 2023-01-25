using Salary_management.Controller.Infrastructure.Entities.Enums;
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

namespace Salary_management.View.Positions
{
    public partial class PositionDetailForm : BaseForm
    {
        private string idPosition;

        public PositionDetailForm(Management mng, string id)
        {
            InitializeComponent();
            this.idPosition = id;
            this.mng = mng;

        }

        private void PositionDetailForm_Load(object sender, EventArgs e)
        {
            LoadDataPositionDetail();
            AuthorizationButton(mng.Role);

        }

        private void AuthorizationButton(Role Role)
        {
            switch (Role)
            {
                case Role.Viewer:
                    actionGroupBox.Visible = false;
                    break;
                case Role.Accountant:
                    deletePanel.Visible = false;
                    break;
                case Role.Admin:
                    break;
                default: throw new ArgumentException();
            }
        }

        private void LoadDataPositionDetail()
        {
            var repo = new RepositoryPosition();
            var detailPosition = repo.GetPositionDetail(idPosition);

            nameText.Text = detailPosition.Name;
            baseSalaryText.Text = detailPosition.BaseSalary.ToString();
            rankText.Text = detailPosition.Rank.Name.ToString();

            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                employeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }


            var repoTable = new RepositoryPosition();
            var table = repoTable.GetTimeline(idPosition).Payload;
            foreach (var employee in table)
            {
                positionDetailTable.Rows.Add(employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }
        }
        private void nameGroupBox_Resize(object sender, EventArgs e)
        {
        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {

        }
    }
}
