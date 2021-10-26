using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2
{
    public partial class Form4 : Form
    {
        int[] sayilar = new int[10];
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(sayitxt.Text);
            if (sayi > 10 || sayi <= 0)
            {
                MessageBox.Show("Lütfen 1 ile 10 arasında bir sayı giriniz.", "Uyarı!!");
            }
            else
            {
                Random rastgele = new Random();
                sonuc.Text = "";
                for (int i = 0; i < sayi; i++)
                {
                    sayilar[i] = rastgele.Next(0, 100);
                    sonuc.Text = sonuc.Text + (i + 1) + ") " + sayilar[i] + "\n";
                }
            }
        }
    }
}
