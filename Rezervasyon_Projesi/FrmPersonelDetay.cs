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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Rezervasyon_Projesi
{
    public partial class Rezervasyonlar : Form
    {
        
        public Rezervasyonlar()
        {
            InitializeComponent();
            
        }
        
        public string tcnumara;

       
        sqlbaglantisi bgl = new sqlbaglantisi();
        

        private void buttonRezervasyonYap_Click(object sender, EventArgs e)
        {

            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTcNo.Text == "" || MskTelefonNo.Text == "" || TxtMailAdres.Text == "" ||  CMBARACSEGMENTİ.Text == "" | cmbaracmodeli.Text == "" || datetimealis.Text == "" || datatimebirakis.Text == "" || mskalissaati.Text == "" || mskbirakissaati.Text == "")
            {
                MessageBox.Show("Eksik Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MskTcNo.Text.Length != 11)
            {
                MessageBox.Show("Eksik Tc Kimlik Numarası girdiniz","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(MskTelefonNo.Text.Length != 10)
            {
                MessageBox.Show("Eksik Telefon Numarası girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Rezervasyonlar (MusteriAd,MusteriSoyad,MUsteriTc,MusteriTelefon,MusteriMail,Musteriİstek,RezervasyonAlisTarihi,RezervasyonAlisSaati,RezervasyonBirakisTarihi,RezervasyonBirakisSaati,RezervasyonSegment,RezervasyonModel,RezervasyonEksigorta,RezervasyonFiyat) VALUES ('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + MskTcNo.Text + "','" + MskTelefonNo.Text + "','" + TxtMailAdres.Text + "','" + richTextBoxmusteriistek.Text + "','" + datetimealis.Value.ToString("yyyy-MM-dd") + "','" + mskalissaati.Text + "','" + datatimebirakis.Value.ToString("yyyy-MM-dd") + "','" + mskbirakissaati.Text + "','" + CMBARACSEGMENTİ.Text + "','" + cmbaracmodeli.Text + "','" + textBoxEkSigorta.Text + "','" + labelGenelTutar.Text + "')", bgl.baglanti());   
            komut.ExecuteNonQuery();           
            MessageBox.Show("Rezervasyon Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void TxtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void MskTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MskTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmPersonelDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tcnumara;

            SqlCommand komut2 = new SqlCommand("SELECT PersonelAd,PersonelSoyad FROM Tbl_Personel WHERE PersonelTc=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", tcnumara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                labelAdSOYAD.Text = dr[0]+ " " + dr[1];
            }
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("SELECT SegmentAd FROM Tbl_Segmentler", bgl.baglanti());
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                CMBARACSEGMENTİ.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close();

            richTextBoxmusteriistek.Text = "İstek..";
        }

        private void CMBARACSEGMENTİ_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbaracmodeli.Items.Clear();
            SqlCommand komut2 = new SqlCommand("SELECT ModelAd FROM Tbl_Modeller WHERE MODELSEGMENT=@P1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CMBARACSEGMENTİ.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbaracmodeli.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void radiobutonevet_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutonevet.Checked)
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxEkSigorta.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxEkSigorta.Text) * 200;
                textBoxEkSigorta.Text = ucret.ToString();

            }
            if (radiobuttonhayir.Checked)
            {
                textBoxEkSigorta.Text = 0.ToString();
            }
            int sayi1 = Convert.ToInt32(textBoxKiralamaTutari.Text);
            int sayi2 = Convert.ToInt32(textBoxEkSigorta.Text);
            int sonucc = sayi1 + sayi2;
            labelGenelTutar.Text = sonucc.ToString() + "₺";
        }

        private void datatimebirakis_ValueChanged(object sender, EventArgs e)
        {
            if (CMBARACSEGMENTİ.Text == "Ekonomik Grup" )
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxKiralamaTutari.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxKiralamaTutari.Text) * 600;
                textBoxKiralamaTutari.Text = ucret.ToString();

            }
            if (CMBARACSEGMENTİ.Text == "Orta Grup" )
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxKiralamaTutari.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxKiralamaTutari.Text) * 1200;               
                textBoxKiralamaTutari.Text = ucret.ToString();
            }
            if (CMBARACSEGMENTİ.Text == "Lüks Grup")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxKiralamaTutari.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxKiralamaTutari.Text) * 1600;
                textBoxKiralamaTutari.Text = ucret.ToString();

            }
            if(CMBARACSEGMENTİ.Text == "Suv Grup")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxKiralamaTutari.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxKiralamaTutari.Text) * 1400;
                textBoxKiralamaTutari.Text = ucret.ToString();
            }
            if (CMBARACSEGMENTİ.Text=="Cabrio Grup")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxKiralamaTutari.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxKiralamaTutari.Text) * 2000;
                textBoxKiralamaTutari.Text = ucret.ToString();
            }
            
        }

        private void textBoxİndirim_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void buttonindirim_Click(object sender, EventArgs e)
        {
            int donusum = Convert.ToInt32(textBoxİndirim.Text);
            if (donusum > 100)
            {
                MessageBox.Show("Lütfen 0 ile 100 arasında bir indirim oranı giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (!int.TryParse(textBoxKiralamaTutari.Text, out int sayi))
            {
                return;
            }
            if (!int.TryParse(textBoxİndirim.Text, out int yuzde))
            {
                return;
            }
            int yuzdeSayi = sayi - (sayi * yuzde / 100);

            textBoxKiralamaTutari.Text = yuzdeSayi.ToString();

        }

        private void BtnRezervasyonlar_Click(object sender, EventArgs e)
        {
            FrmRezervasyonlarListe fr = new FrmRezervasyonlarListe();
            fr.Show();
            
        }

        private void butonDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurularForm fr = new FrmDuyurularForm();
            fr.Show();
        }

        private void cmbaracmodeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("SELECT ModelAd FROM Tbl_Modeller WHERE ModelSegment=@p1", bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", CMBARACSEGMENTİ.Text);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    cmbaracmodeli.Items.Add(dr[0]);
            //}
            //bgl.baglanti().Close();

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
