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
    public partial class GUISpieler : Form
    {
        private Spieler _spieler;

        public GUISpieler(Spieler spieler)
        {
            _spieler = spieler;


            InitializeComponent();

            lblPlayer.Text = _spieler.Name;
            lblLevel.Text = _spieler.Level.ToString();
            lblLeben.Text = _spieler.Leben.ToString();
            lblMana.Text = _spieler.Mana.ToString();
            lblAngriff.Text = _spieler.Angriff.ToString();
            lblRuestung.Text = _spieler.Ruestung.ToString();
            lblKlasse.Text = _spieler.Klasse;
            lblMaxLeben.Text = _spieler.MaxLeben.ToString();
            lblMaxMana.Text = _spieler.MaxMana.ToString();

        }

        // !!!!!!! Entkommentieren, wenn GUIInventar fertig ist !!!!!!!

        //private void btnInventar_Click(object sender, EventArgs e)
        //{
        //    GUIInventar form = new GUIInventar()
        //    form.ShowDialog();
        //}

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
