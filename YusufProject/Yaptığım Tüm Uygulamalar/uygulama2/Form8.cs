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
    public partial class Form8 : Form
    {
        int sayac1 = 0;
        int sayac2 = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random o1 = new Random();
            label2.Text = Convert.ToString(o1.Next(1, 6));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random o2 = new Random();
            label4.Text = Convert.ToString(o2.Next(1, 6));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int puan1 = Convert.ToInt32(label2.Text);
            int puan2 = Convert.ToInt32(label4.Text);
            if (puan1 > puan2)
            {
                label7.Text = "1. Oyuncu Kazandı!!!";
                sayac1++;
                label5.Text = "Puanı: " + sayac1;
            }
            else if (puan1 < puan2)
            {
                label7.Text = "2. Oyuncu Kazandı!!!";
                sayac2++;
                label6.Text = "Puanı: " + sayac2;
            }
            else
            {
                label7.Text = "Berabere Kalındı!!!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac1 > sayac2)
            {
                MessageBox.Show("Oyuncu 1 Oyunu Kazandı");
            }
            else if (sayac1 < sayac2)
            {
                MessageBox.Show("Oyuncu 2 Oyunu Kazandı");
            }
            else
            {
                MessageBox.Show("Oyuncu 1 ve 2 Berabere Kaldı");
            }

            DialogResult sj = new DialogResult();
            sj = MessageBox.Show("Tekrar oynamak ister misiniz?", "Uyarı!", MessageBoxButtons.YesNo);

            if (sj == DialogResult.Yes)
            {
                sayac1 = 0;
                sayac2 = 0;
                label2.Text = "";
                label4.Text = "";
                label7.Text = "";
                label5.Text = "Puanı: " + sayac1;
                label6.Text = "Puanı: " + sayac2;
            }
            if (sj == DialogResult.No)
            {
                MessageBox.Show("Bizimle oynadığınız için teşekkür ederiz.");
                this.Close();
            }
        }
    }
}
