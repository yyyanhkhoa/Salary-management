﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_management.View.Qualifications
{
    public partial class QualificationsForm : BaseForm
    {
        public QualificationsForm(Management mng)
        {
            InitializeComponent();
            this.mng = mng;
        }

        private void QualificationsForm_Load(object sender, EventArgs e)
        {

        }
    }
}