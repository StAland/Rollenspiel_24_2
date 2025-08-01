using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Gegner : Charakter, IGegner
    {
        public int Erfahrungszuwachs { get; }
        List<Gegenstand> _inventar = new List<Gegenstand>();
        public Gegner(string name, int leben, int maxLeben, int mana, int maxMana, int angriff, int ruestung, int level, string klasse, int erfahrungszuwachs, Point position)
            : base(name, leben, maxLeben, mana, maxMana, angriff, ruestung, klasse, position)
        {
            Erfahrungszuwachs = erfahrungszuwachs;
        }
    }
}