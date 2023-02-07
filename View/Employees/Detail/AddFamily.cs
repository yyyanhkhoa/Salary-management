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
    public partial class AddFamily : Form
    {
        private Management mng;
        private int idFamily;
        private string idEmployee;
        public AddFamily(Management mng, int id, string idEmployee)
        {
            InitializeComponent();
            this.mng = mng;
            this.idFamily = id;
            this.idEmployee = idEmployee;
        }
        private void AddFamily_Load(object sender, EventArgs e)
        {
            


            if (idFamily == 0)
            {
                // add
              

            }
            else
            {
                // fix
                var repo = new RepositoryFamily();
                var family = repo.GetFamilyDetail(idFamily);

                var repoE = new RepositoryEmployee();
                var employee = repoE.GetEmployeeDetail(idEmployee);

                if(employee.Gender == Gender.Male)
                {
                    HusbanBtn.Visible = false;
                }
                else
                {
                    WifeBtn.Visible = false;
                }
                AddBtn.Text = "Save";                
                NameText.Text = family.Name;
                if (family.RelativeType == RelativeType.Husband)
                {
                    HusbanBtn.Checked = true;
                }
                if (family.RelativeType == RelativeType.Wife)
                {
                    WifeBtn.Checked = true;
                }
                if (family.RelativeType == RelativeType.Child)
                {
                    ChildBtn.Checked = true;
                }
                DateOfBirth.Value = new DateTime(family.DateOfBirth.Year, family.DateOfBirth.Month, family.DateOfBirth.Day);
                occupationText.Text = family.Occupation;               
            }
        }

        private void AddFamilyGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmployee, 1));
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(idFamily == 0)
            {
                //add family
                if (NameText.Text == "") MessageBox.Show("Pls input name");
                else if ((!WifeBtn.Checked) && (!HusbanBtn.Checked) && (!ChildBtn.Checked)) MessageBox.Show("Pls select relative");
                else if (occupationText.Text == "") MessageBox.Show("Pls input occupation");
                else
                {
                    var repo = new RepositoryFamily();
                    RelativeType relative;
                    if (WifeBtn.Checked) relative = RelativeType.Wife;
                    else if (HusbanBtn.Checked) relative = RelativeType.Husband;
                    else relative = RelativeType.Child;
                    DateOnly dateOfBirth = DateOnly.FromDateTime(DateOfBirth.Value);

                    var result = repo.InsertFamily(new InputFamily()
                    {
                        Name = NameText.Text,
                        DateOfBirth = dateOfBirth,
                        Occupation = occupationText.Text,
                        RelativeType = relative,
                        EmployeeId = idEmployee,
                    });

                    if (result.Success)
                    {
                        MessageBox.Show("Insert Family success");
                        mng.OpenChildForm(new View.Employees.Detail.InformationDetailAboutEmployeeForm(this.mng, idEmployee, 1));
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                    }
                }
            }
            else
            {               

            }

        }
    }
}
