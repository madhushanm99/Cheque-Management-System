namespace Project_CMS
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Received = new System.Windows.Forms.ToolStripButton();
            this.Issued = new System.Windows.Forms.ToolStripButton();
            this.Report = new System.Windows.Forms.ToolStripDropDownButton();
            this.Rec_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.Iss_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.Button4 = new System.Windows.Forms.ToolStripButton();
            this.UserManage = new System.Windows.Forms.ToolStripButton();
            this.About = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Received,
            this.Issued,
            this.Report,
            this.Button4,
            this.UserManage,
            this.About,
            this.LogOut});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Received
            // 
            this.Received.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Received.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Received.Image = ((System.Drawing.Image)(resources.GetObject("Received.Image")));
            this.Received.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Received.Name = "Received";
            this.Received.Size = new System.Drawing.Size(83, 25);
            this.Received.Text = "Received";
            this.Received.Click += new System.EventHandler(this.Received_Click);
            // 
            // Issued
            // 
            this.Issued.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Issued.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Issued.Image = ((System.Drawing.Image)(resources.GetObject("Issued.Image")));
            this.Issued.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Issued.Name = "Issued";
            this.Issued.Size = new System.Drawing.Size(62, 25);
            this.Issued.Text = "Issued";
            this.Issued.Click += new System.EventHandler(this.Issued_Click);
            // 
            // Report
            // 
            this.Report.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rec_Report,
            this.Iss_Report});
            this.Report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(74, 25);
            this.Report.Text = "Report";
            // 
            // Rec_Report
            // 
            this.Rec_Report.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rec_Report.Name = "Rec_Report";
            this.Rec_Report.Size = new System.Drawing.Size(192, 24);
            this.Rec_Report.Text = "Received-Report";
            this.Rec_Report.Click += new System.EventHandler(this.Rec_Report_Click);
            // 
            // Iss_Report
            // 
            this.Iss_Report.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iss_Report.Name = "Iss_Report";
            this.Iss_Report.Size = new System.Drawing.Size(192, 24);
            this.Iss_Report.Text = "Issued-Report";
            this.Iss_Report.Click += new System.EventHandler(this.Iss_Report_Click);
            // 
            // Button4
            // 
            this.Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
            this.Button4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 25);
            this.Button4.Text = "Button4";
            // 
            // UserManage
            // 
            this.UserManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UserManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UserManage.Image = ((System.Drawing.Image)(resources.GetObject("UserManage.Image")));
            this.UserManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(154, 25);
            this.UserManage.Text = "User Management";
            this.UserManage.Click += new System.EventHandler(this.UserManage_Click);
            // 
            // About
            // 
            this.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(61, 25);
            this.About.Text = "About";
            // 
            // LogOut
            // 
            this.LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(74, 25);
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(204, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wellcome";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Menu_Form";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Form_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Received;
        private System.Windows.Forms.ToolStripButton Issued;
        private System.Windows.Forms.ToolStripButton Button4;
        private System.Windows.Forms.ToolStripButton UserManage;
        private System.Windows.Forms.ToolStripButton About;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.ToolStripDropDownButton Report;
        private System.Windows.Forms.ToolStripMenuItem Rec_Report;
        private System.Windows.Forms.ToolStripMenuItem Iss_Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}