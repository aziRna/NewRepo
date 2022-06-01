using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMYONETIM
{
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bakiye ucret = new Bakiye();
            this.Hide();
            ucret.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
        public static String HesapNo;
        private void Anaekran_Load(object sender, EventArgs e)
        {
            HesapNoTbl.Text = "Hesap Numarası:" + Giris.HesapNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yatir yatir = new Yatir();
            yatir.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PinDegistir Pin = new PinDegistir();
            Pin.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paracek pc = new Paracek();
            pc.Show();
            this.Hide();

        }

        private void HesapNoTbl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizlipara hizlipara = new Hizlipara();
            hizlipara.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aciklama aciklama = new Aciklama();
            aciklama.Show();
            this.Hide();
        }
    }
}
