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

namespace Salary_management.View.Employees
{
    public partial class AddNewEmployeeForm : BaseForm
    {
        public AddNewEmployeeForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;

        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));

        }

        private void addBtn_Click(object sender, EventArgs e)
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

                var result = RepoEmployee.InsertEmployee(new EmployeeInput()
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
                    MessageBox.Show("Insert Employee success");
                    mng.OpenChildForm(new Salary_management.View.Employees.ListEmployeeForm(this.mng));
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }

            }
        }

        private void pictureBoxBtn_Click(object sender, EventArgs e)
        {
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
    }
}
