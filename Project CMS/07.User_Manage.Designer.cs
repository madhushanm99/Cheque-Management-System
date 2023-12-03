namespace Project_CMS
{
    partial class User_Manage
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
            this.UsersAddorRemoveGrp = new System.Windows.Forms.GroupBox();
            this.Edit_btn = new MetroFramework.Controls.MetroButton();
            this.Delete_btn = new MetroFramework.Controls.MetroButton();
            this.User_Name_txt = new MetroFramework.Controls.MetroTextBox();
            this.Type_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Re_Password_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Password_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Save_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Clear_btn = new MetroFramework.Controls.MetroButton();
            this.AdminLogGrp = new System.Windows.Forms.GroupBox();
            this.Login_btn = new MetroFramework.Controls.MetroButton();
            this.Admin_Password_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.UsersDgv = new System.Windows.Forms.DataGridView();
            this.UsersAddorRemoveGrp.SuspendLayout();
            this.AdminLogGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersAddorRemoveGrp
            // 
            this.UsersAddorRemoveGrp.Controls.Add(this.Clear_btn);
            this.UsersAddorRemoveGrp.Controls.Add(this.Edit_btn);
            this.UsersAddorRemoveGrp.Controls.Add(this.Delete_btn);
            this.UsersAddorRemoveGrp.Controls.Add(this.User_Name_txt);
            this.UsersAddorRemoveGrp.Controls.Add(this.Type_cmb);
            this.UsersAddorRemoveGrp.Controls.Add(this.metroLabel4);
            this.UsersAddorRemoveGrp.Controls.Add(this.Re_Password_txt);
            this.UsersAddorRemoveGrp.Controls.Add(this.metroLabel3);
            this.UsersAddorRemoveGrp.Controls.Add(this.Password_txt);
            this.UsersAddorRemoveGrp.Controls.Add(this.metroLabel2);
            this.UsersAddorRemoveGrp.Controls.Add(this.Save_btn);
            this.UsersAddorRemoveGrp.Controls.Add(this.metroLabel1);
            this.UsersAddorRemoveGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersAddorRemoveGrp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsersAddorRemoveGrp.Location = new System.Drawing.Point(24, 202);
            this.UsersAddorRemoveGrp.Margin = new System.Windows.Forms.Padding(4);
            this.UsersAddorRemoveGrp.Name = "UsersAddorRemoveGrp";
            this.UsersAddorRemoveGrp.Padding = new System.Windows.Forms.Padding(4);
            this.UsersAddorRemoveGrp.Size = new System.Drawing.Size(247, 219);
            this.UsersAddorRemoveGrp.TabIndex = 5;
            this.UsersAddorRemoveGrp.TabStop = false;
            this.UsersAddorRemoveGrp.Text = "Add or Remove Users";
            // 
            // Edit_btn
            // 
            this.Edit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Edit_btn.Highlight = true;
            this.Edit_btn.Location = new System.Drawing.Point(85, 166);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(75, 23);
            this.Edit_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Edit_btn.TabIndex = 11;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseSelectable = true;
            this.Edit_btn.UseStyleColors = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Delete_btn.Highlight = true;
            this.Delete_btn.Location = new System.Drawing.Point(164, 166);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Delete_btn.TabIndex = 6;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseSelectable = true;
            this.Delete_btn.UseStyleColors = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // User_Name_txt
            // 
            // 
            // 
            // 
            this.User_Name_txt.CustomButton.Image = null;
            this.User_Name_txt.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.User_Name_txt.CustomButton.Name = "";
            this.User_Name_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.User_Name_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.User_Name_txt.CustomButton.TabIndex = 1;
            this.User_Name_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.User_Name_txt.CustomButton.UseSelectable = true;
            this.User_Name_txt.CustomButton.Visible = false;
            this.User_Name_txt.Lines = new string[0];
            this.User_Name_txt.Location = new System.Drawing.Point(102, 25);
            this.User_Name_txt.MaxLength = 32767;
            this.User_Name_txt.Name = "User_Name_txt";
            this.User_Name_txt.PasswordChar = '\0';
            this.User_Name_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_Name_txt.SelectedText = "";
            this.User_Name_txt.SelectionLength = 0;
            this.User_Name_txt.SelectionStart = 0;
            this.User_Name_txt.ShortcutsEnabled = true;
            this.User_Name_txt.Size = new System.Drawing.Size(137, 29);
            this.User_Name_txt.TabIndex = 0;
            this.User_Name_txt.UseSelectable = true;
            this.User_Name_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.User_Name_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Type_cmb
            // 
            this.Type_cmb.BackColor = System.Drawing.Color.White;
            this.Type_cmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Type_cmb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Type_cmb.FormattingEnabled = true;
            this.Type_cmb.ItemHeight = 23;
            this.Type_cmb.Items.AddRange(new object[] {
            "Accountant",
            "User",
            "Admin",
            "[Selecet Type]"});
            this.Type_cmb.Location = new System.Drawing.Point(102, 130);
            this.Type_cmb.Name = "Type_cmb";
            this.Type_cmb.Size = new System.Drawing.Size(137, 29);
            this.Type_cmb.TabIndex = 3;
            this.Type_cmb.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(7, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Type :";
            // 
            // Re_Password_txt
            // 
            // 
            // 
            // 
            this.Re_Password_txt.CustomButton.Image = null;
            this.Re_Password_txt.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.Re_Password_txt.CustomButton.Name = "";
            this.Re_Password_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Re_Password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Re_Password_txt.CustomButton.TabIndex = 1;
            this.Re_Password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Re_Password_txt.CustomButton.UseSelectable = true;
            this.Re_Password_txt.CustomButton.Visible = false;
            this.Re_Password_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Re_Password_txt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Re_Password_txt.Lines = new string[0];
            this.Re_Password_txt.Location = new System.Drawing.Point(102, 95);
            this.Re_Password_txt.MaxLength = 32767;
            this.Re_Password_txt.Name = "Re_Password_txt";
            this.Re_Password_txt.PasswordChar = '#';
            this.Re_Password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Re_Password_txt.SelectedText = "";
            this.Re_Password_txt.SelectionLength = 0;
            this.Re_Password_txt.SelectionStart = 0;
            this.Re_Password_txt.ShortcutsEnabled = true;
            this.Re_Password_txt.Size = new System.Drawing.Size(138, 29);
            this.Re_Password_txt.TabIndex = 2;
            this.Re_Password_txt.UseCustomBackColor = true;
            this.Re_Password_txt.UseSelectable = true;
            this.Re_Password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Re_Password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Re_Password_txt.Leave += new System.EventHandler(this.Re_Password_txt_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Re: Password :";
            // 
            // Password_txt
            // 
            // 
            // 
            // 
            this.Password_txt.CustomButton.Image = null;
            this.Password_txt.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.Password_txt.CustomButton.Name = "";
            this.Password_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password_txt.CustomButton.TabIndex = 1;
            this.Password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_txt.CustomButton.UseSelectable = true;
            this.Password_txt.CustomButton.Visible = false;
            this.Password_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Password_txt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Password_txt.Lines = new string[0];
            this.Password_txt.Location = new System.Drawing.Point(102, 60);
            this.Password_txt.MaxLength = 32767;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '#';
            this.Password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password_txt.SelectedText = "";
            this.Password_txt.SelectionLength = 0;
            this.Password_txt.SelectionStart = 0;
            this.Password_txt.ShortcutsEnabled = true;
            this.Password_txt.Size = new System.Drawing.Size(137, 29);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.UseSelectable = true;
            this.Password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(7, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password :";
            // 
            // Save_btn
            // 
            this.Save_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_btn.Highlight = true;
            this.Save_btn.Location = new System.Drawing.Point(6, 166);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseSelectable = true;
            this.Save_btn.UseStyleColors = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "User Name :";
            // 
            // Clear_btn
            // 
            this.Clear_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear_btn.Highlight = true;
            this.Clear_btn.Location = new System.Drawing.Point(6, 192);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(233, 23);
            this.Clear_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseSelectable = true;
            this.Clear_btn.UseStyleColors = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // AdminLogGrp
            // 
            this.AdminLogGrp.Controls.Add(this.Login_btn);
            this.AdminLogGrp.Controls.Add(this.Admin_Password_txt);
            this.AdminLogGrp.Controls.Add(this.metroLabel5);
            this.AdminLogGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogGrp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminLogGrp.Location = new System.Drawing.Point(24, 64);
            this.AdminLogGrp.Margin = new System.Windows.Forms.Padding(4);
            this.AdminLogGrp.Name = "AdminLogGrp";
            this.AdminLogGrp.Padding = new System.Windows.Forms.Padding(4);
            this.AdminLogGrp.Size = new System.Drawing.Size(247, 119);
            this.AdminLogGrp.TabIndex = 4;
            this.AdminLogGrp.TabStop = false;
            this.AdminLogGrp.Text = "Admin Login";
            // 
            // Login_btn
            // 
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_btn.Highlight = true;
            this.Login_btn.Location = new System.Drawing.Point(85, 88);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseSelectable = true;
            this.Login_btn.UseStyleColors = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Admin_Password_txt
            // 
            // 
            // 
            // 
            this.Admin_Password_txt.CustomButton.Image = null;
            this.Admin_Password_txt.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.Admin_Password_txt.CustomButton.Name = "";
            this.Admin_Password_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Admin_Password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Admin_Password_txt.CustomButton.TabIndex = 1;
            this.Admin_Password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Admin_Password_txt.CustomButton.UseSelectable = true;
            this.Admin_Password_txt.CustomButton.Visible = false;
            this.Admin_Password_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Admin_Password_txt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Admin_Password_txt.Lines = new string[0];
            this.Admin_Password_txt.Location = new System.Drawing.Point(36, 53);
            this.Admin_Password_txt.MaxLength = 32767;
            this.Admin_Password_txt.Name = "Admin_Password_txt";
            this.Admin_Password_txt.PasswordChar = '#';
            this.Admin_Password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Admin_Password_txt.SelectedText = "";
            this.Admin_Password_txt.SelectionLength = 0;
            this.Admin_Password_txt.SelectionStart = 0;
            this.Admin_Password_txt.ShortcutsEnabled = true;
            this.Admin_Password_txt.Size = new System.Drawing.Size(204, 29);
            this.Admin_Password_txt.TabIndex = 0;
            this.Admin_Password_txt.UseCustomBackColor = true;
            this.Admin_Password_txt.UseSelectable = true;
            this.Admin_Password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Admin_Password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(7, 25);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Password :";
            // 
            // UsersDgv
            // 
            this.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDgv.Location = new System.Drawing.Point(278, 85);
            this.UsersDgv.Name = "UsersDgv";
            this.UsersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDgv.Size = new System.Drawing.Size(203, 306);
            this.UsersDgv.TabIndex = 6;
            this.UsersDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDgv_CellDoubleClick);
            // 
            // User_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 440);
            this.Controls.Add(this.UsersDgv);
            this.Controls.Add(this.UsersAddorRemoveGrp);
            this.Controls.Add(this.AdminLogGrp);
            this.Name = "User_Manage";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.User_Manage_Load);
            this.UsersAddorRemoveGrp.ResumeLayout(false);
            this.UsersAddorRemoveGrp.PerformLayout();
            this.AdminLogGrp.ResumeLayout(false);
            this.AdminLogGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UsersAddorRemoveGrp;
        private MetroFramework.Controls.MetroTextBox User_Name_txt;
        private MetroFramework.Controls.MetroComboBox Type_cmb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox Re_Password_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Password_txt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Save_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox AdminLogGrp;
        private MetroFramework.Controls.MetroButton Login_btn;
        private MetroFramework.Controls.MetroTextBox Admin_Password_txt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton Clear_btn;
        private MetroFramework.Controls.MetroButton Delete_btn;
        private System.Windows.Forms.DataGridView UsersDgv;
        private MetroFramework.Controls.MetroButton Edit_btn;
    }
}