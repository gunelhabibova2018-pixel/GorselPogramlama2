using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333
{
    public partial class Form1 : Form
    {private bool isDragging=false;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation=e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging) {
                button1.Location=new Point((e.X - lastLocation.X)+button1.Left, (e.Y - lastLocation.Y)+button1.Top);
                }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging=false;
        }
    }
}
