using System.Drawing.Drawing2D;

namespace _4lü_işlemeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            panelHesapMakinesi.Visible = false;
            panelCarpimTablosu.Visible = false;
            panelAsalSayi.Visible = false;
            panelFaktoriyel.Visible = false;
            panelSayiTahmin.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    panelHesapMakinesi.Visible = true;
                    break;
                case 1:  
                    panelCarpimTablosu.Visible = true;
                    break;
                case 2:
                    panelSayiTahmin.Visible = true;
                    break;
                case 3:
                    panelAsalSayi.Visible = true;
                    break;
                case 4:
                    panelFaktoriyel.Visible = true;
                    break;


            }
        }

        private void İslemYap(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            double sayi1, sayi2, sonuc;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            switch (btn.Text)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 == 0)
                    {
                        labelSonuc.Text = "0'a bölünemez!";
                        return;
                    }
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    labelSonuc.Text = "Bilinmeyen işlem!";
                    return;
            }

            labelSonuc.Text = "Sonuç: " + sonuc.ToString();
        }
        private void buttonCarp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add($"{i} x {j} = {i * j}");

                }
                listBox1.Items.Add("-------------------------------");
            }
        }
        private void buttonKontrol_Click(object sender, EventArgs e)
        {

            int sayi;
            bool asalMi = true;

            if (int.TryParse(textBoxAsal.Text, out sayi))
            {
                if (sayi < 2)
                {
                    labelSonuccc.Text = "Asal sayı değil!";
                    return;
                }

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break; 
                    }
                }

                if (asalMi)
                    labelSonuccc.Text = $"{sayi} asal.";
                else
                    labelSonuccc.Text = $"{sayi} asal değil.";
            }
            else
            {
                labelSonuccc.Text = "Lütfen geçerli bir sayı girin!";
            }
        }
        private void buttonFaktoriyel_Click(object sender, EventArgs e)
        {
            int sayi;
            long faktoriyel = 1; 

            if (int.TryParse(textBoxFaktoriyel.Text, out sayi))
            {
                if (sayi < 0)
                {
                    labelFaktoriyelSonuc.Text = "Negatif sayıların faktöriyeli yok!";
                    return;
                }

                if (sayi > 20)
                {
                    labelFaktoriyelSonuc.Text = "Düşük sayı gir";
                    return;
                }

                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }

                labelFaktoriyelSonuc.Text = $"{sayi}! = {faktoriyel}";
            }
            else
            {
                labelFaktoriyelSonuc.Text = "Lütfen geçerli bir sayı girin!";
            }
        }
        // sayı tahmin oyunu

        Random rastgele = new Random(); 
        int hedefSayi;                   
        int denemeSayisi;                

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            hedefSayi = rastgele.Next(1, 101); 
            denemeSayisi = 0;
            labelDurumm.Text = "Sayı belirlendi! Tahmininizi girin.";
            textBoxTahmin.Text = "";
        }

        private void buttonTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin;
            if (!int.TryParse(textBoxTahmin.Text, out tahmin))
            {
                labelDurumm.Text = "Lütfen geçerli bir sayı girin!";
                return;
            }

            denemeSayisi++;

            bool bildiMi = false;
            while (!bildiMi)
            {
                if (tahmin < hedefSayi)
                {
                    labelDurumm.Text = "Daha büyük bir sayı girin!";
                    break;
                }
                else if (tahmin > hedefSayi)
                {
                    labelDurumm.Text = "Daha küçük bir sayı girin!";
                    break;
                }
                else
                {
                    labelDurumm.Text = $"Tebrikler! {denemeSayisi}. denemede bildiniz!";
                    bildiMi = true;
                    break;
                }
            }

            textBoxTahmin.Clear();
            textBoxTahmin.Focus();
        }


    }
}
