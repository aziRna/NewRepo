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
    public partial class Paracek : Form
    {
        public Paracek()
        {
            InitializeComponent();
        }

        string Hesap = Giris.HesapNo;
        int bakiye;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Bakiye from HesapTbl where HesapNo='" +Hesap+ "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BakiyeTbl.Text = "Guncel Bakiyen: ₺" + dt.Rows[0][0].ToString();
            bakiye = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }

        private void YatirimEkle()
        {

            string Tip = "Paracek";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + paracekTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Hesap Olusturuldu");
                Con.Close();
                Giris log = new Giris();
                log.Show();
                this.Hide();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void Paracek_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Anaekran anaekran = new Anaekran();
            anaekran.Show();
            this.Hide();

        }

        private void BakiyeTbl_Click(object sender, EventArgs e)
        {

        }
        int yenibakiye;
        private void button1_Click(object sender, EventArgs e)
        {
            if (paracekTb.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else if (Convert.ToInt32(paracekTb.Text) <= 0)
            {
                MessageBox.Show("Dogru bir deger giriniz");
            }
            else if (Convert.ToInt32(paracekTb.Text) > bakiye)
            {
                MessageBox.Show("Bakiye Negatif olamaz");
            }
            else
            {


                yenibakiye = bakiye - Convert.ToInt32(paracekTb.Text);
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Para Çekme işlemi");
                    Con.Close();
                    YatirimEkle();
                    Paracek paracek = new Paracek();
                    paracek.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void paracekTb_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
