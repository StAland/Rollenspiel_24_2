using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Verbrauchsgegenstand : Gegenstand
    {
        public int Leben { get; protected set; }
        public int Mana { get; protected set; }

        public Verbrauchsgegenstand(string name, int leben, int mana) 
            : base(name, "Verbrauchsgegenstand")
        {
            this.Leben = leben;
            this.Mana = mana;
        }

        public int GetLeben()
        {
            return Leben;
        }

        public int GetMana()
        {
            return Mana;
        }

    }

    public class Heiltrank : Verbrauchsgegenstand
    {
        public Heiltrank() : base("Heiltrank +10", 10, 0)
        {
        }

    }

    public class Manatrank : Verbrauchsgegenstand
    {
        public Manatrank() : base("Manatrank +10", 0, 10)
        {
        }

    }
}