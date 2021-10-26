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
    public partial class Form6 : Form
    {
        public static int[] toplamlar = new int[100];
        int sayac = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            int a, b, t;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            t = b - a;
            for (int i = a; i <= b; i++)
            {
                s = i.ToString();
                label2.Text = s;
                label2.Refresh();
            }
            label4.Text = t.ToString();
            toplamlar[sayac] = t;
            sayac++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 listbox = new Form7();
            listbox.Show();
        }
    }
}
