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
    public partial class PinDegistir : Form
    {
        

        public PinDegistir()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Hesap = Giris.HesapNo;
        private void label13_Click(object sender, EventArgs e)
        {
            Anaekran anaekran = new Anaekran();
            anaekran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Giriniz ve Onaylanıyız");
            }
            else if (Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("Birinci sifre ve ikinci sifre birbirinden farklı");
            }
            else
            {
     
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Pin=" + Pin1Tb.Text + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin değiştirme işlemi işlemi");
                    Con.Close();
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PinDegistir_Load(object sender, EventArgs e)
        {

        }
    }
    
}
