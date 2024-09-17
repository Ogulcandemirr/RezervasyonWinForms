namespace Rezervasyon_Projesi
{
    partial class FrmGirislerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirislerForm));
            this.buttonMusteri = new System.Windows.Forms.Button();
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.buttonYonetici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampanyalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaKoşullarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMusteri
            // 
            this.buttonMusteri.BackColor = System.Drawing.Color.Red;
            this.buttonMusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMusteri.BackgroundImage")));
            this.buttonMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusteri.Location = new System.Drawing.Point(144, 238);
            this.buttonMusteri.Name = "buttonMusteri";
            this.buttonMusteri.Size = new System.Drawing.Size(199, 293);
            this.buttonMusteri.TabIndex = 0;
            this.buttonMusteri.UseVisualStyleBackColor = false;
            this.buttonMusteri.Click += new System.EventHandler(this.buttonMusteri_Click);
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPersonel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPersonel.BackgroundImage")));
            this.buttonPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPersonel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPersonel.Location = new System.Drawing.Point(349, 238);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(199, 293);
            this.buttonPersonel.TabIndex = 1;
            this.buttonPersonel.UseVisualStyleBackColor = false;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // buttonYonetici
            // 
            this.buttonYonetici.BackColor = System.Drawing.Color.Lime;
            this.buttonYonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYonetici.BackgroundImage")));
            this.buttonYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYonetici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonYonetici.Location = new System.Drawing.Point(554, 238);
            this.buttonYonetici.Name = "buttonYonetici";
            this.buttonYonetici.Size = new System.Drawing.Size(199, 293);
            this.buttonYonetici.TabIndex = 2;
            this.buttonYonetici.UseVisualStyleBackColor = false;
            this.buttonYonetici.Click += new System.EventHandler(this.buttonYonetici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(187, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(601, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "YÖNETİCİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(398, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERSONEL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.kampanyalarToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.kiralamaKoşullarıToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // kampanyalarToolStripMenuItem
            // 
            this.kampanyalarToolStripMenuItem.Name = "kampanyalarToolStripMenuItem";
            this.kampanyalarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.kampanyalarToolStripMenuItem.Text = "Kampanyalar";
            this.kampanyalarToolStripMenuItem.Click += new System.EventHandler(this.kampanyalarToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // kiralamaKoşullarıToolStripMenuItem
            // 
            this.kiralamaKoşullarıToolStripMenuItem.Name = "kiralamaKoşullarıToolStripMenuItem";
            this.kiralamaKoşullarıToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kiralamaKoşullarıToolStripMenuItem.Text = "Kiralama Koşulları";
            this.kiralamaKoşullarıToolStripMenuItem.Click += new System.EventHandler(this.kiralamaKoşullarıToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = "Demir Car Rentals";
            // 
            // FrmGirislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(977, 616);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonYonetici);
            this.Controls.Add(this.buttonPersonel);
            this.Controls.Add(this.buttonMusteri);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGirislerForm";
            this.Text = "Ana Sayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMusteri;
        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.Button buttonYonetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampanyalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaKoşullarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

