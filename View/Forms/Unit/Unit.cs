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

namespace Salary_management.View.Forms.Unit
{
    public partial class Unit : Form
    {
        Management mng;
        public Unit(Management mng)
        {
            this.mng = mng;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var RepoUnit = new RepositoryUnit();
            string Id = IDText.Text;
            string Name = NameText.Text;
            string Address = AddressText.Text;
            string phone = PhoneText.Text;
            DateOnly dataOfFounded = DateOnly.FromDateTime(DateFoundedText.Value);
            var result = RepoUnit.InsertUnit(new InputUnit(){
                
                Name = Name,
                PhoneNumber = phone,
                Address = Address,
                DateFounded = dataOfFounded,
            }) ;

            if (result.Success)
            {
                MessageBox.Show("Insert Unit success");
                mng.OpenChildForm(new View.Forms.Employee.ListInformation(this.mng), sender);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
           
        }

        private void FixBtn_Click(object sender, EventArgs e)
        {

        }

        private void DetailBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
