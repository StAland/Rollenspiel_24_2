using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
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

        public int getLeben()
        {
            return leben;
        }

        public int getMana()
        {
            return mana;
        }

        public override void benutzen()
        {
            Console.WriteLine($"{getName()} wurde verwendet!");
            if (leben > 0)
                Console.WriteLine($"Leben wurde um {leben} erhöht.");
            if (mana > 0)
                Console.WriteLine($"Mana wurde um {mana} erhöht.");
        }
    }

    public class Heiltrank : Verbrauchsgegenstand
    {
        public Heiltrank() : base("Heiltrank +10", 10, 0)
        {
        }

        public override void benutzen()
        {
            Console.WriteLine("+10 Leben");
            base.benutzen();
        }
    }

    public class Manatrank : Verbrauchsgegenstand
    {
        public Manatrank() : base("Manatrank +10", 0, 10)
        {
        }

        public override void benutzen()
        {
            Console.WriteLine("+10 Mana");
            base.benutzen();
        }
    }
}