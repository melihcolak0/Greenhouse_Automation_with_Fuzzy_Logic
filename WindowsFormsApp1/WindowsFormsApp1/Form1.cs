using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        // Melih Çolak (203302057) Bulanık Kontrol Yöntemiyle Sera Otomasyonu Kısmi Simülasyonu


        // Sıcaklık ve Hava nemi değişkenlerinin globalleştirilmesi.
        public string a; // TextBox 1'den okunan sıcaklık değeri öncelikle bir string değişkenine (string a) aktarılır. 
        public double sicaklik; // String türündeki a değişkeni double türündeki sicaklik değişkenine aktarılır.
        public double sicaklik_2; // Sıcaklığın "Çok Düşük" değeri için yardımcı değişken.
        public double sicaklik_3; // Sıcaklığın "Düşük" değeri için yardımcı değişken.
        public double sicaklik_4; // Sıcaklığın "Orta" değeri için yardımcı değişken.
        public double sicaklik_5; // Sıcaklığın "Yüksek" değeri için yardımcı değişken.
        public double sicaklik_6; // Sıcaklığın "Çok Düşük" değeri için yardımcı değişken.
        public double i_1; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double i_2; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double i_3; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double i_4; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double i_5; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.

        public string b; // TextBox 2'den okunan hava nemi değeri öncelikle bir string değişkenine (string b) aktarılır.
        public double hava_nemi; // String türündeki b değişkeni double türündeki hava_nemi değişkenine aktarılır.
        public double hava_nemi_2; // Hava neminin "Çok Düşük" için yardımcı değişken.
        public double hava_nemi_3; // Hava neminin "Düşük" için yardımcı değişken.
        public double hava_nemi_4; // Hava neminin "Orta" için yardımcı değişken.
        public double hava_nemi_5; // Hava neminin "Yüksek" için yardımcı değişken.
        public double hava_nemi_6; // Hava neminin "Çok Yüksekk" için yardımcı değişken.
        public double j_1; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double j_2; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double j_3; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double j_4; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.
        public double j_5; // Girişlerin üyelik değerlerini kural tabanına aktarmak için kullanılan değişkenler.

        public double a_1; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_2; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_3; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_4; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_5; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_6; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_7; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_8; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_9; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_10; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_11; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken. 
        public double a_12; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_13; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_14; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_15; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_16; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_17; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_18; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_19; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_20; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_21; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_22; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_23; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_24; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.
        public double a_25; // Sıcaklık ve Hava Nemi değerlerinin kural tabanı için minimum işlemi uygulanması sonucu aktarıldığı değişken.

        public double pay;    //Ağırlıklı Ortalama İşleminin Payı
        public double payda;  //Ağırlıklı Ortalama İşleminin Paydası
        public double islem;  //Ağırlıklı Ortalama İşlemi Sonucu

        public double cok_dusuk; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double cok_dusuk_2; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double dusuk; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double dusuk_2; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double orta; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler. 
        public double orta_2; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double yuksek; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double yuksek_2; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double cok_yuksek; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.
        public double cok_yuksek_2; // Ağırlıklı ortalama sonucunu sınıflandırmak için kullanılan değişkenler.

        public double i_1_1; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double i_1_2; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double i_1_3; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double i_1_4; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler

        public double i_1_1_1; // Sıcaklık sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double i_1_1_2; // Sıcaklık sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double i_1_1_3; // Sıcaklık sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double i_1_1_4; // Sıcaklık sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double i_1_1_5; // Sıcaklık sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.

        public double j_1_1; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double j_1_2; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double j_1_3; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler
        public double j_1_4; //Chart üzerine iki değişkenden büyük olanı çizdirmek için kullanılan değişkenler

        public double j_1_1_1; // Hava Nemi sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double j_1_1_2; // Hava Nemi sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double j_1_1_3; // Hava Nemi sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double j_1_1_4; // Hava Nemi sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.
        public double j_1_1_5; // Hava Nemi sınıflandırmalarını Chart üzerinde göstermek için kullanılan değişken.

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e) // Uygulanan Kurallar formunu açmak için kullanılan buton.
        {
            Uygulanan_Kurallar form2 = new Uygulanan_Kurallar();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // Programı Kapat butonu ve ardından açılan MessageBox.
        {
            DialogResult result1 = MessageBox.Show("Programı kapatmaya emin misin?", "Programdan Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }

        // Sıfırlama Butonu (Restart)
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e) //Isıtma çıkışı için kural tabanının kullanılması.
        {
            a = textBox1.Text;
            double sicaklik = Convert.ToDouble(a);

            b = textBox2.Text;
            double hava_nemi = Convert.ToDouble(b);

            if (sicaklik < -10 | sicaklik > 50) // Değişken sınır kontrolü.
            {
                DialogResult result3 = MessageBox.Show("Sıcaklık değişkeni -10 ve 50 arasında değer alabilir. Lütfen sıcaklık değerini tekrar giriniz!", "Değişken Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result3 == DialogResult.OK)
                {
                    textBox1.Clear();
                }

            }
            if (hava_nemi < 0 | hava_nemi > 100) // Değişken sınır kontrolü.
            {
                DialogResult result3 = MessageBox.Show("Hava Nemi değişkeni 0 ve 100 arasında değer alabilir. Lütfen hava nemi değerini tekrar giriniz!", "Değişken Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result3 == DialogResult.OK)
                {
                    textBox2.Clear();
                }
            }
                       
            // Sıcaklık Değişkeninin Sınıflandırılması

            //--------Sıcaklık (Çok Düşük)--------
            label7.Text = sicaklik.ToString();
            if (sicaklik >= -10 & sicaklik <= 0)
            {
                label7.Text = "1";
            }
            else if (sicaklik >= 0 & sicaklik <= 10)
            {
                sicaklik_2 = (10 - sicaklik) / 10;
                label7.Text = sicaklik_2.ToString();
            }
            else if (sicaklik > 10 | sicaklik < -10)
            {
                label7.Text = "0";
            }

            //--------Sıcaklık (Düşük)--------
            label13.Text = sicaklik.ToString();
            if (sicaklik < 0 | sicaklik > 15)
            {
                label13.Text = "0";
            }
            else if (sicaklik >= 0 & sicaklik <= 7.5)
            {
                sicaklik_3 = sicaklik / 7.5;
                label13.Text = sicaklik_3.ToString();
            }
            else if (sicaklik >= 7.5 & sicaklik <= 15)
            {
                sicaklik_3 = (15 - sicaklik) / 7.5;
                label13.Text = sicaklik_3.ToString();
            }

            //--------Sıcaklık (Orta)--------      
            label16.Text = sicaklik.ToString();
            if (sicaklik < 14 | sicaklik > 26)
            {
                label16.Text = "0";
            }
            else if (sicaklik >= 14 & sicaklik <= 20)
            {
                sicaklik_4 = (sicaklik - 14) / 6;
                label16.Text = sicaklik_4.ToString();
            }
            else if (sicaklik >= 20 & sicaklik <= 26)
            {
                sicaklik_4 = (26 - sicaklik) / 6;
                label16.Text = sicaklik_4.ToString();
            }

            //--------Sıcaklık (Yüksek)--------
            label15.Text = sicaklik.ToString();
            if (sicaklik < 20 | sicaklik > 40)
            {
                label15.Text = "0";
            }
            else if (sicaklik >= 20 & sicaklik <= 30)
            {
                sicaklik_5 = (sicaklik - 20) / 10;
                label15.Text = sicaklik_5.ToString();
            }
            else if (sicaklik >= 30 & sicaklik <= 40)
            {
                sicaklik_5 = (40 - sicaklik) / 10;
                label15.Text = sicaklik_5.ToString();
            }

            //--------Sıcaklık (Çok Yüksek)--------
            label14.Text = sicaklik.ToString();
            if (sicaklik < 30 | sicaklik > 50)
            {
                label14.Text = "0";
            }
            else if (sicaklik >= 30 & sicaklik <= 40)
            {
                sicaklik_6 = (sicaklik - 30) / 10;
                label14.Text = sicaklik_6.ToString();
            }
            else if (sicaklik >= 40 & sicaklik <= 50)
            {
                label14.Text = "1";
            }

            i_1 = Convert.ToDouble(label7.Text);   //Çok Düşük
            i_2 = Convert.ToDouble(label13.Text);  //Düşük
            i_3 = Convert.ToDouble(label16.Text);  //Orta
            i_4 = Convert.ToDouble(label15.Text);  //Yüksek
            i_5 = Convert.ToDouble(label14.Text);  //Çok Yüksek

            i_1_1_1 = Convert.ToDouble(label7.Text);
            i_1_1_2 = Convert.ToDouble(label13.Text);
            i_1_1_3 = Convert.ToDouble(label16.Text);
            i_1_1_4 = Convert.ToDouble(label15.Text);
            i_1_1_5 = Convert.ToDouble(label14.Text);

            // Chart Üzzerinde Sıcaklık Değerlerini Gösterme

            if (i_1_1_1 != 0 & i_1_1_2 != 0) //Çok Düşük ve Düşük != 0 ise
            {
                for (i_1_1 = Math.Max(i_1_1_1, i_1_1_2); i_1_1 >= 0; i_1_1 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1);
                }
            }
            if (i_1_1_2 != 0 & i_1_1_3 != 0) //Düşük ve Orta != 0 ise
            {
                for (i_1_2 = Math.Max(i_1_1_2, i_1_1_3); i_1_2 >= 0; i_1_2 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_2);
                }
            }
            if (i_1_1_3 != 0 & i_1_1_4 != 0) //Orta ve Yüksek != 0 ise
            {
                for (i_1_3 = Math.Max(i_1_1_3, i_1_1_4); i_1_3 >= 0; i_1_3 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_3);
                }
            }
            if (i_1_1_4 != 0 & i_1_1_5 != 0) //Yüksek ve Çok Yüksek != 0 ise
            {
                for (i_1_4 = Math.Max(i_1_1_4, i_1_1_5); i_1_4 >= 0; i_1_4 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_4);
                }
            }
            if (i_1_1_1 != 0) //Sadece Çok Düşük != 0 ise 
            {
                for (i_1_1_1 = Convert.ToDouble(label7.Text); i_1_1_1 >= 0; i_1_1_1 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1_1);
                }
            }
            if (i_1_1_2 != 0) //Sadece Düşük != 0 ise
            {
                for (i_1_1_2 = Convert.ToDouble(label13.Text); i_1_1_2 >= 0; i_1_1_2 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1_2);
                }
            }
            if (i_1_1_3 != 0) //Sadece Orta != 0 ise
            {
                for (i_1_1_3 = Convert.ToDouble(label16.Text); i_1_1_3 >= 0; i_1_1_3 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1_3);
                }
            }
            if (i_1_1_4 != 0) //Sadece Yüksek != 0 ise
            {
                for (i_1_1_4 = Convert.ToDouble(label15.Text); i_1_1_4 >= 0; i_1_1_4 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1_4);
                }
            }
            if (i_1_1_5 != 0) //Sadece Çok Yüksek != 0 ise
            {
                for (i_1_1_5 = Convert.ToDouble(label14.Text); i_1_1_5 >= 0; i_1_1_5 -= 0.07)
                {
                    this.chart1.Series["Sıcaklık"].Points.AddXY(sicaklik, i_1_1_5);
                }
            }

            // Hava Nemi Değişkeninin Sınıflandırlıması

            //--------Hava Nemi (Çok Düşük)--------
            label17.Text = hava_nemi.ToString();
            if (hava_nemi >= 0 & hava_nemi <= 20)
            {
                label17.Text = "1";
            }
            else if (hava_nemi >= 20 & hava_nemi <= 40)
            {
                hava_nemi_2 = (40 - hava_nemi) / 20;
                label17.Text = hava_nemi_2.ToString();
            }
            else if (hava_nemi > 40 | hava_nemi < 0)
            {
                label17.Text = "0";
            }

            //--------Hava Nemi (Düşük)--------
            label24.Text = hava_nemi.ToString();
            if (hava_nemi > 59 | hava_nemi < 20)
            {
                label24.Text = "0";
            }
            else if (hava_nemi >= 20 & hava_nemi <= 39.5)
            {
                hava_nemi_3 = (hava_nemi - 20) / 19.5;
                label24.Text = hava_nemi_3.ToString();
            }
            else if (hava_nemi >= 39.5 & hava_nemi <= 59)
            {
                hava_nemi_3 = (59 - hava_nemi) / 19.5;
                label24.Text = hava_nemi_3.ToString();
            }

            //--------Hava Nemi (Orta)--------
            label25.Text = hava_nemi.ToString();
            if (hava_nemi > 70 | hava_nemi < 50)
            {
                label25.Text = "0";
            }
            else if (hava_nemi >= 50 & hava_nemi <= 60)
            {
                hava_nemi_4 = (hava_nemi - 50) / 10;
                label25.Text = hava_nemi_4.ToString();
            }
            else if (hava_nemi >= 60 & hava_nemi <= 70)
            {
                hava_nemi_4 = (70 - hava_nemi) / 10;
                label25.Text = hava_nemi_4.ToString();
            }

            //--------Hava Nemi (Yüksek)--------
            label26.Text = hava_nemi.ToString();
            if (hava_nemi > 90 | hava_nemi < 60)
            {
                label26.Text = "0";
            }
            else if (hava_nemi >= 60 & hava_nemi <= 75)
            {
                hava_nemi_5 = (hava_nemi - 60) / 15;
                label26.Text = hava_nemi_5.ToString();
            }
            else if (hava_nemi >= 75 & hava_nemi <= 90)
            {
                hava_nemi_5 = (90 - hava_nemi) / 15;
                label26.Text = hava_nemi_5.ToString();
            }

            //--------Hava Nemi (Çok Yüksek)--------
            label23.Text = hava_nemi.ToString();
            if (hava_nemi > 100 | hava_nemi < 80)
            {
                label23.Text = "0";
            }
            else if (hava_nemi >= 80 & hava_nemi <= 90)
            {
                hava_nemi_6 = (hava_nemi - 80) / 10;
                label23.Text = hava_nemi_6.ToString();
            }
            else if (hava_nemi >= 90 & hava_nemi <= 100)
            {
                label23.Text = "1";
            }

            j_1 = Convert.ToDouble(label17.Text);   //Çok Düşük
            j_2 = Convert.ToDouble(label24.Text);   //Düşük
            j_3 = Convert.ToDouble(label25.Text);   //Orta
            j_4 = Convert.ToDouble(label26.Text);   //Yüksek
            j_5 = Convert.ToDouble(label23.Text);   //Çok Yüksek

            j_1_1_1 = Convert.ToDouble(label17.Text);
            j_1_1_2 = Convert.ToDouble(label24.Text);
            j_1_1_3 = Convert.ToDouble(label25.Text);
            j_1_1_4 = Convert.ToDouble(label26.Text);
            j_1_1_5 = Convert.ToDouble(label23.Text);

            // Chart Üzerinde Hava Nemi Değerlerini Gösterme

            if (j_1_1_1 != 0 & j_1_1_2 != 0) //Çok Düşük ve Düşük != 0 ise
            {
                for (j_1_1 = Math.Max(j_1_1_1, j_1_1_2); j_1_1 >= 0; j_1_1 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1);
                }
            }
            if (j_1_1_2 != 0 & j_1_1_3 != 0) //Düşük ve Orta != 0 ise
            {
                for (j_1_2 = Math.Max(j_1_1_2, j_1_1_3); j_1_2 >= 0; j_1_2 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_2);
                }
            }
            if (j_1_1_3 != 0 & j_1_1_4 != 0) //Orta ve Yüksek != 0 ise
            {
                for (j_1_3 = Math.Max(j_1_1_3, j_1_1_4); j_1_3 >= 0; j_1_3 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_3);
                }
            }
            if (j_1_1_4 != 0 & j_1_1_5 != 0) //Yüksek ve Çok Yüksek != 0 ise
            {
                for (j_1_4 = Math.Max(j_1_1_4, j_1_1_5); j_1_4 >= 0; j_1_4 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_4);
                }
            }
            if (j_1_1_1 != 0) //Sadece Çok Düşük != 0 ise 
            {
                for (j_1_1_1 = Convert.ToDouble(label17.Text); j_1_1_1 >= 0; j_1_1_1 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1_1);
                }
            }
            if (j_1_1_2 != 0) //Sadece Düşük != 0 ise
            {
                for (j_1_1_2 = Convert.ToDouble(label24.Text); j_1_1_2 >= 0; j_1_1_2 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1_2);
                }
            }
            if (j_1_1_3 != 0) //Sadece Orta != 0 ise
            {
                for (j_1_1_3 = Convert.ToDouble(label25.Text); j_1_1_3 >= 0; j_1_1_3 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1_3);
                }
            }
            if (j_1_1_4 != 0) //Sadece Yüksek != 0 ise
            {
                for (j_1_1_4 = Convert.ToDouble(label26.Text); j_1_1_4 >= 0; j_1_1_4 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1_4);
                }
            }
            if (j_1_1_5 != 0) //Sadece Çok Yüksek != 0 ise
            {
                for (j_1_1_5 = Convert.ToDouble(label23.Text); j_1_1_5 >= 0; j_1_1_5 -= 0.07)
                {
                    this.chart2.Series["Hava Nemi"].Points.AddXY(hava_nemi, j_1_1_5);
                }
            }


        }

        // Kural Tabanı Uygulanması
        private void button5_Click(object sender, EventArgs e)
        {
            a_1 = Math.Min(i_1, j_1);
            if (a_1 == 0)
            {
                label46.Text = "-";
            }
            else
            {
                label46.Text = a_1.ToString();
            }
            a_2 = Math.Min(i_1, j_2);
            if (a_2 == 0)
            {
                label47.Text = "-";
            }
            else
            {
                label47.Text = a_2.ToString();
            }
            a_3 = Math.Min(i_1, j_3);
            if (a_3 == 0)
            {
                label48.Text = "-";
            }
            else
            {
                label48.Text = a_3.ToString();
            }
            a_4 = Math.Min(i_1, j_4);
            if (a_4 == 0)
            {
                label49.Text = "-";
            }
            else
            {
                label49.Text = a_4.ToString();
            }
            a_5 = Math.Min(i_1, j_5);
            if (a_5 == 0)
            {
                label72.Text = "-";
            }
            else
            {
                label72.Text = a_5.ToString();
            }
            a_6 = Math.Min(i_2, j_1);
            if (a_6 == 0)
            {
                label50.Text = "-";
            }
            else
            {
                label50.Text = a_6.ToString();
            }
            a_7 = Math.Min(i_2, j_2);
            if (a_7 == 0)
            {
                label51.Text = "-";
            }
            else
            {
                label51.Text = a_7.ToString();
            }
            a_8 = Math.Min(i_2, j_3);
            if (a_8 == 0)
            {
                label52.Text = "-";
            }
            else
            {
                label52.Text = a_8.ToString();
            }
            a_9 = Math.Min(i_2, j_4);
            if (a_9 == 0)
            {
                label53.Text = "-";
            }
            else
            {
                label53.Text = a_9.ToString();
            }
            a_10 = Math.Min(i_2, j_5);
            if (a_10 == 0)
            {
                label54.Text = "-";
            }
            else
            {
                label54.Text = a_10.ToString();
            }
            a_11 = Math.Min(i_3, j_1);
            if (a_11 == 0)
            {
                label55.Text = "-";
            }
            else
            {
                label55.Text = a_11.ToString();
            }
            a_12 = Math.Min(i_3, j_2);
            if (a_12 == 0)
            {
                label56.Text = "-";
            }
            else
            {
                label56.Text = a_12.ToString();
            }
            a_13 = Math.Min(i_3, j_3);
            if (a_13 == 0)
            {
                label57.Text = "-";
            }
            else
            {
                label57.Text = a_13.ToString();
            }
            a_14 = Math.Min(i_3, j_4);
            if (a_14 == 0)
            {
                label58.Text = "-";
            }
            else
            {
                label58.Text = a_14.ToString();
            }
            a_15 = Math.Min(i_3, j_5);
            if (a_15 == 0)
            {
                label59.Text = "-";
            }
            else
            {
                label59.Text = a_15.ToString();
            }
            a_16 = Math.Min(i_4, j_1);
            if (a_16 == 0)
            {
                label60.Text = "-";
            }
            else
            {
                label60.Text = a_16.ToString();
            }
            a_17 = Math.Min(i_4, j_2);
            if (a_17 == 0)
            {
                label61.Text = "-";
            }
            else
            {
                label61.Text = a_17.ToString();
            }
            a_18 = Math.Min(i_4, j_3);
            if (a_18 == 0)
            {
                label66.Text = "-";
            }
            else
            {
                label66.Text = a_18.ToString();
            }
            a_19 = Math.Min(i_4, j_4);
            if (a_19 == 0)
            {
                label63.Text = "-";
            }
            else
            {
                label63.Text = a_19.ToString();
            }
            a_20 = Math.Min(i_4, j_5);
            if (a_20 == 0)
            {
                label62.Text = "-";
            }
            else
            {
                label62.Text = a_20.ToString();
            }
            a_21 = Math.Min(i_5, j_1);
            if (a_21 == 0)
            {
                label64.Text = "-";
            }
            else
            {
                label64.Text = a_21.ToString();
            }
            a_22 = Math.Min(i_5, j_2);
            if (a_22 == 0)
            {
                label65.Text = "-";
            }
            else
            {
                label65.Text = a_22.ToString();
            }
            a_23 = Math.Min(i_5, j_3);
            if (a_23 == 0)
            {
                label70.Text = "-";
            }
            else
            {
                label70.Text = a_23.ToString();
            }
            a_24 = Math.Min(i_5, j_4);
            if (a_24 == 0)
            {
                label71.Text = "-";
            }
            else
            {
                label71.Text = a_24.ToString();
            }
            a_25 = Math.Min(i_5, j_5);
            if (a_25 == 0)
            {
                label69.Text = "-";
            }
            else
            {
                label69.Text = a_25.ToString();
            }
        }

        // Ağırlıklı Ortalama İşlemi
        private void button6_Click(object sender, EventArgs e)
        {
            pay = (a_1 * 5.25) + (a_2 * 5.25) + (a_3 * 4.25) + (a_4 * 4.25) + (a_5 * 4.25) + (a_6 * 4.25) + (a_7 * 4.25) + (a_8 * 4.25) + (a_9 * 3) + (a_10 * 3) + (a_11 * 3) + (a_12 * 3) + (a_13 * 3) + (a_14 * 3) + (a_15 * 1.5) + (a_16 * 1.5) + (a_17 * 1.5) + (a_18 * 1.5) + (a_19 * 1.5) + (a_20 * 1.5) + (a_21 * 0.5) + (a_22 * 0.5) + (a_23 * 0.5) + (a_24 * 0.5) + (a_25 * 0.5);
            payda = (a_1 + a_2 + a_3 + a_4 + a_5 + a_6 + a_7 + a_8 + a_9 + a_10 + a_11 + a_12 + a_13 + a_14 + a_15 + a_16 + a_17 + a_18 + a_19 + a_20 + a_21 + a_22 + a_23 + a_24 + a_25);
            islem = pay / payda;
            label73.Text = islem.ToString();
        }

        // Ağırlıklı Ortalama İşleminin Sınıflandırılması
        private void button7_Click(object sender, EventArgs e)
        {
            // Çok Düşük
            if (islem <= 1 & islem >= 0)
            {
                if (islem <= 0.5 & islem >= 0)
                {
                    cok_dusuk = 1;
                    cok_dusuk_2 = cok_dusuk * 100;
                    label75.Text = cok_dusuk_2.ToString();
                }
                if (islem <= 1 & islem >= 0.5)
                {
                    cok_dusuk = (1 - islem) / 0.5;
                    cok_dusuk_2 = cok_dusuk * 100;
                    label75.Text = cok_dusuk_2.ToString();
                }
            }
            // Düşük
            if (islem <= 3 & islem >= 0)
            {
                if (islem <= 1.5 & islem >= 0)
                {
                    dusuk = islem / 1.5;
                    dusuk_2 = dusuk * 100;
                    label76.Text = dusuk_2.ToString();
                }
                if (islem <= 3 & islem >= 1.5)
                {
                    dusuk = (3 - islem) / 1.5;
                    dusuk_2 = dusuk * 100;
                    label76.Text = dusuk_2.ToString();
                }
            }

            // Orta
            if (islem <= 4 & islem >= 2)
            {
                if (islem <= 3 & islem >= 2)
                {
                    orta = islem - 2;
                    orta_2 = orta * 100;
                    label77.Text = orta_2.ToString();
                }
                if (islem <= 4 & islem >= 3)
                {
                    orta = 4 - islem;
                    orta_2 = orta * 100;
                    label77.Text = orta_2.ToString();
                }
            }

            // Yüksek
            if (islem <= 5 & islem >= 3.5)
            {
                if (islem <= 4.25 & islem >= 3.5)
                {
                    yuksek = (islem - 3.5) / 0.75;
                    yuksek_2 = yuksek * 100;
                    label78.Text = yuksek_2.ToString();
                }
                if (islem <= 5 & islem >= 4.25)
                {
                    yuksek = (5 - islem) / 0.75;
                    yuksek_2 = yuksek * 100;
                    label78.Text = yuksek_2.ToString();
                }
            }
            // Çok Yüksek
            if (islem <= 6 & islem >= 4.5)
            {
                if (islem <= 5.25 & islem >= 4.5)
                {
                    cok_yuksek = (islem - 4.5) / 0.75;
                    cok_yuksek_2 = cok_yuksek * 100;
                    label79.Text = cok_yuksek_2.ToString();
                }
                if (islem <= 6 & islem >= 5.25)
                {
                    cok_yuksek = 1;
                    cok_yuksek_2 = 1 * 100;
                    label79.Text = cok_yuksek_2.ToString();
                }
            }

            // Chart Isıtma Değerlerini Gösterme
            if (cok_dusuk != 0)
            {
                for (islem = pay / payda; islem >= 0; islem -= 0.08)
                {
                    this.chart3.Series["Isıtma"].Points.AddXY(islem, cok_dusuk);
                }
            }
            if (dusuk != 0)
            {
                for (islem = pay / payda; islem >= 0; islem -= 0.08)
                {
                    this.chart3.Series["Isıtma"].Points.AddXY(islem, dusuk);
                }
            }
            if (orta != 0)
            {
                for (islem = pay / payda; islem >= 0; islem -= 0.08)
                {
                    this.chart3.Series["Isıtma"].Points.AddXY(islem, orta);
                }
            }
            if (yuksek != 0)
            {
                for (islem = pay / payda; islem >= 0; islem -= 0.08)
                {
                    this.chart3.Series["Isıtma"].Points.AddXY(islem, yuksek);
                }
            }
            if (cok_yuksek != 0)
            {
                for (islem = pay / payda; islem >= 0; islem -= 0.08)
                {
                    this.chart3.Series["Isıtma"].Points.AddXY(islem, cok_yuksek);
                }
            }
        }

        
    }
}
