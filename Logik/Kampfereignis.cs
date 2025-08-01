using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logik
{
    public class Kampfereignis : IEreignis
    {
        public void Ausloesen(Spieler spieler)
        {
            var gegner = new Gegner("name", 100, 20, 20, 10, 10, 5, 2, "none", 10, new System.Drawing.Point(0, 0));

        }
    }
}
