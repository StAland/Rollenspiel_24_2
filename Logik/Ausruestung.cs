using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Ausruestung : Gegenstand
    {
        public int Angriff { get; }
        public int Ruestung { get; }

        public Ausruestung(string name, int angriff, int ruestung) 
            : base(name, "Ausruestung")
        {
            this.Angriff = angriff;
            this.Ruestung = ruestung;
        }

    }

    public class Schwert : Ausruestung
    {
        public Schwert() : base("Schwert", 7, 0)
        {
        }
    }

    public class Schild : Ausruestung
    {
        public Schild() : base("Schild", 0, 5)
        {
        }
    }
}