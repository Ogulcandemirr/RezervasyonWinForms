using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rezervasyon_Projesi
{
    public partial class FrmMusteriGirispaneli : Form
    {
        public FrmMusteriGirispaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void linkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusteriKayitForm fr = new FrmMusteriKayitForm();
            fr.Show();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Musteri WHERE MusteriTc=@p1 AND MusteriSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcno.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text); 
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMusteriDetayyy fr = new FrmMusteriDetayyy();
                fr.tc=mskTcno.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Tc girdiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void buttonAnaMenu_Click(object sender, EventArgs e)
        {
            FrmGirislerForm fr = new FrmGirislerForm();
            fr.Show();
            this.Hide();
        }
    }
}
