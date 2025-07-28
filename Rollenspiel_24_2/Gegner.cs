using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{
    internal class Gegner : Charakter
    {
        public int Erfahrungszuwachs { get; }
        List<Gegenstand> _inventar = new List<Gegenstand>();
        public Gegner(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse, int erfahrungszuwachs, Point position)
            : base(name, leben, mana, angriff, ruestung, klasse, position)
        {
            Erfahrungszuwachs = erfahrungszuwachs;
    }
        }
}
