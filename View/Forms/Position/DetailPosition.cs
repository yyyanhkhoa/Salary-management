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

namespace Salary_management.View.Forms.Position
{
    public partial class DetailPosition : Form
    {
        Management mng;
        string idPosition;
        public DetailPosition(Management mng, string id)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.mng = mng;
            this.idPosition = id;
        }

        private void DetailPosition_Load(object sender, EventArgs e)
        {
            var repo = new RepositoryPosition();
            var detailPosition = repo.GetPositionDetail(idPosition);

            nameText.Text = detailPosition.Name;
            baseSalaryText.Text = detailPosition.BaseSalary.ToString();
            nameRankText.Text = detailPosition.Rank.Name.ToString();

            var repoEmployee = new RepositoryEmployee();
            List<Model.Employee> listEmployee = repoEmployee.GetEmployees("");
            foreach (Model.Employee employee in listEmployee)
            {
                EmployeeComboBox.Items.Add(employee.Id + ":" + employee.Name);
            }


            var repoTable = new RepositoryPosition();
            var table = repoTable.GetTimeline(idPosition).Payload;
            foreach (var employee in table)
            {
                detailPositionGridView.Rows.Add(employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }

        }

        private void nameRankText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryPositionHistory();
            string NameAndId = EmployeeComboBox.Text;
            string id = NameAndId.Trim().Split(":")[0];
            DateOnly startDay = DateOnly.FromDateTime(startDateText.Value);
            DateOnly? endDate;

            if (!WorkRecentlyCheckBox.Checked) endDate = DateOnly.FromDateTime(endDateText.Value);
            else endDate = null;
            var result = repo.InsertPositionHistory(new InputPositionHistory()
            {
                EmployeeId = id,
                PositionId = idPosition,
                StartDate = startDay,
                EndDate = endDate,
            });
            if (result.Success)
            {
                MessageBox.Show("Insert new Employee in Position success");

                mng.OpenChildForm(new View.Forms.Position.DetailPosition(this.mng, this.idPosition), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void WorkRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {

                if (WorkRecentlyCheckBox.Checked) endDatePanel.Visible = false;
                else endDatePanel.Visible = true;
            
        }
    }
}
