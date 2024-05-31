namespace GelismisTelefonRehberi
{
    partial class SonArananlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonArananlar));
            listViewLast = new ListView();
            ımageList1 = new ImageList(components);
            statusStripLast = new StatusStrip();
            toolStripStatusLabelTime = new ToolStripStatusLabel();
            toolStripStatusLabelLast = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStripLast.SuspendLayout();
            SuspendLayout();
            // 
            // listViewLast
            // 
            listViewLast.Location = new Point(0, 0);
            listViewLast.Name = "listViewLast";
            listViewLast.Size = new Size(452, 438);
            listViewLast.SmallImageList = ımageList1;
            listViewLast.TabIndex = 0;
            listViewLast.UseCompatibleStateImageBehavior = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-outgoing-call-50 (1).png");
            ımageList1.Images.SetKeyName(1, "icons8-outgoing-call-64.png");
            ımageList1.Images.SetKeyName(2, "icons8-end-call-64.png");
            // 
            // statusStripLast
            // 
            statusStripLast.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTime, toolStripStatusLabelLast });
            statusStripLast.Location = new Point(0, 428);
            statusStripLast.Name = "statusStripLast";
            statusStripLast.Size = new Size(430, 22);
            statusStripLast.TabIndex = 1;
            statusStripLast.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            toolStripStatusLabelTime.Size = new Size(118, 17);
            toolStripStatusLabelTime.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelLast
            // 
            toolStripStatusLabelLast.Name = "toolStripStatusLabelLast";
            toolStripStatusLabelLast.Size = new Size(118, 17);
            toolStripStatusLabelLast.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SonArananlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(statusStripLast);
            Controls.Add(listViewLast);
            Name = "SonArananlar";
            Text = "Son Arananlar";
            Load += SonArananlar_Load;
            statusStripLast.ResumeLayout(false);
            statusStripLast.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewLast;
        private StatusStrip statusStripLast;
        private ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabelLast;
        private ImageList ımageList1;
    }
}