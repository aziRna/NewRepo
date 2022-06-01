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
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        int basla = 0;




        private void Baslangic_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            basla += 2;
            ilerilemebari.Value = basla;
            Yuzde.Text = ""+basla;
            if (ilerilemebari.Value == 100)
            {
                ilerilemebari.Value = 0;
                timer1.Stop();
                Giris giris = new Giris();
                this.Hide();
                giris.Show();
            }

        }

        private void ilerilemebari_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
