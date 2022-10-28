namespace Salary_management.Forms
{
    partial class ListFormEmployeeInformation
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
            this.CurrentUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TitleListEmployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(780, 430);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ListViewEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 160);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(760, 260);
            this.panel4.TabIndex = 2;
            // 
            // ListViewEmployee
            // 
            this.ListViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.NameEmployee,
            this.Birth,
            this.CurrentUnit,
            this.CurrentSalary,
            this.Detail});
            this.ListViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewEmployee.Location = new System.Drawing.Point(10, 10);
            this.ListViewEmployee.Name = "ListViewEmployee";
            this.ListViewEmployee.RowHeadersWidth = 51;
            this.ListViewEmployee.RowTemplate.Height = 29;
            this.ListViewEmployee.Size = new System.Drawing.Size(736, 236);
            this.ListViewEmployee.TabIndex = 0;
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
            this.NameEmployee.HeaderText = "Name";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.Width = 125;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Birth";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.Width = 110;
            // 
            // CurrentUnit
            // 
            this.CurrentUnit.HeaderText = "Current Unit";
            this.CurrentUnit.MinimumWidth = 6;
            this.CurrentUnit.Name = "CurrentUnit";
            this.CurrentUnit.Width = 110;
            // 
            // CurrentSalary
            // 
            this.CurrentSalary.HeaderText = "Current Salary";
            this.CurrentSalary.MinimumWidth = 6;
            this.CurrentSalary.Name = "CurrentSalary";
            this.CurrentSalary.Width = 125;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TitleListEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(760, 150);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 97);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(736, 39);
            this.panel3.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchBtn.Location = new System.Drawing.Point(612, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 35);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(107, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 34);
            this.textBox1.TabIndex = 1;
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
            this.TitleListEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleListEmployee.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleListEmployee.Location = new System.Drawing.Point(10, 10);
            this.TitleListEmployee.Name = "TitleListEmployee";
            this.TitleListEmployee.Size = new System.Drawing.Size(293, 32);
            this.TitleListEmployee.TabIndex = 0;
            this.TitleListEmployee.Text = "Employee Management";
            // 
            // ListFormEmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListFormEmployeeInformation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ListEmployee";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListViewEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label TitleListEmployee;
        private Panel panel3;
        private Button SearchBtn;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel4;
        private DataGridView ListViewEmployee;
        private DataGridViewTextBoxColumn IdEmployee;
        private DataGridViewTextBoxColumn NameEmployee;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn CurrentUnit;
        private DataGridViewTextBoxColumn CurrentSalary;
        private DataGridViewButtonColumn Detail;
    }
}