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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        
        private void btnvur_Click(object sender, EventArgs e)
        {
                int knz = frmknz.knz;
                int knzaz = frmknz.knzaz;
                int ihtimal = ScrollBar1.Value;
                int vurus = r.Next(100);
                if (vurus <= ihtimal)
                {
                    int azaltmamiktari = r.Next(2, 103 - ihtimal);
                    if (prgrsbrDusmanCan.Value <= azaltmamiktari)
                        {
                        //Düşman öldü.
                        prgrsbrDusmanCan.Value = 0;
                        SoundPlayer w = new SoundPlayer("sounds/mixkit-medieval-show-fanfare-announcement-226.wav");  
                        w.Play();
                        MessageBox.Show("Nyan Cat Öldü Kazandın!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        prgrsbrCan.Value = 100;
                        prgrsbrDusmanCan.Value = 100;
                        prgrsbrYemek.Value = 0;
                        Frmbaslangic frmbaslangic = new Frmbaslangic();
                        frmbaslangic.Show();
                        this.Hide();
                        goto bitir;
                    }
                    else
                    {
                        prgrsbrDusmanCan.Value -= azaltmamiktari;
                       
                            if (azaltmamiktari >= 40)
                            {
                            SoundPlayer p = new SoundPlayer("sounds/punch-gaming-sound-effect-hd.wav");
                            p.Play();
                            MessageBox.Show("Kritik vurdun!\nHamle sırası karşı tarafta.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }else if (azaltmamiktari < 10)
                            {
                                SoundPlayer p = new SoundPlayer("sounds/punch-gaming-sound-effect-hd.wav");
                                p.Play();
                                MessageBox.Show("Zayıf vurdun\nHamle sırası karşı tarafta.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (azaltmamiktari < 40)
                            {
                                  SoundPlayer p = new SoundPlayer("sounds/punch-gaming-sound-effect-hd.wav");
                                  p.Play();
                                  MessageBox.Show("Normal vurdun\nHamle sırası karşı tarafta.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                }
                else
                {
                //Düşman saldırıyı blokladı.
                SoundPlayer n = new SoundPlayer("sounds/nope-construction-worker-tf2-gaming-sound-effect-hd.wav");
                n.Play();
                MessageBox.Show("Bloklandı\nHamle sırası karşı tarafta.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
                int aolasilik = r.Next(knz,16);
                if (aolasilik >= 100-prgrsbrYemek.Value)
                {
                    prgrsbrYemek.Value = 100;
                    SoundPlayer o = new SoundPlayer("sounds/577028__highpixel__maledeath-sound-8.wav");
                    o.Play();
                    MessageBox.Show("Açlıktan Öldün!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //prgrsbrCan.Value = 100;
                    //prgrsbrDusmanCan.Value = 100;
                    //prgrsbrYemek.Value = 0;
                    Frmbaslangic frmbaslangic = new Frmbaslangic();
                    frmbaslangic.Show();
                    this.Hide();
                    goto bitir;
                }
                else
                {
                      prgrsbrYemek.Value += aolasilik;
                }
                karsitarafinhamlesi();
        bitir:;
            
        }

        private void tmrihtimal_Tick(object sender, EventArgs e)
        {
            //scrllbarın değeri scrollbar hareket ettirilirken ekranda gösteriliyor.
            lblihtimal.Text = ScrollBar1.Value.ToString();
        }
        
        
        void karsitarafinhamlesi()
        {
            //Karşı taraf hamle yapıyor.
            int knzaz = frmknz.knzaz;
            int ihtimal = r.Next(1,200-prgrsbrCan.Value);
            int vurus = r.Next(1,101);
            if (vurus <= ihtimal)
            {
                int azaltmamiktari = r.Next(knzaz, 200 - ihtimal);
                if (prgrsbrCan.Value <= azaltmamiktari)
                {
                    //Öldün.
                    SoundPlayer o = new SoundPlayer("sounds/male-death-sound-37671.wav");
                    o.Play();
                    prgrsbrCan.Value = 0;
                    MessageBox.Show("Öldün!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    prgrsbrCan.Value = 100;
                    prgrsbrDusmanCan.Value = 100;
                    prgrsbrYemek.Value = 0;
                    Frmbaslangic frmbaslangic = new Frmbaslangic();
                    frmbaslangic.Show();
                    this.Hide();
                    goto bitir;
                }
                else
                {
                    prgrsbrCan.Value -= azaltmamiktari;
                    if (azaltmamiktari >= 40)
                    {
                        SoundPlayer p = new SoundPlayer("sounds/punch-gaming-sound-effect-hd.wav");
                        p.Play();
                        MessageBox.Show("Nyan Cat kritik vurdu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (azaltmamiktari < 10)
                    {
                        MessageBox.Show("Nyan Cat zayıf vurdu. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (azaltmamiktari < 40)
                    {
                        SoundPlayer p = new SoundPlayer("sounds/punch-gaming-sound-effect-hd.wav");
                        p.Play();
                        MessageBox.Show("Nyan Cat normal vurdu. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                //Düşmanın saldırısı bloklandı.
                SoundPlayer n = new SoundPlayer("sounds/nope-construction-worker-tf2-gaming-sound-effect-hd.wav");
                n.Play();
                MessageBox.Show("Saldırıyı Blokladın. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bitir:;
         
        }
    }
}
