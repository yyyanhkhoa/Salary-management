namespace Salary_management.View.Forms.Unit
{
    partial class UnitDetailForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.ListEmployeeTable = new System.Windows.Forms.DataGridView();
            this.IDGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployeeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDayGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FixBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EndDatePanel = new System.Windows.Forms.Panel();
            this.EndDateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.WorkRecentlyCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartDateInput = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnionTab = new System.Windows.Forms.TabPage();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployeeTable)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.EndDatePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BackBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(1166, 48);
            this.panel6.TabIndex = 7;
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Location = new System.Drawing.Point(5, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 38);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EmployeeTab);
            this.tabControl1.Controls.Add(this.UnionTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 490);
            this.tabControl1.TabIndex = 10;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.InformationGroupBox);
            this.EmployeeTab.Controls.Add(this.groupBox1);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 29);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(1158, 457);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Employee";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.ListEmployeeTable);
            this.InformationGroupBox.Controls.Add(this.panel7);
            this.InformationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationGroupBox.Location = new System.Drawing.Point(345, 3);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.InformationGroupBox.Size = new System.Drawing.Size(810, 451);
            this.InformationGroupBox.TabIndex = 10;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Information of Unit";
            // 
            // ListEmployeeTable
            // 
            this.ListEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListEmployeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGrid,
            this.NameEmployeeGrid,
            this.StartDayGrid,
            this.EndDateGrid});
            this.ListEmployeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListEmployeeTable.Location = new System.Drawing.Point(10, 112);
            this.ListEmployeeTable.Name = "ListEmployeeTable";
            this.ListEmployeeTable.RowHeadersWidth = 51;
            this.ListEmployeeTable.RowTemplate.Height = 29;
            this.ListEmployeeTable.Size = new System.Drawing.Size(790, 329);
            this.ListEmployeeTable.TabIndex = 1;
            // 
            // IDGrid
            // 
            this.IDGrid.HeaderText = "ID";
            this.IDGrid.MinimumWidth = 6;
            this.IDGrid.Name = "IDGrid";
            this.IDGrid.ReadOnly = true;
            this.IDGrid.Width = 60;
            // 
            // NameEmployeeGrid
            // 
            this.NameEmployeeGrid.HeaderText = "Name Employee";
            this.NameEmployeeGrid.MinimumWidth = 6;
            this.NameEmployeeGrid.Name = "NameEmployeeGrid";
            this.NameEmployeeGrid.ReadOnly = true;
            this.NameEmployeeGrid.Width = 150;
            // 
            // StartDayGrid
            // 
            this.StartDayGrid.HeaderText = "Start Day";
            this.StartDayGrid.MinimumWidth = 6;
            this.StartDayGrid.Name = "StartDayGrid";
            this.StartDayGrid.ReadOnly = true;
            this.StartDayGrid.Width = 125;
            // 
            // EndDateGrid
            // 
            this.EndDateGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDateGrid.HeaderText = "EndDate";
            this.EndDateGrid.MinimumWidth = 6;
            this.EndDateGrid.Name = "EndDateGrid";
            this.EndDateGrid.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox5);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(790, 82);
            this.panel7.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DateText);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(491, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 82);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date ";
            // 
            // DateText
            // 
            this.DateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateText.Location = new System.Drawing.Point(3, 23);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(293, 27);
            this.DateText.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(445, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(46, 82);
            this.panel10.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PhoneText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(335, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 82);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phone";
            // 
            // PhoneText
            // 
            this.PhoneText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneText.Location = new System.Drawing.Point(3, 23);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.ReadOnly = true;
            this.PhoneText.Size = new System.Drawing.Size(104, 27);
            this.PhoneText.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(289, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 82);
            this.panel9.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddressText);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(178, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address";
            // 
            // AddressText
            // 
            this.AddressText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressText.Location = new System.Drawing.Point(3, 23);
            this.AddressText.Name = "AddressText";
            this.AddressText.ReadOnly = true;
            this.AddressText.Size = new System.Drawing.Size(105, 27);
            this.AddressText.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(132, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(46, 82);
            this.panel8.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NameText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameText.Location = new System.Drawing.Point(3, 23);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(126, 27);
            this.NameText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.EndDatePanel);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(342, 451);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.FixBtn);
            this.panel4.Controls.Add(this.AddBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 312);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(322, 73);
            this.panel4.TabIndex = 7;
            // 
            // FixBtn
            // 
            this.FixBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FixBtn.Location = new System.Drawing.Point(206, 20);
            this.FixBtn.Name = "FixBtn";
            this.FixBtn.Size = new System.Drawing.Size(94, 31);
            this.FixBtn.TabIndex = 1;
            this.FixBtn.Text = "Fix";
            this.FixBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBtn.Location = new System.Drawing.Point(20, 20);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 31);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EndDatePanel
            // 
            this.EndDatePanel.Controls.Add(this.EndDateInput);
            this.EndDatePanel.Controls.Add(this.label3);
            this.EndDatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EndDatePanel.Location = new System.Drawing.Point(10, 243);
            this.EndDatePanel.Name = "EndDatePanel";
            this.EndDatePanel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.EndDatePanel.Size = new System.Drawing.Size(322, 69);
            this.EndDatePanel.TabIndex = 6;
            // 
            // EndDateInput
            // 
            this.EndDateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndDateInput.Location = new System.Drawing.Point(85, 20);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(227, 27);
            this.EndDateInput.TabIndex = 1;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.WorkRecentlyCheckBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 180);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(322, 63);
            this.panel5.TabIndex = 4;
            // 
            // WorkRecentlyCheckBox
            // 
            this.WorkRecentlyCheckBox.AutoSize = true;
            this.WorkRecentlyCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkRecentlyCheckBox.Location = new System.Drawing.Point(10, 10);
            this.WorkRecentlyCheckBox.Name = "WorkRecentlyCheckBox";
            this.WorkRecentlyCheckBox.Size = new System.Drawing.Size(302, 43);
            this.WorkRecentlyCheckBox.TabIndex = 0;
            this.WorkRecentlyCheckBox.Text = "Work recently";
            this.WorkRecentlyCheckBox.UseVisualStyleBackColor = true;
            this.WorkRecentlyCheckBox.CheckedChanged += new System.EventHandler(this.WorkRecentlyCheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StartDateInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 105);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel2.Size = new System.Drawing.Size(322, 75);
            this.panel2.TabIndex = 1;
            // 
            // StartDateInput
            // 
            this.StartDateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartDateInput.Location = new System.Drawing.Point(91, 20);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(221, 27);
            this.StartDateInput.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel1.Size = new System.Drawing.Size(322, 75);
            this.panel1.TabIndex = 0;
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(145, 20);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(167, 28);
            this.EmployeeComboBox.TabIndex = 1;
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
            // UnionTab
            // 
            this.UnionTab.Location = new System.Drawing.Point(4, 29);
            this.UnionTab.Name = "UnionTab";
            this.UnionTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnionTab.Size = new System.Drawing.Size(1158, 457);
            this.UnionTab.TabIndex = 1;
            this.UnionTab.Text = "Union";
            this.UnionTab.UseVisualStyleBackColor = true;
            // 
            // UnitDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel6);
            this.Name = "UnitDetailForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Text = "Unit Detail";
            this.Load += new System.EventHandler(this.UnitDetailForm_Load);
            this.panel6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployeeTable)).EndInit();
            this.panel7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.EndDatePanel.ResumeLayout(false);
            this.EndDatePanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel6;
        private Button BackBtn;
        private TabControl tabControl1;
        private TabPage EmployeeTab;
        private GroupBox InformationGroupBox;
        private DataGridView ListEmployeeTable;
        private DataGridViewTextBoxColumn IDGrid;
        private DataGridViewTextBoxColumn NameEmployeeGrid;
        private DataGridViewTextBoxColumn StartDayGrid;
        private DataGridViewTextBoxColumn EndDateGrid;
        private Panel panel7;
        private GroupBox groupBox5;
        private TextBox DateText;
        private Panel panel10;
        private GroupBox groupBox4;
        private TextBox PhoneText;
        private Panel panel9;
        private GroupBox groupBox3;
        private TextBox AddressText;
        private Panel panel8;
        private GroupBox groupBox2;
        private TextBox NameText;
        private GroupBox groupBox1;
        private Panel panel4;
        private Button FixBtn;
        private Button AddBtn;
        private Panel EndDatePanel;
        private DateTimePicker EndDateInput;
        private Label label3;
        private Panel panel5;
        private CheckBox WorkRecentlyCheckBox;
        private Panel panel2;
        private DateTimePicker StartDateInput;
        private Label label2;
        private Panel panel1;
        private ComboBox EmployeeComboBox;
        private Label label1;
        private TabPage UnionTab;
    }
}