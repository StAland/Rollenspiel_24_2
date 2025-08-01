using Logik;

namespace Rollenspiel_24_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
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
            var _spieler  = new Spieler(spielername,
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
            var gegner = new Gegner("name", 100, 20, 20, 10, 10, 5, 2, "none", 10, new System.Drawing.Point(0, 0));

            Application.Run(new Kampfübersicht(_spieler, gegner));
        }
    }
}