using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View.Positions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
namespace Salary_management.View.Units
{
    public partial class FixUnitDetailForm : BaseForm
    {
        int idUnitHistory;
        string idUnit;
        string idEmployee;


        public FixUnitDetailForm(Management mng,int idUnitHistory, string idUnit, string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnitHistory = idUnitHistory;
            this.idUnit = idUnit;
            this.idEmployee = idEmployee;
        }

        private void FixUnitDetailForm_Load(object sender, EventArgs e)
        {
            LoadInfoHistory();

        }


        private void LoadInfoHistory()
        {
            var repo = new RepositoryUnitHistory();
            var result = repo.GetUnitHistory(idUnitHistory);
            var startDate = result.StartDate;
            var endDate = result.EndDate;
            startDateTimePicker.Value = new DateTime(startDate.Year, startDate.Month, startDate.Day);


            if (endDate == null)
            {
                workRecentlyCheckBox.Checked = true;
            }
            else
            {
                endDateTimePicker.Value = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day);
                workRecentlyCheckBox.Checked = false;
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryUnitHistory();
            DateOnly startDate = DateOnly.FromDateTime(startDateTimePicker.Value);

            DateOnly endDate;
            if (!workRecentlyCheckBox.Checked)
            {
                endDate = DateOnly.FromDateTime(endDateTimePicker.Value);
            }

            var result = repo.FixUnitHistory(idUnitHistory, new InputUnitHistory()
            {
                StartDate = startDate,
                EndDate = endDate,
                EmployeeId = idEmployee,
                UnitId = idUnit,
            });
            if (result.Success)
            {
                MessageBox.Show("Update History in Unit success");
                mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));
            }
        }

        private void workRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (workRecentlyCheckBox.Checked) endDatePanel.Visible = false;
            else endDatePanel.Visible = true;
        }
    }
}
