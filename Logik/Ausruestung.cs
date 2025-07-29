using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Ausruestung : Gegenstand
    {
        private int angriff;
        private int ruestung;

        public Ausruestung(string name, int angriff, int ruestung) 
            : base(name, "Ausruestung")
        {
            this.angriff = angriff;
            this.ruestung = ruestung;
        }

        public int GetAngriff()
        {
            return angriff;
        }

        public int GetRuestung()
        {
            return ruestung;
        }

        public int Angriff { get; protected set; }
        public int Ruestung { get; protected set; }
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