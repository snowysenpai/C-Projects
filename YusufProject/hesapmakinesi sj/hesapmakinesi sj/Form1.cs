using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Yusuf Selimhan Yüksel - 201104030

namespace hesapmakinesi_sj
{

    public partial class Form1 : Form
    {

                                                        // Yusuf Selimhan Yüksel //
        string[] dizi = new string[100]; // Geçmiş Listesi için dizi tanımladım.             // 201104030
        int sayac1 = 0;                  // Label kontrolü için sayaç tanımladım.            // 201104030
        int sayac2 = 0;                  // Geçmiş listesinin kontrolü için sayac tanımladım // 201104030
        public Form1()
        {
            InitializeComponent();
        }
        // Sayı Tanımlamaları Başlangıç //
        private void button16_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "0";
            else 
                label3.Text = label3.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "1";
            else
                label3.Text = label3.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "2";
            else
                label3.Text = label3.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "3";
            else
                label3.Text = label3.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "4";
            else
                label3.Text = label3.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "5";
            else
                label3.Text = label3.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "6";
            else
                label3.Text = label3.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "7";
            else
                label3.Text = label3.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "8";
            else
                label3.Text = label3.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = label1.Text + "9";
            else
                label3.Text = label3.Text + "9";
        }
        // Sayı tanımlamaları sonu //

        // CE - Bulunduğu Label'i silme tuşu//
        private void button2_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
                label1.Text = "";
            else
                label3.Text = "";
        }
         //CE- Bulunduğu Label'i silme tuşu//

        // İşlem Tanımlamaları Başlangıcı// Label2'yi işlemleri tanımlamak için kullandım. Label'3 e geçmesi için sayacı 1 arttırdım.
        // 
        private void button4_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "*";
                sayac1++;
            }
        }

        private void button13_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "+";
                sayac1++;
            }
        }

        private void button18_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "-";
                sayac1++;
            }
        }

        private void button19_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "÷";
                sayac1++;
            }
        }
        private void button20_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                label2.Text = "POW";
                sayac1++;
            }
        }

        private void button22_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                label2.Text = "MOD";
                sayac1++;
            }
        }

        private void button21_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "EBOB";
                sayac1++;
            }
        }

        private void button23_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "EKOK";
                sayac1++;
            }
        }

        private void button24_Click(object sender, EventArgs e) // 201104030
        {
            if (label1.Text == "")
            {
                MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                label2.Text = "√";
            }
        }

        private void button8_Click(object sender, EventArgs e) // 201104030
        {
            try
            {
                double sayi1 = Convert.ToDouble(label1.Text);
                if (label1.Text == "")
                {
                    MessageBox.Show("İlk sayı girilmeden işlem girilmez", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    sayi1 = sayi1 * -1;
                    label1.Text = Convert.ToString(sayi1);
                }
            }
            catch (FormatException) // Hataları önlemek için catch'ten destek aldım
            {
                MessageBox.Show("Eğer bir sayı girmediysen onu negatif yapamazsın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // İşlem tanımlamaları sonu //

        // Virgül tanımlaması başlangıcı // Normal hesap makinelerinde virgül tuşuna basınca direkt olarak başa sıfır koyuyordu. //
        // Onu örnek alarak düzenledim. //
        private void button17_Click(object sender, EventArgs e) // 201104030
        {
            if (sayac1 == 0)
            {
                if (label1.Text == "") label1.Text = "0,";
                else label1.Text = label1.Text + ",";
            }
            else 
            {
                if (label3.Text == "") label3.Text = "0,";
                else label3.Text = label3.Text + ",";
            }
        }

        // virgül tanımlaması sonu//

        // Eşittir butonu başlangıcı // Karekök işlemlerinde label3'ü kullanmayacağımız için onu dışarıda tuttum harici tüm işlemlerde normal bir şekilde kullandım  \\
        // Try-Catch işlemi ile hataları önledim \\
        private void button25_Click(object sender, EventArgs e) 
        {
            if (label2.Text != "√")
            {
                try
                {
                    double sayi1 = Convert.ToDouble(label1.Text); // 201104030
                    double sayi2 = Convert.ToDouble(label3.Text); // 201104030
                    double sonuc = 0;
                    if (label2.Text == "+") // Toplamı işlemi kodu
                    {
                        sonuc = sayi1 + sayi2;
                        label4.Text = "= " + sonuc;
                        dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                        sayac2++;
                        sayac1 = 0;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                    }
                    else if (label2.Text == "-") // Çıkarma işlemi kodu // 201104030
                    {
                        sonuc = sayi1 - sayi2;
                        label4.Text = "= " + sonuc;
                        dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                        sayac2++;
                        sayac1 = 0;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                    }
                    else if (label2.Text == "*") // Çarpma işlemi kodu // 201104030
                    {
                        sonuc = sayi1 * sayi2;
                        label4.Text = "= " + sonuc;
                        dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                        sayac2++;
                        sayac1 = 0;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                    }
                    else if (label2.Text == "÷") // Bölme işlemi kodu // 201104030
                    {
                        if (label3.Text == "0")
                        {
                            label4.Text = "= ∞";
                            dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                            sayac2++;
                            sayac1 = 0;
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                            label4.Text = "= " + sonuc;
                            dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                            sayac2++;
                            sayac1 = 0;
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                        }
                    }
                    else if (label2.Text == "POW") // Üs alma kodu // 201104030
                    {
                        sonuc = Math.Pow(sayi1, sayi2);
                        label4.Text = "= " + sonuc;
                        dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                        sayac2++;
                        sayac1 = 0;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                    }
                    else if (label2.Text == "EBOB") // Ebob alma kodu // 201104030
                    {
                        for (int i = 1; i < sayi1; i++)
                        {
                            if (sayi1 % i == 0 && sayi2 % i == 0)
                            {
                                sonuc = i;
                            }
                        }
                        if (sonuc == 0)
                        {
                            MessageBox.Show("Ebob işleminde virgüllü sayıları hesaplayamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "HATA!!";
                            sayac1 = 0;

                        }
                        else
                        {
                            label4.Text = "= " + sonuc;
                            dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                            sayac2++;
                            sayac1 = 0;
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                        }
                    }
                    else if (label2.Text == "EKOK") // Ekok  alma kodu // 201104030
                    {
                        double max = sayi1 * sayi2;
                        int i = Convert.ToInt32(max);
                 
                        for (int j = i; j > 0; j--)
                        {
                            if (j % sayi1 == 0 && j % sayi2 == 0)
                            {
                                sonuc = j;
                            }
                        }
                        if (sonuc==0)
                        {
                            MessageBox.Show("Ekok işleminde virgüllü sayıları hesaplayamazsınız!","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                            label4.Text = "HATA!!";
                            sayac1 = 0;

                        }
                        else
                        {
                            label4.Text = "= " + sonuc;
                            dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                            sayac2++;
                            sayac1 = 0;
                            label1.Text = "";
                            label2.Text = "";
                            label3.Text = "";
                        }
                    }
                    else if (label2.Text == "MOD") // Mod alma kodu // 201104030
                    {
                        sonuc = sayi1 % sayi2;
                        label4.Text = "= " + sonuc;
                        dizi[sayac2] = label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text;
                        sayac2++;
                        sayac1 = 0;
                        label1.Text = "";
                        label2.Text = "";
                        label3.Text = "";
                    }
                }
                catch (System.FormatException)
                {
                    if (label1.Text == "") MessageBox.Show("Birinci sayı girilmedi.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);        // Label 1 boşken E tuşuna basılırsa hata veriyor // 201104030
                    else if (label2.Text == "") MessageBox.Show("İşlem girilmedi.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);          // Label 2 boşken E tuşuna basılırsa hata veriyor // 201104030
                    else if (label3.Text == "") MessageBox.Show("İkinci sayı girilmedi.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);    // Label 3 boşken E tuşuna basılırsa hata veriyor // 201104030
                }
            }
            else // Karekök alma kodu (Sadece label 1 alınıyor) // 201104030
            {
                double sayi1 = Convert.ToDouble(label1.Text);
                double sonuc = Math.Sqrt(sayi1);
                label4.Text = "= " + sonuc;
                dizi[sayac2] = label1.Text + " " + label2.Text + " " + label4.Text;
                sayac2++;
                sayac1 = 0;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }

        }

        // Tüm labelleri Silme Tuşu olan C tuşu \\ // 201104030
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "= ";
            sayac1 = 0;
        }

        // Tüm labelleri yok eden c tuşu son \\ // 201104030

        // Göster başlangıç // Geçmişi kere yeniledikten sonra hata verecekti. Aynı geçmişi bir daha yazdıracaktı. Onu if - else ile önledim.
        // Label6 yani eğer geçmiş listesi doluysa önce siliyor sonra tekrar for döngüsüne giriyor. Boşsa direk yazdırıyor. \\

        private void button26_Click(object sender, EventArgs e)
        {
            if (label6.Text != "")
            {
                label6.Text = "";
                for (int i = 0; i < sayac2; i++)
                {
                    label6.Text = label6.Text + "\n" + dizi[i];
                }
            }
            else
            {
                for (int i = 0; i < sayac2; i++)
                {
                    label6.Text = label6.Text + "\n" + dizi[i];
                }
            }
        }

        // Göster butonu son \\

        // Tek - tek silme başlangıç. Eğer label'in içi boşsa ArgumentOutOfRangeException Hatası vericekti. Try - Catch kullandım.

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac1 == 0)
                    label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

                else 
                    label3.Text = label3.Text.Substring(0, label3.Text.Length - 1);
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bir sayı yokken silemezsin.","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        // Tek - tek silme sonu.
    }
}