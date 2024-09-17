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
using System.Data.Common;

namespace Rezervasyon_Projesi
{
    public partial class FrmmodellerForm : Form
    {
        public FrmmodellerForm()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmmodellerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Segmentler",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("SELECT * FROM Tbl_Modeller", bgl.baglanti());
            dv.Fill(dt2);
            dataGridView2.DataSource = dt2;

           //segmentleri comboboxa çektim
            
            SqlCommand komut = new SqlCommand("SELECT SegmentAd FROM Tbl_Segmentler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxmodelsegment.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Segmentler (SegmentAd) VALUES (@s1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@s1",comboBoxSegment.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Segment Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilensatirIndex= dataGridView1.SelectedCells[0].RowIndex;
            textBoxSwgmentId.Text = dataGridView1.Rows[secilensatirIndex].Cells[0].Value.ToString();
            comboBoxSegment.Text = dataGridView1.Rows[secilensatirIndex].Cells[1].Value.ToString();

        }

        private void buttonSil1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Segmentler WHERE SegmentId=@e1", bgl.baglanti());
            komut.Parameters.AddWithValue("@e1",textBoxSwgmentId.Text); 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Segment Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonGuncelle1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Segmentler SET SegmentAd=@g1 WHERE SegmentId=@g2",bgl.baglanti());
            komut.Parameters.AddWithValue("@g1",comboBoxSegment.Text);
            komut.Parameters.AddWithValue("@g2", textBoxSwgmentId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Segment Güncelleme işlemi gerçekleştirildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Modeller (ModelAd,ModelSegment) VALUES (@m1,@m2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1",comboBoxModelAd.Text);
            komut.Parameters.AddWithValue("@m2", comboBoxmodelsegment.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Model Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Modeller WHERE ModelId=@l1", bgl.baglanti());
            komut.Parameters.AddWithValue("@l1", textBoxSwgmentId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Model Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Modeller SET ModelAd=@d1 WHERE ModelId=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", comboBoxModelAd.Text);
            komut.Parameters.AddWithValue("@d2", textBoxModelId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Model Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBoxmodelsegment_SelectedIndexChanged(object sender, EventArgs e)
        {
           comboBoxModelAd.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT ModelAd,ModelSegment FROM Tbl_Modeller WHERE ModelSegment=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",comboBoxmodelsegment.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxModelAd.Items.Add(dr[0] +" " +dr[1]);

            }
            bgl.baglanti().Close();
        }

        private void butongeri_Click(object sender, EventArgs e)
        {
            FrmYoneticiDetay FR = new FrmYoneticiDetay();
            FR.Show();
            this.Hide();
        }
    }
}
