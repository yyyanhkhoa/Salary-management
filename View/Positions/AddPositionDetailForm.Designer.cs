namespace Salary_management.View.Positions
{
    partial class AddPositionDetailForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.addEmployeeInPositionBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.endDatePanel = new System.Windows.Forms.Panel();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.workRecentlyCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.endDatePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addEmployeeInPositionBtn);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 404);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(800, 46);
            this.panel4.TabIndex = 22;
            // 
            // addEmployeeInPositionBtn
            // 
            this.addEmployeeInPositionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addEmployeeInPositionBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addEmployeeInPositionBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addEmployeeInPositionBtn.Location = new System.Drawing.Point(702, 5);
            this.addEmployeeInPositionBtn.Name = "addEmployeeInPositionBtn";
            this.addEmployeeInPositionBtn.Size = new System.Drawing.Size(98, 41);
            this.addEmployeeInPositionBtn.TabIndex = 1;
            this.addEmployeeInPositionBtn.Text = "+ Add";
            this.addEmployeeInPositionBtn.UseVisualStyleBackColor = false;
            this.addEmployeeInPositionBtn.Click += new System.EventHandler(this.addEmployeeInPositionBtn_Click);
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
            // endDatePanel
            // 
            this.endDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDatePanel.Controls.Add(this.endDateTimePicker);
            this.endDatePanel.Controls.Add(this.label3);
            this.endDatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.endDatePanel.Location = new System.Drawing.Point(0, 194);
            this.endDatePanel.Name = "endDatePanel";
            this.endDatePanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.endDatePanel.Size = new System.Drawing.Size(800, 69);
            this.endDatePanel.TabIndex = 21;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDateTimePicker.Location = new System.Drawing.Point(85, 20);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(703, 27);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "End date: ";
            // 
            // workRecentlyCheckBox
            // 
            this.workRecentlyCheckBox.AutoSize = true;
            this.workRecentlyCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.workRecentlyCheckBox.Location = new System.Drawing.Point(0, 150);
            this.workRecentlyCheckBox.Name = "workRecentlyCheckBox";
            this.workRecentlyCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.workRecentlyCheckBox.Size = new System.Drawing.Size(800, 44);
            this.workRecentlyCheckBox.TabIndex = 20;
            this.workRecentlyCheckBox.Text = "Work recently";
            this.workRecentlyCheckBox.UseVisualStyleBackColor = true;
            this.workRecentlyCheckBox.CheckedChanged += new System.EventHandler(this.workRecentlyCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.startDateTimePicker);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel3.Size = new System.Drawing.Size(800, 75);
            this.panel3.TabIndex = 19;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateTimePicker.Location = new System.Drawing.Point(91, 20);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(697, 27);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start date: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.employeeComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 18;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(145, 20);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(643, 28);
            this.employeeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Employee: ";
            // 
            // AddPositionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.endDatePanel);
            this.Controls.Add(this.workRecentlyCheckBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AddPositionDetailForm";
            this.Text = "AddPositionDetailForm";
            this.Load += new System.EventHandler(this.AddPositionDetailForm_Load);
            this.panel4.ResumeLayout(false);
            this.endDatePanel.ResumeLayout(false);
            this.endDatePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Button addEmployeeInPositionBtn;
        private Button backBtn;
        private Panel endDatePanel;
        private DateTimePicker endDateTimePicker;
        private Label label3;
        private CheckBox workRecentlyCheckBox;
        private Panel panel3;
        private DateTimePicker startDateTimePicker;
        private Label label2;
        private Panel panel2;
        private ComboBox employeeComboBox;
        private Label label1;
    }
}