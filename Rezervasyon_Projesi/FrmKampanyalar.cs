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
    public partial class FrmKampanyalar : Form
    {
        public FrmKampanyalar()
        {
            InitializeComponent();
        }

        private void buttonkapat_Click(object sender, EventArgs e)
        {
            FrmGirislerForm fr = new FrmGirislerForm();
            fr.Show();
            this.Hide();
        }
    }
}
