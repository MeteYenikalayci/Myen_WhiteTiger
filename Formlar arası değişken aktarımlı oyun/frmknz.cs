using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Formlar_arası_değişken_aktarımlı_oyun
{
    public partial class frmknz : Form
    {
        public frmknz()
        {
            InitializeComponent();
        }
        public static int knz;
        public static int knzaz;

        private void btnKolay_Click(object sender, EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            knz = 1;
            knzaz = 1;
            frm1.Show();
            this.Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            knz = 3;
            knzaz = 5;
            frm1.Show();
            this.Hide();
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            knz = 6;
            knzaz = 10;
            frm1.Show();
            this.Hide();
        }
    }
}
