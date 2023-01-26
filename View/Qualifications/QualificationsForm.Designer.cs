namespace Salary_management.View.Qualifications
{
    partial class QualificationsForm
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
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.qualificationTab = new System.Windows.Forms.TabPage();
            this.expertiseTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.expertiseTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.IdExpertiseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameExpertiseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.deleteExpertiseBtn = new System.Windows.Forms.Button();
            this.addExpertiseBtn = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.nameExpertiseText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneTabControl1.SuspendLayout();
            this.expertiseTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expertiseTable)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Controls.Add(this.qualificationTab);
            this.siticoneTabControl1.Controls.Add(this.expertiseTab);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(800, 450);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 0;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // qualificationTab
            // 
            this.qualificationTab.Location = new System.Drawing.Point(4, 44);
            this.qualificationTab.Name = "qualificationTab";
            this.qualificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.qualificationTab.Size = new System.Drawing.Size(792, 402);
            this.qualificationTab.TabIndex = 0;
            this.qualificationTab.Text = "Qualifications";
            this.qualificationTab.UseVisualStyleBackColor = true;
            // 
            // expertiseTab
            // 
            this.expertiseTab.Controls.Add(this.panel1);
            this.expertiseTab.Location = new System.Drawing.Point(4, 44);
            this.expertiseTab.Name = "expertiseTab";
            this.expertiseTab.Padding = new System.Windows.Forms.Padding(3);
            this.expertiseTab.Size = new System.Drawing.Size(792, 402);
            this.expertiseTab.TabIndex = 1;
            this.expertiseTab.Text = "Expertises";
            this.expertiseTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(786, 396);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.expertiseTable);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(307, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 386);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Expertise";
            // 
            // expertiseTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.expertiseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expertiseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.expertiseTable.ColumnHeadersHeight = 22;
            this.expertiseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.expertiseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExpertiseColumn,
            this.nameExpertiseColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expertiseTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.expertiseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expertiseTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expertiseTable.Location = new System.Drawing.Point(3, 23);
            this.expertiseTable.Name = "expertiseTable";
            this.expertiseTable.RowHeadersVisible = false;
            this.expertiseTable.RowHeadersWidth = 51;
            this.expertiseTable.RowTemplate.Height = 29;
            this.expertiseTable.Size = new System.Drawing.Size(468, 360);
            this.expertiseTable.TabIndex = 0;
            this.expertiseTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.expertiseTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.expertiseTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.expertiseTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.expertiseTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.expertiseTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.expertiseTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expertiseTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.expertiseTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expertiseTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expertiseTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.expertiseTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.expertiseTable.ThemeStyle.HeaderStyle.Height = 22;
            this.expertiseTable.ThemeStyle.ReadOnly = false;
            this.expertiseTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.expertiseTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.expertiseTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expertiseTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.expertiseTable.ThemeStyle.RowsStyle.Height = 29;
            this.expertiseTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.expertiseTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.expertiseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expertiseTable_CellContentClick);
            // 
            // IdExpertiseColumn
            // 
            this.IdExpertiseColumn.HeaderText = "ID";
            this.IdExpertiseColumn.MinimumWidth = 6;
            this.IdExpertiseColumn.Name = "IdExpertiseColumn";
            this.IdExpertiseColumn.ReadOnly = true;
            // 
            // nameExpertiseColumn
            // 
            this.nameExpertiseColumn.HeaderText = "Name";
            this.nameExpertiseColumn.MinimumWidth = 6;
            this.nameExpertiseColumn.Name = "nameExpertiseColumn";
            this.nameExpertiseColumn.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel12);
            this.groupBox5.Controls.Add(this.panel14);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(5, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 386);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.deleteExpertiseBtn);
            this.panel12.Controls.Add(this.addExpertiseBtn);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(3, 106);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(296, 63);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(108, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(80, 43);
            this.panel13.TabIndex = 6;
            // 
            // deleteExpertiseBtn
            // 
            this.deleteExpertiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.deleteExpertiseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteExpertiseBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteExpertiseBtn.Location = new System.Drawing.Point(188, 10);
            this.deleteExpertiseBtn.Name = "deleteExpertiseBtn";
            this.deleteExpertiseBtn.Size = new System.Drawing.Size(98, 43);
            this.deleteExpertiseBtn.TabIndex = 5;
            this.deleteExpertiseBtn.Text = "- Delete";
            this.deleteExpertiseBtn.UseVisualStyleBackColor = false;
            this.deleteExpertiseBtn.Click += new System.EventHandler(this.deleteExpertiseBtn_Click);
            // 
            // addExpertiseBtn
            // 
            this.addExpertiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.addExpertiseBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addExpertiseBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addExpertiseBtn.Location = new System.Drawing.Point(10, 10);
            this.addExpertiseBtn.Name = "addExpertiseBtn";
            this.addExpertiseBtn.Size = new System.Drawing.Size(98, 43);
            this.addExpertiseBtn.TabIndex = 3;
            this.addExpertiseBtn.Text = "+ Add";
            this.addExpertiseBtn.UseVisualStyleBackColor = false;
            this.addExpertiseBtn.Click += new System.EventHandler(this.addExpertiseBtn_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.nameExpertiseText);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(3, 23);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(20);
            this.panel14.Size = new System.Drawing.Size(296, 83);
            this.panel14.TabIndex = 2;
            // 
            // nameExpertiseText
            // 
            this.nameExpertiseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameExpertiseText.Location = new System.Drawing.Point(76, 20);
            this.nameExpertiseText.Name = "nameExpertiseText";
            this.nameExpertiseText.Size = new System.Drawing.Size(200, 27);
            this.nameExpertiseText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name :";
            // 
            // QualificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneTabControl1);
            this.Name = "QualificationsForm";
            this.Text = "QualificationsForm";
            this.Load += new System.EventHandler(this.QualificationsForm_Load);
            this.siticoneTabControl1.ResumeLayout(false);
            this.expertiseTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expertiseTable)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage qualificationTab;
        private TabPage expertiseTab;
        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Panel panel12;
        private Panel panel14;
        private TextBox nameExpertiseText;
        private Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView expertiseTable;
        private DataGridViewTextBoxColumn IdExpertiseColumn;
        private DataGridViewTextBoxColumn nameExpertiseColumn;
        private Panel panel13;
        private Button deleteExpertiseBtn;
        private Button addExpertiseBtn;
    }
}