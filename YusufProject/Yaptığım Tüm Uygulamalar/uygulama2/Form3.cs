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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(sayitxt.Text);
            double islem = (3.14) * Math.Pow(sayi, 2);
            sonuc.Text = islem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(sayitxt.Text);
            double taban = Convert.ToDouble(tabantxt.Text);
            double islem = Math.Log(sayi, taban);
            sonuc.Text = islem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(sayitxt.Text);
            double islem = Math.Sqrt(sayi);
            sonuc.Text = islem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
