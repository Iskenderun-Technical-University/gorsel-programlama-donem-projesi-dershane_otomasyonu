﻿
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
namespace vtgb_otomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ogr_bilgileri ogr = new ogr_bilgileri();
            //ogr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //personel_bilgileri per = new personel_bilgileri();
            //per.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            veli_bilgileri vel = new veli_bilgileri();
            vel.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            hesap_bilgileri hesap = new hesap_bilgileri();
            hesap.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Sinav_Takip gozlem = new Sinav_Takip();
            gozlem.Show();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Yardimci_Form adus = new Yardimci_Form();
            adus.Show();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Sinav_Listeleri liste = new Sinav_Listeleri();
            liste.Show();*/
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           /* this.Hide();
            veli_bilgi bilgi = new veli_bilgi();
            bilgi.Show();*/
        }
    }
}
