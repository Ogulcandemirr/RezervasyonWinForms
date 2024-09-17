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
    public partial class FrmYoneticiDetay : Form
    {
        public FrmYoneticiDetay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmYoneticiDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tcnumara;

            SqlCommand komut = new SqlCommand("SELECT YoneticiAdSoyad FROM Tbl_Yonetici WHERE YoneticiTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",labelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSOYAD.Text= dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Segmentler", bgl.baglanti());
            da.Fill(dt1); //SANAL TABLO
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter("SELECT * FROM Tbl_Personel",bgl.baglanti());
            da1.Fill(dt2);
            dataGridView4.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Tbl_Modeller", bgl.baglanti());
            da2.Fill(dt3);
            dataGridView2.DataSource = dt3;
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyuru (Duyuru) VALUES (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonpersonelPaneli_Click(object sender, EventArgs e)
        {
            FrmPersonelPaneli fr = new FrmPersonelPaneli();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmmodellerForm fr = new FrmmodellerForm();
            fr.Show();
            this.Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonİstatistikler_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
            this.Hide();
        }
    }
}
