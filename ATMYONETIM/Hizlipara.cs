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
    public partial class Hizlipara : Form
    {
        public Hizlipara()
        {
            InitializeComponent();
        }


        int bakiye;
        string Hesap = Giris.HesapNo;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Bakiye from HesapTbl where HesapNo='" + Hesap + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BakiyeTbl.Text = "Guncel Bakiyen: ₺" + dt.Rows[0][0].ToString();
            bakiye = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }

        private void BakiyeTbl_Click(object sender, EventArgs e)
        {

        }

        private void Hizlipara_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int amt1=100,amt2=500,amt3=1000,amt4=2000,amt5=5000,amt6=10000;
        private void YatirimEkle1()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," +100+ ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void YatirimEkle2()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void YatirimEkle3()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void YatirimEkle4()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + 2000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void YatirimEkle5()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + 5000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void YatirimEkle6()
        {

            string Tip = "Hizli Para";
            try
            {
                Con.Open();
                string query = "insert into YatirTbl values('" + Hesap + "','" + Tip + "'," + 10000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
            if (bakiye<100)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 100;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle1();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bakiye < 500)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 500;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle2();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bakiye < 1000)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 1000;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle3();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bakiye < 2000)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 2000;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle4();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bakiye < 100)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 2000;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle5();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bakiye < 100)
            {
                MessageBox.Show("Bakiye Negatif olamaz!");
            }
            else
            {
                int yenibakiye = bakiye - 10000;
                try
                {
                    Con.Open();
                    string query = "update HesapTbl set Bakiye=" + yenibakiye + " where HesapNo='" + Hesap + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı Yatirim işlemi");
                    Con.Close();
                    YatirimEkle6();
                    Hizlipara hizlipara = new Hizlipara();
                    hizlipara.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
