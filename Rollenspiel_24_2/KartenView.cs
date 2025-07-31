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
    public partial class KartenView : UserControl
    {
        public Karte? Karte { get; set; }
        public KartenView()
        {
            Karte = new Karte();
            InitializeComponent();
            this.DoubleBuffered = true;
            
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode || Karte?.Felder == null)
            {
                this.BorderStyle = BorderStyle.Fixed3D;
                return;
            }

            base.OnPaint(e);
            if (Karte?.Felder == null) return;

            int feldBreite = this.Width / Karte.Felder.GetLength(0);
            int feldHöhe = this.Height / Karte.Felder.GetLength(1);

            for (int x = 0; x < Karte.Felder.GetLength(0); x++)
            {
                for (int y = 0; y < Karte.Felder.GetLength(1); y++)
                {
                    var feld = Karte.Felder[x, y];
                    var rect = new Rectangle(x * feldBreite, y * feldHöhe, feldBreite, feldHöhe);
                    if (Karte.Spieler != null && Karte.Spieler.Position == new Point(x, y))
                    {
                        e.Graphics.FillRectangle(Brushes.Red, rect);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(feld.IsBetretbar() ? Brushes.LightGreen : Brushes.DarkGray, rect);
                    }
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
            }
        }
    }
}
