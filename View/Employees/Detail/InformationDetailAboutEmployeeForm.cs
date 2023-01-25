using Salary_management.Controller.Infrastructure.Data.Input;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Controller.Infrastructure.Repositories;
using Salary_management.Infrastructure.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using SystemColors = System.Drawing.SystemColors;
namespace Salary_management.View.Employees.Detail
{
    public partial class InformationDetailAboutEmployeeForm : BaseForm
    {
        private string idEmployee;
        public InformationDetailAboutEmployeeForm(Management mng, string id)
        {
            InitializeComponent();
            this.idEmployee = id;
            this.mng = mng;

        }
        //METHODS
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
                    break;
                case Role.Accountant:
                    saveBtn.Enabled = false;

                    break;
                case Role.Admin:
                    saveBtn.Enabled = false;
                    break;
                default: throw new ArgumentException();
            }
        }
        private void LoadDetailInformation()
        {
            var repo = new RepositoryEmployee();
            var employee = repo.GetEmployeeDetail(idEmployee);
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
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));

        }

        private void pictureBoxBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
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

        private void saveBtn_EnabledChanged(object sender, EventArgs e)
        {
            saveBtn.BackColor = saveBtn.Enabled ? Color.FromArgb(26,25,62) : SystemColors.Control;
            saveBtn.ForeColor = saveBtn.Enabled ? Color.Gainsboro : Color.Black;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void dateOfBirthDataPicker_ValueChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void ethnicText_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void identityText_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void startDateDataPicker_ValueChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }

        private void coefficientAllowanceText_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

        }
    }
}
