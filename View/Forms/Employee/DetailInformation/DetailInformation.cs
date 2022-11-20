using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public DetailInformation(Management mng,string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idEmployee = idEmployee;
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
            }           
                
        }
        void enableQualification(bool check)
        {
            if (check == true)
            {
                namecallQualificationTB.Enabled = true;
                nameQualificationTB.Enabled = true;
                dateQualification.Enabled = true;
                placeQualificationTB.Enabled = true;
                exQualificationTB.Enabled = true;                  
            }
            else
            {
                namecallQualificationTB.Enabled = false;
                nameQualificationTB.Enabled = false;
                dateQualification.Enabled = false;
                placeQualificationTB.Enabled = false;
                exQualificationTB.Enabled = false;

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
            this.QualificationListView.Rows.Clear();
            RepositoryFamily repoFamily = new RepositoryFamily();
            List<Model.Family> list = repoFamily.GetFamiliesByEmployee(idEmployee);
            foreach (Model.Family famili in list)
            {
                FamilyGridView.Rows.Add(famili.Id, famili.Name, famili.DateOfBirth, famili.Occupation, famili.RelativeType.ToString());
            }
        }
        private void getUnionInfo()
        {
           // this.UnionGridView.Rows.Clear();
           // RepositoryUnion repoUnion = new RepositoryUnion();
           // List<Model.Union> list = repoUnion.GetFamiliesByEmployee(idEmployee);
          //  foreach (Model.Union union in list)
            //{
          //      UnionGridView.Rows.Add(famili.Id, famili.Name, famili.DateOfBirth, famili.Occupation, famili.RelativeType.ToString());
           // }
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
                    //MessageBox.Show(name + " " + gender + " " + dateOfBirth + " " + ethnic + " " + address + " " + startDate + " " + identity + " " + coefficientAllowance);


                    var imageConverter = new ImageConverter();
                    // cap nhat employee
                    var result = RepoEmployee.InsertEmployee(new EmployeeInput()
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
                        MessageBox.Show("Insert Employee success");
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

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            string idFamily = FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value.ToString();           
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, Int16.Parse(idFamily), idEmployee), sender);
        }

        private void RemoveFamilyBtn_Click(object sender, EventArgs e)
        {
            string idFamily = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();
            //xoa = id family
            var repo = new RepositoryFamily();
            repo.DeleteFamily(Int16.Parse(idFamily));
            getFamilyInfo();
        }

        private void addQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng, "0"), sender);
        }

        private void addUnion_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng, "0"), sender);

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fixQualificationBtn_Click(object sender, EventArgs e)
        {
            if (fixQualificationBtn.Text == "Fix")
            {
                fixQualificationBtn.Text = "Save";
                enableQualification(true);
            }
            else
            {
                fixQualificationBtn.Text = "Fix";
                enableQualification(false);
            }
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

        private void fixUnion_Click(object sender, EventArgs e)
        {

        }

        private void FamilyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
    }
}
