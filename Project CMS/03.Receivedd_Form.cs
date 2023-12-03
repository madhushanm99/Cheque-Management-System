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
    public partial class Received_Form : MetroForm
    {
        public Received_Form(string User)
        {
            InitializeComponent();
            Edit_btn.Enabled = false;
            Delete_btn.Enabled = false;
            if (User == "Admin")
            {
                Edit_btn.Enabled = true;
                Delete_btn.Enabled = true;
            }
        }

        //Connection To Database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4E95055;Initial Catalog=CMS;" +
            "Integrated Security=True");

        public string Cheque_No = "";

        private void Received_Form_Load(object sender, EventArgs e)
        {
            GetReceivedData();
            TexClear();
            
        }

        //Display Current Records in Data Grid Viwe
        private void GetReceivedData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Received", con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                Received_Cheques_Viwer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

            
            

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Received VALUES(@ChequeNumber, @Date, @Amount, " +
                        "@ShopName, @Bank, @CityofBank )", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@ChequeNumber", Cheque_No_Rec.Text);
                    cmd.Parameters.AddWithValue("@Date", Date_Rec.Text);
                    cmd.Parameters.AddWithValue("@Amount", Amount_Rec.Text);
                    cmd.Parameters.AddWithValue("@ShopName", Shop_Name_Rec.Text);
                    cmd.Parameters.AddWithValue("@Bank", Bank_Rec.Text);
                    cmd.Parameters.AddWithValue("@CityofBank", COB_Rec.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Recevied Cheque is Successfuly saved in the database", "Saved",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetReceivedData();
                    TexClear();
                    Save_btn.Enabled = false;
                    Panel1.Enabled = false;
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Entered Cheque Number is Already in the System", "Re-Checke?", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void TexClear()
        {
            
            Cheque_No_Rec.Clear();
            Amount_Rec.Clear();
            Shop_Name_Rec.Clear();
            Bank_Rec.Clear();
            COB_Rec.Clear();
            Date_Rec.Value = DateTime.Now;

            Date_Rec.Focus();
            Edit_btn.Enabled = false;
            Delete_btn.Enabled = false;
            Panel1.Enabled = false;
        }

        private bool IsValid()
        {

            if (Date_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Select the Date", "Date?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Date_Rec.Focus();
                return false;
            }
            else if (Cheque_No_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Cheque Number", "Cheque Number?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Cheque_No_Rec.Focus();
                return false;
            }
            else if (Amount_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Cheque Amount", "Cheque Amount?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Amount_Rec.Focus();
                return false;
            }
            else if (Shop_Name_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Shop Name", " Shop Name?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Shop_Name_Rec.Focus();
                return false;
            }
            else if (Bank_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Bank", "Bank?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Bank_Rec.Focus();
                return false;
            }
            else if (COB_Rec.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Ciy of Bank", "City of Bank?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                COB_Rec.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Received_Cheques_Viwer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cheque_No = Received_Cheques_Viwer.SelectedRows[0].Cells[0].Value.ToString();

                Cheque_No_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[0].Value.ToString();
                Date_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[1].Value.ToString();
                Amount_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[2].Value.ToString();
                Shop_Name_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[3].Value.ToString();
                Bank_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[4].Value.ToString();
                COB_Rec.Text = Received_Cheques_Viwer.SelectedRows[0].Cells[5].Value.ToString();

                Panel1.Enabled = true;
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

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cheque_No != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Received SET ChequeNumber = @ChequeNumber, " +
                        "Date = @Date, Amount = @Amount, ShopName = @ShopName, Bank = @Bank, " +
                        "CityofBank = @CityofBank WHERE ChequeNumber='" + Cheque_No + "'", con)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@ChequeNumber", Cheque_No_Rec.Text);
                    cmd.Parameters.AddWithValue("@Date", Date_Rec.Text);
                    cmd.Parameters.AddWithValue("@Amount", Amount_Rec.Text);
                    cmd.Parameters.AddWithValue("@ShopName", Shop_Name_Rec.Text);
                    cmd.Parameters.AddWithValue("@Bank", Bank_Rec.Text);
                    cmd.Parameters.AddWithValue("@CityofBank", COB_Rec.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Cheque Details Updated Successfuly", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetReceivedData();
                    TexClear();
                    Cheque_No = "";
                    Panel1.Enabled = false;

                }
                else
                {
                    MetroMessageBox.Show(this, "Select Cheque for  Update", "Select?", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cheque_No != "")
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Received WHERE ChequeNumber = @ChequeNumber ", con)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@ChequeNumber", this.Cheque_No);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Cheque Information is Delete Successfuly", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetReceivedData();
                    TexClear();
                    Panel1.Enabled = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Cheque for Delete", "Select?", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TexClear();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            TexClear();
            Panel1.Enabled = true;
            Save_btn.Enabled = true;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
