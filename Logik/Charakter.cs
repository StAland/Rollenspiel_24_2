using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public abstract class Charakter
    {
        public string Name { get; }
        public int Leben { get; protected set; }
        public int Mana { get; protected set; }

        public int Angriff { get; protected set; }
        public int Ruestung { get; protected set; }

        public string Klasse { get; private set; }

        //Ausrüstung für den Charakter als Liste
        protected List<Gegenstand> _ausruestung = new List<Gegenstand>();

        public Point Position { get; protected set; }

        public Charakter(string name, int leben, int mana, int angriff, int ruestung, string klasse, Point position)
        {
            Name = name;
            Leben = leben;
            Mana = mana;
            Angriff = angriff;
            Ruestung = ruestung;
            Klasse = klasse;
            Position = position;
        }

        public void Heilen(Verbrauchsgegenstand gegenstand)
        {
            Leben += gegenstand.Leben;
        }

        public void SetArmor(int neueRuestung)
        {
            if (neueRuestung < 0)
            {
                throw new ArgumentException("Ruestung darf nicht kleiner 0 sein");
            }
            Ruestung = neueRuestung;
        }

        public void SetMana(int neueMana)
        {
            Mana = neueMana;
        }
        public int NimmtSchaden(int schaden)
        {
            Leben -= schaden;
            return schaden;
        }

        
        public abstract bool IstTot();

    }
}