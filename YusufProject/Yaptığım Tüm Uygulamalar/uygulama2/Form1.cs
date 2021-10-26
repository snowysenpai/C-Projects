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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Uygulamadan çıkış yapmak istermisiniz?","Uyarı",MessageBoxButtons.YesNo);
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
            Form2 diziform = new Form2();
            diziform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 matematikselmetodlar = new Form3();
            matematikselmetodlar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 matematikselmetodlar2 = new Form4();
            matematikselmetodlar2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 labelrefresh = new Form5();
            labelrefresh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 ikisayiarasifark = new Form6();
            ikisayiarasifark.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 zaroyunu = new Form8();
            zaroyunu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 vizefinalhesaplama = new Form9();
            vizefinalhesaplama.ShowDialog();
        }
    }
}
