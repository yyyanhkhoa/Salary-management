namespace Salary_management
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.PeronalBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.SettingBtn);
            this.panelMenu.Controls.Add(this.PeronalBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 616);
            this.panelMenu.TabIndex = 0;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingBtn.Image")));
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 146);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SettingBtn.Size = new System.Drawing.Size(220, 66);
            this.SettingBtn.TabIndex = 2;
            this.SettingBtn.Text = "    Setting";
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // PeronalBtn
            // 
            this.PeronalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PeronalBtn.FlatAppearance.BorderSize = 0;
            this.PeronalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeronalBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.PeronalBtn.Image = ((System.Drawing.Image)(resources.GetObject("PeronalBtn.Image")));
            this.PeronalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeronalBtn.Location = new System.Drawing.Point(0, 80);
            this.PeronalBtn.Name = "PeronalBtn";
            this.PeronalBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.PeronalBtn.Size = new System.Drawing.Size(220, 66);
            this.PeronalBtn.TabIndex = 1;
            this.PeronalBtn.Text = "    Personal";
            this.PeronalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PeronalBtn.UseVisualStyleBackColor = true;
            this.PeronalBtn.Click += new System.EventHandler(this.PeronalBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(763, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 616);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Management";
            this.Text = "Management";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button PeronalBtn;
        private Panel panelLogo;
        private Button SettingBtn;
        private Panel panelTitleBar;
    }
}