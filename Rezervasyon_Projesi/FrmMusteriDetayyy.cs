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
using System.Reflection.Emit;

namespace Rezervasyon_Projesi
{
    public partial class FrmMusteriDetayyy : Form
    {
        public FrmMusteriDetayyy()
        {
            InitializeComponent();
        }
        public string tc;

      
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmMusteriDetayyy_Load(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l" };
            string[] sembol2 = { "x", "/", "*", "-", "?", "%", "+", "&" };
            string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G", "H" };

            Random rand = new Random();
            int s1, s2, s3, s4, s5, s6;

            s1 = rand.Next(0, sembol1.Length);
            s2 = rand.Next(0, 10);
            s3 = rand.Next(0, sembol2.Length);
            s4 = rand.Next(0, 10);
            s5 = rand.Next(0, sembol3.Length);
            s6 = rand.Next(0, 10);

            textBoxİndirimKodu.Text = sembol1[s1].ToString() + s2.ToString() + sembol2[s3].ToString() + s4.ToString() + sembol3[s5].ToString() + s6.ToString();


            labelTC.Text = tc;

           //Adı soyadı çektim
            SqlCommand komut = new SqlCommand("SELECT MusteriAd,MusteriSoyad FROM Tbl_Musteri WHERE MusteriTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSOYAD.Text = dr[0] + " " + dr[1].ToString();
            }
            bgl.baglanti().Close();

            //SEGMENTLERİ ÇEKTİM

            SqlCommand komut6 = new SqlCommand("SELECT SegmentAd FROM Tbl_Segmentler", bgl.baglanti());
            SqlDataReader dr2 = komut6.ExecuteReader();
            while (dr2.Read())
            {
                CMBARACSEGMENTİ.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void CMBARACSEGMENTİ_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbaracmodeli.Items.Clear();    
            SqlCommand komut3= new SqlCommand("SELECT ModelAd FROM Tbl_Modeller WHERE MODELSEGMENT=@P1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CMBARACSEGMENTİ.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbaracmodeli.Items.Add(dr3[0]);
            }
            bgl.baglanti() .Close();
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

        private void TxtEhliyetNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTcNo.Text = "";
            MskTelefonNo.Text = "";
            TxtMailAdres.Text = "";
            rchAdres.Text = "";
            TxtEhliyetNo.Text = "";
        }
        private void buttonGeri_Click(object sender, EventArgs e)
        {
            FrmMusteriGirispaneli fr = new FrmMusteriGirispaneli();
            fr.Show();
            this.Hide();
        }

        private void radiobutonevet_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutonevet.Checked)
            {
                MessageBox.Show("Kiralamak istediğiniz aracı günlük 200 ₺ karşılığında sigortalamayı onaylıyor musunuz","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            }
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
            int sayi1 = Convert.ToInt32(textBoxTotalucret.Text);
            int sayi2 = Convert.ToInt32(textBoxEkSigorta.Text);
            int sonucc = sayi1 + sayi2;
            labelGenelTutar.Text = sonucc.ToString() + "₺";
        }
        private void cmbaracmodeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBARACSEGMENTİ.SelectedIndex == 0 && cmbaracmodeli.SelectedIndex == 0)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\egea.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 0 && cmbaracmodeli.SelectedIndex == 1)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\Taliant.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 0 && cmbaracmodeli.SelectedIndex == 2)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\corsa.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 0 && cmbaracmodeli.SelectedIndex == 3)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\clio.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 0 && cmbaracmodeli.SelectedIndex == 4)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\ibiza.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 1 && cmbaracmodeli.SelectedIndex == 0)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\focus.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 1 && cmbaracmodeli.SelectedIndex == 1)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\megane.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 1 && cmbaracmodeli.SelectedIndex == 2)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\skoda.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 2 && cmbaracmodeli.SelectedIndex == 0)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\passat.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 2 && cmbaracmodeli.SelectedIndex == 1)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\volvo.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 2 && cmbaracmodeli.SelectedIndex == 2)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\mercedes.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 2 && cmbaracmodeli.SelectedIndex == 3)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\bmw.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 3 && cmbaracmodeli.SelectedIndex == 0)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\pejo.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 3 && cmbaracmodeli.SelectedIndex == 1)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\tucson.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 4 && cmbaracmodeli.SelectedIndex == 0)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\audi.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 4 && cmbaracmodeli.SelectedIndex == 1)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\mercedescabrio.png");
            }
            if (CMBARACSEGMENTİ.SelectedIndex == 4 && cmbaracmodeli.SelectedIndex == 2)
            {
                pictureBoxARAcOTO.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\bmwcabrio.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumgunu = dateTimePickerDOGUMTARİHİ.Value;
            DateTime now = DateTime.Now;

            int yas = now.Year - dogumgunu.Year;

            if (yas < 21)
            {
                MessageBox.Show("Minimum kiralama yaşı 21 olmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTcNo.Text == "" || MskTelefonNo.Text == "" || TxtMailAdres.Text == "" || dateTimePickerDOGUMTARİHİ.Text == "" || rchAdres.Text == "" || TxtEhliyetNo.Text == "" || CMBARACSEGMENTİ.Text == "" | cmbaracmodeli.Text == "" || datetimealis.Text == "" || datatimebirakis.Text == "" || mskalissaati.Text == "" || mskbirakissaati.Text == "")
            {
                MessageBox.Show("Rezervasyonunuzu tamamlamak için tüm alanları doldurmalısınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmRezervasyonBasarili fr = new FrmRezervasyonBasarili();
            fr.Show();
            this.Hide();

            SqlCommand rezolustur= new SqlCommand("INSERT INTO Tbl_Rezervasyonlar (MusteriAd,MusteriSoyad,MUsteriTc,MusteriTelefon,MusteriMail,Musteriİstek,RezervasyonAlisTarihi,RezervasyonAlisSaati,RezervasyonBirakisTarihi,RezervasyonBirakisSaati,RezervasyonSegment,RezervasyonModel,RezervasyonEksigorta,RezervasyonFiyat) VALUES ('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + MskTcNo.Text + "','" + MskTelefonNo.Text + "','" + TxtMailAdres.Text + "','" + richTextBoxmusteriistek.Text + "','" + datetimealis.Value.ToString("yyyy-MM-dd") + "','" + mskalissaati.Text + "','" + datatimebirakis.Value.ToString("yyyy-MM-dd") + "','" + mskbirakissaati.Text + "','" + CMBARACSEGMENTİ.Text + "','" + cmbaracmodeli.Text + "','" + textBoxEkSigorta.Text + "','" + labelGenelTutar.Text + "')", bgl.baglanti());
            rezolustur.ExecuteNonQuery();
            
        }

        private void datatimebirakis_ValueChanged(object sender, EventArgs e) // BUNU PERSONEL EKRANINDA ÇAALIŞTIR !!
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri", bgl.baglanti());
            //da.Fill(dt);
            //DataGridViewAktifRezler.DataSource = dt;

            if (CMBARACSEGMENTİ.Text == "Ekonomik Grup" && textBoxİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxTotalucret.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxTotalucret.Text) * 600;
                ucret = ucret - (ucret * 10 / 100);
                textBoxTotalucret.Text = ucret.ToString();

            }
            if (CMBARACSEGMENTİ.Text == "Orta Grup" && textBoxİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxTotalucret.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxTotalucret.Text) * 1200;
                ucret = ucret - (ucret * 10 / 100);
                textBoxTotalucret.Text = ucret.ToString();
            }
            if (CMBARACSEGMENTİ.Text == "Lüks Grup" && textBoxİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxTotalucret.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxTotalucret.Text) * 1600;
                ucret = ucret - (ucret * 10 / 100);
                textBoxTotalucret.Text = ucret.ToString();

            }
            if (CMBARACSEGMENTİ.Text == "Suv Grup" && textBoxİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxTotalucret.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxTotalucret.Text) * 1400;
                ucret = ucret - (ucret * 10 / 100);
                textBoxTotalucret.Text = ucret.ToString();

            }
            if (CMBARACSEGMENTİ.Text == "Cabrio Grup" && textBoxİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(datetimealis.Text);
                DateTime BuyukTarih = Convert.ToDateTime(datatimebirakis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxTotalucret.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxTotalucret.Text) * 2000;
                ucret = ucret - (ucret * 10 / 100);
                textBoxTotalucret.Text = ucret.ToString();
            }
        }
    }
    
}
