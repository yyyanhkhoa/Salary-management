namespace Salary_management.View.Forms.OtherTab
{
    partial class OtherTab
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
            this.OtherPageTab = new System.Windows.Forms.TabControl();
            this.UnionTab = new System.Windows.Forms.TabPage();
            this.ListUnionGroupBox = new System.Windows.Forms.GroupBox();
            this.ListUnionGrid = new System.Windows.Forms.DataGridView();
            this.IDGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUnionGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.Button();
            this.QualificationTab = new System.Windows.Forms.TabPage();
            this.OtherPageTab.SuspendLayout();
            this.UnionTab.SuspendLayout();
            this.ListUnionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListUnionGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtherPageTab
            // 
            this.OtherPageTab.Controls.Add(this.UnionTab);
            this.OtherPageTab.Controls.Add(this.QualificationTab);
            this.OtherPageTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtherPageTab.Location = new System.Drawing.Point(0, 0);
            this.OtherPageTab.Name = "OtherPageTab";
            this.OtherPageTab.SelectedIndex = 0;
            this.OtherPageTab.Size = new System.Drawing.Size(840, 528);
            this.OtherPageTab.TabIndex = 0;
            // 
            // UnionTab
            // 
            this.UnionTab.Controls.Add(this.ListUnionGroupBox);
            this.UnionTab.Controls.Add(this.groupBox1);
            this.UnionTab.Controls.Add(this.panel1);
            this.UnionTab.Location = new System.Drawing.Point(4, 29);
            this.UnionTab.Name = "UnionTab";
            this.UnionTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnionTab.Size = new System.Drawing.Size(832, 495);
            this.UnionTab.TabIndex = 0;
            this.UnionTab.Text = "Union";
            this.UnionTab.UseVisualStyleBackColor = true;
            // 
            // ListUnionGroupBox
            // 
            this.ListUnionGroupBox.Controls.Add(this.ListUnionGrid);
            this.ListUnionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUnionGroupBox.Location = new System.Drawing.Point(291, 55);
            this.ListUnionGroupBox.Name = "ListUnionGroupBox";
            this.ListUnionGroupBox.Size = new System.Drawing.Size(538, 437);
            this.ListUnionGroupBox.TabIndex = 2;
            this.ListUnionGroupBox.TabStop = false;
            this.ListUnionGroupBox.Text = "ListUnion";
            // 
            // ListUnionGrid
            // 
            this.ListUnionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUnionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGrid,
            this.NameUnionGrid});
            this.ListUnionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUnionGrid.Location = new System.Drawing.Point(3, 23);
            this.ListUnionGrid.Name = "ListUnionGrid";
            this.ListUnionGrid.RowHeadersWidth = 51;
            this.ListUnionGrid.RowTemplate.Height = 29;
            this.ListUnionGrid.Size = new System.Drawing.Size(532, 411);
            this.ListUnionGrid.TabIndex = 0;
            // 
            // IDGrid
            // 
            this.IDGrid.HeaderText = "ID";
            this.IDGrid.MinimumWidth = 6;
            this.IDGrid.Name = "IDGrid";
            this.IDGrid.Width = 125;
            // 
            // NameUnionGrid
            // 
            this.NameUnionGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameUnionGrid.HeaderText = "Name Union";
            this.NameUnionGrid.MinimumWidth = 6;
            this.NameUnionGrid.Name = "NameUnionGrid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 189);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(282, 63);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(98, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 43);
            this.panel4.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteBtn.Location = new System.Drawing.Point(178, 10);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 43);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBtn.Location = new System.Drawing.Point(10, 10);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(88, 43);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NameText);
            this.panel5.Controls.Add(this.NameLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 106);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(282, 83);
            this.panel5.TabIndex = 2;
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameText.Location = new System.Drawing.Point(76, 20);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(186, 27);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameLabel.Location = new System.Drawing.Point(20, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IDText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(282, 83);
            this.panel2.TabIndex = 0;
            // 
            // IDText
            // 
            this.IDText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDText.Location = new System.Drawing.Point(51, 20);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(211, 27);
            this.IDText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NextBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(826, 52);
            this.panel1.TabIndex = 0;
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextBtn.Location = new System.Drawing.Point(722, 10);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(94, 32);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next >";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // QualificationTab
            // 
            this.QualificationTab.Location = new System.Drawing.Point(4, 29);
            this.QualificationTab.Name = "QualificationTab";
            this.QualificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.QualificationTab.Size = new System.Drawing.Size(832, 495);
            this.QualificationTab.TabIndex = 1;
            this.QualificationTab.Text = "Qualification";
            this.QualificationTab.UseVisualStyleBackColor = true;
            // 
            // OtherTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 528);
            this.Controls.Add(this.OtherPageTab);
            this.Name = "OtherTab";
            this.Text = "OtherTab";
            this.Load += new System.EventHandler(this.OtherTab_Load);
            this.OtherPageTab.ResumeLayout(false);
            this.UnionTab.ResumeLayout(false);
            this.ListUnionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListUnionGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl OtherPageTab;
        private TabPage UnionTab;
        private Panel panel1;
        private Button NextBtn;
        private TabPage QualificationTab;
        private GroupBox ListUnionGroupBox;
        private DataGridView ListUnionGrid;
        private DataGridViewTextBoxColumn IDGrid;
        private DataGridViewTextBoxColumn NameUnionGrid;
        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox IDText;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Button DeleteBtn;
        private Button AddBtn;
        private Panel panel5;
        private TextBox NameText;
        private Label NameLabel;
    }
}