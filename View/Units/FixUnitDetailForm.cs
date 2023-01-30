using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
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
        string idUnit;
        string idEmployee;

        public FixUnitDetailForm(Management mng, string idUnit, string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnit = idUnit;
            this.idEmployee = idEmployee;
        }

        private void FixUnitDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void workRecentlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (workRecentlyCheckBox.Checked) endDatePanel.Visible = false;
            else endDatePanel.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitDetailForm(this.mng, idUnit));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to update this Unit ??", "Confirm Update!!", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {

                DateOnly startDay = DateOnly.FromDateTime(startDateTimePicker.Value);
                DateOnly? endDate;
                if (!workRecentlyCheckBox.Checked) endDate = DateOnly.FromDateTime(endDateTimePicker.Value);

                var repo =new RepositoryUnitHistory();
                /*var result = repo.FixUnitHistory(idUnit, new InputUnitHistory()
                {
                    EmployeeId = idEmployee,
                    EndDate = endDate,
                    StartDate = startDay,
                });*/
            }
        }
    }
}
