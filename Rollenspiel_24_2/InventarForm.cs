using System;
using System.Windows.Forms;
using Logik;
using System.Collections.Generic;

namespace Rollenspiel_24_2
{
    public partial class InventarForm : Form
    {
        private ComboBox filterComboBox;
        private ListBox gegenstandListBox;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem auswaehlenMenuItem;
        private ToolStripMenuItem entfernenMenuItem;
        private ToolStripMenuItem abbrechenMenuItem;

        // Beispielhafte Datenquelle
        private List<Gegenstand> alleGegenstaende = new List<Gegenstand>();

        public InventarForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // ComboBox für Filter
            filterComboBox = new ComboBox();
            filterComboBox.Items.AddRange(new string[] { "Alle Gegenstände", "Verbrauchsgegenstände", "Ausrüstung" });
            filterComboBox.SelectedIndex = 0;
            filterComboBox.Dock = DockStyle.Top;
            filterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            this.Controls.Add(filterComboBox);

            // ListBox für Gegenstände
            gegenstandListBox = new ListBox();
            gegenstandListBox.Dock = DockStyle.Fill;
            gegenstandListBox.MouseDown += GegenstandListBox_MouseDown;
            gegenstandListBox.KeyDown += GegenstandListBox_KeyDown;
            this.Controls.Add(gegenstandListBox);

            // ContextMenuStrip für Aktionen
            contextMenu = new ContextMenuStrip();
            auswaehlenMenuItem = new ToolStripMenuItem("Auswählen", null, AuswaehlenMenuItem_Click);
            entfernenMenuItem = new ToolStripMenuItem("Entfernen", null, EntfernenMenuItem_Click);
            abbrechenMenuItem = new ToolStripMenuItem("Abbrechen", null, AbbrechenMenuItem_Click);
            contextMenu.Items.AddRange(new ToolStripItem[] { auswaehlenMenuItem, entfernenMenuItem, abbrechenMenuItem });

            // Beispielhafte Gegenstände (zum Testen) ENTFERNT
            alleGegenstaende.Add(new Heiltrank());
            alleGegenstaende.Add(new Manatrank());
            alleGegenstaende.Add(new Schwert());
            alleGegenstaende.Add(new Schild());

            UpdateGegenstandListBox();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGegenstandListBox();
        }

        private void UpdateGegenstandListBox()
        {
            gegenstandListBox.Items.Clear();
            string filter = filterComboBox.SelectedItem.ToString();
            foreach (var g in alleGegenstaende)
            {
                if (filter == "Alle Gegenstände" ||
                    (filter == "Verbrauchsgegenstände" && g is Verbrauchsgegenstand) ||
                    (filter == "Ausrüstung" && g is Ausruestung))
                {
                    gegenstandListBox.Items.Add(g.Name);
                }
            }
        }

        private void GegenstandListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && gegenstandListBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                gegenstandListBox.SelectedIndex = gegenstandListBox.IndexFromPoint(e.Location);
                contextMenu.Show(gegenstandListBox, e.Location);
            }
        }

        private void GegenstandListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gegenstandListBox.SelectedIndex != -1)
            {
                contextMenu.Show(Cursor.Position);
            }
        }

        private void AuswaehlenMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Aktion "Auswählen" implementieren
            MessageBox.Show("Gegenstand ausgewählt: " + gegenstandListBox.SelectedItem);
        }

        private void EntfernenMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Aktion "Entfernen" implementieren
            MessageBox.Show("Gegenstand entfernt: " + gegenstandListBox.SelectedItem);
        }

        private void AbbrechenMenuItem_Click(object sender, EventArgs e)
        {
            // Kontextmenü einfach schließen
        }
    }
}

