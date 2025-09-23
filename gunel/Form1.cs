using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunel
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            button1.Enabled = false;
            button1.BackColor = Color.Red;
        }

        private void saat1_Click(object sender, EventArgs e)
        {

        }

        private void dk1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ss1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            int salise = counter % 100;
            int saniye = (counter / 100) % 60;
            int dakika = (counter / 6000) % 60;
            int saat = (counter / 360000) % 24;



            ss1.Text = salise.ToString("D2");
            sn1.Text = saniye.ToString("D2");
            dk1.Text = dakika.ToString("D2");
            saat1.Text = saat.ToString("D2");

            DateTime simdi = DateTime.Now;
            if (saat == simdi.Hour && dakika == simdi.Minute && saniye == simdi.Second)
            {
                timer1.Stop();
                string notİcerigi=$"Kronometresüresi:{saat1.Text}:{dk1.Text}:{sn1.Text}:{ss1.Text}";
                counter=0 ;
                saat1.Text = "00";
                dk1.Text = "00";
                sn1.Text = "00";
                ss1.Text = "00";


                button1.Enabled = true;
                button1.BackColor = SystemColors.Control;
            }
        }
    }
}
