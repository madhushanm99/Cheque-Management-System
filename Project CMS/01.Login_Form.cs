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
using System.Data.SqlClient;

namespace Project_CMS
{
    public partial class Login_Form : MetroForm
    {
        public Login_Form()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public string UserTyp = "";

        //Connection To Database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4E95055;Initial Catalog=CMS;" +
            "Integrated Security=True");

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName_txt.Text != String.Empty && Password_txt.Text != String.Empty)
                {

                    SqlCommand cmd = new SqlCommand("SELECT Type FROM Users WHERE UserName='" + UserName_txt.Text + "' AND Password='" + Password_txt.Text + "'", con);
                    DataTable dt = new DataTable();
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();

                    if (dt.Rows.Count == 1)
                    {
                        UserTyp = dt.Rows[0]["Type"].ToString(); ;

                        Menu_Form Menu = new Menu_Form(UserTyp);
                        Menu.Show();
                        this.Hide();

                    }

                    else
                    {
                        MetroMessageBox.Show(this, "User Name or Password is Incorrect", "Incorrect?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserName_txt.Focus();
                    }

                }
                else if (UserName_txt.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Please Enter User Name to Login", "User Name?", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    UserName_txt.Focus();
                }
                else if (Password_txt.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Please Enter Password to Login", "Password?", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    Password_txt.Focus();
                }
                else
                {
                    MetroMessageBox.Show(this, "Please Enter User Name to Login", "User Name?", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    UserName_txt.Focus();
                }
                

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
