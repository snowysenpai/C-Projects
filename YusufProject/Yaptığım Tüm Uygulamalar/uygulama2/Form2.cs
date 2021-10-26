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
    public partial class Form2 : Form
    {
        string[] dizi = new string[100];
        int sayac = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                this.Hide();
            }
            if (exit == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;

            if (isim == "")
            {
                MessageBox.Show("Lütfen diziye kaydetmek için bir isim yazınız.", "Uyarı!");
            }

            dizi[sayac] = isim;
            sayac++;
            textBox1.Clear();

            if (sayac == 6)
            {
                DialogResult reset = new DialogResult();
                reset = MessageBox.Show("Dizi doldu. Tüm diziyi sıfırlamak ister misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                if (reset == DialogResult.Yes)
                {
                    sayac = 0;
                    Array.Clear(dizi, sayac, 5);
                    dizi[sayac] = isim;
                    sayac++;
                }
                if (reset == DialogResult.No)
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label2.Text = label2.Text + dizi[i] + "\n";
            }
        }
    }
}
