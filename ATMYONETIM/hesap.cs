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
using Microsoft.SqlServer.Management.Smo;

namespace ATMYONETIM
{
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bakiye = 0; 
            if (HesapIsımTb.Text == "" || HesapNoTb.Text == "" || SoyisimTb.Text == "" || TelefonTb.Text == "" || AdresTb.Text == "" || EgitimCB.Text == "" || PinTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into HesapTbl values('" + HesapNoTb.Text + "','" + HesapIsımTb.Text + "','" + SoyisimTb.Text + "','" + DogumgunuTb.Value.Date + "','" + TelefonTb.Text + "', '" + AdresTb.Text + "','" + EgitimCB.SelectedItem.ToString()+"','"+MeslekTb.Text+"','"+ PinTb.Text + "',"+bakiye+")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap Olusturuldu");
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
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Giris log = new Giris();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoyisimTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
