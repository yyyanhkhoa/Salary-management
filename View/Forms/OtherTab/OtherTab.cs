using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Salary_management.View.Forms.OtherTab
{
    public partial class OtherTab : Form
    {
        Management mng;
        private int QualificationId;       
        public OtherTab(Management mng, int tab = 0)
        {
            this.mng = mng;
            InitializeComponent();
            OtherPageTab.SelectedTab = OtherPageTab.TabPages[tab];
            var listQH = 0;
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

            //get Family info 
            var repoF = new RepositoryFamily();
            List<Model.Family> listF = repoF.GetFamilies("");
            foreach (Model.Family family in listF)
            {
                FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType.ToString());
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            OtherPageTab.SelectTab("QualificationTab");
        }

        void getQualificationHistoryInfo(int idQ)
        {
            this.QualificationHistoryGridView.Rows.Clear();
            var repo = new RepositoryQualification();
            var list = repo.GetQualificationAllowanceTimeline(idQ).Payload;
            foreach (var item in list)
            {
                QualificationHistoryGridView.Rows.Add(item.Id, item.Year, item.Allowance);
            }
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

        private void allowQualificationText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void addQHistoryBtn_Click(object sender, EventArgs e)
        {
            var repo = new RepositoryQualificationAllowanceHistory();           
            if (yearQualificationText.Text == "") MessageBox.Show("Please input year");
            else if (allowQualificationText.Text == "") MessageBox.Show("Please input allowance");
            else
            {
                var result = repo.InsertQualificationAllowanceHistory(new InputQualificationAllowanceHistory()
                {
                    Year = Int16.Parse(yearQualificationText.Text),
                    Allowance = Int32.Parse(allowQualificationText.Text),
                    QualificationId = this.QualificationId,
                });

                if (result.Success)
                {
                    MessageBox.Show("Insert Qualification history Success");
                    getQualificationHistoryInfo(QualificationId);
                }
                else MessageBox.Show(result.ErrorMessage);
            }
        }

        private void allowQualificationText_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearQualificationText_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }           
        }

        private void deleteQHistoryBtn_Click(object sender, EventArgs e)
        {
            string idQH = (QualificationHistoryGridView.Rows[QualificationHistoryGridView.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id 
            var repo = new RepositoryQualificationAllowanceHistory();
            repo.DeleteQualificationAllowanceHistory(Int16.Parse(idQH));
            MessageBox.Show("Delete Qualification history Success");
            getQualificationHistoryInfo(QualificationId);

        }

        private void QualifcationGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void QualifcationGridView_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void QualifcationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void QualifcationGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int16.Parse(QualifcationGridView.Rows[QualifcationGridView.CurrentRow.Index].Cells[0].Value.ToString());
            this.QualificationId = id;
            getQualificationHistoryInfo(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OtherPageTab.SelectTab("FamilyTab"); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchFamilyBtn_Click(object sender, EventArgs e)
        {
            this.FamilyGridView.Rows.Clear();
            RepositoryFamily repo = new RepositoryFamily();
            if (relativeBox.SelectedIndex == -1)
            {
                //search all
                List<Model.Family> list = repo.GetFamilies(searchFamilyText.Text);
                foreach (Model.Family family in list)
                {
                    FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType);
                }
            }
            else if (relativeBox.SelectedIndex == 0)
            {     
                //search all
                List<Model.Family> list = repo.GetFamilies(searchFamilyText.Text);
                foreach (Model.Family family in list)
                {
                    FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType);
                }
            }
            else if (relativeBox.SelectedIndex == 1)
            {
                //search Wife
                List<Model.Family> list = repo.GetFamilies(searchFamilyText.Text, RelativeType.Wife);
                foreach (Model.Family family in list)
                {
                    FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType);
                }

            }
            else if (relativeBox.SelectedIndex == 2)
            {
                //search Husband
                List<Model.Family> list = repo.GetFamilies(searchFamilyText.Text, RelativeType.Husband);
                foreach (Model.Family family in list)
                {
                    FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType);
                }
            }
            else if (relativeBox.SelectedIndex == 3)
            {
                //search Child
                List<Model.Family> list = repo.GetFamilies(searchFamilyText.Text, RelativeType.Child);
                foreach (Model.Family family in list)
                {
                    FamilyGridView.Rows.Add(family.Id, family.Name, family.RelativeType);
                }
            }

        }
    }
}
