using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMYONETIM
{
    public partial class Aciklama : Form
    {
        public Aciklama()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        String Hesap = Giris.HesapNo;
        private void populasyon()
        {
            Con.Open();
            string query = "select * from YatirTbl where HesapNo = '" + Hesap + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AciklamaDS.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Aciklama_Load(object sender, EventArgs e)
        {
            populasyon();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Anaekran anaekran = new Anaekran();
            anaekran.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
