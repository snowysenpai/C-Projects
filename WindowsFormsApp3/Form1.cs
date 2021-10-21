using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static int[] toplamlar = new int[100];
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (exit == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            int a, b, t;
            a = Convert.ToInt32(sayi1.Text);
            b = Convert.ToInt32(sayi2.Text);
            t = b - a;
            for (int i = a; i <= b; i++)
            {
                s = i.ToString();
                surec.Text = s;
                surec.Refresh();
            }
            sonuc.Text = t.ToString();
            toplamlar[sayac] = t;
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 sonuclar = new Form2();
            sonuclar.Show();
        }
    }
}
