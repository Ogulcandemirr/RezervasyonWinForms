﻿namespace Rezervasyon_Projesi
{
    partial class FrmİletisimForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 143);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "İLETİŞİM\n\nKızılsaray Mah.Yener Ulusoy Bulv. 71. Sok. Hor Hor Apt. No:16 D:11\nTele" +
    "fon : 0(242) 248 35 99\nMail : info@basaranakademi.com.tr";
            // 
            // buttonkapat
            // 
            this.buttonkapat.Location = new System.Drawing.Point(331, 242);
            this.buttonkapat.Name = "buttonkapat";
            this.buttonkapat.Size = new System.Drawing.Size(109, 30);
            this.buttonkapat.TabIndex = 13;
            this.buttonkapat.Text = "KAPAT";
            this.buttonkapat.UseVisualStyleBackColor = true;
            this.buttonkapat.Click += new System.EventHandler(this.buttonkapat_Click);
            // 
            // FrmİletisimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(807, 284);
            this.Controls.Add(this.buttonkapat);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmİletisimForm";
            this.Text = "İletişim Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonkapat;
    }
}