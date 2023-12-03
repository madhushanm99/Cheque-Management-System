namespace Project_CMS
{
    partial class Issued_Report
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Date_To_Iss = new MetroFramework.Controls.MetroDateTime();
            this.Date_From_Iss = new MetroFramework.Controls.MetroDateTime();
            this.Clear04 = new System.Windows.Forms.Button();
            this.Clear03 = new System.Windows.Forms.Button();
            this.Chq_Iss_Rp = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Rp_Iss_01 = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Report_Viwe = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Viwe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Date_To_Iss);
            this.groupBox2.Controls.Add(this.Date_From_Iss);
            this.groupBox2.Controls.Add(this.Clear04);
            this.groupBox2.Controls.Add(this.Clear03);
            this.groupBox2.Controls.Add(this.Chq_Iss_Rp);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.Rp_Iss_01);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(24, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(608, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issued Cheques";
            // 
            // Date_To_Iss
            // 
            this.Date_To_Iss.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_To_Iss.CustomFormat = "yyyy-MM-dd";
            this.Date_To_Iss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_To_Iss.Location = new System.Drawing.Point(65, 60);
            this.Date_To_Iss.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date_To_Iss.Name = "Date_To_Iss";
            this.Date_To_Iss.Size = new System.Drawing.Size(152, 29);
            this.Date_To_Iss.TabIndex = 1;
            this.Date_To_Iss.Value = new System.DateTime(2021, 1, 5, 0, 0, 0, 0);
            // 
            // Date_From_Iss
            // 
            this.Date_From_Iss.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_From_Iss.CustomFormat = "yyyy-MM-dd";
            this.Date_From_Iss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_From_Iss.Location = new System.Drawing.Point(65, 17);
            this.Date_From_Iss.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date_From_Iss.Name = "Date_From_Iss";
            this.Date_From_Iss.Size = new System.Drawing.Size(152, 29);
            this.Date_From_Iss.TabIndex = 0;
            this.Date_From_Iss.Value = new System.DateTime(2021, 1, 5, 0, 0, 0, 0);
            // 
            // Clear04
            // 
            this.Clear04.Location = new System.Drawing.Point(471, 50);
            this.Clear04.Name = "Clear04";
            this.Clear04.Size = new System.Drawing.Size(75, 23);
            this.Clear04.TabIndex = 6;
            this.Clear04.Text = "Clear";
            this.Clear04.UseVisualStyleBackColor = true;
            this.Clear04.Click += new System.EventHandler(this.Clear04_Click);
            // 
            // Clear03
            // 
            this.Clear03.Location = new System.Drawing.Point(142, 95);
            this.Clear03.Name = "Clear03";
            this.Clear03.Size = new System.Drawing.Size(75, 23);
            this.Clear03.TabIndex = 3;
            this.Clear03.Text = "Clear";
            this.Clear03.UseVisualStyleBackColor = true;
            this.Clear03.Click += new System.EventHandler(this.Clear03_Click);
            // 
            // Chq_Iss_Rp
            // 
            this.Chq_Iss_Rp.Location = new System.Drawing.Point(417, 22);
            this.Chq_Iss_Rp.Name = "Chq_Iss_Rp";
            this.Chq_Iss_Rp.Size = new System.Drawing.Size(129, 22);
            this.Chq_Iss_Rp.TabIndex = 4;
            this.Chq_Iss_Rp.TextChanged += new System.EventHandler(this.Chq_Iss_Rp_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(322, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Cheque No : ";
            // 
            // Rp_Iss_01
            // 
            this.Rp_Iss_01.Location = new System.Drawing.Point(25, 95);
            this.Rp_Iss_01.Name = "Rp_Iss_01";
            this.Rp_Iss_01.Size = new System.Drawing.Size(75, 23);
            this.Rp_Iss_01.TabIndex = 2;
            this.Rp_Iss_01.Text = "Show";
            this.Rp_Iss_01.UseVisualStyleBackColor = true;
            this.Rp_Iss_01.Click += new System.EventHandler(this.Rp_Iss_01_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(7, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "To :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(7, 22);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "From :";
            // 
            // Report_Viwe
            // 
            this.Report_Viwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_Viwe.Location = new System.Drawing.Point(24, 201);
            this.Report_Viwe.Name = "Report_Viwe";
            this.Report_Viwe.Size = new System.Drawing.Size(608, 203);
            this.Report_Viwe.TabIndex = 5;
            // 
            // Issued_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 427);
            this.Controls.Add(this.Report_Viwe);
            this.Controls.Add(this.groupBox2);
            this.Name = "Issued_Report";
            this.Text = "Issued Report";
            this.Load += new System.EventHandler(this.Issued_Report_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Viwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroDateTime Date_To_Iss;
        private MetroFramework.Controls.MetroDateTime Date_From_Iss;
        private System.Windows.Forms.Button Clear04;
        private System.Windows.Forms.Button Clear03;
        private System.Windows.Forms.TextBox Chq_Iss_Rp;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button Rp_Iss_01;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView Report_Viwe;
    }
}