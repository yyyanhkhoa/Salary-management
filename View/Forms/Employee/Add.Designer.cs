namespace Salary_management.View.Forms.Employee
{
    partial class AddEmployee
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
            this.AddEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AddEmployeeGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddEmployeeGroupBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(873, 468);
            this.panel1.TabIndex = 1;
            // 
            // AddEmployeeGroupBox
            // 
            this.AddEmployeeGroupBox.AutoSize = true;
            this.AddEmployeeGroupBox.BackColor = System.Drawing.Color.White;
            this.AddEmployeeGroupBox.Controls.Add(this.panel2);
            this.AddEmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployeeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeGroupBox.Location = new System.Drawing.Point(10, 10);
            this.AddEmployeeGroupBox.Name = "AddEmployeeGroupBox";
            this.AddEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AddEmployeeGroupBox.Size = new System.Drawing.Size(851, 400);
            this.AddEmployeeGroupBox.TabIndex = 4;
            this.AddEmployeeGroupBox.TabStop = false;
            this.AddEmployeeGroupBox.Text = "Add Employee Form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GenderGroupBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.NameGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(5, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(841, 100);
            this.panel2.TabIndex = 0;
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleBtn);
            this.GenderGroupBox.Controls.Add(this.radioButton1);
            this.GenderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenderGroupBox.Location = new System.Drawing.Point(466, 10);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(365, 80);
            this.GenderGroupBox.TabIndex = 3;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.AutoSize = true;
            this.FemaleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FemaleBtn.Location = new System.Drawing.Point(66, 23);
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Size = new System.Drawing.Size(296, 54);
            this.FemaleBtn.TabIndex = 1;
            this.FemaleBtn.TabStop = true;
            this.FemaleBtn.Text = "Female";
            this.FemaleBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Location = new System.Drawing.Point(3, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 54);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(447, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 80);
            this.panel4.TabIndex = 2;
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.textBox1);
            this.NameGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(437, 80);
            this.NameGroupBox.TabIndex = 0;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 27);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 410);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(851, 46);
            this.panel3.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddBtn.Location = new System.Drawing.Point(753, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 41);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "+ Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Location = new System.Drawing.Point(0, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 41);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 488);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AddEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddEmployeeGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button BackBtn;
        private Button AddBtn;
        private GroupBox AddEmployeeGroupBox;
        private Panel panel2;
        private GroupBox GenderGroupBox;
        private RadioButton radioButton1;
        private Panel panel4;
        private GroupBox NameGroupBox;
        private TextBox textBox1;
        private RadioButton FemaleBtn;
    }
}