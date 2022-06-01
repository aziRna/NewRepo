using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ATMYONETIM
{
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Bakiye from HesapTbl where HesapNo='"+HesapNoTbl.Text+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BakiyeTbl.Text = "₺"+dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void Bakiye_Load(object sender, EventArgs e)
        {
            HesapNoTbl.Text = Giris.HesapNo;
            getbalance();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Anaekran anaekran = new Anaekran();
            this.Hide();
            anaekran.Show();
        }
    }
}
