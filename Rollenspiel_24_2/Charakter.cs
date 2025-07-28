using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{
    public abstract class Charakter
    {
        private string _name;
        public int Leben { get; private set; }
        public int Mana { get; private set; }

        public int Angriff { get; private set; }
        public int Ruestung { get; private set; }
        
        private int _level;
        public string Klasse { get; private set; }

        //Ausrüstung für den Charakter als Liste
        private List<string> _ausruestung = new List<string>();

        public Point position = new Point(0, 0);

        public Charakter(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse)
        {
            _name = name;
            Leben = leben;
            Mana = mana;
            Angriff = angriff;
            Ruestung = ruestung;
            _level = level;
            Klasse = klasse;
        }

        public static void angriff()
        {
            return;
        }

        public static void heilen()
        {
            return;
        }

        public static void setArmor(int neueRuestung)
        {
            return;
        }
        public static void getPosition()
        {
            return;
        }
        public static void setMana()
        {
            return;
        }
        public static void nimmtSchaden()
        {
            return;
        }
        public static void istTot()
        {
            return;
        }
    }
}
