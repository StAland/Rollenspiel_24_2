using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    internal class Karte
    {
        public enum Richtung
        {
            hoch,
            runter,
            links,
            rechts
        }
        private Feld[,] felder;
        private Spieler _spieler;


        public Karte()
        {
            // ToDo Karte aus Json File oder ähnlichem laden
            CreateRandomMap();
        }

        private void CreateRandomMap()
        {
            int x = 10;
            int y = 10;
            var rand = new Random();
            felder = new Feld[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var begehbar = rand.Next(0, 2) == 1;
                    felder[i, j] = new Feld("Feldname", begehbar);
                }
            }
        }

        public bool IsBetretbar(Point point)
        {
            // Prüfen ob die Position gültig ist
            if (point.X < 0 || point.Y < 0 || point.X >= felder.GetLength(0) || point.Y >= felder.GetLength(1))
                return false;

            // Hole das Feld an der Position
            Feld feld = felder[point.X, point.Y];

            // Überprüfe, ob das Feld betreten werden darf
            return feld.IsBetretbar();
           
        }

        public void Bewegen(Richtung richtung)
        {
            Point aktuellePosition = _spieler.Position;
            Point neuePosition = aktuellePosition;

            switch (richtung)
            {
                case Richtung.hoch:
                    neuePosition.Y += 1;
                    break;
                case Richtung.runter:
                    neuePosition.Y -= 1;
                    break;
                case Richtung.links:
                    neuePosition.X -= 1;
                    break;
                case Richtung.rechts:
                    neuePosition.X += 1;
                    break;
            }
            // dürfen wir dieses Feld betreten 
            // wenn ja dann bewegen Funktion des spielers aufrufen 
            if (IsBetretbar(neuePosition))
            {
                _spieler.Bewegen(neuePosition);
            }
            else
            {
                Console.WriteLine("Feld ist nicht betretbar");
            }
        }
    }
}
