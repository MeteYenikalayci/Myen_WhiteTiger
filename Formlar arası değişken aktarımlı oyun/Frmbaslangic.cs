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
    public partial class Frmbaslangic : Form
    {
        public Frmbaslangic()
        {
            InitializeComponent();
        }
     
        private void btnbasla_Click(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer("sounds/gta-san-andreas-mission-passed-sound.wav");
            p.Play();
            frmknz frmknz = new frmknz();
            frmknz.Show();
            this.Hide();
            
        }

        private void btnwasted_Click(object sender, EventArgs e)
        {
            SoundPlayer d = new SoundPlayer("sounds/gta-5-wasted-sound-effect-online.wav");
            d.Play();
            MessageBox.Show("Başarısız Oldun!","Bildiri",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
