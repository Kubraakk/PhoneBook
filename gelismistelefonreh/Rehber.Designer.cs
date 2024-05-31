namespace gelismistelefonreh
{
    partial class Rehber
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rehber));
            statusStrip1 = new StatusStrip();
            toolStripStatusLBLdatetime = new ToolStripStatusLabel();
            toolStripStatusLblkisisayisi = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStripRehber = new MenuStrip();
            aramaToolStripMenuItem = new ToolStripMenuItem();
            favorilerToolStripMenuItem = new ToolStripMenuItem();
            FavEkletoolStripMenuItem = new ToolStripMenuItem();
            tümFavoriKişilerToolStripMenuItem = new ToolStripMenuItem();
            filtrelemeToolStripMenuItem = new ToolStripMenuItem();
            aileToolStripMenuItem = new ToolStripMenuItem();
            evToolStripMenuItem = new ToolStripMenuItem();
            işToolStripMenuItem = new ToolStripMenuItem();
            okulToolStripMenuItem = new ToolStripMenuItem();
            tümüToolStripMenuItem = new ToolStripMenuItem();
            sıralamaToolStripMenuItem = new ToolStripMenuItem();
            ismeGöreSıralamaToolStripMenuItem = new ToolStripMenuItem();
            soyadaGöreSıralamaToolStripMenuItem = new ToolStripMenuItem();
            numarayaGöreSıralamaToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            kişiyiSilToolStripMenuItem = new ToolStripMenuItem();
            kişiyiDüzenleToolStripMenuItem = new ToolStripMenuItem();
            listViewRehber = new ListView();
            ımageList1 = new ImageList(components);
            statusStrip1.SuspendLayout();
            menuStripRehber.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLBLdatetime, toolStripStatusLblkisisayisi });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(444, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLBLdatetime
            // 
            toolStripStatusLBLdatetime.ForeColor = SystemColors.Window;
            toolStripStatusLBLdatetime.Name = "toolStripStatusLBLdatetime";
            toolStripStatusLBLdatetime.Size = new Size(118, 17);
            toolStripStatusLBLdatetime.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLblkisisayisi
            // 
            toolStripStatusLblkisisayisi.ForeColor = SystemColors.Window;
            toolStripStatusLblkisisayisi.Name = "toolStripStatusLblkisisayisi";
            toolStripStatusLblkisisayisi.Size = new Size(118, 17);
            toolStripStatusLblkisisayisi.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // menuStripRehber
            // 
            menuStripRehber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStripRehber.Items.AddRange(new ToolStripItem[] { aramaToolStripMenuItem, favorilerToolStripMenuItem, filtrelemeToolStripMenuItem, sıralamaToolStripMenuItem, düzenleToolStripMenuItem });
            menuStripRehber.Location = new Point(0, 0);
            menuStripRehber.Name = "menuStripRehber";
            menuStripRehber.Size = new Size(444, 25);
            menuStripRehber.TabIndex = 2;
            menuStripRehber.Text = "menuStrip1";
            // 
            // aramaToolStripMenuItem
            // 
            aramaToolStripMenuItem.ForeColor = SystemColors.Window;
            aramaToolStripMenuItem.Image = (Image)resources.GetObject("aramaToolStripMenuItem.Image");
            aramaToolStripMenuItem.Name = "aramaToolStripMenuItem";
            aramaToolStripMenuItem.Size = new Size(74, 21);
            aramaToolStripMenuItem.Text = "Arama";
            aramaToolStripMenuItem.DropDownOpened += aramaToolStripMenuItem_DropDownOpened;
            aramaToolStripMenuItem.Click += aramaToolStripMenuItem_Click;
            // 
            // favorilerToolStripMenuItem
            // 
            favorilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FavEkletoolStripMenuItem, tümFavoriKişilerToolStripMenuItem });
            favorilerToolStripMenuItem.ForeColor = SystemColors.Window;
            favorilerToolStripMenuItem.Image = (Image)resources.GetObject("favorilerToolStripMenuItem.Image");
            favorilerToolStripMenuItem.Name = "favorilerToolStripMenuItem";
            favorilerToolStripMenuItem.Size = new Size(86, 21);
            favorilerToolStripMenuItem.Text = "Favoriler";
            favorilerToolStripMenuItem.DropDownOpened += favorilerToolStripMenuItem_DropDownOpened;
            // 
            // FavEkletoolStripMenuItem
            // 
            FavEkletoolStripMenuItem.ForeColor = SystemColors.Window;
            FavEkletoolStripMenuItem.Name = "FavEkletoolStripMenuItem";
            FavEkletoolStripMenuItem.Size = new Size(179, 22);
            FavEkletoolStripMenuItem.Text = "Favoriye Ekle";
            FavEkletoolStripMenuItem.Click += FavEkletoolStripMenuItem_Click_1;
            // 
            // tümFavoriKişilerToolStripMenuItem
            // 
            tümFavoriKişilerToolStripMenuItem.ForeColor = SystemColors.Window;
            tümFavoriKişilerToolStripMenuItem.Name = "tümFavoriKişilerToolStripMenuItem";
            tümFavoriKişilerToolStripMenuItem.Size = new Size(179, 22);
            tümFavoriKişilerToolStripMenuItem.Text = "Tüm Favori Kişiler";
            tümFavoriKişilerToolStripMenuItem.Click += tümFavoriKişilerToolStripMenuItem_Click;
            // 
            // filtrelemeToolStripMenuItem
            // 
            filtrelemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aileToolStripMenuItem, evToolStripMenuItem, işToolStripMenuItem, okulToolStripMenuItem, tümüToolStripMenuItem });
            filtrelemeToolStripMenuItem.ForeColor = SystemColors.Window;
            filtrelemeToolStripMenuItem.Image = (Image)resources.GetObject("filtrelemeToolStripMenuItem.Image");
            filtrelemeToolStripMenuItem.Name = "filtrelemeToolStripMenuItem";
            filtrelemeToolStripMenuItem.Size = new Size(92, 21);
            filtrelemeToolStripMenuItem.Text = "Filtreleme";
            filtrelemeToolStripMenuItem.DropDownOpened += filtrelemeToolStripMenuItem_DropDownOpened;
            // 
            // aileToolStripMenuItem
            // 
            aileToolStripMenuItem.ForeColor = SystemColors.Window;
            aileToolStripMenuItem.Name = "aileToolStripMenuItem";
            aileToolStripMenuItem.Size = new Size(108, 22);
            aileToolStripMenuItem.Text = "Aile";
            aileToolStripMenuItem.Click += aileToolStripMenuItem_Click;
            // 
            // evToolStripMenuItem
            // 
            evToolStripMenuItem.ForeColor = SystemColors.Window;
            evToolStripMenuItem.Name = "evToolStripMenuItem";
            evToolStripMenuItem.Size = new Size(108, 22);
            evToolStripMenuItem.Text = "Ev";
            evToolStripMenuItem.Click += evToolStripMenuItem_Click;
            // 
            // işToolStripMenuItem
            // 
            işToolStripMenuItem.ForeColor = SystemColors.Window;
            işToolStripMenuItem.Name = "işToolStripMenuItem";
            işToolStripMenuItem.Size = new Size(108, 22);
            işToolStripMenuItem.Text = "İş";
            işToolStripMenuItem.Click += işToolStripMenuItem_Click;
            // 
            // okulToolStripMenuItem
            // 
            okulToolStripMenuItem.ForeColor = SystemColors.Window;
            okulToolStripMenuItem.Name = "okulToolStripMenuItem";
            okulToolStripMenuItem.Size = new Size(108, 22);
            okulToolStripMenuItem.Text = "Okul";
            okulToolStripMenuItem.Click += okulToolStripMenuItem_Click;
            // 
            // tümüToolStripMenuItem
            // 
            tümüToolStripMenuItem.ForeColor = SystemColors.Window;
            tümüToolStripMenuItem.Name = "tümüToolStripMenuItem";
            tümüToolStripMenuItem.Size = new Size(108, 22);
            tümüToolStripMenuItem.Text = "Tümü";
            tümüToolStripMenuItem.Click += tümüToolStripMenuItem_Click;
            // 
            // sıralamaToolStripMenuItem
            // 
            sıralamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ismeGöreSıralamaToolStripMenuItem, soyadaGöreSıralamaToolStripMenuItem, numarayaGöreSıralamaToolStripMenuItem });
            sıralamaToolStripMenuItem.ForeColor = SystemColors.Window;
            sıralamaToolStripMenuItem.Image = (Image)resources.GetObject("sıralamaToolStripMenuItem.Image");
            sıralamaToolStripMenuItem.Name = "sıralamaToolStripMenuItem";
            sıralamaToolStripMenuItem.Size = new Size(86, 21);
            sıralamaToolStripMenuItem.Text = "Sıralama";
            sıralamaToolStripMenuItem.DropDownOpened += sıralamaToolStripMenuItem_DropDownOpened;
            // 
            // ismeGöreSıralamaToolStripMenuItem
            // 
            ismeGöreSıralamaToolStripMenuItem.ForeColor = SystemColors.Window;
            ismeGöreSıralamaToolStripMenuItem.Name = "ismeGöreSıralamaToolStripMenuItem";
            ismeGöreSıralamaToolStripMenuItem.Size = new Size(223, 22);
            ismeGöreSıralamaToolStripMenuItem.Text = "İsme Göre Sıralama";
            ismeGöreSıralamaToolStripMenuItem.Click += ismeGöreSıralamaToolStripMenuItem_Click;
            // 
            // soyadaGöreSıralamaToolStripMenuItem
            // 
            soyadaGöreSıralamaToolStripMenuItem.ForeColor = SystemColors.Window;
            soyadaGöreSıralamaToolStripMenuItem.Name = "soyadaGöreSıralamaToolStripMenuItem";
            soyadaGöreSıralamaToolStripMenuItem.Size = new Size(223, 22);
            soyadaGöreSıralamaToolStripMenuItem.Text = "Soyada Göre Sıralama";
            soyadaGöreSıralamaToolStripMenuItem.Click += soyadaGöreSıralamaToolStripMenuItem_Click;
            // 
            // numarayaGöreSıralamaToolStripMenuItem
            // 
            numarayaGöreSıralamaToolStripMenuItem.ForeColor = SystemColors.Window;
            numarayaGöreSıralamaToolStripMenuItem.Name = "numarayaGöreSıralamaToolStripMenuItem";
            numarayaGöreSıralamaToolStripMenuItem.Size = new Size(223, 22);
            numarayaGöreSıralamaToolStripMenuItem.Text = "Numaraya Göre Sıralama";
            numarayaGöreSıralamaToolStripMenuItem.Click += numarayaGöreSıralamaToolStripMenuItem_Click;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kişiyiSilToolStripMenuItem, kişiyiDüzenleToolStripMenuItem });
            düzenleToolStripMenuItem.ForeColor = SystemColors.Window;
            düzenleToolStripMenuItem.Image = (Image)resources.GetObject("düzenleToolStripMenuItem.Image");
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(82, 21);
            düzenleToolStripMenuItem.Text = "Düzenle";
            düzenleToolStripMenuItem.DropDownOpened += düzenleToolStripMenuItem_DropDownOpened;
            // 
            // kişiyiSilToolStripMenuItem
            // 
            kişiyiSilToolStripMenuItem.ForeColor = SystemColors.Window;
            kişiyiSilToolStripMenuItem.Name = "kişiyiSilToolStripMenuItem";
            kişiyiSilToolStripMenuItem.Size = new Size(155, 22);
            kişiyiSilToolStripMenuItem.Text = "Kişiyi Sil";
            kişiyiSilToolStripMenuItem.Click += kişiyiSilToolStripMenuItem_Click;
            // 
            // kişiyiDüzenleToolStripMenuItem
            // 
            kişiyiDüzenleToolStripMenuItem.ForeColor = SystemColors.Window;
            kişiyiDüzenleToolStripMenuItem.Name = "kişiyiDüzenleToolStripMenuItem";
            kişiyiDüzenleToolStripMenuItem.Size = new Size(155, 22);
            kişiyiDüzenleToolStripMenuItem.Text = "Kişiyi Düzenle";
            kişiyiDüzenleToolStripMenuItem.Click += kişiyiDüzenleToolStripMenuItem_Click;
            // 
            // listViewRehber
            // 
            listViewRehber.LargeImageList = ımageList1;
            listViewRehber.Location = new Point(0, 28);
            listViewRehber.Name = "listViewRehber";
            listViewRehber.Size = new Size(444, 397);
            listViewRehber.SmallImageList = ımageList1;
            listViewRehber.TabIndex = 3;
            listViewRehber.UseCompatibleStateImageBehavior = false;
            listViewRehber.View = View.SmallIcon;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-person-64.png");
            ımageList1.Images.SetKeyName(1, "icons8-person-64 (1).png");
            // 
            // Rehber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(444, 450);
            Controls.Add(listViewRehber);
            Controls.Add(statusStrip1);
            Controls.Add(menuStripRehber);
            MainMenuStrip = menuStripRehber;
            Name = "Rehber";
            Text = "Rehber";
            Load += Rehber_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStripRehber.ResumeLayout(false);
            menuStripRehber.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLBLdatetime;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStripRehber;
        private ToolStripMenuItem aramaToolStripMenuItem;
        private ToolStripMenuItem favorilerToolStripMenuItem;
        private ToolStripMenuItem filtrelemeToolStripMenuItem;
        private ToolStripMenuItem sıralamaToolStripMenuItem;
        private ToolStripMenuItem ismeGöreSıralamaToolStripMenuItem;
        private ToolStripMenuItem numarayaGöreSıralamaToolStripMenuItem;
        private ToolStripMenuItem soyadaGöreSıralamaToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLblkisisayisi;
        private ImageList ımageList1;
        private ToolStripMenuItem favoriyeEkleToolStripMenuItem;
        private ToolStripMenuItem favoridenÇıkarToolStripMenuItem;
        private ToolStripMenuItem FavEkletoolStripMenuItem;
        private ToolStripMenuItem tümFavoriKişilerToolStripMenuItem;
        public ListView listViewRehber;
        private ToolStripMenuItem kişiyiSilToolStripMenuItem;
        private ToolStripMenuItem kişiyiDüzenleToolStripMenuItem;
        private ToolStripMenuItem aileToolStripMenuItem;
        private ToolStripMenuItem evToolStripMenuItem;
        private ToolStripMenuItem işToolStripMenuItem;
        private ToolStripMenuItem okulToolStripMenuItem;
        private ToolStripMenuItem tümüToolStripMenuItem;
    }
}