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
    public partial class Yatir : Form
    {
        public Yatir()
        {
            InitializeComponent();
        }


        string Hesap = Giris.HesapNo;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void YatirimEkle()
        {

            string Tip = "Yatir";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" +Hesap+ "','" +Tip+ "'," + YatirAmtTb.Text + ",'" + DateTime.Today.Date.ToString() +"')";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (YatirAmtTb.Text ==  "" || Convert.ToInt32(YatirAmtTb.Text) <= 0)
            {
                MessageBox.Show("Miktar giriniz");
            }
            else
            {
             
                yenibakiye = eskibakiye + Convert.ToInt32(YatirAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye="+ yenibakiye+ " where HesapNo='"+Hesap+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle();
                    Anaekran anaekran = new Anaekran();
                    anaekran.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void YatirAmtTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Anaekran anaekran = new Anaekran();
            anaekran.Show();
            this.Hide();
        }

        int eskibakiye, yenibakiye;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Bakiye from HesapTbl where HesapNo='" + Hesap + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            eskibakiye = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }
        private void Yatir_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
