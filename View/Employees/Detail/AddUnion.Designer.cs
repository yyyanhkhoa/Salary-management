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
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.unionJoinBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startDayBox = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.endDayBox = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AddUnionGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.AddUnionGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddBtn.Location = new System.Drawing.Point(696, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 41);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.BackBtn.Location = new System.Drawing.Point(0, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 41);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.unionJoinBox);
            this.NameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(770, 63);
            this.NameGroupBox.TabIndex = 0;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // unionJoinBox
            // 
            this.unionJoinBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unionJoinBox.FormattingEnabled = true;
            this.unionJoinBox.Location = new System.Drawing.Point(3, 23);
            this.unionJoinBox.Name = "unionJoinBox";
            this.unionJoinBox.Size = new System.Drawing.Size(764, 28);
            this.unionJoinBox.TabIndex = 1;
            this.unionJoinBox.Text = "--Select--";
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
            this.panel2.Size = new System.Drawing.Size(790, 83);
            this.panel2.TabIndex = 3;
            // 
            // startDayBox
            // 
            this.startDayBox.CustomFormat = "";
            this.startDayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDayBox.Location = new System.Drawing.Point(3, 23);
            this.startDayBox.Name = "startDayBox";
            this.startDayBox.Size = new System.Drawing.Size(322, 27);
            this.startDayBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startDayBox);
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
            this.panel5.Location = new System.Drawing.Point(5, 115);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(790, 91);
            this.panel5.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(367, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Day";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.endDayBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(72, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 45);
            this.panel6.TabIndex = 2;
            this.panel6.Visible = false;
            // 
            // endDayBox
            // 
            this.endDayBox.CustomFormat = "";
            this.endDayBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.endDayBox.Location = new System.Drawing.Point(35, 0);
            this.endDayBox.Name = "endDayBox";
            this.endDayBox.Size = new System.Drawing.Size(303, 27);
            this.endDayBox.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "End?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddUnionGroupBox
            // 
            this.AddUnionGroupBox.AutoSize = true;
            this.AddUnionGroupBox.BackColor = System.Drawing.Color.White;
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
            // AddUnion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUnionGroupBox);
            this.Name = "AddUnion";
            this.Text = "AddUnion";
            this.Load += new System.EventHandler(this.AddUnion_Load);
            this.panel3.ResumeLayout(false);
            this.NameGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.AddUnionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel3;
        private GroupBox NameGroupBox;
        private Panel panel2;
        private DateTimePicker startDayBox;
        private GroupBox groupBox1;
        private Panel panel5;
        private GroupBox AddUnionGroupBox;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private DateTimePicker endDayBox;
        private Panel panel6;
        private ComboBox unionJoinBox;
        private Button AddBtn;
        private Button BackBtn;
    }
}