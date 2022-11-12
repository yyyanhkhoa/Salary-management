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
            string id = IDText.Text;
            string Name = NameText.Text;
            string Address = AddressText.Text;
            string phone = PhoneText.Text;
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

        private void FixBtn_Click(object sender, EventArgs e)
        {

        }

        private void DetailBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Unit.UnitDetail(), sender);
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            this.UnitGridView.Rows.Clear();
            RepositoryUnit repo = new RepositoryUnit();
            List<Model.Unit> list = repo.GetUnits("");
            foreach (Model.Unit unit in list)
            {
                UnitGridView.Rows.Add(unit.Id,unit.Name,unit.Address,unit.PhoneNumber,unit.DateFounded);
            }
            
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            this.UnitGridView.Rows.Clear();
            RepositoryUnit repo = new RepositoryUnit();
            List<Model.Unit> list = repo.GetUnits(SearchText.Text);
            foreach (Model.Unit unit in list)
            {
                UnitGridView.Rows.Add(unit.Id, unit.Name, unit.Address, unit.PhoneNumber, unit.DateFounded);
            }
        }
    }
}
