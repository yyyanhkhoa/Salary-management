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

namespace Salary_management.View.Forms.Employee.DetailInformation
{
    public partial class AddFamily : Form
    {
        private Management mng;       
        public AddFamily(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void AddFamilyGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng), sender);
        }

        private void AddFamily_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var RepoUnit = new RepositoryUnit();
            //string id = IDText.Text;
            string Name = NameText.Text;
            string Occupation = CoefficientAllowanceText.Text;
            string relative = PhoneText.Text;
            if (id == "") MessageBox.Show("Pls input Id");
            else if (Name == "") MessageBox.Show("Pls input name");
            else if (Address == "") MessageBox.Show("Pls input address");
            else if (phone == "") MessageBox.Show("Pls input phone");
            else
            {
                DateOnly dataOfFounded = DateOnly.FromDateTime(DateFoundedText.Value);
                var result = RepoUnit.InsertUnit(new InputUnit()
                {
                    Id = id,
                    Name = Name,
                    PhoneNumber = phone,
                    Address = Address,
                    DateFounded = dataOfFounded,
                });

                if (result.Success)
                {
                    MessageBox.Show("Insert Unit success");
                    mng.OpenChildForm(new View.Forms.Unit.Unit(this.mng), sender);

                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}
