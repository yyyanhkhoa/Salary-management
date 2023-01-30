using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.View.Units;
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
using SystemColors = System.Drawing.SystemColors;
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
            SetUI();
        }


        private void SetUI()
        {
            idText.ReadOnly = true;
            fixPositionBtn.Enabled = false;
        }
        private void AuthorizationButton(Role Role)
        {
            switch (Role)
            {
                case Role.Viewer:
                    nameText.ReadOnly = true;
                    baseSalaryText.ReadOnly = true;
                    idText.ReadOnly = true;

                    deleteDetailBtn.Visible = false;
                    addBtn.Visible = false;
                    fixDetailBtn.Visible = false;
                    fixPositionBtn.Visible = false;
                    break;
                case Role.Accountant:
                    deleteDetailBtn.Visible = false;
                    break;
                case Role.Admin:
                    break;
                default: throw new ArgumentException();
            }
        }

        private void LoadDataPositionDetail()
        {
            var repo = new RepositoryPosition();
            var position = repo.GetPositionDetail(idPosition);

            idText.Text = position.Id;
            nameText.Text = position.Name;
            baseSalaryText.Text = position.BaseSalary.ToString();
            descriptionText.Text = position.Description;

            //load rank combobox
            var rankInPosition = position.Rank;
            rankComboBox.Text = rankInPosition.Id.ToString() + "-" + rankInPosition.Name;

            var repoRank =new RepositoryRank();
            List<Model.Rank> list = repoRank.GetRank("");
            foreach (Model.Rank rank in list)
            {
                rankComboBox.Items.Add(rank.Id + "-" + rank.Name);
            }
            //load table
            var repoTable = new RepositoryUnit();
            var table = repoTable.GetTimeline(idPosition).Payload;
            foreach (var employee in table)
            {
                positionDetailTable.Rows.Add(employee.UnitId, employee.EmployeeId, employee.EmployeeName, employee.StartDate.ToString(), employee.EndDate.ToString());
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new AddPositionDetailForm(this.mng, idPosition));
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ListPositionForm(mng));
        }

        private void fixDetailBtn_Click(object sender, EventArgs e)
        {

        }

        private void positionDetailTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = positionDetailTable.Rows[e.RowIndex];
                if (positionDetailTable.CurrentRow.Index == positionDetailTable.Rows.Count - 1)
                {
                    fixDetailBtn.Enabled = false;
                    deleteDetailBtn.Enabled = false;
                }
                else
                {
                    fixDetailBtn.Enabled = true;
                    deleteDetailBtn.Enabled = true;
                }

            }
        }

        private void descriptionText_TextChanged(object sender, EventArgs e)
        {
            fixPositionBtn.Enabled = true;
        }

        private void idText_TextChanged(object sender, EventArgs e)
        {
            fixPositionBtn.Enabled = true;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            fixPositionBtn.Enabled = true;
        }

        private void baseSalaryText_TextChanged(object sender, EventArgs e)
        {
            fixPositionBtn.Enabled = true;
        }

        private void fixPositionBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "") MessageBox.Show("Name empty");
            else if (baseSalaryText.Text == "") MessageBox.Show("Address Empty");
            else
            {
                MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to update this Position ??", "Confirm Update!!", MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    var repo = new RepositoryPosition();
                    var result = repo.FixPosition(idPosition, new InputPosition()
                    {
                        Name = nameText.Text,
                        BaseSalary = int.Parse(baseSalaryText.Text),
                        Description = descriptionText.Text,
                        RankId = int.Parse(rankComboBox.Text.Trim().Split("-")[0]),
                    }) ;

                    if (result.Success)
                    {

                        MessageBox.Show("Update Unit success");
                        mng.OpenChildForm(new PositionDetailForm(this.mng, idPosition));
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
            }
        }

        private void fixDetailBtn_EnabledChanged(object sender, EventArgs e)
        {
            fixDetailBtn.BackColor = fixDetailBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            fixDetailBtn.ForeColor = fixDetailBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void deleteDetailBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteDetailBtn.BackColor = deleteDetailBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteDetailBtn.ForeColor = deleteDetailBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void rankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fixPositionBtn.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ListPositionForm(mng));
        }
    }
}
