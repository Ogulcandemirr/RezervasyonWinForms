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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Personel WHERE PersonelTc=@p1 AND PersonelSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Rezervasyonlar fr = new Rezervasyonlar();
                fr.tcnumara = maskedTextBoxtc.Text;
                fr.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş yaptınız");
            }
            bgl.baglanti().Close();
        }
    }
}
