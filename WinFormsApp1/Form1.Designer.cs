namespace WinFormsApp1
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
            comboBox = new ComboBox();
            buttonHesapla = new Button();
            buttonSil = new Button();
            labelSonuc = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(53, 24);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(230, 24);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(75, 23);
            buttonHesapla.TabIndex = 1;
            buttonHesapla.Text = "button1";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(230, 53);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(75, 23);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "button2";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(393, 53);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(38, 15);
            labelSonuc.TabIndex = 3;
            labelSonuc.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(496, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelSonuc);
            Controls.Add(buttonSil);
            Controls.Add(buttonHesapla);
            Controls.Add(comboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox;
        private Button buttonHesapla;
        private Button buttonSil;
        private Label labelSonuc;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
