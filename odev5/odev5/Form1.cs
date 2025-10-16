using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<Button> numberButtons = new List<Button>();
        Timer moveTimer = new Timer();
        
        int remainingTime = 60; // 60 saniye
        List<int> clickedEvenNumbers = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartGame()
        {
            // 10 adet sayı butonunu oluştur
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(50, 50);
                btn.Text = rnd.Next(1, 101).ToString();
                btn.Click += NumberButton_Click;
                btn.BackColor = Color.White;
                numberButtons.Add(btn);
                panel1.Controls.Add(btn);
            }

            // İlk rastgele konumlandırma
            MoveButtons();

            // Buton hareket timer
            moveTimer.Interval = 500; // 0.5 saniye
            moveTimer.Tick += (s, e) => MoveButtons();
            moveTimer.Start();

            // Geri sayım timer
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            label1.Text = $"Süre: {remainingTime} sn";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int number = int.Parse(btn.Text);

            if (number % 2 == 0) // çiftse
            {
                clickedEvenNumbers.Add(number);
            }

            btn.Visible = false; // kaybolsun
            listBox1.Items.Add(number);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = $"Süre: {remainingTime} sn";

            if (remainingTime <= 0)
            {
                EndGame(timeOut: true);
            }
        }

        private void MoveButtons()
        {
            foreach (var btn in numberButtons)
            {
                if (!btn.Visible) continue; // görünmeyenleri taşımıyoruz
                int maxX = panel1.Width - btn.Width;
                int maxY = panel1.Height - btn.Height;

                btn.Location = new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            EndGame(timeOut: false);
        }

        private void EndGame(bool timeOut)
        {
            moveTimer.Stop();
            countdownTimer.Stop();

            if (timeOut)
            {
                MessageBox.Show("Süre doldu! Doğru tamamlayamadınız");
                return;
            }

            // ListBox'taki çift sayıları sırala (Bubble Sort)
            List<int> sortedClicked = new List<int>(clickedEvenNumbers);
            BubbleSort(sortedClicked);

            // Küçük çift sayılar (1-100 arası) içinden 1. çiftleri belirleyelim
            List<int> allEvenNumbers = new List<int>();
            for (int i = 2; i <= 100; i += 2)
                allEvenNumbers.Add(i);

            // Tıklanması gereken en küçük çift sayılar
            List<int> smallestEvens = new List<int>();
            for (int i = 0; i < clickedEvenNumbers.Count; i++)
            {
                smallestEvens.Add(allEvenNumbers[i]);
            }

            // Karşılaştırma
            bool correct = true;
            if (sortedClicked.Count != smallestEvens.Count)
            {
                correct = false;
            }
            else
            {
                for (int i = 0; i < sortedClicked.Count; i++)
                {
                    if (sortedClicked[i] != smallestEvens[i])
                    {
                        correct = false;
                        break;
                    }
                }
            }

            if (correct)
                MessageBox.Show($"Doğru tamamladınız! Kalan süre: {remainingTime} saniye");
            else
                MessageBox.Show($"Yanlış tamamladınız! Kalan süre: {remainingTime} saniye");
        }

        private void BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
