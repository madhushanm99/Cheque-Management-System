namespace Project_CMS
{
    partial class Received_Report
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear02 = new System.Windows.Forms.Button();
            this.Clear01 = new System.Windows.Forms.Button();
            this.Date_To_Rec = new MetroFramework.Controls.MetroDateTime();
            this.Date_From_Rec = new MetroFramework.Controls.MetroDateTime();
            this.Chq_Rec_Rp = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Rp_Rec_01 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Report_Viwe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Viwe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear02);
            this.groupBox1.Controls.Add(this.Clear01);
            this.groupBox1.Controls.Add(this.Date_To_Rec);
            this.groupBox1.Controls.Add(this.Date_From_Rec);
            this.groupBox1.Controls.Add(this.Chq_Rec_Rp);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.Rp_Rec_01);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(608, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Cheques";
            // 
            // Clear02
            // 
            this.Clear02.Location = new System.Drawing.Point(471, 50);
            this.Clear02.Name = "Clear02";
            this.Clear02.Size = new System.Drawing.Size(75, 23);
            this.Clear02.TabIndex = 6;
            this.Clear02.Text = "Clear";
            this.Clear02.UseVisualStyleBackColor = true;
            this.Clear02.Click += new System.EventHandler(this.Clear02_Click);
            // 
            // Clear01
            // 
            this.Clear01.Location = new System.Drawing.Point(142, 95);
            this.Clear01.Name = "Clear01";
            this.Clear01.Size = new System.Drawing.Size(75, 23);
            this.Clear01.TabIndex = 3;
            this.Clear01.Text = "Clear";
            this.Clear01.UseVisualStyleBackColor = true;
            this.Clear01.Click += new System.EventHandler(this.Clear01_Click);
            // 
            // Date_To_Rec
            // 
            this.Date_To_Rec.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_To_Rec.CustomFormat = "yyyy-MM-dd";
            this.Date_To_Rec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_To_Rec.Location = new System.Drawing.Point(65, 60);
            this.Date_To_Rec.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date_To_Rec.Name = "Date_To_Rec";
            this.Date_To_Rec.Size = new System.Drawing.Size(152, 29);
            this.Date_To_Rec.TabIndex = 1;
            this.Date_To_Rec.Value = new System.DateTime(2021, 1, 5, 0, 0, 0, 0);
            // 
            // Date_From_Rec
            // 
            this.Date_From_Rec.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_From_Rec.CustomFormat = "yyyy-MM-dd";
            this.Date_From_Rec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_From_Rec.Location = new System.Drawing.Point(65, 17);
            this.Date_From_Rec.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date_From_Rec.Name = "Date_From_Rec";
            this.Date_From_Rec.Size = new System.Drawing.Size(152, 29);
            this.Date_From_Rec.TabIndex = 0;
            this.Date_From_Rec.Value = new System.DateTime(2021, 1, 5, 0, 0, 0, 0);
            // 
            // Chq_Rec_Rp
            // 
            this.Chq_Rec_Rp.Location = new System.Drawing.Point(417, 22);
            this.Chq_Rec_Rp.Name = "Chq_Rec_Rp";
            this.Chq_Rec_Rp.Size = new System.Drawing.Size(129, 22);
            this.Chq_Rec_Rp.TabIndex = 4;
            this.Chq_Rec_Rp.TextChanged += new System.EventHandler(this.Chq_Rec_Rp_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(322, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Cheque No : ";
            // 
            // Rp_Rec_01
            // 
            this.Rp_Rec_01.Location = new System.Drawing.Point(23, 95);
            this.Rp_Rec_01.Name = "Rp_Rec_01";
            this.Rp_Rec_01.Size = new System.Drawing.Size(75, 23);
            this.Rp_Rec_01.TabIndex = 2;
            this.Rp_Rec_01.Text = "Show";
            this.Rp_Rec_01.UseVisualStyleBackColor = true;
            this.Rp_Rec_01.Click += new System.EventHandler(this.Rp_Rec_01_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(7, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "To :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(7, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From :";
            // 
            // Report_Viwe
            // 
            this.Report_Viwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_Viwe.Location = new System.Drawing.Point(24, 202);
            this.Report_Viwe.Name = "Report_Viwe";
            this.Report_Viwe.Size = new System.Drawing.Size(608, 203);
            this.Report_Viwe.TabIndex = 3;
            // 
            // Received_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 427);
            this.Controls.Add(this.Report_Viwe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Received_Report";
            this.Padding = new System.Windows.Forms.Padding(30, 60, 20, 20);
            this.Text = "Received Reports";
            this.Load += new System.EventHandler(this.Received_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Viwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear02;
        private System.Windows.Forms.Button Clear01;
        private MetroFramework.Controls.MetroDateTime Date_To_Rec;
        private MetroFramework.Controls.MetroDateTime Date_From_Rec;
        private System.Windows.Forms.TextBox Chq_Rec_Rp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button Rp_Rec_01;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView Report_Viwe;
    }
}