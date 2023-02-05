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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Salary_management.View.Positions
{
    public partial class FixEmployeeInPositionForm : BaseForm
    {
        int idPositionHistory;
        string idPosition;
        string idEmployee;
        public FixEmployeeInPositionForm(Management mng,int idPositionHistory, string idPosition, string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idPositionHistory = idPositionHistory;
            this.idPosition = idPosition;
            this.idEmployee = idEmployee;
        }

        private void FixEmployeeInPositionForm_Load(object sender, EventArgs e)
        {
            LoadInfoHistory();
        }


        private void LoadInfoHistory()
        {
            var repo =new RepositoryPositionHistory();
            var result = repo.GetPositionHistory(idPositionHistory);
            var startDate = result.StartDate;
            var endDate = result.EndDate;
            startDateTimePicker.Value = new DateTime(startDate.Year,startDate.Month,startDate.Day);


            if (endDate==null)
            {
                workRecentlyCheckBox.Checked = true;
            }
            else
            {
                endDateTimePicker.Value = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day);
                workRecentlyCheckBox.Checked = false;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryPositionHistory();
            DateOnly startDate = DateOnly.FromDateTime(startDateTimePicker.Value);

            DateOnly endDate;
            if (!workRecentlyCheckBox.Checked)
            {
                endDate = DateOnly.FromDateTime(endDateTimePicker.Value);
            }

            var result = repo.FixPositionHistory(idPositionHistory, new InputPositionHistory()
            {
                StartDate = startDate,
                EndDate = endDate,
                EmployeeId = idEmployee,
                PositionId = idPosition,
            });
            if (result.Success)
            {
                MessageBox.Show("Update History success");
                mng.OpenChildForm(new PositionDetailForm(this.mng,idPosition));
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new PositionDetailForm(this.mng, idPosition));
        }

        private void workRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (workRecentlyCheckBox.Checked) endDatePanel.Visible = false;
            else endDatePanel.Visible = true;
        }
    }
}
