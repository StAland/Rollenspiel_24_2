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
        private Feld[,] felder;


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
                    //var rand = new Random();
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
    }
    }
