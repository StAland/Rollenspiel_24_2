using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Karte
    {
        public enum Richtung
        {
            hoch,
            runter,
            links,
            rechts
        }
        private Feld[,] felder;
        private Spieler _spieler;
        public Feld[,] Felder { get {  return felder; } }
        public Spieler Spieler {  get { return _spieler; } }

        public Karte()
        {
            // ToDo Karte aus Json File oder ähnlichem laden
            CreateRandomMap();
            CreateRandomPlayer();
        }

        private void CreateRandomMap()
        {
            int x = 10;
            int y = 10;
            var rand = new Random();
            felder = new Feld[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var gewichtungKampf = rand.Next(0, 50);
                    var kampf = new Kampfereignis();
                    var kampfGewichtung = new EreignisWahrscheinlichkeit(gewichtungKampf, kampf);
                    var gewichtungNichts = rand.Next(0, 50);
                    var nichtsGewichtung = new EreignisWahrscheinlichkeit(gewichtungNichts);
                    var ereignisse = new List<EreignisWahrscheinlichkeit>
                    {
                        nichtsGewichtung,
                        kampfGewichtung
                    };
                    var begehbar = rand.Next(0, 100) < 80;
                    felder[i, j] = new Feld("Feldname", begehbar, ereignisse);
                }
            }
        }

        private void CreateRandomPlayer()
        {
            
            string spielername = "Test";
            int leben = 15;
            int mana = 5;
            int angriff = 7;
            int ruestung = 7;
            int level = 1;
            string klasse = "Testklasse";
            int erfahrung = 5;
            Point position = new Point(1, 3);
            List<Gegenstand> inventar = new List<Gegenstand>();
            ILogging logger = new ConsolenLogger();
            _spieler = _spieler = new Spieler(spielername,
                leben,
                leben,
                mana,
                mana,
                angriff,
                ruestung,
                level,
                klasse,
                erfahrung,
                inventar,
                position,
                logger);
        }

        public bool IsBetretbar(Point point)
        {
            // Prüfen ob die Position gültig ist
            if (point.X < 0 || point.Y < 0 || point.X >= felder.GetLength(0) || point.Y >= felder.GetLength(1))
                return false;

            // Hole das Feld an der Position
            Feld feld = felder[point.X, point.Y];

            // Überprüfe, ob das Feld betreten werden darf
            return feld.IsBetretbar();
           
        }

        public void Bewegen(Richtung richtung)
        {
            Point aktuellePosition = _spieler.Position;
            Point neuePosition = aktuellePosition;

            switch (richtung)
            {
                case Richtung.hoch:
                    neuePosition.Y -= 1;
                    break;
                case Richtung.runter:
                    neuePosition.Y += 1;
                    break;
                case Richtung.links:
                    neuePosition.X -= 1;
                    break;
                case Richtung.rechts:
                    neuePosition.X += 1;
                    break;
            }
            // dürfen wir dieses Feld betreten 
            // wenn ja dann bewegen Funktion des spielers aufrufen 
            if (IsBetretbar(neuePosition))
            {
                _spieler.Bewegen(neuePosition);
            }
            //else
            //{
            //    Console.WriteLine("Feld ist nicht betretbar");
            //}
        }
        public bool IstBegehbar(Richtung richtung)
        {
            Point aktuellePosition = _spieler.Position;
            Point neuePosition = aktuellePosition;

            switch (richtung)
            {
                case Richtung.hoch:
                    neuePosition.Y -= 1;
                    break;
                case Richtung.runter:
                    neuePosition.Y += 1;
                    break;
                case Richtung.links:
                    neuePosition.X -= 1;
                    break;
                case Richtung.rechts:
                    neuePosition.X += 1;
                    break;
            }

            return IsBetretbar(neuePosition);
        }

        public IEreignis EreignisAuslösen()
        {
            var position = _spieler.Position;
            var feld = Felder[position.X, position.Y];

            if (feld == null) return null;
            var ereignisse = feld.Ereignisse;

            if (ereignisse == null || ereignisse.Count == 0) return null;
            var gewichtungssumme = ereignisse.Sum(x => x.Gewichtung);
            var rand = new Random();
            var zufall = rand.Next(0, gewichtungssumme);
            var summe = 0;
            IEreignis? ereignis = null;
            foreach (var e in ereignisse)
            {
                summe += e.Gewichtung;
                if (summe >= zufall)
                {
                    ereignis = e.Ereignis;
                    break;
                }
            }
            
            if (ereignis == null) return null;
            return ereignis;
        }
    }
}
