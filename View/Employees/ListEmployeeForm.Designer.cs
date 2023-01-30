namespace Salary_management.View.Employees
{
    partial class ListEmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeTabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listEmployeeTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.employeeIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBirthTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdentityTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAllowanceTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailBtnTable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.retirementBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.familyTab = new System.Windows.Forms.TabPage();
            this.employeeTabControl.SuspendLayout();
            this.employeeTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEmployeeTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTabControl
            // 
            this.employeeTabControl.Controls.Add(this.employeeTab);
            this.employeeTabControl.Controls.Add(this.familyTab);
            this.employeeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.employeeTabControl.Location = new System.Drawing.Point(0, 0);
            this.employeeTabControl.Name = "employeeTabControl";
            this.employeeTabControl.SelectedIndex = 0;
            this.employeeTabControl.Size = new System.Drawing.Size(800, 450);
            this.employeeTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.employeeTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.employeeTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.employeeTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.employeeTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.employeeTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.employeeTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.employeeTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.employeeTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.employeeTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.employeeTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.employeeTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.employeeTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.employeeTabControl.TabIndex = 0;
            this.employeeTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.employeeTabControl.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.panel5);
            this.employeeTab.Controls.Add(this.panel1);
            this.employeeTab.ForeColor = System.Drawing.Color.Black;
            this.employeeTab.Location = new System.Drawing.Point(4, 44);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(10);
            this.employeeTab.Size = new System.Drawing.Size(792, 402);
            this.employeeTab.TabIndex = 0;
            this.employeeTab.Text = "Employee";
            this.employeeTab.UseVisualStyleBackColor = true;
            this.employeeTab.Click += new System.EventHandler(this.employeeTab_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listEmployeeTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 135);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel5.Size = new System.Drawing.Size(772, 257);
            this.panel5.TabIndex = 1;
            // 
            // listEmployeeTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listEmployeeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listEmployeeTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listEmployeeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listEmployeeTable.ColumnHeadersHeight = 22;
            this.listEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listEmployeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDTable,
            this.employeeNameTable,
            this.employeeBirthTable,
            this.employeeIdentityTable,
            this.employeeAllowanceTable,
            this.employeeDetailBtnTable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listEmployeeTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.listEmployeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmployeeTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listEmployeeTable.Location = new System.Drawing.Point(0, 20);
            this.listEmployeeTable.Name = "listEmployeeTable";
            this.listEmployeeTable.RowHeadersVisible = false;
            this.listEmployeeTable.RowHeadersWidth = 51;
            this.listEmployeeTable.RowTemplate.Height = 29;
            this.listEmployeeTable.Size = new System.Drawing.Size(772, 237);
            this.listEmployeeTable.TabIndex = 0;
            this.listEmployeeTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listEmployeeTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listEmployeeTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listEmployeeTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listEmployeeTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listEmployeeTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listEmployeeTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listEmployeeTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.listEmployeeTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listEmployeeTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEmployeeTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listEmployeeTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listEmployeeTable.ThemeStyle.HeaderStyle.Height = 22;
            this.listEmployeeTable.ThemeStyle.ReadOnly = false;
            this.listEmployeeTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listEmployeeTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listEmployeeTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEmployeeTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listEmployeeTable.ThemeStyle.RowsStyle.Height = 29;
            this.listEmployeeTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listEmployeeTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listEmployeeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listEmployeeTable_CellContentClick);
            // 
            // employeeIDTable
            // 
            this.employeeIDTable.HeaderText = "ID";
            this.employeeIDTable.MinimumWidth = 6;
            this.employeeIDTable.Name = "employeeIDTable";
            // 
            // employeeNameTable
            // 
            this.employeeNameTable.HeaderText = "Name";
            this.employeeNameTable.MinimumWidth = 6;
            this.employeeNameTable.Name = "employeeNameTable";
            // 
            // employeeBirthTable
            // 
            this.employeeBirthTable.HeaderText = "Birth";
            this.employeeBirthTable.MinimumWidth = 6;
            this.employeeBirthTable.Name = "employeeBirthTable";
            // 
            // employeeIdentityTable
            // 
            this.employeeIdentityTable.HeaderText = "Identity";
            this.employeeIdentityTable.MinimumWidth = 6;
            this.employeeIdentityTable.Name = "employeeIdentityTable";
            // 
            // employeeAllowanceTable
            // 
            this.employeeAllowanceTable.HeaderText = "Allowance";
            this.employeeAllowanceTable.MinimumWidth = 6;
            this.employeeAllowanceTable.Name = "employeeAllowanceTable";
            // 
            // employeeDetailBtnTable
            // 
            this.employeeDetailBtnTable.HeaderText = "Detail";
            this.employeeDetailBtnTable.MinimumWidth = 6;
            this.employeeDetailBtnTable.Name = "employeeDetailBtnTable";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(772, 125);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(760, 58);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.retirementBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(495, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel6.Size = new System.Drawing.Size(146, 48);
            this.panel6.TabIndex = 4;
            // 
            // retirementBtn
            // 
            this.retirementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.retirementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.retirementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.retirementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.retirementBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retirementBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.retirementBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.retirementBtn.ForeColor = System.Drawing.Color.White;
            this.retirementBtn.Location = new System.Drawing.Point(10, 0);
            this.retirementBtn.Name = "retirementBtn";
            this.retirementBtn.Size = new System.Drawing.Size(126, 38);
            this.retirementBtn.TabIndex = 0;
            this.retirementBtn.Text = "Retirement";
            this.retirementBtn.Click += new System.EventHandler(this.retirementBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(641, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel4.Size = new System.Drawing.Size(114, 48);
            this.panel4.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(10, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 38);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(760, 34);
            this.panel2.TabIndex = 2;
            // 
            // searchText
            // 
            this.searchText.DefaultText = "";
            this.searchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.Location = new System.Drawing.Point(61, 5);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderText = "";
            this.searchText.SelectedText = "";
            this.searchText.Size = new System.Drawing.Size(694, 24);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // familyTab
            // 
            this.familyTab.Location = new System.Drawing.Point(4, 44);
            this.familyTab.Name = "familyTab";
            this.familyTab.Padding = new System.Windows.Forms.Padding(3);
            this.familyTab.Size = new System.Drawing.Size(792, 402);
            this.familyTab.TabIndex = 2;
            this.familyTab.Text = "Family";
            this.familyTab.UseVisualStyleBackColor = true;
            // 
            // ListEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeTabControl);
            this.Name = "ListEmployeeForm";
            this.Text = "ListEmployeeForm";
            this.Load += new System.EventHandler(this.ListEmployeeForm_Load);
            this.employeeTabControl.ResumeLayout(false);
            this.employeeTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEmployeeTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl employeeTabControl;
        private TabPage employeeTab;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addBtn;
        private Label label1;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchText;
        private Label label2;
        private Panel panel5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listEmployeeTable;
        private DataGridViewTextBoxColumn employeeIDTable;
        private DataGridViewTextBoxColumn employeeNameTable;
        private DataGridViewTextBoxColumn employeeBirthTable;
        private DataGridViewTextBoxColumn employeeIdentityTable;
        private DataGridViewTextBoxColumn employeeAllowanceTable;
        private DataGridViewButtonColumn employeeDetailBtnTable;
        private TabPage familyTab;
        private Panel panel6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton retirementBtn;
    }
}