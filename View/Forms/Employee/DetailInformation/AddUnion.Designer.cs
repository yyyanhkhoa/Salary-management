namespace Salary_management.View.Forms.Employee.DetailInformation
{
    partial class AddUnion
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AddUnionGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.AddUnionGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 399);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(790, 46);
            this.panel3.TabIndex = 7;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddBtn.Location = new System.Drawing.Point(692, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 41);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "+ Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameText.Location = new System.Drawing.Point(3, 20);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(272, 27);
            this.NameText.TabIndex = 0;
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameText);
            this.NameGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(278, 50);
            this.NameGroupBox.TabIndex = 0;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(5, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(790, 70);
            this.panel2.TabIndex = 3;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CustomFormat = "";
            this.DateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateOfBirth.Location = new System.Drawing.Point(3, 23);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(322, 27);
            this.DateOfBirth.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Day";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(5, 102);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(790, 91);
            this.panel5.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(367, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Day";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(5, 193);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(790, 80);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 60);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "End Day";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(764, 34);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // AddUnionGroupBox
            // 
            this.AddUnionGroupBox.AutoSize = true;
            this.AddUnionGroupBox.BackColor = System.Drawing.Color.White;
            this.AddUnionGroupBox.Controls.Add(this.panel4);
            this.AddUnionGroupBox.Controls.Add(this.panel1);
            this.AddUnionGroupBox.Controls.Add(this.panel5);
            this.AddUnionGroupBox.Controls.Add(this.panel2);
            this.AddUnionGroupBox.Controls.Add(this.panel3);
            this.AddUnionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUnionGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddUnionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddUnionGroupBox.Name = "AddUnionGroupBox";
            this.AddUnionGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AddUnionGroupBox.Size = new System.Drawing.Size(800, 450);
            this.AddUnionGroupBox.TabIndex = 6;
            this.AddUnionGroupBox.TabStop = false;
            this.AddUnionGroupBox.Text = "Add Union Form";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox1.Location = new System.Drawing.Point(3, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 45);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "End?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 126);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Process";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 126);
            this.panel4.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 93);
            this.textBox1.TabIndex = 0;
            // 
            // AddUnion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUnionGroupBox);
            this.Name = "AddUnion";
            this.Text = "AddUnion";
            this.panel3.ResumeLayout(false);
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.AddUnionGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn;
        private Panel panel3;
        private Button AddBtn;
        private TextBox NameText;
        private GroupBox NameGroupBox;
        private Panel panel2;
        private DateTimePicker DateOfBirth;
        private GroupBox groupBox1;
        private Panel panel5;
        private Panel panel1;
        private GroupBox AddUnionGroupBox;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Panel panel4;
        private GroupBox groupBox4;
        private TextBox textBox1;
    }
}