﻿using System;
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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            hesap hessap = new hesap();
            hessap.Show();
            this.Hide();
        }
        public static String HesapNo;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\black\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from HesapTbl where HesapNo='"+HesapNoTb.Text+"' and Pin = "+PinTb.Text+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") 
            {
                HesapNo = HesapNoTb.Text;
                Anaekran anaekran = new Anaekran();
                anaekran.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Yanlis Hesap Numarasi ya da PIN kodu");
            }

            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
