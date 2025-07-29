using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
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

        public string GetName()
        {
            return name;
        }

        public string GetTyp()
        {
            return typ;
        }
    }
}
