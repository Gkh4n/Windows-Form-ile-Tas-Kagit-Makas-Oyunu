using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKM
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int skor = 0;
        int RakipSkor = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void RenkReset()
        {
            btnTasPc.BackColor = Color.Gray;
            btnKagitPc.BackColor = Color.Gray;
            btnMakasPc.BackColor = Color.Gray;
            btnTas.BackColor = Color.Gray;
            btnKagit.BackColor = Color.Gray;
            btnMakas.BackColor = Color.Gray;
        }
        private void btnTas_Click(object sender, EventArgs e)
        {
            RenkReset();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                durumLbl.Text = "Beraberlik";
                btnTasPc.BackColor = Color.Blue;
                btnTas.BackColor = Color.Blue;
            }
            else if (deger == 2)
            {
                RakipSkor++;
                rakipLbl.Text = "Rakip: " + RakipSkor.ToString();
                durumLbl.Text = "Kaybettin!";
                btnKagitPc.BackColor = Color.Green;
                btnTas.BackColor = Color.Red;
            }
            else if (deger == 3)
            {
                skor++;
                skorLbl.Text = "Sen: " + skor.ToString();
                durumLbl.Text = "Kazandın!";
                btnMakasPc.BackColor = Color.Red;
                btnTas.BackColor = Color.Green;
            }
        }
        private void btnKagit_Click(object sender, EventArgs e)
        {
            RenkReset();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                skor++;
                skorLbl.Text = "Sen: " + skor.ToString();
                durumLbl.Text = "Kazandın!";
                btnTasPc.BackColor = Color.Red;
                btnKagit.BackColor = Color.Green;
            }
            else if (deger == 2)
            {
                durumLbl.Text = "Beraberlik";
                btnKagitPc.BackColor = Color.Blue;
                btnKagit.BackColor = Color.Blue;
            }
            else if (deger == 3)
            {
                RakipSkor++;
                rakipLbl.Text = "Rakip: " + RakipSkor.ToString();
                durumLbl.Text = "Kaybettin!";
                btnMakasPc.BackColor = Color.Green;
                btnKagit.BackColor = Color.Red;
            }
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            RenkReset();
            int deger;
            deger = random.Next(1, 4);

            if (deger == 1)
            {
                RakipSkor++;
                rakipLbl.Text = "Rakip: " + RakipSkor.ToString();
                durumLbl.Text = "Kaybettin!";
                btnTasPc.BackColor = Color.Green;
                btnMakas.BackColor = Color.Red;
            }
            else if (deger == 2)
            {
                skor++;
                skorLbl.Text = "Sen: " + skor.ToString();
                durumLbl.Text = "Kazandın!";
                btnKagitPc.BackColor = Color.Red;
                btnMakas.BackColor = Color.Green;
            }
            else if (deger == 3)
            {
                durumLbl.Text = "Beraberlik";
                btnMakasPc.BackColor = Color.Blue;
                btnMakas.BackColor = Color.Blue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnYeniden.Enabled = false;
            if (RakipSkor == 3)
            {
                durumLbl.Text = "";
                sonucLbl.Text = "Üzgünüm Oyunu Rakip Kazandı!";
                btnTasPc.Enabled = false;
                btnKagitPc.Enabled = false;
                btnMakasPc.Enabled = false;
                btnTas.Enabled = false;
                btnKagit.Enabled = false;
                btnMakas.Enabled = false;
                btnYeniden.Enabled = true;
                timer1.Stop();
            }
            else if (skor == 3)
            {
                durumLbl.Text = "";
                sonucLbl.Text = "Tebrikler Oyunu Sen Kazandın!";
                btnTasPc.Enabled = false;
                btnKagitPc.Enabled = false;
                btnMakasPc.Enabled = false;
                btnTas.Enabled = false;
                btnKagit.Enabled = false;
                btnMakas.Enabled = false;
                btnYeniden.Enabled = true;
                timer1.Stop();
            }

            if (btnYeniden.Enabled == false)
            {
                btnYeniden.Visible = false;
            }
            else if (btnYeniden.Enabled == true)
            {
                btnYeniden.Visible = true;
            }

            
        }
        private void btnYeniden_Click(object sender, EventArgs e)
        {
            
            skor = 0;
            skorLbl.Text = "Sen: " + skor.ToString();
            RakipSkor = 0;
            rakipLbl.Text = "Rakip: " + RakipSkor.ToString();
            durumLbl.Text = "";
            sonucLbl.Text = "";
            btnTasPc.Enabled = true;
            btnKagitPc.Enabled = true;
            btnMakasPc.Enabled = true;
            btnTas.Enabled = true;
            btnKagit.Enabled = true;
            btnMakas.Enabled = true;
            btnYeniden.Enabled = false;
            RenkReset();
            btnTas.BackColor = Color.White;
            btnKagit.BackColor = Color.White;
            btnMakas.BackColor = Color.White;
            timer1.Start();
        }

    }
}