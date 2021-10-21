using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziform
{
    public partial class Form1 : Form
    {   // Dizi ve sayaç tanımladık.
        string[] dizi = new string[100];
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String türü bir isim. textBox1'e tanımladık.
            string isim = textBox1.Text;

            // İsim boş ise hata vericek.
            if (isim == "")
            {
                MessageBox.Show("Lütfen diziye kaydetmek için bir isim yazınız.", "Uyarı!");
            }

            // İsmi diziye tanımlayıp sayacı 1 arttırdık.
            dizi[sayac] = isim;
            sayac++;
            textBox1.Clear();

            // Eğer Tüm diziler dolu ise hata vericek 1. sıradakini silip silmek istemediğimizi soracak.
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

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label2.Text = label2.Text + dizi[i] + "\n";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?","Uyarı!", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
                Application.Exit();
            if (exit == DialogResult.No)
            {
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
