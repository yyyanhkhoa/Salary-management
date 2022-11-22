﻿using Salary_management.Controller.Infrastructure.Repositories;
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
    public partial class AddUnion : Form
    {
        private Management mng;
        private string idUnion;
        private string idEmploye;
        public AddUnion(Management mng, string idUnion, string idEmploye)
        {
            InitializeComponent();
            this.mng = mng;
            this.idUnion = idUnion;
            this.idEmploye = idEmploye;
        }

        private void AddUnion_Load(object sender, EventArgs e)
        {
            var repoUnion = new RepositoryUnion();
            var listUnion = repoUnion.GetUnions("");
            foreach (var union in listUnion)
            {
                unionJoinBox.Items.Add(union.Id + ":" + union.Name);

            }
            if (idUnion == "0")
            {
                // add


            }
            else
            {
                // fix
                var repo = new RepositoryUnion();
                var union = repo.GetUnionDetail(idUnion);
                AddBtn.Text = "Save";
                NameText.Text = union.Name;
           
               // startDay.Value = new DateTime(union.DateOfBirth.Year, family.DateOfBirth.Month, family.DateOfBirth.Day);
               // occupationText.Text = family.Occupation;

            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mng.OpenChildForm(new View.Forms.Employee.DetailInformation.DetailInformation(this.mng, idEmploye), sender);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                panel6.Visible = false;
            }
            else panel6.Visible = true;
        }


    }
}
