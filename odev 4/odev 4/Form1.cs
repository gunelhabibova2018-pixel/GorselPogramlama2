using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            timer1.Interval = 1000; 
            timer1.Start();
        }
        Random rnd = new Random();
        int score = 0;

        
        Rectangle targetArea = new Rectangle(200, 150, 300, 300);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateRandomButton();
        }
        private void CreateRandomButton()
        {
            int number = rnd.Next(1, 11); 
            Button btn = new Button();
            btn.Width = 50;
            btn.Height = 50;

            int x = rnd.Next(this.ClientSize.Width - btn.Width);
            int y = rnd.Next(this.ClientSize.Height - btn.Height);
            btn.Location = new Point(x, y);

            btn.Text = number.ToString();

            
            bool inTargetArea = targetArea.Contains(btn.Bounds);

            if (inTargetArea)
                btn.ForeColor = Color.Red;
            else
                btn.ForeColor = Color.Black;

            
            btn.Click += (s, e) =>
            {
                if (btn.ForeColor == Color.Red)
                    score += number;
                else
                    score -= number;

                UpdateScore();
                btn.Dispose(); 
            };

            this.Controls.Add(btn);
            btn.BringToFront();
        }

        private void UpdateScore()
        {
            labelScore.Text = score.ToString();

            if (score >= 100)
            {
                timer1.Stop();
                MessageBox.Show("Kazandınız!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
