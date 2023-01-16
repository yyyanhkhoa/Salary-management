namespace Salary_management.View.Positions
{
    partial class AddNewPositionForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.AddEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RankGroupBox = new System.Windows.Forms.GroupBox();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BaseSalaryGroupBox = new System.Windows.Forms.GroupBox();
            this.baseSalaryText = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.IdGroupBox = new System.Windows.Forms.GroupBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.AddEmployeeGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RankGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BaseSalaryGroupBox.SuspendLayout();
            this.panel7.SuspendLayout();
            this.IdGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(798, 46);
            this.panel3.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addBtn.Location = new System.Drawing.Point(700, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 41);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "+ Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.backBtn.Location = new System.Drawing.Point(0, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 41);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "< Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddEmployeeGroupBox
            // 
            this.AddEmployeeGroupBox.AutoSize = true;
            this.AddEmployeeGroupBox.BackColor = System.Drawing.Color.White;
            this.AddEmployeeGroupBox.Controls.Add(this.panel5);
            this.AddEmployeeGroupBox.Controls.Add(this.panel4);
            this.AddEmployeeGroupBox.Controls.Add(this.panel2);
            this.AddEmployeeGroupBox.Controls.Add(this.panel7);
            this.AddEmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployeeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddEmployeeGroupBox.Name = "AddEmployeeGroupBox";
            this.AddEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AddEmployeeGroupBox.Size = new System.Drawing.Size(798, 391);
            this.AddEmployeeGroupBox.TabIndex = 7;
            this.AddEmployeeGroupBox.TabStop = false;
            this.AddEmployeeGroupBox.Text = "Add Position Form";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(5, 294);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(788, 92);
            this.panel5.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptionText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(768, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionText.Location = new System.Drawing.Point(3, 23);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(762, 46);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RankGroupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(5, 206);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(788, 88);
            this.panel4.TabIndex = 4;
            // 
            // RankGroupBox
            // 
            this.RankGroupBox.Controls.Add(this.rankComboBox);
            this.RankGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankGroupBox.Location = new System.Drawing.Point(10, 10);
            this.RankGroupBox.Name = "RankGroupBox";
            this.RankGroupBox.Size = new System.Drawing.Size(768, 68);
            this.RankGroupBox.TabIndex = 2;
            this.RankGroupBox.TabStop = false;
            this.RankGroupBox.Text = "Rank";
            // 
            // rankComboBox
            // 
            this.rankComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Location = new System.Drawing.Point(3, 37);
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(762, 28);
            this.rankComboBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BaseSalaryGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(5, 118);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(788, 88);
            this.panel2.TabIndex = 3;
            // 
            // BaseSalaryGroupBox
            // 
            this.BaseSalaryGroupBox.Controls.Add(this.baseSalaryText);
            this.BaseSalaryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseSalaryGroupBox.Location = new System.Drawing.Point(10, 10);
            this.BaseSalaryGroupBox.Name = "BaseSalaryGroupBox";
            this.BaseSalaryGroupBox.Size = new System.Drawing.Size(768, 68);
            this.BaseSalaryGroupBox.TabIndex = 2;
            this.BaseSalaryGroupBox.TabStop = false;
            this.BaseSalaryGroupBox.Text = "Base Salary";
            // 
            // baseSalaryText
            // 
            this.baseSalaryText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baseSalaryText.Location = new System.Drawing.Point(3, 38);
            this.baseSalaryText.Name = "baseSalaryText";
            this.baseSalaryText.Size = new System.Drawing.Size(762, 27);
            this.baseSalaryText.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.IdGroupBox);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(5, 32);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(788, 86);
            this.panel7.TabIndex = 2;
            // 
            // IdGroupBox
            // 
            this.IdGroupBox.Controls.Add(this.idText);
            this.IdGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdGroupBox.Location = new System.Drawing.Point(10, 10);
            this.IdGroupBox.Name = "IdGroupBox";
            this.IdGroupBox.Size = new System.Drawing.Size(381, 66);
            this.IdGroupBox.TabIndex = 3;
            this.IdGroupBox.TabStop = false;
            this.IdGroupBox.Text = "ID";
            // 
            // idText
            // 
            this.idText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.idText.Location = new System.Drawing.Point(3, 36);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(375, 27);
            this.idText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(391, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameText.Location = new System.Drawing.Point(3, 36);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(381, 27);
            this.nameText.TabIndex = 0;
            // 
            // AddNewPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 437);
            this.Controls.Add(this.AddEmployeeGroupBox);
            this.Controls.Add(this.panel3);
            this.Name = "AddNewPositionForm";
            this.Text = "AddNewPositionForm";
            this.Load += new System.EventHandler(this.AddNewPositionForm_Load);
            this.panel3.ResumeLayout(false);
            this.AddEmployeeGroupBox.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.RankGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.BaseSalaryGroupBox.ResumeLayout(false);
            this.BaseSalaryGroupBox.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.IdGroupBox.ResumeLayout(false);
            this.IdGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel3;
        private Button addBtn;
        private Button backBtn;
        private GroupBox AddEmployeeGroupBox;
        private Panel panel5;
        private GroupBox groupBox4;
        private RichTextBox descriptionText;
        private Panel panel4;
        private GroupBox RankGroupBox;
        private ComboBox rankComboBox;
        private Panel panel2;
        private GroupBox BaseSalaryGroupBox;
        private TextBox baseSalaryText;
        private Panel panel7;
        private GroupBox IdGroupBox;
        private TextBox idText;
        private GroupBox groupBox2;
        private TextBox nameText;
    }
}