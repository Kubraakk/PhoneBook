namespace gelismistelefonreh
{
    partial class Favoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favoriler));
            timer1 = new System.Windows.Forms.Timer(components);
            statusStripFavoriler = new StatusStrip();
            toolStripStatusLabelFavDate = new ToolStripStatusLabel();
            toolStripStatusLabelFavoriNum = new ToolStripStatusLabel();
            menuStripFavoriler = new MenuStrip();
            favoridenÇıkarToolStripMenuItem = new ToolStripMenuItem();
            listViewFavoriler = new ListView();
            ımageList1 = new ImageList(components);
            statusStripFavoriler.SuspendLayout();
            menuStripFavoriler.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // statusStripFavoriler
            // 
            statusStripFavoriler.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelFavDate, toolStripStatusLabelFavoriNum });
            statusStripFavoriler.Location = new Point(0, 428);
            statusStripFavoriler.Name = "statusStripFavoriler";
            statusStripFavoriler.Size = new Size(445, 22);
            statusStripFavoriler.TabIndex = 1;
            statusStripFavoriler.Text = "statusStrip1";
            // 
            // toolStripStatusLabelFavDate
            // 
            toolStripStatusLabelFavDate.ForeColor = SystemColors.Window;
            toolStripStatusLabelFavDate.Name = "toolStripStatusLabelFavDate";
            toolStripStatusLabelFavDate.Size = new Size(118, 17);
            toolStripStatusLabelFavDate.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelFavoriNum
            // 
            toolStripStatusLabelFavoriNum.ForeColor = SystemColors.Window;
            toolStripStatusLabelFavoriNum.Name = "toolStripStatusLabelFavoriNum";
            toolStripStatusLabelFavoriNum.Size = new Size(118, 17);
            toolStripStatusLabelFavoriNum.Text = "toolStripStatusLabel2";
            // 
            // menuStripFavoriler
            // 
            menuStripFavoriler.Items.AddRange(new ToolStripItem[] { favoridenÇıkarToolStripMenuItem });
            menuStripFavoriler.Location = new Point(0, 0);
            menuStripFavoriler.Name = "menuStripFavoriler";
            menuStripFavoriler.Size = new Size(445, 24);
            menuStripFavoriler.TabIndex = 2;
            menuStripFavoriler.Text = "menuStrip1";
            // 
            // favoridenÇıkarToolStripMenuItem
            // 
            favoridenÇıkarToolStripMenuItem.ForeColor = SystemColors.Window;
            favoridenÇıkarToolStripMenuItem.Image = (Image)resources.GetObject("favoridenÇıkarToolStripMenuItem.Image");
            favoridenÇıkarToolStripMenuItem.Name = "favoridenÇıkarToolStripMenuItem";
            favoridenÇıkarToolStripMenuItem.Size = new Size(117, 20);
            favoridenÇıkarToolStripMenuItem.Text = "Favoriden Çıkar";
            favoridenÇıkarToolStripMenuItem.Click += favoridenÇıkarToolStripMenuItem_Click;
            // 
            // listViewFavoriler
            // 
            listViewFavoriler.Location = new Point(0, 27);
            listViewFavoriler.Name = "listViewFavoriler";
            listViewFavoriler.Size = new Size(445, 398);
            listViewFavoriler.SmallImageList = ımageList1;
            listViewFavoriler.TabIndex = 3;
            listViewFavoriler.UseCompatibleStateImageBehavior = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-favorite-user-67.png");
            ımageList1.Images.SetKeyName(1, "icons8-best-67.png");
            ımageList1.Images.SetKeyName(2, "icons8-favorite-50 (1).png");
            ımageList1.Images.SetKeyName(3, "icons8-favorite-24.png");
            // 
            // Favoriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(listViewFavoriler);
            Controls.Add(statusStripFavoriler);
            Controls.Add(menuStripFavoriler);
            MainMenuStrip = menuStripFavoriler;
            Name = "Favoriler";
            Text = "Favoriler";
            Load += Favoriler_Load;
            statusStripFavoriler.ResumeLayout(false);
            statusStripFavoriler.PerformLayout();
            menuStripFavoriler.ResumeLayout(false);
            menuStripFavoriler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStripFavoriler;
        private ToolStripStatusLabel toolStripStatusLabelFavDate;
        private ToolStripStatusLabel toolStripStatusLabelFavoriNum;
        private MenuStrip menuStripFavoriler;
        private ToolStripMenuItem favoridenÇıkarToolStripMenuItem;
        private ListView listViewFavoriler;
        private ImageList ımageList1;
    }
}