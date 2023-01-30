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

namespace Salary_management.View.Units
{
    public partial class AddUnitForm : BaseForm
    {
        public AddUnitForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var RepoUnit = new RepositoryUnit();
            string id = idText.Text;
            string Name = nameText.Text;
            string Address = addressText.Text;
            string phone = phoneText.Text;
            if (id == "") MessageBox.Show("Pls input Id");
            else if (Name == "") MessageBox.Show("Pls input name");
            else if (Address == "") MessageBox.Show("Pls input address");
            else if (phone == "") MessageBox.Show("Pls input phone");
            else
            {
                DateOnly dataOfFounded = DateOnly.FromDateTime(dateFoundedDataPicker.Value);
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
                    mng.OpenChildForm(new UnitsForm(this.mng));

                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new UnitsForm(this.mng));

        }

        private void AddUnitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
