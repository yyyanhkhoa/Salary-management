namespace Salary_management.View.Forms.Employee
{
    partial class FormEmployeeDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.AddNewBtn = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.CoefficientAllowanceGroupBox = new System.Windows.Forms.GroupBox();
            this.CoefficientAllowanceText = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.StartDateGroupBox = new System.Windows.Forms.GroupBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.IdentityGroupBox = new System.Windows.Forms.GroupBox();
            this.IdentityText = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.EthnicGroupBox = new System.Windows.Forms.GroupBox();
            this.EthnicText = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.MaleBtn = new System.Windows.Forms.RadioButton();
            this.FemaleBtn = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ImagePicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FixBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FamilyGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.RemoveFamilyBtn = new System.Windows.Forms.Button();
            this.FixFamilyBtn = new System.Windows.Forms.Button();
            this.AddFamilyBtn = new System.Windows.Forms.Button();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.npgsqlDataAdapter2 = new Npgsql.NpgsqlDataAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AddEmployeeGroupBox.SuspendLayout();
            this.panel12.SuspendLayout();
            this.CoefficientAllowanceGroupBox.SuspendLayout();
            this.panel9.SuspendLayout();
            this.StartDateGroupBox.SuspendLayout();
            this.IdentityGroupBox.SuspendLayout();
            this.EthnicGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AddressGroupBox.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyGridView)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(842, 526);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 504);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddEmployeeGroupBox);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeGroupBox
            // 
            this.AddEmployeeGroupBox.AutoSize = true;
            this.AddEmployeeGroupBox.BackColor = System.Drawing.Color.White;
            this.AddEmployeeGroupBox.Controls.Add(this.AddNewBtn);
            this.AddEmployeeGroupBox.Controls.Add(this.panel12);
            this.AddEmployeeGroupBox.Controls.Add(this.panel9);
            this.AddEmployeeGroupBox.Controls.Add(this.panel5);
            this.AddEmployeeGroupBox.Controls.Add(this.panel7);
            this.AddEmployeeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployeeGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.AddEmployeeGroupBox.Name = "AddEmployeeGroupBox";
            this.AddEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.AddEmployeeGroupBox.Size = new System.Drawing.Size(806, 419);
            this.AddEmployeeGroupBox.TabIndex = 11;
            this.AddEmployeeGroupBox.TabStop = false;
            this.AddEmployeeGroupBox.Text = "Detail Employee Form";
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewBtn.Location = new System.Drawing.Point(5, 404);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(796, 10);
            this.AddNewBtn.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.CoefficientAllowanceGroupBox);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel12.Location = new System.Drawing.Point(5, 324);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(796, 80);
            this.panel12.TabIndex = 5;
            // 
            // CoefficientAllowanceGroupBox
            // 
            this.CoefficientAllowanceGroupBox.Controls.Add(this.CoefficientAllowanceText);
            this.CoefficientAllowanceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientAllowanceGroupBox.Location = new System.Drawing.Point(10, 10);
            this.CoefficientAllowanceGroupBox.Name = "CoefficientAllowanceGroupBox";
            this.CoefficientAllowanceGroupBox.Size = new System.Drawing.Size(776, 60);
            this.CoefficientAllowanceGroupBox.TabIndex = 1;
            this.CoefficientAllowanceGroupBox.TabStop = false;
            this.CoefficientAllowanceGroupBox.Text = "Coefficient Allowance";
            // 
            // CoefficientAllowanceText
            // 
            this.CoefficientAllowanceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientAllowanceText.Location = new System.Drawing.Point(3, 23);
            this.CoefficientAllowanceText.Name = "CoefficientAllowanceText";
            this.CoefficientAllowanceText.Size = new System.Drawing.Size(770, 27);
            this.CoefficientAllowanceText.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.StartDateGroupBox);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.IdentityGroupBox);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.EthnicGroupBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel9.Location = new System.Drawing.Point(5, 243);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(796, 81);
            this.panel9.TabIndex = 4;
            // 
            // StartDateGroupBox
            // 
            this.StartDateGroupBox.Controls.Add(this.StartDate);
            this.StartDateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartDateGroupBox.Location = new System.Drawing.Point(489, 10);
            this.StartDateGroupBox.Name = "StartDateGroupBox";
            this.StartDateGroupBox.Size = new System.Drawing.Size(297, 61);
            this.StartDateGroupBox.TabIndex = 4;
            this.StartDateGroupBox.TabStop = false;
            this.StartDateGroupBox.Text = "Start Date At School";
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "";
            this.StartDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartDate.Location = new System.Drawing.Point(3, 31);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(291, 27);
            this.StartDate.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(466, 10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(23, 61);
            this.panel11.TabIndex = 3;
            // 
            // IdentityGroupBox
            // 
            this.IdentityGroupBox.Controls.Add(this.IdentityText);
            this.IdentityGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IdentityGroupBox.Location = new System.Drawing.Point(185, 10);
            this.IdentityGroupBox.Name = "IdentityGroupBox";
            this.IdentityGroupBox.Size = new System.Drawing.Size(281, 61);
            this.IdentityGroupBox.TabIndex = 2;
            this.IdentityGroupBox.TabStop = false;
            this.IdentityGroupBox.Text = "Identity";
            // 
            // IdentityText
            // 
            this.IdentityText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IdentityText.Location = new System.Drawing.Point(3, 31);
            this.IdentityText.Name = "IdentityText";
            this.IdentityText.Size = new System.Drawing.Size(275, 27);
            this.IdentityText.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(144, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(41, 61);
            this.panel10.TabIndex = 1;
            // 
            // EthnicGroupBox
            // 
            this.EthnicGroupBox.Controls.Add(this.EthnicText);
            this.EthnicGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.EthnicGroupBox.Location = new System.Drawing.Point(10, 10);
            this.EthnicGroupBox.Name = "EthnicGroupBox";
            this.EthnicGroupBox.Size = new System.Drawing.Size(134, 61);
            this.EthnicGroupBox.TabIndex = 0;
            this.EthnicGroupBox.TabStop = false;
            this.EthnicGroupBox.Text = "Ethnic";
            // 
            // EthnicText
            // 
            this.EthnicText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EthnicText.Location = new System.Drawing.Point(3, 31);
            this.EthnicText.Name = "EthnicText";
            this.EthnicText.Size = new System.Drawing.Size(128, 27);
            this.EthnicText.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.AddressGroupBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(5, 161);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(796, 82);
            this.panel5.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(466, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date of Birth";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CustomFormat = "";
            this.DateOfBirth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DateOfBirth.Location = new System.Drawing.Point(3, 32);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(314, 27);
            this.DateOfBirth.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(444, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 62);
            this.panel6.TabIndex = 2;
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.AddressText);
            this.AddressGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddressGroupBox.Location = new System.Drawing.Point(10, 10);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(434, 62);
            this.AddressGroupBox.TabIndex = 1;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Address";
            // 
            // AddressText
            // 
            this.AddressText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddressText.Location = new System.Drawing.Point(3, 32);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(428, 27);
            this.AddressText.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.ImagePicture);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(5, 32);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(796, 129);
            this.panel7.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GenderGroupBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.NameGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(144, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(642, 70);
            this.panel2.TabIndex = 2;
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.MaleBtn);
            this.GenderGroupBox.Controls.Add(this.FemaleBtn);
            this.GenderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenderGroupBox.Location = new System.Drawing.Point(307, 10);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Padding = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.GenderGroupBox.Size = new System.Drawing.Size(325, 50);
            this.GenderGroupBox.TabIndex = 3;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // MaleBtn
            // 
            this.MaleBtn.AutoSize = true;
            this.MaleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaleBtn.Location = new System.Drawing.Point(40, 23);
            this.MaleBtn.Name = "MaleBtn";
            this.MaleBtn.Size = new System.Drawing.Size(167, 24);
            this.MaleBtn.TabIndex = 2;
            this.MaleBtn.TabStop = true;
            this.MaleBtn.Text = "Male";
            this.MaleBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.AutoSize = true;
            this.FemaleBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FemaleBtn.Location = new System.Drawing.Point(207, 23);
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Size = new System.Drawing.Size(78, 24);
            this.FemaleBtn.TabIndex = 1;
            this.FemaleBtn.TabStop = true;
            this.FemaleBtn.Text = "Female";
            this.FemaleBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(288, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 50);
            this.panel4.TabIndex = 2;
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameText);
            this.NameGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameGroupBox.Location = new System.Drawing.Point(10, 10);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(278, 50);
            this.NameGroupBox.TabIndex = 0;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NameText.Location = new System.Drawing.Point(3, 20);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(272, 27);
            this.NameText.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(123, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(21, 109);
            this.panel8.TabIndex = 1;
            // 
            // ImagePicture
            // 
            this.ImagePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePicture.Location = new System.Drawing.Point(10, 10);
            this.ImagePicture.Name = "ImagePicture";
            this.ImagePicture.Size = new System.Drawing.Size(113, 109);
            this.ImagePicture.TabIndex = 0;
            this.ImagePicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FixBtn);
            this.panel3.Controls.Add(this.BackBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 422);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(806, 46);
            this.panel3.TabIndex = 10;
            // 
            // FixBtn
            // 
            this.FixBtn.BackColor = System.Drawing.Color.Yellow;
            this.FixBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FixBtn.Location = new System.Drawing.Point(708, 5);
            this.FixBtn.Name = "FixBtn";
            this.FixBtn.Size = new System.Drawing.Size(98, 41);
            this.FixBtn.TabIndex = 1;
            this.FixBtn.Text = "Fix";
            this.FixBtn.UseVisualStyleBackColor = false;
            this.FixBtn.Click += new System.EventHandler(this.FixBtn_Click_1);
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Location = new System.Drawing.Point(0, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 41);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Family";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.FamilyGridView);
            this.groupBox2.Controls.Add(this.panel14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(806, 465);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Family Form";
            // 
            // FamilyGridView
            // 
            this.FamilyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FamilyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.FamilyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FamilyGridView.Location = new System.Drawing.Point(5, 106);
            this.FamilyGridView.Name = "FamilyGridView";
            this.FamilyGridView.RowHeadersWidth = 51;
            this.FamilyGridView.RowTemplate.Height = 29;
            this.FamilyGridView.Size = new System.Drawing.Size(796, 354);
            this.FamilyGridView.TabIndex = 17;
            this.FamilyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FamilyGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 180F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 80F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Ocupation";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.FillWeight = 95F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Relative Type";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 156;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.RemoveFamilyBtn);
            this.panel14.Controls.Add(this.FixFamilyBtn);
            this.panel14.Controls.Add(this.AddFamilyBtn);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(5, 32);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(10);
            this.panel14.Size = new System.Drawing.Size(796, 74);
            this.panel14.TabIndex = 16;
            // 
            // RemoveFamilyBtn
            // 
            this.RemoveFamilyBtn.AutoSize = true;
            this.RemoveFamilyBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveFamilyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveFamilyBtn.Location = new System.Drawing.Point(268, 10);
            this.RemoveFamilyBtn.Name = "RemoveFamilyBtn";
            this.RemoveFamilyBtn.Size = new System.Drawing.Size(260, 54);
            this.RemoveFamilyBtn.TabIndex = 5;
            this.RemoveFamilyBtn.Text = "Remove";
            this.RemoveFamilyBtn.UseVisualStyleBackColor = false;
            // 
            // FixFamilyBtn
            // 
            this.FixFamilyBtn.AutoSize = true;
            this.FixFamilyBtn.BackColor = System.Drawing.Color.Transparent;
            this.FixFamilyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FixFamilyBtn.Location = new System.Drawing.Point(528, 10);
            this.FixFamilyBtn.Name = "FixFamilyBtn";
            this.FixFamilyBtn.Size = new System.Drawing.Size(258, 54);
            this.FixFamilyBtn.TabIndex = 4;
            this.FixFamilyBtn.Text = "Fix";
            this.FixFamilyBtn.UseVisualStyleBackColor = false;
            this.FixFamilyBtn.Click += new System.EventHandler(this.FixFamilyBtn_Click);
            // 
            // AddFamilyBtn
            // 
            this.AddFamilyBtn.AutoSize = true;
            this.AddFamilyBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddFamilyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddFamilyBtn.Location = new System.Drawing.Point(10, 10);
            this.AddFamilyBtn.Name = "AddFamilyBtn";
            this.AddFamilyBtn.Size = new System.Drawing.Size(258, 54);
            this.AddFamilyBtn.TabIndex = 3;
            this.AddFamilyBtn.Text = "Add";
            this.AddFamilyBtn.UseVisualStyleBackColor = false;
            this.AddFamilyBtn.Click += new System.EventHandler(this.AddFamilyBtn_Click);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlDataAdapter2
            // 
            this.npgsqlDataAdapter2.DeleteCommand = null;
            this.npgsqlDataAdapter2.InsertCommand = null;
            this.npgsqlDataAdapter2.SelectCommand = null;
            this.npgsqlDataAdapter2.UpdateCommand = null;
            // 
            // FormEmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 526);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeDetail";
            this.Text = "FormEmployeeDetail";
            this.Load += new System.EventHandler(this.FormEmployeeDetail_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AddEmployeeGroupBox.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.CoefficientAllowanceGroupBox.ResumeLayout(false);
            this.CoefficientAllowanceGroupBox.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.StartDateGroupBox.ResumeLayout(false);
            this.IdentityGroupBox.ResumeLayout(false);
            this.IdentityGroupBox.PerformLayout();
            this.EthnicGroupBox.ResumeLayout(false);
            this.EthnicGroupBox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FamilyGridView)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private DataGridView FamilyGridView;
        private Panel panel14;
        private Button RemoveFamilyBtn;
        private Button FixFamilyBtn;
        private Button AddFamilyBtn;
        private GroupBox AddEmployeeGroupBox;
        private Panel AddNewBtn;
        private Panel panel12;
        private GroupBox CoefficientAllowanceGroupBox;
        private TextBox CoefficientAllowanceText;
        private Panel panel9;
        private GroupBox StartDateGroupBox;
        private DateTimePicker StartDate;
        private Panel panel11;
        private GroupBox IdentityGroupBox;
        private TextBox IdentityText;
        private Panel panel10;
        private GroupBox EthnicGroupBox;
        private TextBox EthnicText;
        private Panel panel5;
        private GroupBox groupBox1;
        private DateTimePicker DateOfBirth;
        private Panel panel6;
        private GroupBox AddressGroupBox;
        private TextBox AddressText;
        private Panel panel7;
        private Panel panel2;
        private GroupBox GenderGroupBox;
        private RadioButton MaleBtn;
        private RadioButton FemaleBtn;
        private Panel panel4;
        private GroupBox NameGroupBox;
        private TextBox NameText;
        private Panel panel8;
        private PictureBox ImagePicture;
        private Panel panel3;
        private Button FixBtn;
        private Button BackBtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}