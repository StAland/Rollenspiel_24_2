namespace Logik
{
    public class BattleManager
    {

        private ISpieler _spieler;
        private Gegner _gegner;


        public BattleManager (Spieler spieler, Gegner gegner)
        {
            _spieler = spieler;
            _gegner = gegner;
        }

        public void Attack(Action<string> ausgabe)
        {
            //Attack(_spieler, _gegner, ausgabe);
            //Attack(_gegner, _spieler, ausgabe);
        }

        private void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
        {

            
            int schaden = defender.NimmtSchaden(attacker.Angriff); 

            ausgabe($"{attacker.Name} greift {defender.Name} an und verursacht {schaden} Schaden.");

            if (defender.IstTot())
            {
                ausgabe($"{defender.Name} wurde besiegt!");

                if (defender is Spieler)
                {
                    //MessageBox.Show("Du wurdest besiegt!");
                    //Application.Restart();
                }
                else if (attacker is Spieler spieler && defender is Gegner gegner)
                {
                    //spieler.ErfahrungErhalten(gegner.Erfahrungszuwachs, ausgabe);
                    ausgabe($"{spieler.Name} erhält {gegner.Erfahrungszuwachs} XP!");
                }
            }
        }
        public void UseItem(Gegenstand item)
        {
            UseItem(_spieler, item);
            
        }
        private void UseItem(ISpieler spieler, Gegenstand item)
        {
            if (spieler is Spieler actualSpieler)
            {
                //int vorherLeben = actualSpieler.Leben;
                //int vorherMana = actualSpieler.Mana;

                actualSpieler.UseItem(item);

                //int geheilt = actualSpieler.Leben - vorherLeben;
                //int manaReg = actualSpieler.Mana - vorherMana;

                //if (geheilt > 0)
                //    ausgabe($"{actualSpieler.Name} verwendet {item.Name} und heilt sich um {geheilt} HP.");
                //if (manaReg > 0)
                //    ausgabe($"{actualSpieler.Name} verwendet {item.Name} und regeneriert {manaReg} Mana.");


                //Attack(gegner, spieler, ausgabe);
            }
        }
        private void UseItem(Charakter spieler, Gegenstand item, Action<string> ausgabe)
        {
            if (spieler is Spieler actualSpieler)
            {
                //int vorherLeben = actualSpieler.Leben;
                //int vorherMana = actualSpieler.Mana;

                actualSpieler.UseItem(item);

                //int geheilt = actualSpieler.Leben - vorherLeben;
                //int manaReg = actualSpieler.Mana - vorherMana;

                //if (geheilt > 0)
                //    ausgabe($"{actualSpieler.Name} verwendet {item.Name} und heilt sich um {geheilt} HP.");
                //if (manaReg > 0)
                //    ausgabe($"{actualSpieler.Name} verwendet {item.Name} und regeneriert {manaReg} Mana.");

                
                //Attack(gegner, spieler, ausgabe);
            }
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


    }
}