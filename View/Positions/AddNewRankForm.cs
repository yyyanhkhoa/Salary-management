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
    public partial class AddNewRankForm : BaseForm
    {
        public AddNewRankForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Positions.ListPositionForm(this.mng));

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var RepoRank = new RepositoryRank();
            string name = nameText.Text;
            string milestone =milestoneComboBox.Text;
            string Coefficient = coefficientText.Text;
            var result = RepoRank.InsertRank(new InputRank()
            {
                Name = name,
                Milestone = int.Parse(milestone),
                Coefficient = float.Parse(Coefficient),
            });
            if (result.Success)
            {
                MessageBox.Show("Insert Rank success");
                mng.OpenChildForm(new View.Positions.ListPositionForm(this.mng));
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }

        private void AddNewRankForm_Load(object sender, EventArgs e)
        {

        }
    }
}
