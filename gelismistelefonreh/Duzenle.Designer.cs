namespace gelismistelefonreh
{
    partial class Duzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelDuzenle = new Panel();
            pictureBox1 = new PictureBox();
            buttonKaydet = new Button();
            comboBoxTel = new ComboBox();
            maskedTextBoxTel = new MaskedTextBox();
            textBoxSoyisim = new TextBox();
            textBoxIsım = new TextBox();
            panelDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 98);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 127);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 156);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 185);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon Türü:";
            // 
            // panelDuzenle
            // 
            panelDuzenle.Controls.Add(pictureBox1);
            panelDuzenle.Controls.Add(buttonKaydet);
            panelDuzenle.Controls.Add(comboBoxTel);
            panelDuzenle.Controls.Add(maskedTextBoxTel);
            panelDuzenle.Controls.Add(textBoxSoyisim);
            panelDuzenle.Controls.Add(textBoxIsım);
            panelDuzenle.Controls.Add(label3);
            panelDuzenle.Controls.Add(label1);
            panelDuzenle.Controls.Add(label4);
            panelDuzenle.Controls.Add(label2);
            panelDuzenle.Location = new Point(4, 4);
            panelDuzenle.Name = "panelDuzenle";
            panelDuzenle.Size = new Size(316, 279);
            panelDuzenle.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GelismisTelefonRehberi.Properties.Resources.icons8_person_64__2_;
            pictureBox1.Location = new Point(119, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 64);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // buttonKaydet
            // 
            buttonKaydet.ForeColor = SystemColors.Window;
            buttonKaydet.Location = new Point(74, 228);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(155, 32);
            buttonKaydet.TabIndex = 8;
            buttonKaydet.Text = "Değişiklikleri Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // comboBoxTel
            // 
            comboBoxTel.FormattingEnabled = true;
            comboBoxTel.Items.AddRange(new object[] { "Aile", "Ev", "İş", "Okul" });
            comboBoxTel.Location = new Point(138, 182);
            comboBoxTel.Name = "comboBoxTel";
            comboBoxTel.Size = new Size(121, 23);
            comboBoxTel.TabIndex = 7;
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(138, 148);
            maskedTextBoxTel.Mask = "(999) 000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(100, 23);
            maskedTextBoxTel.TabIndex = 6;
            // 
            // textBoxSoyisim
            // 
            textBoxSoyisim.Location = new Point(138, 119);
            textBoxSoyisim.Name = "textBoxSoyisim";
            textBoxSoyisim.Size = new Size(100, 23);
            textBoxSoyisim.TabIndex = 5;
            // 
            // textBoxIsım
            // 
            textBoxIsım.Location = new Point(138, 90);
            textBoxIsım.Name = "textBoxIsım";
            textBoxIsım.Size = new Size(100, 23);
            textBoxIsım.TabIndex = 4;
            // 
            // Duzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 285);
            Controls.Add(panelDuzenle);
            Name = "Duzenle";
            Text = "Duzenle";
            Load += Duzenle_Load;
            panelDuzenle.ResumeLayout(false);
            panelDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelDuzenle;
        private Button buttonKaydet;
        private ComboBox comboBoxTel;
        private MaskedTextBox maskedTextBoxTel;
        private TextBox textBoxSoyisim;
        private TextBox textBoxIsım;
        private PictureBox pictureBox1;
    }
}