namespace _4lü_işlemeler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            panelHesapMakinesi = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            labelSonuc = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panelFaktoriyel = new Panel();
            labelFaktoriyelSonuc = new Label();
            textBoxFaktoriyel = new TextBox();
            buttonFaktoriyel = new Button();
            panelAsalSayi = new Panel();
            labelSonuccc = new Label();
            textBoxAsal = new TextBox();
            labelSonucc = new Label();
            buttonKontrol = new Button();
            panelCarpimTablosu = new Panel();
            buttonCarp = new Button();
            listBox1 = new ListBox();
            panelSayiTahmin = new Panel();
            labelDurumm = new Label();
            textBoxTahmin = new TextBox();
            buttonTahmin = new Button();
            buttonBasla = new Button();
            panelHesapMakinesi.SuspendLayout();
            panelFaktoriyel.SuspendLayout();
            panelAsalSayi.SuspendLayout();
            panelCarpimTablosu.SuspendLayout();
            panelSayiTahmin.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HesapMakinesi ", "Çarpım Tablosu", "Sayı Tahmin Oyunu", "Asal Sayı Kontrolü", "Faktoriyel Hesaplama" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panelHesapMakinesi
            // 
            panelHesapMakinesi.BackColor = Color.FromArgb(0, 0, 64);
            panelHesapMakinesi.Controls.Add(button5);
            panelHesapMakinesi.Controls.Add(button4);
            panelHesapMakinesi.Controls.Add(button3);
            panelHesapMakinesi.Controls.Add(button2);
            panelHesapMakinesi.Controls.Add(labelSonuc);
            panelHesapMakinesi.Controls.Add(button1);
            panelHesapMakinesi.Controls.Add(textBox2);
            panelHesapMakinesi.Controls.Add(textBox1);
            panelHesapMakinesi.Location = new Point(12, 41);
            panelHesapMakinesi.Name = "panelHesapMakinesi";
            panelHesapMakinesi.Size = new Size(296, 276);
            panelHesapMakinesi.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(21, 159);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = true;
            button5.Click += İslemYap;
            // 
            // button4
            // 
            button4.Location = new Point(111, 130);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += İslemYap;
            // 
            // button3
            // 
            button3.Location = new Point(111, 159);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += İslemYap;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Location = new Point(21, 217);
            button2.Name = "button2";
            button2.Size = new Size(165, 50);
            button2.TabIndex = 4;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelSonuc
            // 
            labelSonuc.ForeColor = SystemColors.ControlLightLight;
            labelSonuc.Location = new Point(162, 42);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(99, 66);
            labelSonuc.TabIndex = 3;
            labelSonuc.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(21, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += İslemYap;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // panelFaktoriyel
            // 
            panelFaktoriyel.BackColor = Color.FromArgb(0, 0, 64);
            panelFaktoriyel.Controls.Add(labelFaktoriyelSonuc);
            panelFaktoriyel.Controls.Add(textBoxFaktoriyel);
            panelFaktoriyel.Controls.Add(buttonFaktoriyel);
            panelFaktoriyel.Location = new Point(324, 338);
            panelFaktoriyel.Name = "panelFaktoriyel";
            panelFaktoriyel.Size = new Size(313, 170);
            panelFaktoriyel.TabIndex = 3;
            // 
            // labelFaktoriyelSonuc
            // 
            labelFaktoriyelSonuc.ForeColor = SystemColors.ControlLightLight;
            labelFaktoriyelSonuc.Location = new Point(223, 57);
            labelFaktoriyelSonuc.Name = "labelFaktoriyelSonuc";
            labelFaktoriyelSonuc.Size = new Size(75, 28);
            labelFaktoriyelSonuc.TabIndex = 2;
            labelFaktoriyelSonuc.Text = "0";
            // 
            // textBoxFaktoriyel
            // 
            textBoxFaktoriyel.Location = new Point(65, 43);
            textBoxFaktoriyel.Name = "textBoxFaktoriyel";
            textBoxFaktoriyel.Size = new Size(100, 23);
            textBoxFaktoriyel.TabIndex = 1;
            // 
            // buttonFaktoriyel
            // 
            buttonFaktoriyel.BackColor = Color.Gray;
            buttonFaktoriyel.Location = new Point(223, 15);
            buttonFaktoriyel.Name = "buttonFaktoriyel";
            buttonFaktoriyel.Size = new Size(75, 23);
            buttonFaktoriyel.TabIndex = 0;
            buttonFaktoriyel.Text = "Hesapla";
            buttonFaktoriyel.UseVisualStyleBackColor = false;
            buttonFaktoriyel.Click += buttonFaktoriyel_Click;
            // 
            // panelAsalSayi
            // 
            panelAsalSayi.BackColor = Color.FromArgb(0, 0, 64);
            panelAsalSayi.Controls.Add(labelSonuccc);
            panelAsalSayi.Controls.Add(textBoxAsal);
            panelAsalSayi.Controls.Add(labelSonucc);
            panelAsalSayi.Controls.Add(buttonKontrol);
            panelAsalSayi.Location = new Point(324, 41);
            panelAsalSayi.Name = "panelAsalSayi";
            panelAsalSayi.Size = new Size(313, 276);
            panelAsalSayi.TabIndex = 3;
            // 
            // labelSonuccc
            // 
            labelSonuccc.ForeColor = SystemColors.ControlLightLight;
            labelSonuccc.Location = new Point(186, 92);
            labelSonuccc.Name = "labelSonuccc";
            labelSonuccc.Size = new Size(100, 23);
            labelSonuccc.TabIndex = 3;
            labelSonuccc.Text = "0";
            // 
            // textBoxAsal
            // 
            textBoxAsal.Location = new Point(21, 19);
            textBoxAsal.Name = "textBoxAsal";
            textBoxAsal.Size = new Size(100, 23);
            textBoxAsal.TabIndex = 2;
            // 
            // labelSonucc
            // 
            labelSonucc.AutoSize = true;
            labelSonucc.Location = new Point(223, 92);
            labelSonucc.Name = "labelSonucc";
            labelSonucc.Size = new Size(0, 15);
            labelSonucc.TabIndex = 1;
            // 
            // buttonKontrol
            // 
            buttonKontrol.BackColor = Color.Gray;
            buttonKontrol.Location = new Point(211, 45);
            buttonKontrol.Name = "buttonKontrol";
            buttonKontrol.Size = new Size(75, 23);
            buttonKontrol.TabIndex = 0;
            buttonKontrol.Text = "Kontrol Et";
            buttonKontrol.UseVisualStyleBackColor = false;
            buttonKontrol.Click += buttonKontrol_Click;
            // 
            // panelCarpimTablosu
            // 
            panelCarpimTablosu.BackColor = Color.FromArgb(0, 0, 64);
            panelCarpimTablosu.Controls.Add(buttonCarp);
            panelCarpimTablosu.Controls.Add(listBox1);
            panelCarpimTablosu.Location = new Point(653, 41);
            panelCarpimTablosu.Name = "panelCarpimTablosu";
            panelCarpimTablosu.Size = new Size(376, 467);
            panelCarpimTablosu.TabIndex = 3;
            // 
            // buttonCarp
            // 
            buttonCarp.BackColor = Color.Silver;
            buttonCarp.Location = new Point(3, 422);
            buttonCarp.Name = "buttonCarp";
            buttonCarp.Size = new Size(373, 42);
            buttonCarp.TabIndex = 2;
            buttonCarp.Text = " Hesapla";
            buttonCarp.UseVisualStyleBackColor = false;
            buttonCarp.Click += buttonCarp_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SeaGreen;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(370, 409);
            listBox1.TabIndex = 0;
            // 
            // panelSayiTahmin
            // 
            panelSayiTahmin.BackColor = Color.FromArgb(0, 0, 64);
            panelSayiTahmin.Controls.Add(labelDurumm);
            panelSayiTahmin.Controls.Add(textBoxTahmin);
            panelSayiTahmin.Controls.Add(buttonTahmin);
            panelSayiTahmin.Controls.Add(buttonBasla);
            panelSayiTahmin.Location = new Point(12, 338);
            panelSayiTahmin.Name = "panelSayiTahmin";
            panelSayiTahmin.Size = new Size(296, 170);
            panelSayiTahmin.TabIndex = 3;
            // 
            // labelDurumm
            // 
            labelDurumm.ForeColor = SystemColors.ControlLightLight;
            labelDurumm.Location = new Point(21, 18);
            labelDurumm.Name = "labelDurumm";
            labelDurumm.Size = new Size(184, 41);
            labelDurumm.TabIndex = 4;
            labelDurumm.Text = "0";
            // 
            // textBoxTahmin
            // 
            textBoxTahmin.Location = new Point(21, 66);
            textBoxTahmin.Name = "textBoxTahmin";
            textBoxTahmin.Size = new Size(100, 23);
            textBoxTahmin.TabIndex = 3;
            // 
            // buttonTahmin
            // 
            buttonTahmin.BackColor = Color.Gray;
            buttonTahmin.Location = new Point(211, 47);
            buttonTahmin.Name = "buttonTahmin";
            buttonTahmin.Size = new Size(60, 41);
            buttonTahmin.TabIndex = 1;
            buttonTahmin.Text = "Tahmin Et";
            buttonTahmin.UseVisualStyleBackColor = false;
            buttonTahmin.Click += buttonTahminEt_Click;
            // 
            // buttonBasla
            // 
            buttonBasla.BackColor = Color.Gray;
            buttonBasla.Location = new Point(211, 14);
            buttonBasla.Name = "buttonBasla";
            buttonBasla.Size = new Size(60, 23);
            buttonBasla.TabIndex = 0;
            buttonBasla.Text = "Başla";
            buttonBasla.UseVisualStyleBackColor = false;
            buttonBasla.Click += buttonBasla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1104, 639);
            Controls.Add(panelFaktoriyel);
            Controls.Add(panelAsalSayi);
            Controls.Add(panelCarpimTablosu);
            Controls.Add(panelSayiTahmin);
            Controls.Add(panelHesapMakinesi);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            panelHesapMakinesi.ResumeLayout(false);
            panelHesapMakinesi.PerformLayout();
            panelFaktoriyel.ResumeLayout(false);
            panelFaktoriyel.PerformLayout();
            panelAsalSayi.ResumeLayout(false);
            panelAsalSayi.PerformLayout();
            panelCarpimTablosu.ResumeLayout(false);
            panelSayiTahmin.ResumeLayout(false);
            panelSayiTahmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panelHesapMakinesi;
        private Panel panelFaktoriyel;
        private Panel panelAsalSayi;
        private Panel panelCarpimTablosu;
        private Panel panelSayiTahmin;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label labelSonuc;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button buttonCarp;
        private Button buttonKontrol;
        private TextBox textBoxAsal;
        private Label labelSonucc;
        private Label labelSonuccc;
        private Button buttonFaktoriyel;
        private TextBox textBoxFaktoriyel;
        private Label labelFaktoriyelSonuc;
        private Button buttonTahmin;
        private Button buttonBasla;
        private Label labelDurumm;
        private TextBox textBoxTahmin;
    }
}
