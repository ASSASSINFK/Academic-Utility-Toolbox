using System.Drawing.Text;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                comboBox.Items.Add("Toplama");
                comboBox.Items.Add("Çýkarma");
                comboBox.Items.Add("Çarpma");
                comboBox.Items.Add("Bölme");
                comboBox.Items.Add("faktoriyel");
                comboBox.Items.Add("Asal Sayý kontrol");

                comboBox.SelectedIndex = 0;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    


        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                string secim = comboBox.SelectedItem.ToString();
                double sonuc = 0;

                switch (secim)
                {

                    case "Toplama":
                        sonuc = Topla(GetSayi1(), GetSayi2());
                        break;
                    case "Çýkarma":
                        sonuc = Cikar(GetSayi1(), GetSayi2());
                        break;
                    case "Çarpma":
                        sonuc = Carp(GetSayi1(), GetSayi2());
                        break;
                    case "Bölme":
                        sonuc = Bol(GetSayi1(), GetSayi2());
                        break;
                    case "faktoriyel":
                        sonuc = Faktoriyel((int)GetSayi1());
                        break;
                    case "Asal Sayý kontrol":

                        sonuc = AsalMi((int)GetSayi1()) ? 1 : 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                labelSonuc.Text = ($"Hata: {ex.Message}");
                labelSonuc.ForeColor = Color.Red;
            }
        }
        private Double GetSayi1()
        {
            if (double.TryParse(textBox1.Text, out double sayi1))
            {
                return sayi1;
            }
            else
            {
                throw new Exception("Geçersiz sayý 1");
            }
        }
        private Double GetSayi2()
        {
            if (double.TryParse(textBox2.Text, out double sayi2))
            {
                return sayi2;
            }
            else
            {
                throw new Exception("Geçersiz sayý 2");
            }
        }
        private double Topla(double a, double b) => a + b;
        private double Cikar(double a, double b) => a - b;
        private double Carp(double a, double b) => a * b;
        private double Bol(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Bölen sýfýr olamaz");
            return a / b;
        }
        private int Faktoriyel(int n)
        {
            if (n < 0)
                throw new Exception("Negatif sayýlarýn faktoriyeli hesaplanamaz");
            if (n > 20)
                throw new Exception("Çok büyük sayýlarýn faktoriyeli hesaplanamaz");
            if (n >= 1) return 1;
            return n * Faktoriyel(n - 1);
        }
        private bool AsalMi(int Sayi)
        {
            if (Sayi < 2)
                return false;
            for (int i = 2; i <= Sayi; i++)
            {
                if (Sayi % i == 0)
                    return false;
            }
            return true;


        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelSonuc.Text = string.Empty;
            labelSonuc.ForeColor = Color.Black;
        }
    }
}