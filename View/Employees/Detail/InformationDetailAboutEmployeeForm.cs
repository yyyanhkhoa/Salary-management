using Microsoft.Reporting.Map.WebForms.BingMaps;
using Salary_management.Controller.Infrastructure.Data;
using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;

namespace Salary_management.View.Employees.Detail
{
    public partial class InformationDetailAboutEmployeeForm : BaseForm
    {
        private string idEmployee;
        public InformationDetailAboutEmployeeForm(Management mng, string id,int tab = 0)
        {
            InitializeComponent();
            this.idEmployee = id;
            this.mng = mng;
            employeeDetailTabControl.SelectedTab = employeeDetailTabControl.TabPages[tab];
        }
        //METHODS
        void enableInfo(bool check)
        {
            if (check == true)
            {
                nameText.Enabled = true;
                addressText.Enabled = true;
                dateOfBirthDataPicker.Enabled = true;
                ethnicText.Enabled = true;
                identityText.Enabled = true;
                coefficientAllowanceText.Enabled = true;
                startDateDataPicker.Enabled = true;
                maleRadioBtn.Enabled = true;
                femaleRadioBtn.Enabled = true;
                pictureBoxBtn.Enabled = true;
            }
            else
            {
                nameText.Enabled = false;
                addressText.Enabled = false;
                dateOfBirthDataPicker.Enabled = false;
                ethnicText.Enabled = false;
                identityText.Enabled = false;
                coefficientAllowanceText.Enabled = false;
                startDateDataPicker.Enabled = false;
                maleRadioBtn.Enabled = false;
                femaleRadioBtn.Enabled = false;
                pictureBoxBtn.Enabled = false;
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
                fixQualificationBtn.BackColor = Color.Yellow;
                fixQualificationBtn.ForeColor = Color.Black;
            }
            else
            {
                nameQualificationBox.Enabled = false;
                dateQualification.Enabled = false;
                placeQualificationTB.Enabled = false;
                scoreQualificationText.Enabled = false;
                fixQualificationBtn.BackColor = Color.FromArgb(26, 25, 62);
                fixQualificationBtn.ForeColor = Color.Gainsboro;
            }           
        }
        void enableFamily(bool check)
        {
            if (check == true)
            {
                nameFamilyText.Enabled = true;
                dateOfBirthFamily.Enabled = true;   
                occupationFamilyBox.Enabled = true;
                RelativeTypeBox.Enabled = true ;
                FixFamilyBtn.BackColor = Color.Yellow;
                FixFamilyBtn.ForeColor = Color.Black;
            }
            else
            {
                nameFamilyText.Enabled = false;
                dateOfBirthFamily.Enabled = false;
                RelativeTypeBox.Enabled = false;
                occupationFamilyBox.Enabled = false;
                FixFamilyBtn.BackColor = Color.FromArgb(26, 25, 62);
                FixFamilyBtn.ForeColor = Color.Gainsboro;
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
                fixUnion.BackColor = Color.Yellow;
                fixUnion.ForeColor = Color.Black;
            }
            else
            {
                unionJoinBox.Enabled = false;
                startDayUnionBox.Enabled = false;
                endDayUnionBox.Enabled = false;
                checkUnionEndDay.Enabled = false;
                fixUnion.BackColor = Color.FromArgb(26, 25, 62);
                fixUnion.ForeColor = Color.Gainsboro;
            }
        }
        private void InformationDetailAboutEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDetailInformation();
            AuthorizationButton(mng.Role);
        }
        
        private void AuthorizationButton(Role Role)
        {
            switch (Role)
            {
                case Role.Viewer:
                    saveBtn.Visible = false;
                    deleteEmployeeBtn.Visible = false;
                    break;
                case Role.Accountant:
                    saveBtn.Enabled = false;
                    deleteEmployeeBtn.Visible = false;
                    break;
                case Role.Admin:
                    saveBtn.Enabled = true;
                    deleteEmployeeBtn.Visible = true;
                    break;
                default: throw new ArgumentException();
            }
        }
       
        private void LoadDetailInformation()
        {
            var repo = new RepositoryEmployee();
            var employee = repo.GetEmployeeDetail(idEmployee);
            enableInfo(false);
            //set enableQualification
            enableQualification(false);
            fixQualificationBtn.BackColor = Color.FromArgb(26, 25, 62);
            fixQualificationBtn.ForeColor = Color.Gainsboro;
            //set enableQualification
            enableUnion(false);
            fixUnion.BackColor = Color.FromArgb(26, 25, 62);
            fixUnion.ForeColor = Color.Gainsboro;
            //set family
            enableFamily(false);
            FixFamilyBtn.BackColor = Color.FromArgb(26, 25, 62);
            FixFamilyBtn.ForeColor = Color.Gainsboro;
            //get Infomation detail
            nameText.Text = employee.Name;
            addressText.Text = employee.Address;
            dateOfBirthDataPicker.Value = new DateTime(employee.DateOfBirth.Year, employee.DateOfBirth.Month, employee.DateOfBirth.Day);
            startDateDataPicker.Value = new DateTime(employee.StartDate.Year, employee.StartDate.Month, employee.StartDate.Day);
            ethnicText.Text = employee.Ethnic;
            identityText.Text = employee.IdentityCardNumber;
            coefficientAllowanceText.Text = employee.CoefficientAllowance.ToString();

            if (employee.Image != null)
            {
                pictureBoxBtn.Image = Image.FromStream(new MemoryStream(employee.Image));
                pictureBoxBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (employee.Gender == Gender.Male)
            {
                maleRadioBtn.Checked = true;
                femaleRadioBtn.Checked = false;
            }
            else
            {
                femaleRadioBtn.Checked = true;
                maleRadioBtn.Checked = false;
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

            int width = PositionGridView.Width + UnitGridView.Width;
            UnitgroupBox.Width = width / 2 + 10;
            UnitGridView.Width = width / 2;

            // change siticoneTabControl1
            employeeDetailTabControl.SizeMode = TabSizeMode.Normal;
            employeeDetailTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;

            //làm biểu đồ (chart)       
            formsPlot1.Plot.XLabel("Months");
            formsPlot1.Plot.YLabel("Salary (vnd)");
            formsPlot1.Plot.SetAxisLimitsX(1, 12);
            formsPlot1.Plot.SetAxisLimitsY(0, 30);
            double[] xPositions = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string[] xLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
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
                SalaryGridView.Rows.Add(salary.Date, salary.EmployeeAllowanceCoefficient, BHXH, BHYT, BHTN, salary.Salary);
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
            if (FamilyGridView.RowCount > 0)
            {
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
        private void pictureBoxBtn_Click(object sender, EventArgs e)
        {
            //saveBtn.Enabled = true;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmo;*.jpg;*.jpeg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxBtn.Image = Image.FromFile(dlg.FileName);
                    pictureBoxBtn.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }      

        void showEmployeeQualifi(Model.EmployeeQualification item, int idEmployeeQualification = 1)
        {
            if (idEmployeeQualification == 0)
            {
                IDQualificationTB.Text = "";
                nameQualificationBox.Text = "--Select--";
                dateQualification.Value = DateTime.Now;
                placeQualificationTB.Text = "";
                scoreQualificationText.Text = "";
            }
            else
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
        }

        void showUnion(Model.UnionHistory item, int idUnion = 1)
        {
            if (idUnion == 0)
            {
                idUnionText.Text = "";
                unionJoinBox.Text = "--Select--";
                startDayUnionBox.Value = DateTime.Now;
                endDayUnionBox.Value = DateTime.Now;
                checkUnionEndDay.Checked = false;
            }
            else
            {
                idUnionText.Text = idUnion.ToString();
                int indexUJ = unionJoinBox.FindString(item.UnionId + "-" + item.UnionName);
                unionJoinBox.SelectedIndex = indexUJ;
                startDayUnionBox.Value = new DateTime(item.StartDate.Year, item.StartDate.Month, item.StartDate.Day);
                if (item.EndDate != null)
                {
                    checkUnionEndDay.Checked = true;
                    endDayUnionBox.Value = new DateTime(item.EndDate.Value.Year, item.EndDate.Value.Month, item.EndDate.Value.Day);
                }
                else
                {
                    checkUnionEndDay.Checked = false;
                }
            }
        }
        void showFamily(Model.Family item,int check = 1 )
        {          
            if (check == 0 ) {
                nameFamilyText.Text = "";
                dateOfBirthFamily.Value = DateTime.Now;
                occupationFamilyBox.Text = "";
                HusbanBtn.Checked = false;
                WifeBtn.Checked = false;
                ChildBtn.Checked = false;
            }
            else
            {
                nameFamilyText.Text = item.Name;
                dateOfBirthFamily.Value = new DateTime(item.DateOfBirth.Year, item.DateOfBirth.Month, item.DateOfBirth.Day);
                occupationFamilyBox.Text = item.Occupation;
                if (item.RelativeType == RelativeType.Husband)
                {
                    HusbanBtn.Checked = true;
                }
                if (item.RelativeType == RelativeType.Wife)
                {
                    WifeBtn.Checked = true;
                }
                if (item.RelativeType == RelativeType.Child)
                {
                    ChildBtn.Checked = true;
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveBtn.Text == "Fix")
            {
                enableInfo(true);
                saveBtn.Text = "Save";
            }
            else
            {
                //update infomation
                if (nameText.Text == "") MessageBox.Show("Pls input name");
                else if ((!maleRadioBtn.Checked) && (!femaleRadioBtn.Checked)) MessageBox.Show("Pls select gender");
                else if (addressText.Text == "") MessageBox.Show("Hay nhap dia chi");
                else if (ethnicText.Text == "") MessageBox.Show("Hay nhap dan toc");
                else if (coefficientAllowanceText.Text == "") MessageBox.Show("Hay nhap he so phu cap");
                else if (identityText.Text == "") MessageBox.Show("Hay nhap cmnd");
                else
                {
                    var RepoEmployee = new RepositoryEmployee();
                    Gender gender;
                    if (maleRadioBtn.Checked) gender = Gender.Male;
                    else gender = Gender.Female;
                    DateOnly dateOfBirth = DateOnly.FromDateTime(dateOfBirthDataPicker.Value);
                    DateOnly startDate = DateOnly.FromDateTime(startDateDataPicker.Value);

                    var imageConverter = new ImageConverter();
                    byte[] img;
                    if (pictureBoxBtn.Image != null)
                    {
                        img = imageConverter.ConvertTo(pictureBoxBtn.Image, typeof(byte[])) as byte[];
                    }
                    else
                    {
                        img = null;
                    }

                    MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to update this employee ??", "Confirm Update!!", MessageBoxButton.YesNo);

                    if (confirmResult == MessageBoxResult.Yes)
                    {
                        var result = RepoEmployee.FixEmployee(idEmployee, new EmployeeInput()
                        {
                            Name = nameText.Text,
                            Gender = gender,
                            DateOfBirth = dateOfBirth,
                            Ethnic = ethnicText.Text,
                            Address = addressText.Text,
                            StartDate = startDate,
                            IdentityCardNumber = identityText.Text,
                            CoefficientAllowance = float.Parse(coefficientAllowanceText.Text),
                            Image = img
                        });

                        if (result.Success)
                        {

                            MessageBox.Show("Update Employee success");
                            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
                        }
                        else
                        {
                            MessageBox.Show(result.ErrorMessage);
                        }
                    }
                }
            }
        
        }
        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this employee ??", "Confirm Delete!!", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                var repo =new RepositoryEmployee();
                repo.DeleteEmployee(idEmployee);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));

        }
        private void backFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
        }
        private void backQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
        }       
        private void backHistoryBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
        }

        private void backSalaryBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
        }

        private void AddFamilyBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddFamily(this.mng, 0, idEmployee));
        }
        private void addQualificationBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddQualification(this.mng, "0", idEmployee));
        }
        private void addUnion_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.AddUnion(this.mng, idEmployee));
        }

        private void FixFamilyBtn_Click(object sender, EventArgs e)
        {
            if (nameFamilyText.Text == "")
            {
                MessageBox.Show("Please select Family first");
            }
            else
            {               
                if (FixFamilyBtn.Text == "Fix")
                {
                    FixFamilyBtn.Text = "Save";
                    enableFamily(true);
                }
                else
                {
                    // fix idFamily
                    var repo = new RepositoryFamily();
                    RelativeType relative;
                    if (WifeBtn.Checked) relative = RelativeType.Wife;
                    else if (HusbanBtn.Checked) relative = RelativeType.Husband;
                    else relative = RelativeType.Child;
                   
                    int idFamily = Int16.Parse(FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value.ToString());
                    
                    var result = repo.FixFamily(idFamily, new InputFamily()
                    {
                        Name = nameFamilyText.Text,
                        DateOfBirth = DateOnly.FromDateTime(dateOfBirthFamily.Value),
                        Occupation = occupationFamilyBox.Text,
                        RelativeType = relative,
                        EmployeeId = idEmployee,
                    });

                    if (result.Success)
                    {
                        MessageBox.Show("Update Family success");
                        getFamilyInfo();
                        showFamily(new Model.Family(),0);
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                    FixFamilyBtn.Text = "Fix";
                    enableFamily(false);
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
                            showUnion(new Model.UnionHistory(), 0);
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
                            showUnion(new Model.UnionHistory(), 0);
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
        private void fixQualificationBtn_Click(object sender, EventArgs e)
        {
            if (IDQualificationTB.Text == "")
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
                            showEmployeeQualifi(new Model.EmployeeQualification(), 0);                                
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
        private void FamilyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            var item = new Model.Family();
            item.Id = Int16.Parse(FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[0].Value.ToString());
            item.Name = FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[1].Value.ToString();          
            item.DateOfBirth = DateOnly.Parse(FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[2].Value.ToString()); 
            item.Occupation = FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[3].Value.ToString();           
            if (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[4].Value.ToString() == "Wife")
            {
                item.RelativeType = RelativeType.Wife ;
            }
            else if (FamilyGridView.Rows[FamilyGridView.CurrentRow.Index].Cells[4].Value.ToString() == "Husband")
            {
                item.RelativeType = RelativeType.Husband;
            }
            else
            {
                item.RelativeType = RelativeType.Child;
            }
            showFamily(item);
        }
        private void QualificationListView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEmployeeQualification = Int16.Parse(QualificationListView.Rows[QualificationListView.CurrentRow.Index].Cells[0].Value.ToString());
            var repo = new RepositoryEmployeeQualification();
            Model.EmployeeQualification qualifi = repo.GetEmployeeQualification(idEmployeeQualification);
            showEmployeeQualifi(qualifi, idEmployeeQualification);
        }
        private void UnionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUnion = Int16.Parse(UnionGridView.Rows[UnionGridView.CurrentRow.Index].Cells[0].Value.ToString());
            var repo = new RepositoryUnionHistory();
            Model.UnionHistory union = repo.GetUnionHistory(idUnion);
            showUnion(union, idUnion);
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
        private void nameQualificationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void unionJoinBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void checkUnionEndDay_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkUnionEndDay.Checked)
            {
                unionEndDayPanel.Visible = false;
            }
            else unionEndDayPanel.Visible = true;
        }

        private void searchSalaryBtn_Click(object sender, EventArgs e)
        {
            SalaryGridView.Rows.Clear();
            RepositorySalary repoSalary = new RepositorySalary();
            List<Model.EmployeeSalary> list = repoSalary.GetEmployeeSalaryAtYear(idEmployee, dateSalaryBox.Value.Year).Payload;
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
            }
            setChart(dataX, dataY);
        }

        private void PositionGridView_Resize(object sender, EventArgs e)
        {
            int width = PositionGridView.Width + UnitGridView.Width;
            PositionGridView.Width = width / 2;
            UnitGridView.Width = width / 2;
        }

        private void saveBtn_EnabledChanged(object sender, EventArgs e)
        {
            saveBtn.BackColor = saveBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            saveBtn.ForeColor = saveBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void deleteEmployeeBtn_EnabledChanged(object sender, EventArgs e)
        {
            deleteEmployeeBtn.BackColor = deleteEmployeeBtn.Enabled ? Color.FromArgb(26, 25, 62) : SystemColors.Control;
            deleteEmployeeBtn.ForeColor = deleteEmployeeBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void backUnionBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new ListEmployeeForm(this.mng));
        }
    }
}
