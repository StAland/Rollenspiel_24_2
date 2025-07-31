using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public abstract class Charakter : ICharakter
    {

        public event EventHandler? Gestorben;
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

        public int Heilen(Verbrauchsgegenstand gegenstand)
        {
            Leben += gegenstand.Leben;
            return gegenstand.Leben;
        }

        public void SetArmor(int neueRuestung)
        {
            if (neueRuestung < 0)
            {
                throw new ArgumentException("Ruestung darf nicht kleiner 0 sein");
            }
            Ruestung = neueRuestung;
        }

        public int SetMana(int neueMana)
        {
            Mana = neueMana;
            return neueMana;
        }
        public int NimmtSchaden(int schaden)
        {
            Leben -= schaden;
            if(Leben <= 0)
            {
                Leben = 0;
                OnGestorben();
            }
            return schaden;
        }

        protected virtual void OnGestorben()
        {
            Gestorben?.Invoke(this, EventArgs.Empty);
        }
        
        public abstract bool IstTot();

    }
}