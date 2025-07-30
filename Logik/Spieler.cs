using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Spieler : Charakter, ISpieler
    {
        private ILogging _logger;
        public int Level { get; private set; }
        public int Erfahrung { get; private set; }

        List<Gegenstand> _inventar = new List<Gegenstand>();

        public Spieler(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse, int erfahrung, List<Gegenstand> inventar, Point position, ILogging logger)
            : base(name, leben, mana, angriff, ruestung, klasse, position)
        {
            Erfahrung = erfahrung;
            _inventar = inventar;
            Level = level;
            _logger = logger;
        }

        public bool InventarCheck(Gegenstand item)
        {
            return _inventar.Any(gegenstand => gegenstand.Name == item.Name);
        }

        public void RemoveItemFromList(Gegenstand item)
        {
            if (InventarCheck(item))
            {
                _inventar.Remove(item);
            };
        }

        public void AddItemToList(Gegenstand item)
        {
            _inventar.Add(item);
        }

        public bool UseItem (Gegenstand item)
        {
            if (InventarCheck(item))
            {
                if (item is Verbrauchsgegenstand verbrauch)
                {
                    UseVerbrauchsgegenstand(verbrauch);
                    return true;
                }
                else if (item is Ausruestung ausruestung)
                {
                    ausruesten(ausruestung);
                    return true;
                }
                else
                {
                    Console.WriteLine("Unbekannter Gegenstandstyp.");
                    _logger.Log("Unbekannter Gegenstandstyp");
                }
            }
            else
            {
                Console.WriteLine("Der gesuchte Gegenstand befindet sich nicht im Inventar.");
            }
            return false;
        }

        private void UseVerbrauchsgegenstand(Verbrauchsgegenstand item)
        {
            Heilen(item);
            RemoveItemFromList(item);
        }

        private void ausruesten(Ausruestung item)
        {
            Ausruesten(item);
            RemoveItemFromList(item);
        }

        public List<Gegenstand> GetVerbauchsgegenstaende()
        {
            return _inventar.Where(item => item is Verbrauchsgegenstand).ToList();
        }


        /*//Bewegung des Spielers mit Point
        public void Bewegen(string bewegung)
        {
            switch (bewegung.ToLower())
            {
                case "oben":
                    Position = new Point(Position.X, Position.Y - 1);
                    break;
                case "unten":
                    Position = new Point(Position.X, Position.Y + 1);
                    break;
                case "links":
                    Position = new Point(Position.X - 1, Position.Y);
                    break;
                case "rechts":
                    Position = new Point(Position.X + 1, Position.Y);
                    break;
                default:
                    Console.WriteLine("Ungültige Bewegung");
                    break;
            }
        }*/

        public void ErfahrungErhalten(int erfahrung)
        {
            Erfahrung += erfahrung;
        }
        private void Ausruesten(Gegenstand item)
        {
            _ausruestung.Add(item);
        }

        public bool LevelUp()
        {
            if (Erfahrung >= Level * 100)
            {
                Level++;
                Leben += 10;
                Mana += 5;
                Angriff += 2;
                Ruestung += 1;
                Console.WriteLine($"{Name} ist auf Level {Level} aufgestiegen!");
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void Bewegen(Point neuePosition)
        {
            throw new NotImplementedException();
        }



        void ISpieler.Bewegen(Point neuePosition)
        {
            Bewegen(neuePosition);
        }

        public override bool IstTot()
        {
            if (Leben <= 0)
            {
                Console.WriteLine("Du bist tot");
                return true;
            }
            return false;
        }
    }
}