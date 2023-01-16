namespace Salary_management.View.Forms.Employee
{
    partial class ListInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ListViewEmployee = new System.Windows.Forms.DataGridView();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TitleListEmployee = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.SalaryTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.salaryGridView = new System.Windows.Forms.DataGridView();
            this.nameEmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.searchSalaryBox = new System.Windows.Forms.ComboBox();
            this.dateSalary = new System.Windows.Forms.DateTimePicker();
            this.searchSalaryBtn = new System.Windows.Forms.Button();
            this.searchSalaryByBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            this.SalaryTab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1017, 406);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ListViewEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 155);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1007, 246);
            this.panel4.TabIndex = 2;
            // 
            // ListViewEmployee
            // 
            this.ListViewEmployee.AllowUserToAddRows = false;
            this.ListViewEmployee.AllowUserToDeleteRows = false;
            this.ListViewEmployee.AllowUserToOrderColumns = true;
            this.ListViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.NameEmployee,
            this.Birth,
            this.Identity,
            this.CurrentSalary,
            this.Detail});
            this.ListViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEmployee.Location = new System.Drawing.Point(10, 10);
            this.ListViewEmployee.Name = "ListViewEmployee";
            this.ListViewEmployee.ReadOnly = true;
            this.ListViewEmployee.RowHeadersWidth = 51;
            this.ListViewEmployee.RowTemplate.Height = 29;
            this.ListViewEmployee.Size = new System.Drawing.Size(983, 222);
            this.ListViewEmployee.TabIndex = 0;
            this.ListViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListViewEmployee_CellContentClick);
            // 
            // IdEmployee
            // 
            this.IdEmployee.HeaderText = "IdEmployee";
            this.IdEmployee.MinimumWidth = 6;
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.ReadOnly = true;
            this.IdEmployee.Width = 125;
            // 
            // NameEmployee
            // 
            this.NameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameEmployee.HeaderText = "Name";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.ReadOnly = true;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Birth";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            this.Birth.Width = 120;
            // 
            // Identity
            // 
            this.Identity.HeaderText = "Identity";
            this.Identity.MinimumWidth = 6;
            this.Identity.Name = "Identity";
            this.Identity.ReadOnly = true;
            this.Identity.Width = 120;
            // 
            // CurrentSalary
            // 
            this.CurrentSalary.HeaderText = "Allowance";
            this.CurrentSalary.MinimumWidth = 6;
            this.CurrentSalary.Name = "CurrentSalary";
            this.CurrentSalary.ReadOnly = true;
            this.CurrentSalary.Width = 125;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Image = global::Salary_management.Properties.Resources.eye_icon;
            this.Detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.Width = 55;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TitleListEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1007, 150);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AddBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(869, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(124, 87);
            this.panel5.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(124, 49);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Controls.Add(this.SearchTextBox);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 97);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(983, 39);
            this.panel3.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchBtn.Location = new System.Drawing.Point(859, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 35);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Location = new System.Drawing.Point(107, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(541, 34);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // TitleListEmployee
            // 
            this.TitleListEmployee.AutoSize = true;
            this.TitleListEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleListEmployee.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleListEmployee.Location = new System.Drawing.Point(10, 10);
            this.TitleListEmployee.Name = "TitleListEmployee";
            this.TitleListEmployee.Size = new System.Drawing.Size(304, 32);
            this.TitleListEmployee.TabIndex = 0;
            this.TitleListEmployee.Text = "Employees Management";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeesTab);
            this.tabControl1.Controls.Add(this.SalaryTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.panel1);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 29);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesTab.Size = new System.Drawing.Size(1023, 412);
            this.EmployeesTab.TabIndex = 0;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // SalaryTab
            // 
            this.SalaryTab.Controls.Add(this.panel6);
            this.SalaryTab.Location = new System.Drawing.Point(4, 29);
            this.SalaryTab.Name = "SalaryTab";
            this.SalaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalaryTab.Size = new System.Drawing.Size(1023, 412);
            this.SalaryTab.TabIndex = 1;
            this.SalaryTab.Text = "Salary";
            this.SalaryTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1017, 406);
            this.panel6.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.salaryGridView);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 118);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(1017, 288);
            this.panel10.TabIndex = 3;
            // 
            // salaryGridView
            // 
            this.salaryGridView.AllowUserToAddRows = false;
            this.salaryGridView.AllowUserToDeleteRows = false;
            this.salaryGridView.AllowUserToOrderColumns = true;
            this.salaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameEmployeeSalary,
            this.unitSalary,
            this.coefficient,
            this.dataGridViewTextBoxColumn5,
            this.BHXH,
            this.BHYT,
            this.Column1,
            this.SalaryGet});
            this.salaryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salaryGridView.Location = new System.Drawing.Point(10, 10);
            this.salaryGridView.Name = "salaryGridView";
            this.salaryGridView.ReadOnly = true;
            this.salaryGridView.RowHeadersWidth = 51;
            this.salaryGridView.RowTemplate.Height = 29;
            this.salaryGridView.Size = new System.Drawing.Size(993, 264);
            this.salaryGridView.TabIndex = 0;
            // 
            // nameEmployeeSalary
            // 
            this.nameEmployeeSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameEmployeeSalary.HeaderText = "Name";
            this.nameEmployeeSalary.MinimumWidth = 100;
            this.nameEmployeeSalary.Name = "nameEmployeeSalary";
            this.nameEmployeeSalary.ReadOnly = true;
            // 
            // unitSalary
            // 
            this.unitSalary.HeaderText = "Unit";
            this.unitSalary.MinimumWidth = 6;
            this.unitSalary.Name = "unitSalary";
            this.unitSalary.ReadOnly = true;
            this.unitSalary.Width = 125;
            // 
            // coefficient
            // 
            this.coefficient.HeaderText = "Coefficient";
            this.coefficient.MinimumWidth = 6;
            this.coefficient.Name = "coefficient";
            this.coefficient.ReadOnly = true;
            this.coefficient.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Allowance";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // BHXH
            // 
            this.BHXH.HeaderText = "BHXH";
            this.BHXH.MinimumWidth = 6;
            this.BHXH.Name = "BHXH";
            this.BHXH.ReadOnly = true;
            this.BHXH.Width = 125;
            // 
            // BHYT
            // 
            this.BHYT.HeaderText = "BHYT";
            this.BHYT.MinimumWidth = 6;
            this.BHYT.Name = "BHYT";
            this.BHYT.ReadOnly = true;
            this.BHYT.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BHTN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // SalaryGet
            // 
            this.SalaryGet.HeaderText = "Salary get";
            this.SalaryGet.MinimumWidth = 6;
            this.SalaryGet.Name = "SalaryGet";
            this.SalaryGet.ReadOnly = true;
            this.SalaryGet.Width = 125;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(1017, 118);
            this.panel7.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.searchSalaryBox);
            this.panel9.Controls.Add(this.dateSalary);
            this.panel9.Controls.Add(this.searchSalaryBtn);
            this.panel9.Controls.Add(this.searchSalaryByBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(10, 65);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2);
            this.panel9.Size = new System.Drawing.Size(993, 39);
            this.panel9.TabIndex = 1;
            // 
            // searchSalaryBox
            // 
            this.searchSalaryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchSalaryBox.FormattingEnabled = true;
            this.searchSalaryBox.Location = new System.Drawing.Point(107, 2);
            this.searchSalaryBox.Name = "searchSalaryBox";
            this.searchSalaryBox.Size = new System.Drawing.Size(551, 28);
            this.searchSalaryBox.TabIndex = 2;
            this.searchSalaryBox.Text = "--Select--";
            this.searchSalaryBox.SelectedIndexChanged += new System.EventHandler(this.searchSalaryBox_SelectedIndexChanged);
            // 
            // dateSalary
            // 
            this.dateSalary.CustomFormat = "";
            this.dateSalary.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateSalary.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSalary.Location = new System.Drawing.Point(658, 2);
            this.dateSalary.Name = "dateSalary";
            this.dateSalary.Size = new System.Drawing.Size(211, 27);
            this.dateSalary.TabIndex = 3;
            // 
            // searchSalaryBtn
            // 
            this.searchSalaryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchSalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchSalaryBtn.Location = new System.Drawing.Point(869, 2);
            this.searchSalaryBtn.Name = "searchSalaryBtn";
            this.searchSalaryBtn.Size = new System.Drawing.Size(122, 35);
            this.searchSalaryBtn.TabIndex = 2;
            this.searchSalaryBtn.Text = "search";
            this.searchSalaryBtn.UseVisualStyleBackColor = true;
            this.searchSalaryBtn.Click += new System.EventHandler(this.searchSalaryBtn_Click);
            // 
            // searchSalaryByBox
            // 
            this.searchSalaryByBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchSalaryByBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchSalaryByBox.FormattingEnabled = true;
            this.searchSalaryByBox.Items.AddRange(new object[] {
            "All",
            "Unit"});
            this.searchSalaryByBox.Location = new System.Drawing.Point(2, 2);
            this.searchSalaryByBox.Name = "searchSalaryByBox";
            this.searchSalaryByBox.Size = new System.Drawing.Size(105, 26);
            this.searchSalaryByBox.TabIndex = 0;
            this.searchSalaryByBox.Text = "--select--";
            this.searchSalaryByBox.SelectedIndexChanged += new System.EventHandler(this.searchSalaryBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees Salay";
            // 
            // ListInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 465);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListInformation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ListEmployee";
            this.Load += new System.EventHandler(this.ListInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListViewEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.SalaryTab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salaryGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label TitleListEmployee;
        private Panel panel3;
        private Button SearchBtn;
        private TextBox SearchTextBox;
        private ComboBox comboBox1;
        private Panel panel4;
        private DataGridView ListViewEmployee;
        private Panel panel5;
        private Button AddBtn;
        private DataGridViewTextBoxColumn IdEmployee;
        private DataGridViewTextBoxColumn NameEmployee;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Identity;
        private DataGridViewTextBoxColumn CurrentSalary;
        private DataGridViewImageColumn Detail;
        private TabControl tabControl1;
        private TabPage EmployeesTab;
        private TabPage SalaryTab;
        private Panel panel6;
        private Panel panel10;
        private DataGridView salaryGridView;
        private Panel panel7;
        private Panel panel9;
        private Button searchSalaryBtn;
        private ComboBox searchSalaryByBox;
        private Label label1;
        private DateTimePicker dateSalary;
        private DataGridViewTextBoxColumn nameEmployeeSalary;
        private DataGridViewTextBoxColumn unitSalary;
        private DataGridViewTextBoxColumn coefficient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn BHXH;
        private DataGridViewTextBoxColumn BHYT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn SalaryGet;
        private ComboBox searchSalaryBox;
    }
}