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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void butongeri_Click(object sender, EventArgs e)
        {
            FrmYoneticiDetay fr = new FrmYoneticiDetay();
            fr.Show();
            this.Hide();
             
        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT RezervasyonAlisTarihi,RezervasyonBirakisTarihi,RezervasyonEksigorta,RezervasyonFiyat FROM Tbl_Rezervasyonlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT  RezervasyonAlisTarihi,RezervasyonBirakisTarihi,RezervasyonEksigorta,RezervasyonFiyat FROM Tbl_Rezervasyonlar WHERE RezervasyonAlisTarihi LIKE '%" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "%' ", bgl.baglanti()); 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            
           

        }
    }
}
