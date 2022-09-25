namespace OrtalamaAgirlikHesaplama
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbKal = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbKul = new System.Windows.Forms.Label();
            this.lbKuk = new System.Windows.Forms.Label();
            this.t1A = new System.Windows.Forms.TextBox();
            this.t1K = new System.Windows.Forms.TextBox();
            this.t1N = new System.Windows.Forms.TextBox();
            this.t1Kul = new System.Windows.Forms.TextBox();
            this.t1Kk = new System.Windows.Forms.TextBox();
            this.t2Kk = new System.Windows.Forms.TextBox();
            this.t2Kul = new System.Windows.Forms.TextBox();
            this.t2N = new System.Windows.Forms.TextBox();
            this.t2K = new System.Windows.Forms.TextBox();
            this.t2A = new System.Windows.Forms.TextBox();
            this.t3Kk = new System.Windows.Forms.TextBox();
            this.t3Kul = new System.Windows.Forms.TextBox();
            this.t3N = new System.Windows.Forms.TextBox();
            this.t3K = new System.Windows.Forms.TextBox();
            this.t3A = new System.Windows.Forms.TextBox();
            this.t4Kk = new System.Windows.Forms.TextBox();
            this.t4Kul = new System.Windows.Forms.TextBox();
            this.t4N = new System.Windows.Forms.TextBox();
            this.t4K = new System.Windows.Forms.TextBox();
            this.t4A = new System.Windows.Forms.TextBox();
            this.t6Kk = new System.Windows.Forms.TextBox();
            this.t6Kul = new System.Windows.Forms.TextBox();
            this.t6N = new System.Windows.Forms.TextBox();
            this.t6K = new System.Windows.Forms.TextBox();
            this.t6A = new System.Windows.Forms.TextBox();
            this.t5Kk = new System.Windows.Forms.TextBox();
            this.t5Kul = new System.Windows.Forms.TextBox();
            this.t5N = new System.Windows.Forms.TextBox();
            this.t5K = new System.Windows.Forms.TextBox();
            this.t5A = new System.Windows.Forms.TextBox();
            this.t7Kk = new System.Windows.Forms.TextBox();
            this.t7Kul = new System.Windows.Forms.TextBox();
            this.t7N = new System.Windows.Forms.TextBox();
            this.t7K = new System.Windows.Forms.TextBox();
            this.t7A = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t1H = new System.Windows.Forms.TextBox();
            this.t2H = new System.Windows.Forms.TextBox();
            this.t3H = new System.Windows.Forms.TextBox();
            this.t4H = new System.Windows.Forms.TextBox();
            this.t5H = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbA.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(79, 9);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(55, 21);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Ağırlık";
            // 
            // lbKal
            // 
            this.lbKal.AutoSize = true;
            this.lbKal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbKal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKal.Location = new System.Drawing.Point(284, 9);
            this.lbKal.Name = "lbKal";
            this.lbKal.Size = new System.Drawing.Size(50, 21);
            this.lbKal.TabIndex = 1;
            this.lbKal.Text = "Kalori";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(475, 9);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(44, 21);
            this.lbN.TabIndex = 2;
            this.lbN.Text = "Nem";
            // 
            // lbKul
            // 
            this.lbKul.AutoSize = true;
            this.lbKul.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbKul.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKul.Location = new System.Drawing.Point(664, 9);
            this.lbKul.Name = "lbKul";
            this.lbKul.Size = new System.Drawing.Size(32, 21);
            this.lbKul.TabIndex = 3;
            this.lbKul.Text = "Kül";
            this.lbKul.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbKuk
            // 
            this.lbKuk.AutoSize = true;
            this.lbKuk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbKuk.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKuk.Location = new System.Drawing.Point(854, 9);
            this.lbKuk.Name = "lbKuk";
            this.lbKuk.Size = new System.Drawing.Size(56, 21);
            this.lbKuk.TabIndex = 4;
            this.lbKuk.Text = "Kükürt";
            // 
            // t1A
            // 
            this.t1A.Location = new System.Drawing.Point(45, 33);
            this.t1A.Name = "t1A";
            this.t1A.Size = new System.Drawing.Size(110, 20);
            this.t1A.TabIndex = 5;
            this.t1A.Click += new System.EventHandler(this.SatırA);
            this.t1A.TextChanged += new System.EventHandler(this.text1A_TextChanged);
            // 
            // t1K
            // 
            this.t1K.Location = new System.Drawing.Point(253, 33);
            this.t1K.Name = "t1K";
            this.t1K.Size = new System.Drawing.Size(110, 20);
            this.t1K.TabIndex = 6;
            // 
            // t1N
            // 
            this.t1N.Location = new System.Drawing.Point(455, 33);
            this.t1N.Name = "t1N";
            this.t1N.Size = new System.Drawing.Size(110, 20);
            this.t1N.TabIndex = 7;
            // 
            // t1Kul
            // 
            this.t1Kul.Location = new System.Drawing.Point(637, 33);
            this.t1Kul.Name = "t1Kul";
            this.t1Kul.Size = new System.Drawing.Size(110, 20);
            this.t1Kul.TabIndex = 8;
            this.t1Kul.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // t1Kk
            // 
            this.t1Kk.Location = new System.Drawing.Point(821, 33);
            this.t1Kk.Name = "t1Kk";
            this.t1Kk.Size = new System.Drawing.Size(110, 20);
            this.t1Kk.TabIndex = 9;
            // 
            // t2Kk
            // 
            this.t2Kk.Location = new System.Drawing.Point(821, 73);
            this.t2Kk.Name = "t2Kk";
            this.t2Kk.Size = new System.Drawing.Size(110, 20);
            this.t2Kk.TabIndex = 14;
            // 
            // t2Kul
            // 
            this.t2Kul.Location = new System.Drawing.Point(637, 73);
            this.t2Kul.Name = "t2Kul";
            this.t2Kul.Size = new System.Drawing.Size(110, 20);
            this.t2Kul.TabIndex = 13;
            // 
            // t2N
            // 
            this.t2N.Location = new System.Drawing.Point(455, 73);
            this.t2N.Name = "t2N";
            this.t2N.Size = new System.Drawing.Size(110, 20);
            this.t2N.TabIndex = 12;
            // 
            // t2K
            // 
            this.t2K.Location = new System.Drawing.Point(253, 73);
            this.t2K.Name = "t2K";
            this.t2K.Size = new System.Drawing.Size(110, 20);
            this.t2K.TabIndex = 11;
            // 
            // t2A
            // 
            this.t2A.Location = new System.Drawing.Point(45, 73);
            this.t2A.Name = "t2A";
            this.t2A.Size = new System.Drawing.Size(110, 20);
            this.t2A.TabIndex = 10;
            this.t2A.Click += new System.EventHandler(this.SatırA);
            this.t2A.TextChanged += new System.EventHandler(this.text2A_TextChanged);
            // 
            // t3Kk
            // 
            this.t3Kk.Location = new System.Drawing.Point(821, 113);
            this.t3Kk.Name = "t3Kk";
            this.t3Kk.Size = new System.Drawing.Size(110, 20);
            this.t3Kk.TabIndex = 19;
            this.t3Kk.Text = "d";
            // 
            // t3Kul
            // 
            this.t3Kul.Location = new System.Drawing.Point(637, 113);
            this.t3Kul.Name = "t3Kul";
            this.t3Kul.Size = new System.Drawing.Size(110, 20);
            this.t3Kul.TabIndex = 18;
            this.t3Kul.Text = "d";
            // 
            // t3N
            // 
            this.t3N.Location = new System.Drawing.Point(455, 113);
            this.t3N.Name = "t3N";
            this.t3N.Size = new System.Drawing.Size(110, 20);
            this.t3N.TabIndex = 17;
            this.t3N.Text = "d";
            // 
            // t3K
            // 
            this.t3K.Location = new System.Drawing.Point(253, 113);
            this.t3K.Name = "t3K";
            this.t3K.Size = new System.Drawing.Size(110, 20);
            this.t3K.TabIndex = 16;
            this.t3K.Text = "d";
            // 
            // t3A
            // 
            this.t3A.Location = new System.Drawing.Point(45, 113);
            this.t3A.Name = "t3A";
            this.t3A.Size = new System.Drawing.Size(110, 20);
            this.t3A.TabIndex = 15;
            this.t3A.Text = "d";
            this.t3A.Click += new System.EventHandler(this.SatırA);
            // 
            // t4Kk
            // 
            this.t4Kk.Location = new System.Drawing.Point(821, 153);
            this.t4Kk.Name = "t4Kk";
            this.t4Kk.Size = new System.Drawing.Size(110, 20);
            this.t4Kk.TabIndex = 24;
            this.t4Kk.Text = "d";
            // 
            // t4Kul
            // 
            this.t4Kul.Location = new System.Drawing.Point(637, 153);
            this.t4Kul.Name = "t4Kul";
            this.t4Kul.Size = new System.Drawing.Size(110, 20);
            this.t4Kul.TabIndex = 23;
            this.t4Kul.Text = "d";
            // 
            // t4N
            // 
            this.t4N.Location = new System.Drawing.Point(455, 153);
            this.t4N.Name = "t4N";
            this.t4N.Size = new System.Drawing.Size(110, 20);
            this.t4N.TabIndex = 22;
            this.t4N.Text = "d";
            // 
            // t4K
            // 
            this.t4K.Location = new System.Drawing.Point(253, 153);
            this.t4K.Name = "t4K";
            this.t4K.Size = new System.Drawing.Size(110, 20);
            this.t4K.TabIndex = 21;
            this.t4K.Text = "d";
            // 
            // t4A
            // 
            this.t4A.Location = new System.Drawing.Point(45, 153);
            this.t4A.Name = "t4A";
            this.t4A.Size = new System.Drawing.Size(110, 20);
            this.t4A.TabIndex = 20;
            this.t4A.Text = "d";
            this.t4A.Click += new System.EventHandler(this.SatırA);
            // 
            // t6Kk
            // 
            this.t6Kk.Location = new System.Drawing.Point(821, 234);
            this.t6Kk.Name = "t6Kk";
            this.t6Kk.Size = new System.Drawing.Size(110, 20);
            this.t6Kk.TabIndex = 34;
            this.t6Kk.Text = "d";
            // 
            // t6Kul
            // 
            this.t6Kul.Location = new System.Drawing.Point(637, 234);
            this.t6Kul.Name = "t6Kul";
            this.t6Kul.Size = new System.Drawing.Size(110, 20);
            this.t6Kul.TabIndex = 33;
            this.t6Kul.Text = "d";
            // 
            // t6N
            // 
            this.t6N.Location = new System.Drawing.Point(455, 234);
            this.t6N.Name = "t6N";
            this.t6N.Size = new System.Drawing.Size(110, 20);
            this.t6N.TabIndex = 32;
            this.t6N.Text = "d";
            // 
            // t6K
            // 
            this.t6K.Location = new System.Drawing.Point(253, 234);
            this.t6K.Name = "t6K";
            this.t6K.Size = new System.Drawing.Size(110, 20);
            this.t6K.TabIndex = 31;
            this.t6K.Text = "d";
            // 
            // t6A
            // 
            this.t6A.Location = new System.Drawing.Point(45, 234);
            this.t6A.Name = "t6A";
            this.t6A.Size = new System.Drawing.Size(110, 20);
            this.t6A.TabIndex = 30;
            this.t6A.Text = "d";
            this.t6A.Click += new System.EventHandler(this.SatırA);
            // 
            // t5Kk
            // 
            this.t5Kk.Location = new System.Drawing.Point(821, 193);
            this.t5Kk.Name = "t5Kk";
            this.t5Kk.Size = new System.Drawing.Size(110, 20);
            this.t5Kk.TabIndex = 29;
            this.t5Kk.Text = "d";
            // 
            // t5Kul
            // 
            this.t5Kul.Location = new System.Drawing.Point(637, 193);
            this.t5Kul.Name = "t5Kul";
            this.t5Kul.Size = new System.Drawing.Size(110, 20);
            this.t5Kul.TabIndex = 28;
            this.t5Kul.Text = "d";
            // 
            // t5N
            // 
            this.t5N.Location = new System.Drawing.Point(455, 193);
            this.t5N.Name = "t5N";
            this.t5N.Size = new System.Drawing.Size(110, 20);
            this.t5N.TabIndex = 27;
            this.t5N.Text = "d";
            // 
            // t5K
            // 
            this.t5K.Location = new System.Drawing.Point(253, 193);
            this.t5K.Name = "t5K";
            this.t5K.Size = new System.Drawing.Size(110, 20);
            this.t5K.TabIndex = 26;
            this.t5K.Text = "d";
            // 
            // t5A
            // 
            this.t5A.Location = new System.Drawing.Point(45, 193);
            this.t5A.Name = "t5A";
            this.t5A.Size = new System.Drawing.Size(110, 20);
            this.t5A.TabIndex = 25;
            this.t5A.Text = "d";
            this.t5A.Click += new System.EventHandler(this.SatırA);
            // 
            // t7Kk
            // 
            this.t7Kk.Location = new System.Drawing.Point(821, 272);
            this.t7Kk.Name = "t7Kk";
            this.t7Kk.Size = new System.Drawing.Size(110, 20);
            this.t7Kk.TabIndex = 45;
            this.t7Kk.Text = "d";
            // 
            // t7Kul
            // 
            this.t7Kul.Location = new System.Drawing.Point(637, 272);
            this.t7Kul.Name = "t7Kul";
            this.t7Kul.Size = new System.Drawing.Size(110, 20);
            this.t7Kul.TabIndex = 44;
            this.t7Kul.Text = "d";
            // 
            // t7N
            // 
            this.t7N.Location = new System.Drawing.Point(455, 272);
            this.t7N.Name = "t7N";
            this.t7N.Size = new System.Drawing.Size(110, 20);
            this.t7N.TabIndex = 43;
            this.t7N.Text = "d";
            // 
            // t7K
            // 
            this.t7K.Location = new System.Drawing.Point(253, 272);
            this.t7K.Name = "t7K";
            this.t7K.Size = new System.Drawing.Size(110, 20);
            this.t7K.TabIndex = 42;
            this.t7K.Text = "d";
            // 
            // t7A
            // 
            this.t7A.Location = new System.Drawing.Point(45, 272);
            this.t7A.Name = "t7A";
            this.t7A.Size = new System.Drawing.Size(110, 20);
            this.t7A.TabIndex = 41;
            this.t7A.Text = "d";
            this.t7A.Click += new System.EventHandler(this.SatırA);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHesapla.Location = new System.Drawing.Point(995, 316);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(95, 29);
            this.btnHesapla.TabIndex = 46;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ağırlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ortalama Kalori Ağırlığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ortalama Nem Ağırlığı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ortalama Kül Ağırlığı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(818, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ortalama Kükürt Ağırlığı";
            // 
            // t1H
            // 
            this.t1H.Location = new System.Drawing.Point(45, 316);
            this.t1H.Name = "t1H";
            this.t1H.Size = new System.Drawing.Size(110, 20);
            this.t1H.TabIndex = 35;
            // 
            // t2H
            // 
            this.t2H.Location = new System.Drawing.Point(253, 316);
            this.t2H.Name = "t2H";
            this.t2H.Size = new System.Drawing.Size(110, 20);
            this.t2H.TabIndex = 36;
            // 
            // t3H
            // 
            this.t3H.Location = new System.Drawing.Point(455, 316);
            this.t3H.Name = "t3H";
            this.t3H.Size = new System.Drawing.Size(110, 20);
            this.t3H.TabIndex = 37;
            // 
            // t4H
            // 
            this.t4H.Location = new System.Drawing.Point(637, 316);
            this.t4H.Name = "t4H";
            this.t4H.Size = new System.Drawing.Size(110, 20);
            this.t4H.TabIndex = 38;
            // 
            // t5H
            // 
            this.t5H.Location = new System.Drawing.Point(821, 316);
            this.t5H.Name = "t5H";
            this.t5H.Size = new System.Drawing.Size(110, 20);
            this.t5H.TabIndex = 39;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 390);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1030, 177);
            this.listView1.TabIndex = 52;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1270, 643);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.t7Kk);
            this.Controls.Add(this.t7Kul);
            this.Controls.Add(this.t7N);
            this.Controls.Add(this.t7K);
            this.Controls.Add(this.t7A);
            this.Controls.Add(this.t5H);
            this.Controls.Add(this.t4H);
            this.Controls.Add(this.t3H);
            this.Controls.Add(this.t2H);
            this.Controls.Add(this.t1H);
            this.Controls.Add(this.t6Kk);
            this.Controls.Add(this.t6Kul);
            this.Controls.Add(this.t6N);
            this.Controls.Add(this.t6K);
            this.Controls.Add(this.t6A);
            this.Controls.Add(this.t5Kk);
            this.Controls.Add(this.t5Kul);
            this.Controls.Add(this.t5N);
            this.Controls.Add(this.t5K);
            this.Controls.Add(this.t5A);
            this.Controls.Add(this.t4Kk);
            this.Controls.Add(this.t4Kul);
            this.Controls.Add(this.t4N);
            this.Controls.Add(this.t4K);
            this.Controls.Add(this.t4A);
            this.Controls.Add(this.t3Kk);
            this.Controls.Add(this.t3Kul);
            this.Controls.Add(this.t3N);
            this.Controls.Add(this.t3K);
            this.Controls.Add(this.t3A);
            this.Controls.Add(this.t2Kk);
            this.Controls.Add(this.t2Kul);
            this.Controls.Add(this.t2N);
            this.Controls.Add(this.t2K);
            this.Controls.Add(this.t2A);
            this.Controls.Add(this.t1Kk);
            this.Controls.Add(this.t1Kul);
            this.Controls.Add(this.t1N);
            this.Controls.Add(this.t1K);
            this.Controls.Add(this.t1A);
            this.Controls.Add(this.lbKuk);
            this.Controls.Add(this.lbKul);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbKal);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbKal;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbKul;
        private System.Windows.Forms.Label lbKuk;
        private System.Windows.Forms.TextBox t1A;
        private System.Windows.Forms.TextBox t1K;
        private System.Windows.Forms.TextBox t1N;
        private System.Windows.Forms.TextBox t1Kul;
        private System.Windows.Forms.TextBox t1Kk;
        private System.Windows.Forms.TextBox t2Kk;
        private System.Windows.Forms.TextBox t2Kul;
        private System.Windows.Forms.TextBox t2N;
        private System.Windows.Forms.TextBox t2K;
        private System.Windows.Forms.TextBox t2A;
        private System.Windows.Forms.TextBox t3Kk;
        private System.Windows.Forms.TextBox t3Kul;
        private System.Windows.Forms.TextBox t3N;
        private System.Windows.Forms.TextBox t3K;
        private System.Windows.Forms.TextBox t3A;
        private System.Windows.Forms.TextBox t4Kk;
        private System.Windows.Forms.TextBox t4Kul;
        private System.Windows.Forms.TextBox t4N;
        private System.Windows.Forms.TextBox t4K;
        private System.Windows.Forms.TextBox t4A;
        private System.Windows.Forms.TextBox t6Kk;
        private System.Windows.Forms.TextBox t6Kul;
        private System.Windows.Forms.TextBox t6N;
        private System.Windows.Forms.TextBox t6K;
        private System.Windows.Forms.TextBox t6A;
        private System.Windows.Forms.TextBox t5Kk;
        private System.Windows.Forms.TextBox t5Kul;
        private System.Windows.Forms.TextBox t5N;
        private System.Windows.Forms.TextBox t5K;
        private System.Windows.Forms.TextBox t5A;
        private System.Windows.Forms.TextBox t7Kk;
        private System.Windows.Forms.TextBox t7Kul;
        private System.Windows.Forms.TextBox t7N;
        private System.Windows.Forms.TextBox t7K;
        private System.Windows.Forms.TextBox t7A;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t1H;
        private System.Windows.Forms.TextBox t2H;
        private System.Windows.Forms.TextBox t3H;
        private System.Windows.Forms.TextBox t4H;
        private System.Windows.Forms.TextBox t5H;
        private System.Windows.Forms.ListView listView1;
    }
}

