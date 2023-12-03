using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Project_CMS
{
    public partial class Menu_Form : MetroForm
    {
        public Menu_Form(string UserType)
        {
            InitializeComponent();
            label1.Text = UserType;

        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            Received.Enabled = false;
            Issued.Enabled = false;
            Report.Enabled = false;
            UserManage.Enabled = false;

            if (label1.Text == "Admin")
            {
                Received.Enabled = true;
                Issued.Enabled = true;
                Report.Enabled = true;
                UserManage.Enabled = true;
            }
            else if (label1.Text == "User")
            {
                Received.Enabled = true;
            }
            else if (label1.Text == "Accountant")
            {
                Report.Enabled = true;
            }

        }

        private void Closefrm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close(); 
            }
        }

        private void Showfrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void Received_Click(object sender, EventArgs e)
        {
            string UserT = label1.Text;
            Closefrm();
            Showfrm(new Received_Form(UserT));
        }

        private void Issued_Click(object sender, EventArgs e)
        {
            string UserT = label1.Text;
            Closefrm();
            Showfrm(new Issued_Form(UserT));
        }

        private void Rec_Report_Click(object sender, EventArgs e)
        {
            Closefrm();
            Showfrm(new Received_Report());
        }

        private void Iss_Report_Click(object sender, EventArgs e)
        {
            
            Closefrm();
            Showfrm(new Issued_Report());
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            Closefrm();
            Showfrm(new User_Manage());
        }

        private void Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Closefrm();
            Login_Form Login = new Login_Form();
            Login.Show();
            
        }

    }
}
