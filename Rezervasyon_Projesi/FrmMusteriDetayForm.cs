using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Rezervasyon_Projesi
{
    public partial class FrmMusteriDetayyy : Form
    {
        public FrmMusteriDetayyy()
        {
            InitializeComponent();
        }
        public string tc;


        

        private void FrmMusteriDetay_Load(object sender, EventArgs e)
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

            TxtİndirimKodu.Text = sembol1[s1].ToString() + s2.ToString() + sembol2[s3].ToString() + s4.ToString() + sembol3[s5].ToString() + s6.ToString();


            labelTc.Text = tc;

            SqlCommand komut = new SqlCommand("SELECT MusteriAd,MusteriSoyad FROM Tbl_Musteri WHERE MusteriTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0]+ " " + dr[1].ToString();
            }
            bgl.baglanti().Close();

            //SEGMENTLERİ ÇEKME

           s
        }

        private void cmbAracSegmenti_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmbAracModeli.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT ModelAd FROM Tbl_Modeller WHERE MODELSEGMENT=@P1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbAracSegmenti.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbAracModeli.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
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
            FrmMusteriGirispaneli fr= new FrmMusteriGirispaneli();
            fr.Show();
            this.Hide();
        }

       

        private void radioButtonEvet_CheckedChanged(object sender, EventArgs e) //TEKRAR DÜZENLE
        {
            //if (radioButtonEvet.Checked == true)
            //{
            //    MessageBox.Show("Kiralama yapacağınız araç için 200 ₺ karşılığında ek sigorta eklemek istiyor musunuz ?","BİLGİ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
  
            //}
            
        }

        private void CmbAracModeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracSegmenti.SelectedIndex == 0 && CmbAracModeli.SelectedIndex == 0) 
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\egea.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 0 && CmbAracModeli.SelectedIndex == 1)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\Taliant.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 0 && CmbAracModeli.SelectedIndex == 2)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\corsa.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 0 && CmbAracModeli.SelectedIndex == 3)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\clio.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 0 && CmbAracModeli.SelectedIndex == 4)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\ibiza.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 1 && CmbAracModeli.SelectedIndex == 0)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\focus.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 1 && CmbAracModeli.SelectedIndex == 1)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\megane.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 1 && CmbAracModeli.SelectedIndex == 2)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\skoda.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 2 && CmbAracModeli.SelectedIndex == 0)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\passat.png");
            }
            if (cmbAracSegmenti.SelectedIndex == 2 && CmbAracModeli.SelectedIndex == 1)
            {
                pictureBoxAracFoto.Image = Image.FromFile("C:\\Users\\OĞULCAN DEMİR\\Desktop\\PictureBoxResimler\\volvo.png");
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnRezervasyonOlustur_Click(object sender, EventArgs e)
        {
            DateTime dogumgunu = dateTimePickerDogumGunu.Value;
            DateTime now = DateTime.Now;

            int yas = now.Year- dogumgunu.Year;

            if (yas < 21)
            {
                MessageBox.Show("Minimum kiralama yaşı 21 olmalıdır","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (TxtAd.Text=="" || TxtSoyad.Text == "" || MskTcNo.Text == "" || MskTelefonNo.Text == "" || TxtMailAdres.Text == "" || dateTimePickerDogumGunu.Text == "" || rchAdres.Text == "" || TxtEhliyetNo.Text == "" || cmbAracSegmenti.Text == "" | CmbAracModeli.Text == "" || dateTimePickerGiris.Text == "" || dateTimePickerCikis.Text == "" || MskAlisSaati.Text == "" || MskBirakisSaati.Text == "")
            {
                MessageBox.Show("Rezervasyonunuzu tamamlamak için tüm alanları doldurmalısınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FrmRezervasyonBasarili fr = new FrmRezervasyonBasarili();
            fr.Show();
            this.Hide();
        }

        private void dateTimePickerCikis_ValueChanged(object sender, EventArgs e) // BUNU PERSONEL EKRANINDA ÇAALIŞTIR !!
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Musteri", bgl.baglanti());
            //da.Fill(dt);
            //DataGridViewAktifRezler.DataSource = dt;
            
            
            
            if (cmbAracSegmenti.Text == "Ekonomik Grup" && TxtİndirimKodu.Text !="")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(dateTimePickerGiris.Text);
                DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerCikis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxToplamFiyat.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxToplamFiyat.Text) * 600;
                ucret = ucret - (ucret * 10 / 100);
                textBoxToplamFiyat.Text = ucret.ToString() + "₺";

            }
            if (cmbAracSegmenti.Text=="Orta Grup" && TxtİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(dateTimePickerGiris.Text);
                DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerCikis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxToplamFiyat.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxToplamFiyat.Text) * 1200;
                ucret = ucret - (ucret * 10 / 100);
                textBoxToplamFiyat.Text = ucret.ToString() + "₺";
            }
            if(cmbAracSegmenti.Text == "Lüks Grup" && TxtİndirimKodu.Text != "")
            {
                int ucret;
                DateTime kucukTarih = Convert.ToDateTime(dateTimePickerGiris.Text);
                DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerCikis.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - kucukTarih;


                textBoxToplamFiyat.Text = sonuc.TotalDays.ToString();
                ucret = Convert.ToInt32(textBoxToplamFiyat.Text) * 1200;
                ucret = ucret - (ucret * 10 / 100);
                textBoxToplamFiyat.Text = ucret.ToString() + "₺";

            }
        }
    }
}
