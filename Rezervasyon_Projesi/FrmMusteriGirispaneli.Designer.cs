namespace Rezervasyon_Projesi
{
    partial class FrmMusteriGirispaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTcno = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.linkLabelUyeOl = new System.Windows.Forms.LinkLabel();
            this.buttonAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre :";
            // 
            // mskTcno
            // 
            this.mskTcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTcno.Location = new System.Drawing.Point(192, 140);
            this.mskTcno.Mask = "00000000000";
            this.mskTcno.Name = "mskTcno";
            this.mskTcno.Size = new System.Drawing.Size(151, 24);
            this.mskTcno.TabIndex = 0;
            this.mskTcno.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(192, 172);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(151, 24);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirisYap.Location = new System.Drawing.Point(225, 202);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(72, 27);
            this.buttonGirisYap.TabIndex = 2;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // linkLabelUyeOl
            // 
            this.linkLabelUyeOl.AutoSize = true;
            this.linkLabelUyeOl.Location = new System.Drawing.Point(349, 183);
            this.linkLabelUyeOl.Name = "linkLabelUyeOl";
            this.linkLabelUyeOl.Size = new System.Drawing.Size(39, 13);
            this.linkLabelUyeOl.TabIndex = 6;
            this.linkLabelUyeOl.TabStop = true;
            this.linkLabelUyeOl.Text = "Üye Ol";
            this.linkLabelUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUyeOl_LinkClicked);
            // 
            // buttonAnaMenu
            // 
            this.buttonAnaMenu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAnaMenu.Location = new System.Drawing.Point(12, 253);
            this.buttonAnaMenu.Name = "buttonAnaMenu";
            this.buttonAnaMenu.Size = new System.Drawing.Size(90, 23);
            this.buttonAnaMenu.TabIndex = 7;
            this.buttonAnaMenu.Text = "Ana Menü";
            this.buttonAnaMenu.UseVisualStyleBackColor = true;
            this.buttonAnaMenu.Click += new System.EventHandler(this.buttonAnaMenu_Click);
            // 
            // FrmMusteriGirispaneli
            // 
            this.AcceptButton = this.buttonGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 284);
            this.Controls.Add(this.buttonAnaMenu);
            this.Controls.Add(this.linkLabelUyeOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMusteriGirispaneli";
            this.Text = "Müşteri Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTcno;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.LinkLabel linkLabelUyeOl;
        private System.Windows.Forms.Button buttonAnaMenu;
    }
}