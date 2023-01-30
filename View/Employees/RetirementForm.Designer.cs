namespace Salary_management.View.Employees
{
    partial class RetirementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.retirementDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.listEmployeeTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.employeeIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBirthTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdentityTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAllowanceTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailBtnTable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.retirementDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 84);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(788, 34);
            this.panel4.TabIndex = 4;
            // 
            // retirementDate
            // 
            this.retirementDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retirementDate.Location = new System.Drawing.Point(91, 5);
            this.retirementDate.Name = "retirementDate";
            this.retirementDate.Size = new System.Drawing.Size(692, 27);
            this.retirementDate.TabIndex = 1;
            this.retirementDate.ValueChanged += new System.EventHandler(this.retirementDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(788, 78);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Retirement";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 4;
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
            this.listEmployeeTable.Location = new System.Drawing.Point(0, 125);
            this.listEmployeeTable.Name = "listEmployeeTable";
            this.listEmployeeTable.RowHeadersVisible = false;
            this.listEmployeeTable.RowHeadersWidth = 51;
            this.listEmployeeTable.RowTemplate.Height = 29;
            this.listEmployeeTable.Size = new System.Drawing.Size(800, 279);
            this.listEmployeeTable.TabIndex = 5;
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
            // RetirementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEmployeeTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RetirementForm";
            this.Text = "RetirementForm";
            this.Load += new System.EventHandler(this.RetirementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEmployeeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Button backBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listEmployeeTable;
        private DataGridViewTextBoxColumn employeeIDTable;
        private DataGridViewTextBoxColumn employeeNameTable;
        private DataGridViewTextBoxColumn employeeBirthTable;
        private DataGridViewTextBoxColumn employeeIdentityTable;
        private DataGridViewTextBoxColumn employeeAllowanceTable;
        private DataGridViewButtonColumn employeeDetailBtnTable;
        private Panel panel4;
        private DateTimePicker retirementDate;
        private Label label2;
    }
}