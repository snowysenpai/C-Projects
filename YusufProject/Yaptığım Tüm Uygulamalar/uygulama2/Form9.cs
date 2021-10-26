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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            double ortalama = (vize * 0.4) + (final * 0.6);
            if (vize < 0 || vize > 100)
            {
                MessageBox.Show("Lütfen Vize Notunuzu 0 ile 100 arasında giriniz.");
            }
            else
            {
                if (final < 0 || final > 100)
                {
                    MessageBox.Show("Lütfen Final Notunuzu 0 ile 100 arasında giriniz.");
                }
                else
                {
                    if (ortalama <= 45)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "FF";
                        label8.Text = "Kaldı";
                        label8.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (ortalama > 45 && ortalama <= 49)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "FD";
                        label8.Text = "Kaldı";
                        label8.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (ortalama <= 57 && ortalama >= 50)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "DD";
                        label8.Text = "Sorumlu Geçti";
                        label8.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (ortalama <= 64 && ortalama >= 58)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "DC";
                        label8.Text = "Sorumlu Geçti";
                        label8.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (ortalama <= 74 && ortalama >= 65)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "CC";
                        label8.Text = "Geçti";
                        label8.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (ortalama <= 79 && ortalama >= 75)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "CB";
                        label8.Text = "Geçti";
                        label8.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (ortalama <= 84 && ortalama >= 80)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "BB";
                        label8.Text = "Başarıyla Geçti";
                        label8.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (ortalama <= 89 && ortalama >= 85)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "BA";
                        label8.Text = "Başarıyla Geçti";
                        label8.ForeColor = System.Drawing.Color.Green;
                    }
                    else if (ortalama <= 100 && ortalama >= 90)
                    {
                        label6.Text = "" + ortalama;
                        label7.Text = "BB";
                        label8.Text = "Başarıyla Geçti";
                        label8.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
