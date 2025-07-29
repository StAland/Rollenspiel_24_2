using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{
    public class Ausruestung : Gegenstand
    {
        private int angriffswert;
        private int verteidigungswert;

        public Ausruestung(string name, int angriff, int verteidigung) 
            : base(name, "Ausruestung")
        {
            this.angriffswert = angriff;
            this.verteidigungswert = verteidigung;
        }

        public int getAngriffswert()
        {
            return angriffswert;
        }

        public int getVerteidigungswert()
        {
            return verteidigungswert;
        }

        public override void benutzen()
        {
            Console.WriteLine($"{getName()} ausgerüstet");
            if (angriffswert > 0)
                Console.WriteLine($"Angriffswert: +{angriffswert}");
            if (verteidigungswert > 0)
                Console.WriteLine($"Verteidigungswert: +{verteidigungswert}");
        }
    }

    public class Schwert : Ausruestung
    {
        public Schwert() : base("Schwert", 7, 0)
        {
        }

        public override void benutzen()
        {
            Console.WriteLine("Schwert ausgerüstet");
            base.benutzen();
        }
    }

    public class Schild : Ausruestung
    {
        public Schild() : base("Schild", 0, 5)
        {
        }

        public override void benutzen()
        {
            Console.WriteLine("Schild ausgerüstet");
            base.benutzen();
        }
    }
}