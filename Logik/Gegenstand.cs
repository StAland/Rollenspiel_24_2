using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{

    public abstract class Gegenstand
    {
        public string Name { get; protected set; }
        public string Typ { get; protected set; }

        public Gegenstand(string name, string typ)
        {
            this.Name = name;
            this.Typ = typ;
        }

    }
}
