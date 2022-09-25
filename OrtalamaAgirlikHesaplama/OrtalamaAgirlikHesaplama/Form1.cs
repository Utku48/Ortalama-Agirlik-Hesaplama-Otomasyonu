using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaAgirlikHesaplama
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Ağırlığın Hesaplanması
            int A1, A2, A3, A4, A5, A6, A7;
            A1 = Convert.ToInt32(t1A.Text);
            A2 = Convert.ToInt32(t2A.Text);
            A3 = Convert.ToInt32(t3A.Text);
            A4 = Convert.ToInt32(t4A.Text);
            A5 = Convert.ToInt32(t5A.Text);
            A6 = Convert.ToInt32(t6A.Text);
            A7 = Convert.ToInt32(t7A.Text);
          
            int agirlik = A1 + A2 + A3 + A4 + A5 + A6 + A7;
            t1H.Text = "" + (agirlik);
            
            //Ortalama Kalori Ağırlığı Hesaplama
            int K1, K2, K3, K4, K5, K6, K7;
            K1 = Convert.ToInt16(t1K.Text);
            K2 = Convert.ToInt16(t2K.Text);
            K3 = Convert.ToInt16(t3K.Text);
            K4 = Convert.ToInt16(t4K.Text);
            K5 = Convert.ToInt16(t5K.Text);
            K6 = Convert.ToInt16(t6K.Text);
            K7 = Convert.ToInt16(t6K.Text);

            t2H.Text = "" + (((K1 * A1) + (K2 * A2) + (K3 * A3) + (K4 * A4) + (K5 * A5) + (K6 * A6) + (K7 * A7)) / agirlik).ToString();
           
            //Ortalama Nem Ağırlığı Hesaplama
            double N1, N2, N3, N4, N5, N6, N7;
            N1 = Convert.ToDouble(t1N.Text);
            N2 = Convert.ToDouble(t2N.Text);
            N3 = Convert.ToDouble(t3N.Text);
            N4 = Convert.ToInt16(t4N.Text);
            N5 = Convert.ToInt16(t5N.Text);
            N6 = Convert.ToInt16(t6N.Text);
            N7 = Convert.ToInt16(t7N.Text);
          t3H.Text = "" + (((N1 * A1) + (N2 * A2) + (N3 * A3) + (N4 * A4) + (N5 * A5) + (N6 * A6) + (N7 * A7)) / agirlik).ToString();
            
            //Ortalama Kül Ağırlığı Hesaplama
            double kul1, kul2, kul3, kul4, kul5, kul6,kul7;
            kul1 = Convert.ToDouble(t1Kul.Text);
            kul2 = Convert.ToDouble(t2Kul.Text);
            kul3 = Convert.ToDouble(t3Kul.Text);
            kul4 = Convert.ToInt16(t4Kul.Text);
            kul5 = Convert.ToInt16(t5Kul.Text);
            kul6 = Convert.ToInt16(t6Kul.Text);
            kul7 = Convert.ToInt16(t7Kul.Text);
            t4H.Text = "" + (((kul1 * A1) + (kul2 * A2) + (kul3 * A3) + (kul4 * A4) + (kul5 * A5) + (kul6 * A6) + (kul7 * A7)) / agirlik).ToString();

            //Ortalama Kükürt Ağırlığı Hesaplanması

            double kk1, kk2, kk3, kk4, kk5, kk6, kk7;
            kk1 = Convert.ToDouble(t1Kk.Text);
            kk2 = Convert.ToDouble(t2Kk.Text);
            kk3 = Convert.ToDouble(t3Kk.Text);
            kk4 = Convert.ToInt16(t4Kk.Text);
            kk5 = Convert.ToInt16(t5Kk.Text);
            kk6 = Convert.ToInt16(t6Kk.Text);
            kk7 = Convert.ToInt16(t7Kk.Text);
            t5H.Text = "" + (((kk1 * A1) + (kk2 * A2) + (kk3 * A3) + (kk4 * A4) + (kk5 * A5) + (kk6 * A6) + (kk7 * A7)) / agirlik).ToString();








        }

        private void text1A_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text2A_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void text1H_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SatırA(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ağırlık", 150);
            listView1.Columns.Add("Ortalama Kalori Ağırlığı", 150);
            listView1.Columns.Add("Ortalama Nem Ağırlığı", 150);
            listView1.Columns.Add("Ortalama Kül Ağırlığı", 150);
            listView1.Columns.Add("Ortalama Kükürt Ağırlığı", 150);
        }
    }
}
