using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Verbrauchsgegenstand : Gegenstand
    {
        private int leben;
        private int mana;

        public Verbrauchsgegenstand(string name, int leben, int mana) 
            : base(name, "Verbrauchsgegenstand")
        {
            this.leben = leben;
            this.mana = mana;
        }

        public int GetLeben()
        {
            return leben;
        }

        public int GetMana()
        {
            return mana;
        }

        // Methode Benutzen() und ihre Überschreibungen wurden entfernt.
    }

    public class Heiltrank : Verbrauchsgegenstand
    {
        public Heiltrank() : base("Heiltrank +10", 10, 0)
        {
        }

        // Methode Benutzen() und ihre Überschreibungen wurden entfernt.
    }

    public class Manatrank : Verbrauchsgegenstand
    {
        public Manatrank() : base("Manatrank +10", 0, 10)
        {
        }

        // Methode Benutzen() und ihre Überschreibungen wurden entfernt.
    }
}