using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class DetailInformation : Form
    {
        private Management mng;
        private string idEmployee;
       // private int tab;
        public DetailInformation(Management mng,string idEmployee, int tab = 0)
        {
            InitializeComponent();
            this.mng = mng;
            this.idEmployee = idEmployee;
            tabControl1.SelectedTab = tabControl1.TabPages[tab];
        }
        void enableInfo (bool check)
        {
            if (check == true)
            {
                NameText.Enabled = true;
                AddressText.Enabled = true;
                DateOfBirth.Enabled = true;
                EthnicText.Enabled = true;  
                IdentityText.Enabled = true;
                CoefficientAllowanceText.Enabled = true;
                StartDate.Enabled = true;
                MaleBtn.Enabled = true;
                FemaleBtn.Enabled =true;
                ImagePicture.Enabled = true;
            } else
            {
                NameText.Enabled = false;
                AddressText.Enabled = false;
                DateOfBirth.Enabled = false;
                EthnicText.Enabled = false;
                IdentityText.Enabled = false;
                CoefficientAllowanceText.Enabled = false;
                StartDate.Enabled = false;
                MaleBtn.Enabled = false;
                FemaleBtn.Enabled = false;
                ImagePicture.Enabled = false;
            }           
                
        }
        void enableQualification(bool check)
        {
            if (check == true)
            {                
                nameQualificationBox.Enabled = true;
                dateQualification.Enabled = true;
                placeQualificationTB.Enabled = true;
                exQualificationBox.Enabled = true;
                scoreQualificationText.Enabled = true;
            }
            else
            {             
                nameQualificationBox.Enabled = false;
                dateQualification.Enabled = false;
                placeQualificationTB.Enabled = false;
                exQualificationBox.Enabled = false;
                scoreQualificationText.Enabled = false;
            }
        }
      
        private void DetailInformation_Load(object sender, EventArgs e)
        {  
            var repo = new RepositoryEmployee();            
            var employee = repo.GetEmployeeDetail(idEmployee);           
            enableInfo(false);
            enableQualification(false);

            //get Infomation detail
            NameText.Text = employee.Name;
            AddressText.Text = employee.Address;
            DateOfBirth.Value = new DateTime(employee.DateOfBirth.Year, employee.DateOfBirth.Month, employee.DateOfBirth.Day);
            StartDate.Value =new DateTime(employee.StartDate.Year, employee.StartDate.Month, employee.StartDate.Day);
            EthnicText.Text = employee.Ethnic;
            IdentityText.Text = employee.IdentityCardNumber;
            CoefficientAllowanceText.Text = employee.CoefficientAllowance.ToString();
        
            ImagePicture.Image = Image.FromStream(new MemoryStream(employee.Image));
            ImagePicture.SizeMode = PictureBoxSizeMode.StretchImage;
          
            if (employee.Gender == Gender.Male)
            {
                MaleBtn.Checked = true;
                FemaleBtn.Checked = false;
            }
            else
            {
                FemaleBtn.Checked = true;
                MaleBtn.Checked = false;
            }

            //get family info
            getFamilyInfo();

            //get quailifcation info
            IDQualificationTB.Enabled = false; 
            getQualificationInfo();

        }

        private void getFamilyInfo()
        {
            this.FamilyGridView.Rows.Clear();
            RepositoryFamily repoFamily = new RepositoryFamily();
            List<Model.Family> list = repoFamily.GetFamiliesByEmployee(idEmployee);
            foreach (Model.Family famili in list)
            {
                FamilyGridView.Rows.Add(famili.Id, famili.Name, famili.DateOfBirth, famili.Occupation, famili.RelativeType.ToString());
            }
        }
        private void getQualificationInfo()
        {
            var repoQualifi = new RepositoryQualification();
            var listQua = repoQualifi.GetQualifications("");
            foreach (var quali in listQua)
            {
                nameQualificationBox.Items.Add(quali.Id + "-" + quali.Name);             
            }

            this.QualificationListView.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            if (repo.GetEmployeeQualifications(idEmployee).Success == false)
            {
                List<Model.EmployeeQualification> list = repo.GetEmployeeQualifications(idEmployee).Payload;
                foreach (Model.EmployeeQualification qualifi in list)
                {
                    QualificationListView.Rows.Add(qualifi.Id, qualifi.QualificationName, qualifi.IssueDate, qualifi.PlaceOfIssue, qualifi.QualificationId);
                }
            }
          
        }

        private void getHistoryInfo()
        {
            // add unit history
            this.UnitGridView.Rows.Clear();
            RepositoryEmployee repoU = new RepositoryEmployee();
            if (repoU.GetEmployeeUnitHistory(idEmployee).Success == false)
            {
                List<Model.UnitHistory> listUnit = repoU.GetEmployeeUnitHistory(idEmployee).Payload;
                foreach (Model.UnitHistory unit in listUnit)
                {
                    UnitGridView.Rows.Add(unit.StartDate, unit.EndDate, unit.UnitName);
                }
            }

            // add position history          
            this.PositionGridView.Rows.Clear();
            RepositoryEmployee repoP = new RepositoryEmployee();
            if (repoP.GetEmployeePositionHistory(idEmployee).Success == false)
            {
                List<Model.PositionHistory> listPosition = repoP.GetEmployeePositionHistory(idEmployee).Payload;
                foreach (Model.PositionHistory position in listPosition)
                {
                    PositionGridView.Rows.Add(position.StartDate, position.EndDate, position.PositionName);
                }
            }


        }
        private void getUnionInfo()
        {
            this.UnionGridView.Rows.Clear();
            RepositoryEmployee repo = new RepositoryEmployee();
            if (repo.GetEmployeeUnionHistory(idEmployee).Success == false)
            {
                List<Model.UnionHistory> list = repo.GetEmployeeUnionHistory(idEmployee).Payload;
                foreach (Model.UnionHistory union in list)
                {
                    UnionGridView.Rows.Add(union.Id, union.UnionName, union.StartDate, union.EndDate);
                }
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void FixBtn_Click(object sender, EventArgs e)
        {
            if (FixBtn.Text == "Fix")
            {
                enableInfo(true);              
                FixBtn.Text = "Save";
            }
            else
            {
                //update infomation
                if (NameText.Text == "") MessageBox.Show("Pls input name");
                else if ((!MaleBtn.Checked) && (!FemaleBtn.Checked)) MessageBox.Show("Pls select gender");
                else if (AddressText.Text == "") MessageBox.Show("Hay nhap dia chi");
                else if (EthnicText.Text == "") MessageBox.Show("Hay nhap dan toc");
                else if (CoefficientAllowanceText.Text == "") MessageBox.Show("Hay nhap he so phu cap");
                else if (IdentityText.Text == "") MessageBox.Show("Hay nhap cmnd");
                else
                {
                    var RepoEmployee = new RepositoryEmployee();
                    Gender gender;
                    if (MaleBtn.Checked) gender = Gender.Male;
                    else gender = Gender.Female;
                    DateOnly dateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value);
                    DateOnly startDate = DateOnly.FromDateTime(StartDate.Value);
                   
                    var imageConverter = new ImageConverter();
                    // cap nhat employee
                    var result = RepoEmployee.FixEmployee(idEmployee, new EmployeeInput()
                    {
                        Name = NameText.Text,
                        Gender = gender,
                        DateOfBirth = dateOfBirth,
                        Ethnic = EthnicText.Text,
                        Address = AddressText.Text,
                        StartDate = startDate,
                        IdentityCardNumber = IdentityText.Text,
                        CoefficientAllowance = float.Parse(CoefficientAllowanceText.Text),
                        Image = imageConverter.ConvertTo(ImagePicture.Image, typeof(byte[])) as byte[]
                    });

                    if (result.Success)
                    {
                        MessageBox.Show("Insert Employee success" );                      
                        enableInfo(false);
                        FixBtn.Text = "Fix";
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }

                }
               

            }
        }

        private void AddFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, 0, idEmployee), sender);
        }
        private void addQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng, "0", idEmployee), sender);
        }
        private void addUnion_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng, 0, idEmployee), sender);
        }

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            string idFamily = FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value.ToString();           
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, Int16.Parse(idFamily), idEmployee), sender);
        }
        private void fixQualificationBtn_Click(object sender, EventArgs e)
        {
            if (fixQualificationBtn.Text == "Fix")
            {
                fixQualificationBtn.Text = "Save";
                enableQualification(true);
            }
            else
            {   // fix Qualification               
                var repo = new RepositoryEmployeeQualification();
                /*
                string index = ExpertiseBox.Items[ExpertiseBox.SelectedIndex].ToString();
                string[] splits = (index.ToString()).Split('-');
                string idEx = splits[0];
                */

                string idQualification = (QualificationListView.Rows[QualificationListView.CurrentRow.Index].Cells["idQualification"].Value).ToString();
                var result = repo.FixEmployeeQualification(Int16.Parse(idQualification), new InputEmployeeQualification()
                {
                    //Name = NameText.Text,
                    //DateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value),
                   // Occupation = occupationText.Text,
                   // RelativeType = relative,
                    //EmployeeId = idEmploye,
                });

                if (result.Success)
                {
                    MessageBox.Show("Update Family success");
                    
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
                fixQualificationBtn.Text = "Fix";
                enableQualification(false);
            }
        }

        private void RemoveFamilyBtn_Click(object sender, EventArgs e)
        {
            string idFamily = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id family
            var repo = new RepositoryFamily();
            repo.DeleteFamily(Int16.Parse(idFamily));
            getFamilyInfo();
        }
  
        private void fixUnion_Click(object sender, EventArgs e)
        {
            string idUnion = UnionGridView.Rows[UnionGridView.CurrentRow.Index].Cells[0].Value.ToString();
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng, Int32.Parse(idUnion), idEmployee), sender);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
          
        private void backQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void backFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void backUnionBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void removeUnion_Click(object sender, EventArgs e)
        {

        }

        private void FamilyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ImagePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmo;*.jpg;*.jpeg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ImagePicture.Image = Image.FromFile(dlg.FileName);
                    ImagePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QualificationListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idQualification = Int16.Parse(QualificationListView.Rows[QualificationListView.CurrentRow.Index].Cells[0].Value.ToString());
            var repo = new RepositoryEmployeeQualification();           
            var qualifi = repo.GetEmployeeQualification(idQualification);

           
        }

        private void dataGridView2_Resize(object sender, EventArgs e)
        {
            int width = PositionGridView.Width + UnitGridView.Width;
            PositionGridView.Width = width / 2;
            UnitGridView.Width = width / 2;
        }

        private void removeQualification_Click(object sender, EventArgs e)
        {

        }
    }
}
