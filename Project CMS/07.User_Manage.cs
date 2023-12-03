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
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Project_CMS
{
    public partial class User_Manage : MetroForm
    {
        public User_Manage()
        {
            InitializeComponent();
        }

        public string UserName="";
        public string Pswd="";

        //Connection To Database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4E95055;Initial Catalog=CMS;" +
            "Integrated Security=True");

        private void User_Manage_Load(object sender, EventArgs e)
        {
            
            TxtClear();
            UserAddorRemoveDisble();
        }

        //Login to the User Management        
        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (Admin_Password_txt.Text != String.Empty)
                {
                    string UserType = "Admin";
                    SqlCommand cmd = new SqlCommand("SELECT Password FROM Users WHERE Type='" + UserType + "'", con)
                    {
                        CommandType = CommandType.Text
                    };
                    SqlDataReader sdr = null;

                    con.Open();
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Pswd = sdr["Password"].ToString();
                    }

                    con.Close();

                    if (Pswd == Admin_Password_txt.Text)
                    {
                        AdminLogDisble();
                        UserAddorRemoveEnble();
                        GetUsersData();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Your Password is Incorrect", "Incorrect?", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                        Admin_Password_txt.Clear();
                        Admin_Password_txt.Focus();
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "Please Enter Password to Login", "Password?", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    Admin_Password_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        //Add New User for the Database
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@UserName, @Password, @Type)", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@UserName", User_Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Password", Re_Password_txt.Text);
                    cmd.Parameters.AddWithValue("@Type", Type_cmb.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "New User is Added Successfuly", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUsersData();
                    TxtClear();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        //Edit User Password
        private void Edit_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (UserName != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Password=@Password WHERE UserName='" + UserName + "'", con)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@Password", Re_Password_txt.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "User Password is Updated Successfuly", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUsersData();
                    TxtClear();
                    UserName = "";

                }
                else
                {
                    MetroMessageBox.Show(this, "Select User for  Update", "Select?", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        //Delete User Information
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName != "")
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserName='" + UserName + "'", con)
                    {
                        CommandType = CommandType.Text
                    };

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "User Information is Delete Successfuly", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUsersData();
                    TxtClear();
                    UserName = "";

                }
                else
                {
                    MetroMessageBox.Show(this, "Select User for Delete", "Select?", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        //Display Current Records in Data Grid Viwe
        private void GetUsersData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT UserName, Type FROM Users", con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                UsersDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        //Check Validity of the Input Data 
        private bool IsValid()
        {
            if (User_Name_txt.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please Enter User Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                User_Name_txt.Focus();
                return false;
            }

            else if (Password_txt.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please Enter Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_txt.Focus();
                return false;
            }

            else if (Re_Password_txt.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Please Enter Re Enter Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Re_Password_txt.Focus();
                return false;
            }

            else if (Type_cmb.Text == string.Empty || Type_cmb.Text == "[Selecet Type]")
            {
                MetroMessageBox.Show(this, "Please Select User Type", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Type_cmb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        
        //Check Password and Re_Password are same before Insert to Database
        private void Re_Password_txt_Leave(object sender, EventArgs e)
        {
            if (Password_txt.Text != Re_Password_txt.Text)
            {
                MetroMessageBox.Show(this, "Password is not Match. Re-Enter", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_txt.Clear();
                Re_Password_txt.Clear();
                Password_txt.Focus();
            }
            return;
        }
        
        //Select Record From Data Grid Viwe
        private void UsersDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserName = UsersDgv.SelectedRows[0].Cells[0].Value.ToString();

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserName, Password, Type FROM Users WHERE UserName='" + UserName + "'", con);

                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    User_Name_txt.Text = read["UserName"].ToString();
                    Password_txt.Text = read["Password"].ToString();
                    Re_Password_txt.Text = read["Password"].ToString();
                    Type_cmb.Text = read["Type"].ToString();
                }

                read.Close();
                con.Close();
                Edit_btn.Enabled = true;
                Delete_btn.Enabled = true;
                Save_btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }
        private void AdminLogDisble()
        {
            //AdminLogin Group Box Disabe
            AdminLogGrp.Enabled = false;
        }

        private void AdminLogEnble()
        {
            //AdminLogin Group Box Enable
            AdminLogGrp.Enabled = true;
        }

        private void TxtClear()
        {
            //TextBox Clearing
            User_Name_txt.Clear();
            Password_txt.Clear();
            Re_Password_txt.Clear();
            Type_cmb.Text = "[Selecet Type]";
            User_Name_txt.Focus();
            Save_btn.Enabled = true;
            Edit_btn.Enabled = false;
            Delete_btn.Enabled = false;
        }

        private void UserAddorRemoveDisble()
        {
            //Add or Remove User Group Box Disabe
            UsersAddorRemoveGrp.Enabled = false;
        }

        private void UserAddorRemoveEnble()
        {
            //Add or Remove User Group Box Enable
            UsersAddorRemoveGrp.Enabled = true;
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            // All TextBox Clearing
            TxtClear();
        }


    }
}
