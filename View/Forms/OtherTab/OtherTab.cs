using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Salary_management.View.Forms.OtherTab
{
    public partial class OtherTab : Form
    {
        Management mng;
        public OtherTab(Management mng, int tab = 0)
        {
            this.mng = mng;
            InitializeComponent();
            OtherPageTab.SelectedTab = OtherPageTab.TabPages[tab];
        }

        private void OtherTab_Load(object sender, EventArgs e)
        {
            //get Union info 
            var repo = new RepositoryUnion();
            var listUnion = repo.GetUnions("");
            foreach(var item in listUnion)
            {
                ListUnionGrid.Rows.Add(item.Id, item.Name);
            }
            
            //get Expertise info 
            var repoEx = new RepositoryExpertise();
            var listEx = repoEx.GetExpertises("");
            foreach (var ex in listEx)
            {
                ExpertiseBox.Items.Add(ex.Id + "-" + ex.Name);
                ExpertiseGridView.Rows.Add(ex.Id, ex.Name);
            }
            
            //get Qualification info
            var repoQ = new RepositoryQualification();
            var listQualification = repoQ.GetQualifications("");
            foreach (var item in listQualification)
            {               
                QualifcationGridView.Rows.Add(item.Id, item.Name, item.Expertise.Name + "-" + item.ExpertiseId);
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

        private void addQBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryQualification();
            if (ExpertiseBox.Text == "") MessageBox.Show("Please select Expertise");
            else if (NameQText.Text == "") MessageBox.Show("Please input name");
            else
            {
                string index = ExpertiseBox.Items[ExpertiseBox.SelectedIndex].ToString() ;               
                string[] splits = (index.ToString()).Split('-');
                string idEx = splits[0];
                              
                var result = repo.InsertQualification(new InputQualification()
                 {
                     ExpertiseId = Int16.Parse(idEx),
                     Name = NameQText.Text
                 });

                 if (result.Success)
                 {
                     MessageBox.Show("Insert Qualification Success");
                     mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng, 1), sender);
                 }
               else MessageBox.Show(result.ErrorMessage);                 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtherPageTab.SelectTab("ExpertiseTab");
        }

        private void addExpertiseBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryExpertise();
            if (nameExpertiseText.Text == "") MessageBox.Show("Please input name");           
            else
            {
                var result = repo.InsertExpertise(nameExpertiseText.Text);
                if (result.Success)
                {
                    MessageBox.Show("Insert Expertise Success");
                    mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng, 2), sender);
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string idU = (ListUnionGrid.Rows[ListUnionGrid.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id 
            var repo = new RepositoryUnion();
            repo.DeleteUnion(idU);

            MessageBox.Show("Delete Union Success");
            mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng), sender);
        }

        private void deleteQBtn_Click(object sender, EventArgs e)
        {
            string idQ = (QualifcationGridView.Rows[QualifcationGridView.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id 
            var repo = new RepositoryQualification();
            repo.DeleteQualification(Int16.Parse(idQ));

            MessageBox.Show("Delete Qualification Success");
            mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng, 1), sender);
        }

        private void deleteExpertiseBtn_Click(object sender, EventArgs e)
        {
            string idEX = (ExpertiseGridView.Rows[ExpertiseGridView.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id 
            var repo = new RepositoryExpertise();
            repo.DeleteExpertise(Int16.Parse(idEX));

            MessageBox.Show("Delete Expertise Success");
            mng.OpenChildForm(new View.Forms.OtherTab.OtherTab(this.mng, 2), sender);
        }
    }
}
