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
            var repo = new RepositoryUnion();
            var listUnion = repo.GetUnions("");
            foreach(var item in listUnion)
            {
                ListUnionGrid.Rows.Add(item.Id, item.Name);
            }
        }

        

        private void NextBtn_Click(object sender, EventArgs e)
        {
            OtherPageTab.SelectTab("QualificationTab");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryUnion();
            if (IDText.Text == "") MessageBox.Show("Please input id"); 
            else if (NameText.Text == "") MessageBox.Show("Please input name");
            else
            {
                var result = repo.InsertUnion(IDText.Text,NameText.Text);
                if (result.Success) { 
                    MessageBox.Show("Insert Union Success");
                    mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng), sender);
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
