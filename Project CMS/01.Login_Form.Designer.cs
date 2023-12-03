namespace Project_CMS
{
    partial class Login_Form
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Close_btn = new MetroFramework.Controls.MetroButton();
            this.Login_btn = new MetroFramework.Controls.MetroButton();
            this.Password_txt = new MetroFramework.Controls.MetroTextBox();
            this.UserName_txt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(21, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "User Name";
            // 
            // Close_btn
            // 
            this.Close_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close_btn.Highlight = true;
            this.Close_btn.Location = new System.Drawing.Point(125, 161);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(66, 23);
            this.Close_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Close_btn.TabIndex = 10;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseSelectable = true;
            this.Close_btn.UseStyleColors = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_btn.Highlight = true;
            this.Login_btn.Location = new System.Drawing.Point(23, 161);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(66, 23);
            this.Login_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Login_btn.TabIndex = 9;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseSelectable = true;
            this.Login_btn.UseStyleColors = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Password_txt
            // 
            // 
            // 
            // 
            this.Password_txt.CustomButton.Image = null;
            this.Password_txt.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.Password_txt.CustomButton.Name = "";
            this.Password_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password_txt.CustomButton.TabIndex = 1;
            this.Password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_txt.CustomButton.UseSelectable = true;
            this.Password_txt.CustomButton.Visible = false;
            this.Password_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Password_txt.Lines = new string[0];
            this.Password_txt.Location = new System.Drawing.Point(21, 126);
            this.Password_txt.MaxLength = 32767;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '#';
            this.Password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password_txt.SelectedText = "";
            this.Password_txt.SelectionLength = 0;
            this.Password_txt.SelectionStart = 0;
            this.Password_txt.ShortcutsEnabled = true;
            this.Password_txt.Size = new System.Drawing.Size(170, 29);
            this.Password_txt.TabIndex = 8;
            this.Password_txt.UseSelectable = true;
            this.Password_txt.UseStyleColors = true;
            this.Password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserName_txt
            // 
            this.UserName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            // 
            // 
            // 
            this.UserName_txt.CustomButton.Image = null;
            this.UserName_txt.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.UserName_txt.CustomButton.Name = "";
            this.UserName_txt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.UserName_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName_txt.CustomButton.TabIndex = 1;
            this.UserName_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName_txt.CustomButton.UseSelectable = true;
            this.UserName_txt.CustomButton.Visible = false;
            this.UserName_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UserName_txt.Lines = new string[0];
            this.UserName_txt.Location = new System.Drawing.Point(21, 72);
            this.UserName_txt.MaxLength = 32767;
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.PasswordChar = '\0';
            this.UserName_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName_txt.SelectedText = "";
            this.UserName_txt.SelectionLength = 0;
            this.UserName_txt.SelectionStart = 0;
            this.UserName_txt.ShortcutsEnabled = true;
            this.UserName_txt.Size = new System.Drawing.Size(170, 29);
            this.UserName_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName_txt.TabIndex = 7;
            this.UserName_txt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName_txt.UseSelectable = true;
            this.UserName_txt.UseStyleColors = true;
            this.UserName_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserName_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 224);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Name = "Login_Form";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton Close_btn;
        private MetroFramework.Controls.MetroButton Login_btn;
        private MetroFramework.Controls.MetroTextBox Password_txt;
        private MetroFramework.Controls.MetroTextBox UserName_txt;
    }
}