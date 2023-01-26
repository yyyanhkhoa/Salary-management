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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ScottPlot;

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
            siticoneTabControl1.SelectedTab = siticoneTabControl1.TabPages[tab];
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
                scoreQualificationText.Enabled = true;
            }
            else
            {             
                nameQualificationBox.Enabled = false;
                dateQualification.Enabled = false;
                placeQualificationTB.Enabled = false;              
                scoreQualificationText.Enabled = false;
            }
        }

        void enableUnion(bool check)
        {
            if (check == true)
            {
                unionJoinBox.Enabled = true;
                startDayUnionBox.Enabled = true;
                endDayUnionBox.Enabled = true;
                checkUnionEndDay.Enabled = true;
            }
            else
            {
                unionJoinBox.Enabled = false;
                startDayUnionBox.Enabled = false;
                endDayUnionBox.Enabled = false;
                checkUnionEndDay.Enabled = false;
            }
        }

        void showEmployeeQualifi(Model.EmployeeQualification item, int idEmployeeQualification)
        {
            IDQualificationTB.Text = idEmployeeQualification.ToString();            
            int indexQ = nameQualificationBox.FindString(item.QualificationId + "-" + item.QualificationName);
            nameQualificationBox.SelectedIndex = indexQ;
            dateQualification.Value = new DateTime(item.IssueDate.Year, item.IssueDate.Month, item.IssueDate.Day);
            placeQualificationTB.Text = item.PlaceOfIssue;
            scoreQualificationText.Text = item.Score.ToString();
            var repo = new RepositoryQualification();
            var detail = repo.GetQualificationDetail(item.QualificationId);
        }

        void showUnion(Model.UnionHistory item, int idUnion)
        {
            idUnionText.Text = idUnion.ToString();
            int indexUJ = unionJoinBox.FindString(item.UnionId + "-" + item.UnionName);
            unionJoinBox.SelectedIndex = indexUJ;
        }

        private void DetailInformation_Load(object sender, EventArgs e)
        {  
            var repo = new RepositoryEmployee();            
            var employee = repo.GetEmployeeDetail(idEmployee);           
            enableInfo(false);
            enableQualification(false);
            enableUnion(false);
            //get Infomation detail
            NameText.Text = employee.Name;
            AddressText.Text = employee.Address;
            DateOfBirth.Value = new DateTime(employee.DateOfBirth.Year, employee.DateOfBirth.Month, employee.DateOfBirth.Day);
            StartDate.Value =new DateTime(employee.StartDate.Year, employee.StartDate.Month, employee.StartDate.Day);
            EthnicText.Text = employee.Ethnic;
            IdentityText.Text = employee.IdentityCardNumber;
            CoefficientAllowanceText.Text = employee.CoefficientAllowance.ToString();
        
            if(employee.Image != null)
            {
                ImagePicture.Image = Image.FromStream(new MemoryStream(employee.Image));
                ImagePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }          
          
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
            getQualificationInfo();

            //get History Info
            getHistoryInfo();

            //get family info
            getUnionInfo();

            //get salary info
            getSalaryInfo();
            dateSalaryBox.CustomFormat = "yyyy";
            dateSalaryBox.ShowUpDown = true;
            dateSalaryBox.MaxDate = DateTime.Now;

            int width = PositionGridView.Width + UnitGridView.Width ;           
            UnitgroupBox.Width = width / 2 + 10;           
            UnitGridView.Width = width / 2;

            // change siticoneTabControl1
            siticoneTabControl1.SizeMode = TabSizeMode.Normal;
            siticoneTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            //làm biểu đồ (chart)       
            formsPlot1.Plot.XLabel("Months");
            formsPlot1.Plot.YLabel("Salary (vnd)");
            formsPlot1.Plot.SetAxisLimitsX(1, 12);
            formsPlot1.Plot.SetAxisLimitsY(0, 30);
            double[] xPositions = {1,2,3,4,5,6,7,8,9,10,11,12 };
            string[] xLabels = { "Jan", "Feb", "Mar", "Apr" ,"May","Jun" , "Jul", "Aug", "Sep","Oct", "Nov", "Dec" };            
            formsPlot1.Plot.XAxis.ManualTickPositions(xPositions, xLabels);

        }

        private void setChart(double[] dataX, double[] dataY)
        {
            formsPlot1.Refresh();
         
            formsPlot1.Plot.AddScatter(dataX, dataY);
            
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
        private void getSalaryInfo()
        {
            this.SalaryGridView.Rows.Clear();
            RepositorySalary repoSalary = new RepositorySalary();
            List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalaryAtYear(idEmployee).Payload;
            double[] dataX = new double[15];
            double[] dataY = new double[15];
            int count = 0;

            foreach (Model.EmployeeSalary salary in list)
            {
                count++;    
                long BHXH = salary.Salary;
                long BHYT = salary.Salary;
                long BHTN = salary.Salary;
                dataX[count] = count;
                dataY[count] = salary.Salary;
               // dataY[count] = salary.Salary / 1000000;
                SalaryGridView.Rows.Add( salary.Date, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, salary.Salary);
            }
            setChart(dataX, dataY);

        }
        private void getQualificationInfo()
        {
            this.QualificationListView.Rows.Clear();
            this.nameQualificationBox.Items.Clear();
            
            var repoQualifi = new RepositoryQualification();
            var listQua = repoQualifi.GetQualifications("");
            foreach (var quali in listQua)
            {
                nameQualificationBox.Items.Add(quali.Id + "-" + quali.Name + "-" + quali.Expertise.Name);             
            }
           
            RepositoryEmployee repo = new RepositoryEmployee();
            if (repo.GetEmployeeQualifications(idEmployee).Success == true)
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
            // get unit history
            this.UnitGridView.Rows.Clear();
            RepositoryEmployee repoU = new RepositoryEmployee();
            if (repoU.GetEmployeeUnitHistory(idEmployee).Success == true)
            {
                List<Model.UnitHistory> listUnit = repoU.GetEmployeeUnitHistory(idEmployee).Payload;
                foreach (Model.UnitHistory unit in listUnit)
                {
                    UnitGridView.Rows.Add(unit.StartDate, unit.EndDate, unit.UnitName);
                }
            }

            // get position history          
            this.PositionGridView.Rows.Clear();
            RepositoryEmployee repoP = new RepositoryEmployee();
            if (repoP.GetEmployeePositionHistory(idEmployee).Success == true)
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
            if (repo.GetEmployeeUnionHistory(idEmployee).Success == true)
            {
                List<Model.UnionHistory> list = repo.GetEmployeeUnionHistory(idEmployee).Payload;
                foreach (Model.UnionHistory union in list)
                {
                    UnionGridView.Rows.Add(union.Id, union.UnionName, union.StartDate, union.EndDate);
                }
            }

            this.unionJoinBox.Items.Clear();
            var repoUnionJoin = new RepositoryUnion();
            var listU = repoUnionJoin.GetUnions("");
            foreach (var union in listU)
            {
                unionJoinBox.Items.Add(union.Id + "-" + union.Name);
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
             mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng,  idEmployee), sender);
        }

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            string idFamily = FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value.ToString();           
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, Int16.Parse(idFamily), idEmployee), sender);
        }
        private void fixQualificationBtn_Click(object sender, EventArgs e)
        {           
            if (IDQualificationTB.Text == "" )
            {
                MessageBox.Show("Please select Employee Qualification first");
            }
            else
            {
                if (fixQualificationBtn.Text == "Fix")
                {
                    fixQualificationBtn.Text = "Save";
                    enableQualification(true);
                }               
                else
                {
                    if (nameQualificationBox.Text == "") MessageBox.Show("Pls chosse qualification");
                    else if (placeQualificationTB.Text == "") MessageBox.Show("Pls input place of issue");
                    else if (scoreQualificationText.Text == "") MessageBox.Show("Pls input score");
                    else
                    {
                        // fix Qualification               
                        var repo = new RepositoryEmployeeQualification();
                        string indexQ = nameQualificationBox.Items[nameQualificationBox.SelectedIndex].ToString();
                        string[] splitsQ = (indexQ.ToString()).Split('-');
                        string idQ = splitsQ[0];
                        DateOnly date = DateOnly.FromDateTime(dateQualification.Value);

                        var result = repo.FixEmployeeQualification(Int32.Parse(IDQualificationTB.Text), new InputEmployeeQualification()
                        {
                            Score = float.Parse(scoreQualificationText.Text),
                            IssueDate = date,
                            PlaceOfIssue = placeQualificationTB.Text,
                            QualificationId = Int16.Parse(idQ),
                            EmployeeId = idEmployee,
                        });

                        if (result.Success)
                        {
                            MessageBox.Show("Update Employee Qualification success");
                            getQualificationInfo();
                        }
                        else
                        {
                            MessageBox.Show(result.ErrorMessage);
                        }
                        fixQualificationBtn.Text = "Fix";
                        enableQualification(false);
                    }
                   
                }
            }          
        }

        private void fixUnion_Click(object sender, EventArgs e)
        {           
            if (idUnionText.Text == "")
            {
                MessageBox.Show("Please select Union history first");
            }
            else
            {
                if (fixUnion.Text == "Fix")
                {
                    fixUnion.Text = "Save";
                    enableUnion(true);
                }
                else
                {
                    // fix Union                                  
                    var repo = new RepositoryUnionHistory();                   
                    DateOnly startDate = DateOnly.FromDateTime(startDayUnionBox.Value);
                    string indexU = unionJoinBox.Items[unionJoinBox.SelectedIndex].ToString();
                    string[] splitsU = (indexU.ToString()).Split('-');
                    string idU = splitsU[0];                   

                    if (checkUnionEndDay.Checked)
                    {
                        // if have endDay
                        DateOnly enddate = DateOnly.FromDateTime(endDayUnionBox.Value);
                        var result = repo.FixUnionHistory(Int32.Parse(idUnionText.Text), new InputUnionHistory()
                        {
                            UnionId = idU,
                            StartDate = startDate,
                            EmployeeId = idEmployee,
                            EndDate = enddate,                           
                        });
                        if (result.Success)
                        {
                            MessageBox.Show("Update Union history success");
                            getUnionInfo();
                        }
                        else
                        {
                            MessageBox.Show(result.ErrorMessage);
                        }
                    }
                    else
                    {         
                        // if don't have endDay
                        var result = repo.FixUnionHistory(Int32.Parse(idUnionText.Text), new InputUnionHistory()
                        {
                            UnionId = idU,
                            StartDate = startDate,
                            EmployeeId = idEmployee,
                            EndDate = null,
                        });
                        if (result.Success)
                        {
                            MessageBox.Show("Update Union history success");
                            getUnionInfo();
                        }
                        else
                        {
                            MessageBox.Show(result.ErrorMessage);
                        }
                    }
                  
                    fixUnion.Text = "Fix";
                    enableUnion(false);
                    
                }
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

        private void removeQualification_Click(object sender, EventArgs e)
        {
            if (QualificationListView.RowCount > 0)
            {
                string id = (QualificationListView.Rows[QualificationListView.CurrentRow.Index].Cells[0].Value).ToString();
                //xoa = id            
                var repo = new RepositoryEmployeeQualification();
                repo.DeleteEmployeeQualification(Int32.Parse(id));
                getQualificationInfo();

            }
            else
            {
                MessageBox.Show("Pls chossed a Qualification to remove");
            }
          
        }
        private void RemoveFamilyBtn_Click(object sender, EventArgs e)
        {           
            if (FamilyGridView.RowCount > 0) {
                string idFamily = (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value).ToString();
                //xoa = id family
                var repo = new RepositoryFamily();
                repo.DeleteFamily(Int16.Parse(idFamily));
                getFamilyInfo();
                 
            }
            else
            {
                MessageBox.Show("Pls chossed a family to remove");
            }
         
        }
        private void removeUnion_Click(object sender, EventArgs e)
        {
            if (UnionGridView.RowCount > 0)
            {
                string idUnion = (UnionGridView.Rows[UnionGridView.CurrentRow.Index].Cells[0].Value).ToString();
                //xoa = id union
                var repo = new RepositoryUnionHistory();
                repo.DeleteUnionHistory(Int16.Parse(idUnion));
                getUnionInfo();
            }
            else
            {
                MessageBox.Show("Pls chossed an Union to remove");
            }
          
        }
        private void QualificationListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEmployeeQualification = Int16.Parse(QualificationListView.Rows[QualificationListView.CurrentRow.Index].Cells[0].Value.ToString());
            var repo = new RepositoryEmployeeQualification();
            Model.EmployeeQualification qualifi = repo.GetEmployeeQualification(idEmployeeQualification);
            showEmployeeQualifi(qualifi, idEmployeeQualification);
        }

        private void scoreQualificationText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void UnionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUnion = Int16.Parse(UnionGridView.Rows[UnionGridView.CurrentRow.Index].Cells[0].Value.ToString());
            var repo = new RepositoryUnionHistory();
            Model.UnionHistory union = repo.GetUnionHistory(idUnion);
            showUnion(union, idUnion);
        }

        private void checkUnionEndDay_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkUnionEndDay.Checked)
            {
                unionEndDayPanel.Visible = false;
            }
            else unionEndDayPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
        }

        private void searchSalaryBtn_Click(object sender, EventArgs e)
        {
            SalaryGridView.Rows.Clear();
            RepositorySalary repoSalary = new RepositorySalary();
            List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalaryAtYear(idEmployee,dateSalaryBox.Value.Year).Payload;
            double[] dataX = new double[15];
            double[] dataY = new double[15];
            int count = 0;
           
            foreach (Model.EmployeeSalary salary in list)
            {
                count++;
                long BHXH = salary.Salary / 20;
                long BHYT = salary.Salary / 100;
                long BHTN = salary.Salary / 100;
                dataX[count] = count;
                dataY[count] = salary.Salary;
               SalaryGridView.Rows.Add(salary.Date, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, salary.Salary);
                //salary.RankCoefficient,
            }
            setChart(dataX, dataY);
        }

        private void PositionGridView_Resize(object sender, EventArgs e)
        {
            int width = PositionGridView.Width + UnitGridView.Width;
            PositionGridView.Width = width / 2;
            UnitGridView.Width = width / 2;
        }

        private void dateQualification_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
