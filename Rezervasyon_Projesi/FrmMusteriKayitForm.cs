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
    public partial class FrmMusteriKayitForm : Form
    {
        
        public FrmMusteriKayitForm()
        {
            InitializeComponent();
        }
      
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnkayıtYap_Click(object sender, EventArgs e)
        {

            if (TxtAd.Text == "" || TxtSoyad.Text == "" || MskTcNo.Text == "" || MskTelefonNo.Text == "" || TxtMailAdres.Text == "" || rchAdres.Text == "" || TxtEhliyetNo.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Herhangi bir alan boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi başarıyla gerçekleştirildi","ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Musteri (MusteriAd,MusteriSoyad,MusteriTc,MusteriTelefon,MusteriMail,MusteriAdres,MusteriEhliyetNo,MusteriSifre) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTcNo.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefonNo.Text);
            komut.Parameters.AddWithValue("@p5", TxtMailAdres.Text);
            komut.Parameters.AddWithValue("@p6", rchAdres.Text);
            komut.Parameters.AddWithValue("@p7", TxtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@p8", TxtSifre.Text);
            komut.ExecuteNonQuery();
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
    }
}
