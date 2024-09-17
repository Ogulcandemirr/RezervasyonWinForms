using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Projesi
{
    public partial class FrmGirislerForm : Form
    {
        public FrmGirislerForm()
        {
            InitializeComponent();
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteriGirispaneli fr = new FrmMusteriGirispaneli();
            fr.Show();
            this.Hide();
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris fr = new FrmPersonelGiris();
            fr.Show();
            this.Hide();
        }

        private void buttonYonetici_Click(object sender, EventArgs e)
        {
            FrmYoneticiGirisForm fr = new FrmYoneticiGirisForm();
            fr .Show();
            this.Hide();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmGirislerForm fr = new FrmGirislerForm();
            //fr.Show();
            //this.Hide();
        }

        private void kampanyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKampanyalar fr = new FrmKampanyalar();
            fr.Show();
            this.Hide();

        }

        private void kiralamaKoşullarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKiralamaKosulları fr = new FrmKiralamaKosulları();
            fr.Show();
            this.Hide();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkimizda fr = new FrmHakkimizda();
            fr.Show();
            this.Hide();

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmİletisimForm fr = new FrmİletisimForm();
            fr.Show();
            this.Hide();

        }
    }
}
