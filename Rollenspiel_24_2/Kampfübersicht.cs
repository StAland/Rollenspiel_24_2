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
    public partial class Kampfübersicht : Form
    {
        private Spieler spieler;
        private Gegner gegner;
        private BattleManager _battleManager;


        public Kampfübersicht(Spieler spieler, Gegner gegner)
        {
            InitializeComponent();
            this.spieler = spieler;
            this.gegner = gegner;
            _battleManager = new BattleManager(spieler, gegner);

        }

        private void Attack_Click(object sender, EventArgs e)
        {
            _battleManager.Attack(spieler, msg => MessageBox.Show(msg));
            UpdateAnzeige();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            //_battleManager.UseItem(spieler.Inventar[0], msg => MessageBox.Show(msg));
            //UpdateAnzeige();
        }

        private void Fliehen_Click(object sender, EventArgs e)
        {
            _battleManager.Fliehen(msg => MessageBox.Show(msg));
            UpdateAnzeige();
        }
        private void UpdateAnzeige()
        {
            StatSpieler.Items.Clear();
            StatSpieler.Items.Add($"{spieler.Name}");
            StatSpieler.Items.Add($"HP: {spieler.Leben} / {spieler.MaxLeben}");
            StatSpieler.Items.Add($"ATK: {spieler.Angriff}");
            StatSpieler.Items.Add($"DEF: {spieler.Ruestung}");

            StatGegner.Items.Clear();
            StatGegner.Items.Add($"{gegner.Name}");
            StatGegner.Items.Add($"HP: {gegner.Leben} / {gegner.MaxLeben}");
            StatGegner.Items.Add($"ATK: {gegner.Angriff}");
            StatGegner.Items.Add($"DEF: {gegner.Ruestung}");
        }
}
