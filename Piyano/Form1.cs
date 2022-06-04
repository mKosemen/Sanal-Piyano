using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Piyano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer cal = new SoundPlayer();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                btnDo1.PerformClick();
            if (e.KeyCode == Keys.W)
                btnRe1.PerformClick();
            if (e.KeyCode == Keys.E)
                btnMi1.PerformClick();
            if (e.KeyCode == Keys.R)
                btnFa1.PerformClick();
            if (e.KeyCode == Keys.T)
                btnSol1.PerformClick();
            if (e.KeyCode == Keys.Y)
                btnLa1.PerformClick();
            if (e.KeyCode == Keys.U)
                btnSi1.PerformClick();
            if (e.KeyCode == Keys.A)
                btnDo2.PerformClick();
            if (e.KeyCode == Keys.S)
                btnRe2.PerformClick();
            if (e.KeyCode == Keys.D)
                btnMi2.PerformClick();
            if (e.KeyCode == Keys.F)
                btnFa2.PerformClick();
            if (e.KeyCode == Keys.G)
                btnSol2.PerformClick();
            if (e.KeyCode == Keys.H)
                btnLa2.PerformClick();
            if (e.KeyCode == Keys.J)
                btnSi2.PerformClick();
            if (e.KeyCode == Keys.Z)
                btnDo3.PerformClick();
            if (e.KeyCode == Keys.X)
                btnRe3.PerformClick();
            if (e.KeyCode == Keys.C)
                btnMi3.PerformClick();
            if (e.KeyCode == Keys.V)
                btnFa3.PerformClick();
            if (e.KeyCode == Keys.B)
                btnSol3.PerformClick();
            if (e.KeyCode == Keys.N)
                btnLa3.PerformClick();
            if (e.KeyCode == Keys.M)
                btnSi3.PerformClick();
            if (e.KeyCode == Keys.NumPad9)
                btnDoRe1.PerformClick();
            if (e.KeyCode == Keys.NumPad8)
                btnReMi1.PerformClick();
            if (e.KeyCode == Keys.NumPad6)
                btnFaSol1.PerformClick();
            if (e.KeyCode == Keys.NumPad5)
                btnSolLa1.PerformClick();
            if (e.KeyCode == Keys.NumPad4)
                btnLaSİ1.PerformClick();
            if (e.KeyCode == Keys.D1)
                btnDoRe2.PerformClick();
            if (e.KeyCode == Keys.D2)
                btnReMi2.PerformClick();
            if (e.KeyCode == Keys.D3)
                btnFaSol.PerformClick();
            if (e.KeyCode == Keys.D4)
                btnSolLa2.PerformClick();
            if (e.KeyCode == Keys.D5)
                btnLaSi2.PerformClick();
            if (e.KeyCode == Keys.D6)
                btnDoRe3.PerformClick();
            if (e.KeyCode == Keys.D7)
                btnReMi3.PerformClick();
            if (e.KeyCode == Keys.D8)
                btnFaSol3.PerformClick();
            if (e.KeyCode == Keys.D9)
                btnSolLa3.PerformClick();
            if (e.KeyCode == Keys.D0)
                btnLaSİ3.PerformClick();
        }
        private void btnDo1_Click(object sender, EventArgs e)
        {
            Stream do1 = Properties.Resources.Do1;
            cal = new SoundPlayer(do1);
            cal.Play();
        }

        private void btnRe1_Click(object sender, EventArgs e)
        {
            Stream re1 = Properties.Resources.Re1;
            cal = new SoundPlayer(re1);
            cal.Play();
        }

        private void btnMi1_Click(object sender, EventArgs e)
        {
            Stream mi1 = Properties.Resources.Mi1;
            cal = new SoundPlayer(mi1);
            cal.Play();
        }

        private void btnFa1_Click(object sender, EventArgs e)
        {
            Stream fa1 = Properties.Resources.Fa1;
            cal = new SoundPlayer(fa1);
            cal.Play();
        }

        private void btnSol1_Click(object sender, EventArgs e)
        {
            Stream sol1 = Properties.Resources.Sol1;
            cal = new SoundPlayer(sol1);
            cal.Play();
        }

        private void btnLa1_Click(object sender, EventArgs e)
        {
            Stream la1 = Properties.Resources.La1;
            cal = new SoundPlayer(la1);
            cal.Play();
        }

        private void btnSi1_Click(object sender, EventArgs e)
        {
            Stream si1 = Properties.Resources.Si1;
            cal = new SoundPlayer(si1);
            cal.Play();
        }

        private void btnDo2_Click(object sender, EventArgs e)
        {
            Stream do2 = Properties.Resources.Do2;
            cal = new SoundPlayer(do2);
            cal.Play();
        }

        private void btnRe2_Click(object sender, EventArgs e)
        {
            Stream re2 = Properties.Resources.Re2;
            cal = new SoundPlayer(re2);
            cal.Play();
        }

        private void btnMi2_Click(object sender, EventArgs e)
        {
            Stream mi2 = Properties.Resources.Mi2;
            cal = new SoundPlayer(mi2);
            cal.Play();
        }

        private void btnFa2_Click(object sender, EventArgs e)
        {
            Stream fa2 = Properties.Resources.Fa2;
            cal = new SoundPlayer(fa2);
            cal.Play();
        }

        private void btnSol2_Click(object sender, EventArgs e)
        {
            Stream sol2 = Properties.Resources.Sol2;
            cal = new SoundPlayer(sol2);
            cal.Play();
        }

        private void btnLa2_Click(object sender, EventArgs e)
        {
            Stream la2 = Properties.Resources.La2;
            cal = new SoundPlayer(la2);
            cal.Play();
        }

        private void btnSi2_Click(object sender, EventArgs e)
        {
            Stream si2 = Properties.Resources.Si2;
            cal = new SoundPlayer(si2);
            cal.Play();
        }

        private void btnDo3_Click(object sender, EventArgs e)
        {
            Stream do3 = Properties.Resources.Do3;
            cal = new SoundPlayer(do3);
            cal.Play();
        }

        private void btnRe3_Click(object sender, EventArgs e)
        {
            Stream re3 = Properties.Resources.Re3;
            cal = new SoundPlayer(re3);
            cal.Play();
        }

        private void btnMi3_Click(object sender, EventArgs e)
        {
            Stream mi3 = Properties.Resources.Mi3;
            cal = new SoundPlayer(mi3);
            cal.Play();
        }

        private void btnFa3_Click(object sender, EventArgs e)
        {
            Stream fa3 = Properties.Resources.Fa3;
            cal = new SoundPlayer(fa3);
            cal.Play();
        }

        private void btnSol3_Click(object sender, EventArgs e)
        {
            Stream sol3 = Properties.Resources.Sol3;
            cal = new SoundPlayer(sol3);
            cal.Play();
        }

        private void btnLa3_Click(object sender, EventArgs e)
        {
            Stream la3 = Properties.Resources.La3;
            cal = new SoundPlayer(la3);
            cal.Play();
        }

        private void btnSi3_Click(object sender, EventArgs e)
        {
            Stream si3 = Properties.Resources.Si3;
            cal = new SoundPlayer(si3);
            cal.Play();
        }

        private void btnDoRe1_Click(object sender, EventArgs e)
        {
            Stream dore1 = Properties.Resources.DoRe1;
            cal = new SoundPlayer(dore1);
            cal.Play();
        }

        private void btnReMi1_Click(object sender, EventArgs e)
        {
            Stream remi1 = Properties.Resources.ReMi1;
            cal = new SoundPlayer(remi1);
            cal.Play();
        }

        private void btnFaSol1_Click(object sender, EventArgs e)
        {
            Stream fasol1 = Properties.Resources.FaSol1;
            cal = new SoundPlayer(fasol1);
            cal.Play();
        }

        private void btnSolLa1_Click(object sender, EventArgs e)
        {
            Stream solla1 = Properties.Resources.SolLa1;
            cal = new SoundPlayer(solla1);
            cal.Play();
        }

        private void btnLaSi1_Click(object sender, EventArgs e)
        {
            Stream lasi1 = Properties.Resources.LaSi1;
            cal = new SoundPlayer(lasi1);
            cal.Play();
        }

        private void btnDoRe2_Click(object sender, EventArgs e)
        {
            Stream dore2 = Properties.Resources.DoRe2;
            cal = new SoundPlayer(dore2);
            cal.Play();
        }

        private void btnReMi2_Click(object sender, EventArgs e)
        {
            Stream remi2 = Properties.Resources.ReMi2;
            cal = new SoundPlayer(remi2);
            cal.Play();
        }

        private void btnFaSol2_Click(object sender, EventArgs e)
        {
            Stream fasol2 = Properties.Resources.FaSol2;
            cal = new SoundPlayer(fasol2);
            cal.Play();
        }

        private void btnSolLa2_Click(object sender, EventArgs e)
        {
            Stream solla2 = Properties.Resources.SolLa2;
            cal = new SoundPlayer(solla2);
            cal.Play();
        }

        private void btnLaSİ2_Click(object sender, EventArgs e)
        {
            Stream lasi2 = Properties.Resources.LaSi2;
            cal = new SoundPlayer(lasi2);
            cal.Play();
        }

        private void btnDoRe3_Click(object sender, EventArgs e)
        {
            Stream dore3 = Properties.Resources.DoRe3;
            cal = new SoundPlayer(dore3);
            cal.Play();
        }

        private void btnReMi3_Click(object sender, EventArgs e)
        {
            Stream remi3 = Properties.Resources.ReMi3;
            cal = new SoundPlayer(remi3);
            cal.Play();
        }

        private void btnFaSol3_Click(object sender, EventArgs e)
        {
            Stream fasol3 = Properties.Resources.FaSol3;
            cal = new SoundPlayer(fasol3);
            cal.Play();
        }

        private void btnSolLa3_Click(object sender, EventArgs e)
        {
            Stream solla3 = Properties.Resources.SolLa3;
            cal = new SoundPlayer(solla3);
            cal.Play();
        }

        private void btnLaSi3_Click(object sender, EventArgs e)
        {
            Stream lasi3 = Properties.Resources.LaSi3;
            cal = new SoundPlayer(lasi3);
            cal.Play();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (rdArkdasimEsek.Checked)
            {
                Stream arkdasimEsek = Properties.Resources.ArkadasimEsek;
                cal = new SoundPlayer(arkdasimEsek);
                cal.Play();
            }
            else if (rdBellaCiao.Checked)
            {
                Stream bellaCiao = Properties.Resources.BellaCiao;
                cal = new SoundPlayer(bellaCiao);
                cal.Play();
            }
            else if (rdBeniAl.Checked)
            {
                Stream beniAl = Properties.Resources.BeniAl;
                cal = new SoundPlayer(beniAl);
                cal.Play();
            }
            else if (rdDespacito.Checked)
            {
                Stream despacito = Properties.Resources.Despacito1;
                cal = new SoundPlayer(despacito);
                cal.Play();
            }
            else if (rdHayatBayramOlsa.Checked)
            {
                Stream hayatBayramOlsa = Properties.Resources.HayatBayramOlsa;
                cal = new SoundPlayer(hayatBayramOlsa);
                cal.Play();
            }
            else if (rdIzmirMarsi.Checked)
            {
                Stream izmirMarsi = Properties.Resources.IzmirMarsi;
                cal = new SoundPlayer(izmirMarsi);
                cal.Play();
            }
            else if (rdSenBirAysin.Checked)
            {
                Stream senBirAysin = Properties.Resources.SenBirAysın;
                cal = new SoundPlayer(senBirAysin);
                cal.Play();
            }
            else if (rdSeviyorumSeni.Checked)
            {
                Stream seviyorumSeni = Properties.Resources.SeviyorumSeni;
                cal = new SoundPlayer(seviyorumSeni);
                cal.Play();
            }
            else if (rdSevKardesim.Checked)
            {
                Stream sevKardesim = Properties.Resources.SevKardesim;
                cal = new SoundPlayer(sevKardesim);
                cal.Play();
            }
            else if (rdYildizlarinAltinda.Checked)
            {
                Stream yildizlarinAltinda = Properties.Resources.YildizlarinAltinda;
                cal = new SoundPlayer(yildizlarinAltinda);
                cal.Play();
            }
            else
            {
                MessageBox.Show("Parça Seçimi yapınız.");
            }
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            cal.Stop();
        }
    }
}
