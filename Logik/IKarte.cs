using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logik.Karte;

namespace Logik
{
    public interface IKarte
    {
        public enum Richtung;
        public bool IsBetretbar(Point point);
        public void Bewegen(Richtung richtung);
        public bool IstBegehbar(Richtung richtung);

    }
}
