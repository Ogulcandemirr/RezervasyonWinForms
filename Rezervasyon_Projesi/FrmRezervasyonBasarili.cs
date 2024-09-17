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
    public partial class FrmRezervasyonBasarili : Form
    {
        public FrmRezervasyonBasarili()
        {
            InitializeComponent();
        }

        private void buttonCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
