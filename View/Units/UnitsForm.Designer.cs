namespace Salary_management.View.Units
{
    partial class UnitsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listUnitsTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.positionIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFoundedTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDetailBtnTable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listUnitsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(788, 58);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(555, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel5.Size = new System.Drawing.Size(114, 48);
            this.panel5.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(10, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 38);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.EnabledChanged += new System.EventHandler(this.deleteBtn_EnabledChanged);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(669, 5);
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
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unit Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(788, 34);
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
            this.searchText.Size = new System.Drawing.Size(722, 24);
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
            // listUnitsTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listUnitsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listUnitsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listUnitsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listUnitsTable.ColumnHeadersHeight = 22;
            this.listUnitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listUnitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionIDTable,
            this.positionNameTable,
            this.addressTable,
            this.phoneTable,
            this.dateFoundedTable,
            this.positionDetailBtnTable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listUnitsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.listUnitsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUnitsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listUnitsTable.Location = new System.Drawing.Point(0, 125);
            this.listUnitsTable.Name = "listUnitsTable";
            this.listUnitsTable.RowHeadersVisible = false;
            this.listUnitsTable.RowHeadersWidth = 51;
            this.listUnitsTable.RowTemplate.Height = 29;
            this.listUnitsTable.Size = new System.Drawing.Size(800, 325);
            this.listUnitsTable.TabIndex = 3;
            this.listUnitsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listUnitsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listUnitsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listUnitsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listUnitsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listUnitsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listUnitsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listUnitsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.listUnitsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listUnitsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listUnitsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listUnitsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listUnitsTable.ThemeStyle.HeaderStyle.Height = 22;
            this.listUnitsTable.ThemeStyle.ReadOnly = false;
            this.listUnitsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listUnitsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listUnitsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listUnitsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listUnitsTable.ThemeStyle.RowsStyle.Height = 29;
            this.listUnitsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listUnitsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listUnitsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUnitsTable_CellClick);
            this.listUnitsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUnitsTable_CellContentClick);
            // 
            // positionIDTable
            // 
            this.positionIDTable.HeaderText = "ID";
            this.positionIDTable.MinimumWidth = 6;
            this.positionIDTable.Name = "positionIDTable";
            // 
            // positionNameTable
            // 
            this.positionNameTable.HeaderText = "Name";
            this.positionNameTable.MinimumWidth = 6;
            this.positionNameTable.Name = "positionNameTable";
            // 
            // addressTable
            // 
            this.addressTable.HeaderText = "Address";
            this.addressTable.MinimumWidth = 6;
            this.addressTable.Name = "addressTable";
            // 
            // phoneTable
            // 
            this.phoneTable.HeaderText = "Phone";
            this.phoneTable.MinimumWidth = 6;
            this.phoneTable.Name = "phoneTable";
            // 
            // dateFoundedTable
            // 
            this.dateFoundedTable.HeaderText = "Date Founded";
            this.dateFoundedTable.MinimumWidth = 6;
            this.dateFoundedTable.Name = "dateFoundedTable";
            // 
            // positionDetailBtnTable
            // 
            this.positionDetailBtnTable.HeaderText = "Detail";
            this.positionDetailBtnTable.MinimumWidth = 6;
            this.positionDetailBtnTable.Name = "positionDetailBtnTable";
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listUnitsTable);
            this.Controls.Add(this.panel1);
            this.Name = "UnitsForm";
            this.Text = "UnitsForm";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listUnitsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addBtn;
        private Label label1;
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchText;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView listUnitsTable;
        private DataGridViewTextBoxColumn positionIDTable;
        private DataGridViewTextBoxColumn positionNameTable;
        private DataGridViewTextBoxColumn addressTable;
        private DataGridViewTextBoxColumn phoneTable;
        private DataGridViewTextBoxColumn dateFoundedTable;
        private DataGridViewButtonColumn positionDetailBtnTable;
        private Panel panel5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton deleteBtn;
    }
}