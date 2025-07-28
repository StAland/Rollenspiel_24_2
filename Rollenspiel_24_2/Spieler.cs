using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{
    internal class Spieler : Charakter
    {
        public int Level { get; private set; }
        public int Erfahrung { get; private set; }

        List<string> _inventar = new List<string>();

        public Spieler(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse, int erfahrung, List<string> inventar)
            : base(name, leben, mana, angriff, ruestung, level, klasse)
        {
            Erfahrung = erfahrung;
            _inventar = inventar;
        }

        public static void getItemFromList()
        {
            return;
        }
        public static void setItemtoList()
        {
            return;
        }
        public static void bewegen()
        {
            return;
        }
        public static void setLevel()
        {
            return;
        }
        public static void erfahrungErhalten()
        {
            return;
        }
        public static void ausruesten()
        {
            return;
        }
        private static void levelUp()
        {
            return;
        }

    }
}
