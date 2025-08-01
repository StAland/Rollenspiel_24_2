using Logik;
using static Logik.Karte;
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
            AktualisiereBewegungsbutton();
        }

        private bool IsBetretbar(Richtung richtung)
        {
            return _karte.IstBegehbar(richtung);
        }


        private void AktualisiereBewegungsbutton()
        {
            btnHoch.Enabled = IsBetretbar(Karte.Richtung.hoch);
            btnRunter.Enabled = IsBetretbar(Karte.Richtung.runter);
            btnLinks.Enabled = IsBetretbar(Karte.Richtung.links);
            btnRechts.Enabled = IsBetretbar(Karte.Richtung.rechts);
        }

        private void btnHoch_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.hoch);
            kartenView1.Invalidate();
            AktualisiereBewegungsbutton();
            EreignisAusloesen();
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.rechts);
            kartenView1.Invalidate();
            AktualisiereBewegungsbutton();
            EreignisAusloesen();
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.links);
            kartenView1.Invalidate();
            AktualisiereBewegungsbutton();
            EreignisAusloesen();
        }

        private void btnRunter_Click(object sender, EventArgs e)
        {
            _karte.Bewegen(Karte.Richtung.runter);
            kartenView1.Invalidate();
            AktualisiereBewegungsbutton();
            EreignisAusloesen();
        }

        private void kartenView1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpieler_Click(object sender, EventArgs e)
        {
            GUISpieler neueForm = new GUISpieler(_karte.Spieler);
            neueForm.ShowDialog();
        }

        private void btnInventar_Click(object sender, EventArgs e)
        {
            var inventarForm = new InventarForm();
            inventarForm.ShowDialog();
        }

        private void EreignisAusloesen()
        {
            var ereignis = _karte.EreignisAuslösen();
            if (ereignis == null) return;
            if (ereignis is Kampfereignis kampf)
            {
                var gegner = new Gegner("name", 20, 20, 20, 10, 10, 5, 2, "none", 10, new System.Drawing.Point(0, 0));

                var kampfform = new Kampfübersicht(_karte.Spieler, gegner);
                kampfform.ShowDialog();
            }
        }
    }
}
