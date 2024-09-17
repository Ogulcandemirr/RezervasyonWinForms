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
    public partial class FrmRezervasyonlarListe : Form
    {
        public FrmRezervasyonlarListe()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Rezervasyonlar frm = new Rezervasyonlar();
            frm.Show();
            this.Hide();
        }

        private void FrmRezervasyonlarListe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Rezervasyonlar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
