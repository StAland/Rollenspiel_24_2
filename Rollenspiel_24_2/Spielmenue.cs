using Logik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollenspiel_24_2
{
    public partial class Spielmenue : Form
    {
        private Karte _karte;
        public Spielmenue(Karte karte)
        {
            InitializeComponent();
            _karte = karte;
            kartenView1.Karte = _karte;
            kartenView1.Invalidate();
        }

        private void btnOben_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.hoch);
            kartenView1.Invalidate();
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.rechts);
            kartenView1.Invalidate();
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.links);
            kartenView1.Invalidate();
        }

        private void btnRunter_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.runter);
            kartenView1.Invalidate();
        }

        private void kartenView1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpieler_Click(object sender, EventArgs e)
        {

        }

        private void btnInventar_Click(object sender, EventArgs e)
        {

        }
    }
}
