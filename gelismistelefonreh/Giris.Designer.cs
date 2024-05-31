namespace gelismistelefonreh
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panelGiris2 = new Panel();
            labelFail = new Label();
            labelSifre = new Label();
            buttonGiris = new Button();
            progressBarSifre = new ProgressBar();
            passwordFail = new Label();
            passwordFault = new Label();
            txtBxPassword = new TextBox();
            labelSifreGir = new Label();
            girisBttn = new Button();
            pictureBoxGiris = new PictureBox();
            panelGiris2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGiris).BeginInit();
            SuspendLayout();
            // 
            // panelGiris2
            // 
            panelGiris2.BackColor = Color.Transparent;
            panelGiris2.BackgroundImage = (Image)resources.GetObject("panelGiris2.BackgroundImage");
            panelGiris2.BackgroundImageLayout = ImageLayout.Zoom;
            panelGiris2.Controls.Add(labelFail);
            panelGiris2.Controls.Add(labelSifre);
            panelGiris2.Controls.Add(buttonGiris);
            panelGiris2.Controls.Add(progressBarSifre);
            panelGiris2.Controls.Add(passwordFail);
            panelGiris2.Controls.Add(passwordFault);
            panelGiris2.Controls.Add(txtBxPassword);
            panelGiris2.Location = new Point(180, 129);
            panelGiris2.Name = "panelGiris2";
            panelGiris2.Size = new Size(173, 250);
            panelGiris2.TabIndex = 2;
            // 
            // labelFail
            // 
            labelFail.AutoSize = true;
            labelFail.Location = new Point(23, 150);
            labelFail.Name = "labelFail";
            labelFail.Size = new Size(0, 15);
            labelFail.TabIndex = 8;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSifre.ForeColor = SystemColors.Window;
            labelSifre.Location = new Point(7, 0);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(163, 20);
            labelSifre.TabIndex = 4;
            labelSifre.Text = "Lütfen Şifrenizi Giriniz:";
            // 
            // buttonGiris
            // 
            buttonGiris.BackgroundImage = (Image)resources.GetObject("buttonGiris.BackgroundImage");
            buttonGiris.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGiris.ForeColor = SystemColors.Window;
            buttonGiris.Location = new Point(52, 222);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(78, 25);
            buttonGiris.TabIndex = 7;
            buttonGiris.Text = "Giris";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // progressBarSifre
            // 
            progressBarSifre.BackColor = SystemColors.Window;
            progressBarSifre.Location = new Point(35, 204);
            progressBarSifre.Name = "progressBarSifre";
            progressBarSifre.Size = new Size(105, 12);
            progressBarSifre.TabIndex = 6;
            // 
            // passwordFail
            // 
            passwordFail.AutoSize = true;
            passwordFail.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            passwordFail.ForeColor = SystemColors.ButtonFace;
            passwordFail.Location = new Point(72, 114);
            passwordFail.Name = "passwordFail";
            passwordFail.Size = new Size(0, 17);
            passwordFail.TabIndex = 5;
            // 
            // passwordFault
            // 
            passwordFault.AutoSize = true;
            passwordFault.Location = new Point(113, 116);
            passwordFault.Name = "passwordFault";
            passwordFault.Size = new Size(0, 15);
            passwordFault.TabIndex = 4;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(23, 23);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.PasswordChar = '*';
            txtBxPassword.Size = new Size(127, 23);
            txtBxPassword.TabIndex = 2;
            txtBxPassword.TextChanged += txtBxPassword_TextChanged;
            // 
            // labelSifreGir
            // 
            labelSifreGir.AutoSize = true;
            labelSifreGir.BackColor = Color.Transparent;
            labelSifreGir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSifreGir.ForeColor = SystemColors.ButtonFace;
            labelSifreGir.Location = new Point(223, 129);
            labelSifreGir.Name = "labelSifreGir";
            labelSifreGir.Size = new Size(172, 20);
            labelSifreGir.TabIndex = 0;
            labelSifreGir.Text = "Lütfen Şifrenizi Giriniz :";
            // 
            // girisBttn
            // 
            girisBttn.BackgroundImage = (Image)resources.GetObject("girisBttn.BackgroundImage");
            girisBttn.BackgroundImageLayout = ImageLayout.None;
            girisBttn.ForeColor = SystemColors.ButtonFace;
            girisBttn.Location = new Point(193, 362);
            girisBttn.Name = "girisBttn";
            girisBttn.Size = new Size(127, 32);
            girisBttn.TabIndex = 3;
            girisBttn.Text = "Giriş";
            girisBttn.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGiris
            // 
            pictureBoxGiris.Dock = DockStyle.Fill;
            pictureBoxGiris.Image = (Image)resources.GetObject("pictureBoxGiris.Image");
            pictureBoxGiris.Location = new Point(0, 0);
            pictureBoxGiris.Name = "pictureBoxGiris";
            pictureBoxGiris.Size = new Size(496, 504);
            pictureBoxGiris.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGiris.TabIndex = 3;
            pictureBoxGiris.TabStop = false;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 504);
            Controls.Add(panelGiris2);
            Controls.Add(pictureBoxGiris);
            Controls.Add(girisBttn);
            Controls.Add(labelSifreGir);
            DoubleBuffered = true;
            Name = "Giris";
            Text = "Rehber Giriş";
            panelGiris2.ResumeLayout(false);
            panelGiris2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGiris).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelGiris2;
        private Button girisBttn;
        private TextBox txtBxPassword;
        private Label labelSifreGir;
        private PictureBox pictureBoxGiris;
        private Label passwordFault;
        private Label passwordFail;
        private ProgressBar progressBarSifre;
        private Label labelFail;
        private Label labelSifre;
        private Button buttonGiris;
    }
}