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

        //Position des Spielers auf dem Spielfeld mit Point-Klasse
        public Point Position { get; private set; }

        public Spieler(string name, int leben, int mana, int angriff, int ruestung, int level, string klasse, int erfahrung, List<string> inventar, Point position)
            : base(name, leben, mana, angriff, ruestung, klasse)
        {
            Erfahrung = erfahrung;
            _inventar = inventar;
            Position = position;
        }

        public void GetItemFromList()
        {
            return;
        }
        public void SetItemtoList()
        {
            return;
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
        public void SetLevel()
        {
            return;
        }
        public void ErfahrungErhalten()
        {
            return;
        }
        public void Ausruesten()
        {
            return;
        }
        private void LevelUp()
        {
            return;
        }
    }
}
