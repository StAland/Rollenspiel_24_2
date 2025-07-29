using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Ausruestung : Gegenstand
    {
        public int angriff {get;}
        public int ruestung {get;}

        public Ausruestung(string name, int angriff, int ruestung) 
            : base(name, "Ausruestung")
        {
            this.angriff = angriff;
            this.ruestung = ruestung;
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