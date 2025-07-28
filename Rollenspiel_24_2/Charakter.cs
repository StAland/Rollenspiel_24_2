using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollenspiel_24_2
{
    public abstract class Charakter
    {
        public string Name { get; }
        public int Leben { get; private set; }
        public int Mana { get; private set; }

        public int Angriff { get; private set; }
        public int Ruestung { get; private set; }
        
        public string Klasse { get; private set; }

        //Ausrüstung für den Charakter als Liste
        private List<string> _ausruestung = new List<string>();

        public Point position = new Point(0, 0);

        public Charakter(string name, int leben, int mana, int angriff, int ruestung, string klasse)
        {
            Name = name;
            Leben = leben;
            Mana = mana;
            Angriff = angriff;
            Ruestung = ruestung;
            Klasse = klasse;
        }

        public void Angreifen()
        {
            return;
        }

        public void Heilen()
        {
            return;
        }

        public void SetArmor(int neueRuestung)
        {
            return;
        }
        public void GetPosition()
        {
            return;
        }
        public void SetMana()
        {
            return;
        }
        public void NimmtSchaden()
        {
            return;
        }
        public void IstTot()
        {
            return;
        }
    }
}
