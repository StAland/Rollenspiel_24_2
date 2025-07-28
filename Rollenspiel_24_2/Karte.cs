using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
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
            felder = new Feld[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var rand = new Random();
                    var begehbar = rand.Next(0, 2) == 1;
                    felder[i, j] = new Feld("Feldname", begehbar);
                }
            }
        }
    }
}
