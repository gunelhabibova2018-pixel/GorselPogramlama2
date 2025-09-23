namespace gunel
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dk1 = new System.Windows.Forms.Label();
            this.sn1 = new System.Windows.Forms.Label();
            this.ss1 = new System.Windows.Forms.Label();
            this.saat2 = new System.Windows.Forms.Label();
            this.dk2 = new System.Windows.Forms.Label();
            this.sn2 = new System.Windows.Forms.Label();
            this.ss2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saat1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dk1
            // 
            this.dk1.AutoSize = true;
            this.dk1.Location = new System.Drawing.Point(168, 44);
            this.dk1.Name = "dk1";
            this.dk1.Size = new System.Drawing.Size(21, 13);
            this.dk1.TabIndex = 1;
            this.dk1.Text = "Dk";
            this.dk1.Click += new System.EventHandler(this.dk1_Click);
            // 
            // sn1
            // 
            this.sn1.AutoSize = true;
            this.sn1.Location = new System.Drawing.Point(288, 43);
            this.sn1.Name = "sn1";
            this.sn1.Size = new System.Drawing.Size(20, 13);
            this.sn1.TabIndex = 2;
            this.sn1.Text = "Sn";
            // 
            // ss1
            // 
            this.ss1.AutoSize = true;
            this.ss1.Location = new System.Drawing.Point(395, 44);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(19, 13);
            this.ss1.TabIndex = 3;
            this.ss1.Text = "Ss";
            this.ss1.Click += new System.EventHandler(this.ss1_Click);
            // 
            // saat2
            // 
            this.saat2.AutoSize = true;
            this.saat2.Location = new System.Drawing.Point(53, 92);
            this.saat2.Name = "saat2";
            this.saat2.Size = new System.Drawing.Size(29, 13);
            this.saat2.TabIndex = 4;
            this.saat2.Text = "Saat";
            // 
            // dk2
            // 
            this.dk2.AutoSize = true;
            this.dk2.Location = new System.Drawing.Point(171, 91);
            this.dk2.Name = "dk2";
            this.dk2.Size = new System.Drawing.Size(21, 13);
            this.dk2.TabIndex = 5;
            this.dk2.Text = "Dk";
            // 
            // sn2
            // 
            this.sn2.AutoSize = true;
            this.sn2.Location = new System.Drawing.Point(291, 91);
            this.sn2.Name = "sn2";
            this.sn2.Size = new System.Drawing.Size(20, 13);
            this.sn2.TabIndex = 6;
            this.sn2.Text = "Sn";
            // 
            // ss2
            // 
            this.ss2.AutoSize = true;
            this.ss2.Location = new System.Drawing.Point(398, 90);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(19, 13);
            this.ss2.TabIndex = 7;
            this.ss2.Text = "Ss";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.BackColorChanged += new System.EventHandler(this.button1_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saat1
            // 
            this.saat1.AutoSize = true;
            this.saat1.Location = new System.Drawing.Point(53, 43);
            this.saat1.Name = "saat1";
            this.saat1.Size = new System.Drawing.Size(29, 13);
            this.saat1.TabIndex = 4;
            this.saat1.Text = "Saat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.sn2);
            this.Controls.Add(this.dk2);
            this.Controls.Add(this.saat1);
            this.Controls.Add(this.saat2);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.sn1);
            this.Controls.Add(this.dk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dk1;
        private System.Windows.Forms.Label sn1;
        private System.Windows.Forms.Label ss1;
        private System.Windows.Forms.Label saat2;
        private System.Windows.Forms.Label dk2;
        private System.Windows.Forms.Label sn2;
        private System.Windows.Forms.Label ss2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saat1;
    }
}

