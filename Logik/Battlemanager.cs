namespace Logik
{
    public class BattleManager
    {
        private Spieler _spieler;
        private Gegner _gegner;

        public BattleManager(Spieler spieler, Gegner gegner)
        {
            _spieler = spieler;
            _gegner = gegner;
            _spieler.Gestorben += SpielerGestorben;
        }

        public void Attack(Spieler spieler, Action<string> ausgabe)
        {
            Attack(_spieler, _gegner, ausgabe);
            Attack(_gegner, _spieler, ausgabe);
        }

        private void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
        {
            int schaden = defender.NimmtSchaden(attacker.Angriff);

            ausgabe($"{attacker.Name} greift {defender.Name} an und verursacht {schaden} Schaden.");
        }

        public void UseItem(Gegenstand item, Action<string> ausgabe)
        {
            UseItem(_spieler,_gegner, item, ausgabe);
        }

        private void UseItem(Spieler spieler,Gegner gegner ,Gegenstand item, Action<string> ausgabe)
        {
            if (spieler is Spieler actualSpieler && item is Verbrauchsgegenstand verbrauchsgegenstand)
            {
                actualSpieler.UseItem(verbrauchsgegenstand);
                int heilamount = actualSpieler.Heilen(verbrauchsgegenstand);
                ausgabe($"{actualSpieler.Name} heilt sich um {heilamount} Lebenspunkte.");
                Attack(gegner, spieler, ausgabe);
            }
        }

        public void Fliehen(Action<string> ausgabe)
        {
            Fliehen(_spieler, _gegner, ausgabe);
        }

        private bool Fliehen(Charakter spieler, Charakter gegner, Action<string> ausgabe)
        {
            ausgabe($"{spieler.Name} versucht zu fliehen!");

            Random random = new Random();
            bool fluchtErfolgreich = random.Next(100) < 60;

            if (fluchtErfolgreich)
            {
                ausgabe($"{spieler.Name} ist erfolgreich geflohen!");
                return true;
            }
            else
            {
                ausgabe($"Flucht fehlgeschlagen! {gegner.Name} holt {spieler.Name} ein!");
                Attack(gegner, spieler, ausgabe);
                return false;
            }
        }

        private void SpielerGestorben(object? sender, EventArgs e)
        {
            // Hier kommt rein, was passiert, wenn der Spieler stirbt
        }
    }
}
