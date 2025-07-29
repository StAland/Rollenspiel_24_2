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

        List<Gegenstand> _inventar = new List<Gegenstand>();



        public Spieler(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse, int erfahrung, List<Gegenstand> inventar, Point position)
            : base(name, leben, mana, angriff, ruestung, klasse, position)
        {
            Erfahrung = erfahrung;
            _inventar = inventar;
        }

        // !!!!!!!!!! Entkommentieren, wenn Inventar Name Property hat !!!!!!

        //public bool InventarCheck(Gegenstand item)
        //{
        //    return _inventar.Any(gegenstand => gegenstand.Name == item.Name);
        //}

        //public void RemoveItemFromList(Gegenstand item)
        //{
        //    if (InventarCheck(item))
        //    {
        //        _inventar.Remove(item);
        //    } ;
        //}

        public void AddItemToList(Gegenstand item)
        {
            _inventar.Add(item);
        }

        //Bewegung des Spielers mit Point
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
        }

        public void ErfahrungErhalten(int erfahrung)
        {
            Erfahrung += erfahrung;
        }
        public void Ausruesten(Gegenstand item)
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
    }
}