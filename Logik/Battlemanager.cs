namespace Logik
{
    public class BattleManager
    {
        private Spieler _spieler;
        private Gegner _gegner;
        private Action<string> _ausgabe;

        public BattleManager(Spieler spieler, Gegner gegner, Action<string> ausgabe)
        {
            _spieler = spieler;
            _gegner = gegner;
            _ausgabe = ausgabe;
            _spieler.Gestorben += SpielerGestorben;
            _gegner.Gestorben += GegnerGestorben;
        }

        public void Attack(Action<string> ausgabe)
        {
            Attack(_spieler, _gegner, ausgabe);
            Attack(_gegner, _spieler, ausgabe);
        }

        private static void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
        {
            int schaden = defender.NimmtSchaden(attacker.Angriff);
            ausgabe($"{attacker.Name} greift {defender.Name} an und verursacht {schaden} Schaden.");
        }

        public void UseItem(Gegenstand item)
        {
            UseItem(_spieler, _gegner, item);
        }

        private void UseItem(Spieler spieler, Gegner gegner, Gegenstand item)
        {
            if (spieler is Spieler actualSpieler && item is Verbrauchsgegenstand verbrauchsgegenstand)
            {
                actualSpieler.UseItem(verbrauchsgegenstand);
                int heilamount = actualSpieler.Heilen(verbrauchsgegenstand);
                _ausgabe($"{actualSpieler.Name} heilt sich um {heilamount} Lebenspunkte.");
                Attack(gegner, spieler, _ausgabe);
            }
        }

        public bool Fliehen(Action<string> ausgabe)
        {
            ausgabe($"{_spieler.Name} versucht zu fliehen!");
            Random random = new();
            bool fluchtErfolgreich = random.Next(100) < 60;
            if (fluchtErfolgreich)
            {
                ausgabe($"{_spieler.Name} ist erfolgreich geflohen!");
                return true;
            }
            else
            {
                ausgabe($"Flucht fehlgeschlagen! {_gegner.Name} holt {_spieler.Name} ein!");
                Attack(_gegner, _spieler, ausgabe);
                return false;
            }
        }

        private void SpielerGestorben(object? sender, EventArgs e)
        {
            _ausgabe?.Invoke($"{_spieler.Name} ist gestorben!");
           
        }

        private void GegnerGestorben(object? sender, EventArgs e)
        {
            int xp = _gegner.Erfahrungszuwachs;
            _spieler.ErfahrungErhalten(xp);
            _ausgabe?.Invoke($"{_spieler.Name} hat {_gegner.Name} besiegt und erhält {xp} XP!");
        }
    }
}