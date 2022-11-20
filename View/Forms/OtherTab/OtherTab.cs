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

namespace Salary_management.View.Forms.OtherTab
{
    public partial class OtherTab : Form
    {
        Management mng;
        public OtherTab(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void OtherTab_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryUnion();
            if (NameText.Text == "") MessageBox.Show("Please input name");
            else
            {
                var result = repo.InsertUnion(NameText.Text);
                if (result.Success) { MessageBox.Show("Insert Union Success"); }
                else MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
