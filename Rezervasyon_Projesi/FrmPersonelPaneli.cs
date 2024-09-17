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
    public partial class FrmPersonelPaneli : Form
    {
        public FrmPersonelPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmPersonelPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Personel",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (PersonelAd,PersonelSoyad,PersonelTc,PersonelSehir,PersonelMaas,PersonelPozisyon,PersonelSifre) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", textBoxTcNo.Text);
            komut.Parameters.AddWithValue("@p4", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p5", TxtMaas.Text);
            komut.Parameters.AddWithValue("@p6", TxtPozisyon.Text);
            komut.Parameters.AddWithValue("@p7", TextSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxTcNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtPozisyon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TextSifre.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE From Tbl_Personel WHERE PersonelTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBoxTcNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel kaydını silmek istiyor musunuz","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Personel SET PersonelAd=@p1,PersonelSoyad=@p2,PersonelSehir=@p4,PersonelMaas=@p5,PersonelPozisyon=@p6,PersonelSifre=@p7 WHERE personelTc=@p3", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", textBoxTcNo.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSehir.Text);
            komut2.Parameters.AddWithValue("@p5", TxtMaas.Text);
            komut2.Parameters.AddWithValue("@p6", TxtPozisyon.Text);
            komut2.Parameters.AddWithValue("@p7", TextSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi");

        }

        private void butongeri_Click(object sender, EventArgs e)
        {
            FrmYoneticiDetay fr = new FrmYoneticiDetay();
            fr.Show();
            this.Hide();
        }
    }
}
