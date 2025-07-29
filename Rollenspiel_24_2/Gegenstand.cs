using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{

    public abstract class Gegenstand
    {
        private string name;
        private string typ;

        public Gegenstand(string name, string typ)
        {
            this.name = name;
            this.typ = typ;
        }

        public string getName()
        {
            return name;
        }

        public string getTyp()
        {
            return typ;
        }

        public abstract void benutzen();
    }
}
