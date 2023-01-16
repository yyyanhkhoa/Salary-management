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

namespace Salary_management.View.Positions
{
    public partial class AddNewPositionForm : BaseForm
    {
        public AddNewPositionForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void AddNewPositionForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var RepoPosition = new RepositoryPosition();
            string ID = idText.Text;
            string name = nameText.Text;
            string baseSalary = baseSalaryText.Text;
            string rank = rankComboBox.Text;
            string[] id = rank.Trim().Split(":");
            string description = descriptionText.Text;

            if (ID == "") MessageBox.Show("Please input ID");
            else if (name == "") MessageBox.Show("Please input name");
            else if (baseSalary == "") MessageBox.Show("Please input name");
            else
            {
                var result = RepoPosition.InsertPosition(new InputPosition()
                {
                    Id = ID,
                    Name = name,
                    BaseSalary = int.Parse(baseSalary),
                    RankId = int.Parse(id[0]),
                    Description = description,
                });
                if (result.Success)
                {
                    MessageBox.Show("Insert Position success");
                    mng.OpenChildForm(new View.Positions.ListPositionForm(this.mng));
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Positions.ListPositionForm(this.mng));

        }
    }
}
