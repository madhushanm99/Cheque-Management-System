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
    public partial class Issued_Report : MetroForm
    {
        public Issued_Report()
        {
            InitializeComponent();
        }

        //Connection To Database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4E95055;Initial Catalog=CMS;" +
            "Integrated Security=True");

        public string Cheque_No = "";

        private void Clear04_Click(object sender, EventArgs e)
        {
            TxtClear();
            Report_Viwe.DataSource = null;
        }

        private void Chq_Iss_Rp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cheque_No = Chq_Iss_Rp.Text;

                SqlCommand cmd = new SqlCommand("SELECT * FROM Issued WHERE ChequeNumber Like '%" + Cheque_No + "%'", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                Report_Viwe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }
                        
        private void TxtClear()
        {
            Chq_Iss_Rp.Clear();
        }

        private void Rp_Iss_01_Click(object sender, EventArgs e)
        {
            try
            {
                string StartDate = Date_From_Iss.Text.ToString();
                string EndDate = Date_To_Iss.Text.ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Issued WHERE Date BETWEEN'" + StartDate + "'AND'" + EndDate + "'", con);
                DataTable dt = new DataTable();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                Report_Viwe.DataSource = dt;

                DateClear();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                con.Close();
            }
        }

        private void DateClear()
        {
            Date_From_Iss.Value = DateTime.Now;
            Date_To_Iss.Value = DateTime.Now;
        }

        private void Clear03_Click(object sender, EventArgs e)
        {
            DateClear();
            Report_Viwe.DataSource = null;
        }

        private void Issued_Report_Load(object sender, EventArgs e)
        {
            DateClear();
            TxtClear();
        }
    }
}
