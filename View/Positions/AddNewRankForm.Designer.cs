namespace Salary_management.View.Positions
{
    partial class AddNewRankForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RankGroupBox = new System.Windows.Forms.GroupBox();
            this.coefficientText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MilestoneGroupBox = new System.Windows.Forms.GroupBox();
            this.milestoneComboBox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.AddEmployeeGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RankGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MilestoneGroupBox.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 404);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(800, 46);
            this.panel3.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addBtn.Location = new System.Drawing.Point(702, 5);
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
            this.AddEmployeeGroupBox.Controls.Add(this.panel1);
            this.AddEmployeeGroupBox.Controls.Add(this.panel4);
            this.AddEmployeeGroupBox.Controls.Add(this.panel2);
            this.AddEmployeeGroupBox.Controls.Add(this.panel7);
            this.AddEmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployeeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddEmployeeGroupBox.Name = "AddEmployeeGroupBox";
            this.AddEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AddEmployeeGroupBox.Size = new System.Drawing.Size(800, 404);
            this.AddEmployeeGroupBox.TabIndex = 8;
            this.AddEmployeeGroupBox.TabStop = false;
            this.AddEmployeeGroupBox.Text = "Add Rank Form";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 113);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RankGroupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(5, 192);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(790, 94);
            this.panel4.TabIndex = 4;
            // 
            // RankGroupBox
            // 
            this.RankGroupBox.Controls.Add(this.coefficientText);
            this.RankGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankGroupBox.Location = new System.Drawing.Point(10, 10);
            this.RankGroupBox.Name = "RankGroupBox";
            this.RankGroupBox.Size = new System.Drawing.Size(770, 74);
            this.RankGroupBox.TabIndex = 2;
            this.RankGroupBox.TabStop = false;
            this.RankGroupBox.Text = "Coefficient";
            // 
            // coefficientText
            // 
            this.coefficientText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coefficientText.Location = new System.Drawing.Point(3, 44);
            this.coefficientText.Name = "coefficientText";
            this.coefficientText.Size = new System.Drawing.Size(764, 27);
            this.coefficientText.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MilestoneGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(5, 104);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(790, 88);
            this.panel2.TabIndex = 3;
            // 
            // MilestoneGroupBox
            // 
            this.MilestoneGroupBox.Controls.Add(this.milestoneComboBox);
            this.MilestoneGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MilestoneGroupBox.Location = new System.Drawing.Point(10, 10);
            this.MilestoneGroupBox.Name = "MilestoneGroupBox";
            this.MilestoneGroupBox.Size = new System.Drawing.Size(770, 68);
            this.MilestoneGroupBox.TabIndex = 2;
            this.MilestoneGroupBox.TabStop = false;
            this.MilestoneGroupBox.Text = "Milestone";
            // 
            // milestoneComboBox
            // 
            this.milestoneComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.milestoneComboBox.FormattingEnabled = true;
            this.milestoneComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.milestoneComboBox.Location = new System.Drawing.Point(3, 37);
            this.milestoneComboBox.Name = "milestoneComboBox";
            this.milestoneComboBox.Size = new System.Drawing.Size(764, 28);
            this.milestoneComboBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(5, 32);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(790, 72);
            this.panel7.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameText.Location = new System.Drawing.Point(3, 22);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(764, 27);
            this.nameText.TabIndex = 0;
            // 
            // AddNewRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEmployeeGroupBox);
            this.Controls.Add(this.panel3);
            this.Name = "AddNewRankForm";
            this.Text = "AddNewRankForm";
            this.panel3.ResumeLayout(false);
            this.AddEmployeeGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.RankGroupBox.ResumeLayout(false);
            this.RankGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.MilestoneGroupBox.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel4;
        private GroupBox RankGroupBox;
        private TextBox coefficientText;
        private Panel panel2;
        private GroupBox MilestoneGroupBox;
        private ComboBox milestoneComboBox;
        private Panel panel7;
        private GroupBox groupBox2;
        private TextBox nameText;
    }
}