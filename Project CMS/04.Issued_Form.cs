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
    public partial class Issued_Form : MetroForm
    {
        public Issued_Form(string User)
        {
            InitializeComponent();  
        }

        //Connection To Database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4E95055;Initial Catalog=CMS;" +
            "Integrated Security=True");

        public string Cheque_No = "";

        private void Issued_Form_Load(object sender, EventArgs e)
        {
            
            GetIssuedData();
            TexClear();
            
        }

        private void TexClear()
        {
            Cheque_No_Iss.Clear();
            Amount_Iss.Clear();
            Payeer_Iss.Clear();
            Bank_Iss.Clear();
            Date_Iss.Value = DateTime.Now;

            Date_Iss.Focus();
            Edit_btn.Enabled = false;
            Delete_btn.Enabled = false;
            Panel1.Enabled = false;
        }

        private void GetIssuedData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Issued", con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                Issued_Cheques_Viwer.DataSource = dt;

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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Issued VALUES(@ChequeNumber, @Date, @Amount, " +
                        "@Payeer, @Bank )", con)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@ChequeNumber", Cheque_No_Iss.Text);
                    cmd.Parameters.AddWithValue("@Date", Date_Iss.Text);
                    cmd.Parameters.AddWithValue("@Amount", Amount_Iss.Text);
                    cmd.Parameters.AddWithValue("@Payeer", Payeer_Iss.Text);
                    cmd.Parameters.AddWithValue("@Bank", Bank_Iss.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Issued Cheque is Successfuly saved in the database", "Saved",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetIssuedData();
                    TexClear();
                    Panel1.Enabled = false;
                }
            }
            catch (Exception )
            {
                MetroMessageBox.Show(this, "Entered Cheque Number is Already in the System", "Re-Checke?", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                con.Close();
            }
        }

        private bool IsValid()
        {
            if (Date_Iss.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Select the Date", "Date?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Date_Iss.Focus();
                return false;
            }
            else if (Cheque_No_Iss.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Cheque Number", "Cheque Number?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Cheque_No_Iss.Focus();
                return false;
            }
            else if (Amount_Iss.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Cheque Amount", "Cheque Amount?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Amount_Iss.Focus();
                return false;
            }
            else if (Payeer_Iss.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Shop Name", " Shop Name?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Payeer_Iss.Focus();
                return false;
            }
            else if (Bank_Iss.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Enter Bank", "Bank?", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Bank_Iss.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            TexClear();
            Panel1.Enabled = true;
            Save_btn.Enabled = true;
        }
        
        private void Issued_Cheques_Viwer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cheque_No = Issued_Cheques_Viwer.SelectedRows[0].Cells[0].Value.ToString();

                Cheque_No_Iss.Text = Issued_Cheques_Viwer.SelectedRows[0].Cells[0].Value.ToString();
                Date_Iss.Text = Issued_Cheques_Viwer.SelectedRows[0].Cells[1].Value.ToString();
                Amount_Iss.Text = Issued_Cheques_Viwer.SelectedRows[0].Cells[2].Value.ToString();
                Payeer_Iss.Text = Issued_Cheques_Viwer.SelectedRows[0].Cells[3].Value.ToString();
                Bank_Iss.Text = Issued_Cheques_Viwer.SelectedRows[0].Cells[4].Value.ToString();


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
                    SqlCommand cmd = new SqlCommand("UPDATE Issued SET ChequeNumber = @ChequeNumber, " +
                        "Date = @Date, Amount = @Amount, Payeer = @Payeer, Bank = @Bank " +
                         "WHERE ChequeNumber='" + Cheque_No + "'", con)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@ChequeNumber", Cheque_No_Iss.Text);
                    cmd.Parameters.AddWithValue("@Date", Date_Iss.Text);
                    cmd.Parameters.AddWithValue("@Amount", Amount_Iss.Text);
                    cmd.Parameters.AddWithValue("@Payeer", Payeer_Iss.Text);
                    cmd.Parameters.AddWithValue("@Bank", Bank_Iss.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Cheque Details Updated Successfuly", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetIssuedData();
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Issued WHERE ChequeNumber = @ChequeNumber ", con)
                    {
                        CommandType = CommandType.Text
                    };

                    cmd.Parameters.AddWithValue("@ChequeNumber", this.Cheque_No);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Cheque Information is Delete Successfuly", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetIssuedData();
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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
