namespace Logik
{
    public class BattleManager
    {
        public void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
        {
            int vorherHP = defender.Leben;
            defender.NimmtSchaden(attacker.Angriff);
            int schaden = vorherHP - defender.Leben;

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

        public void UseItem(Charakter spieler, Charakter gegner, Gegenstand item, Action<string> ausgabe)
        {
            if (spieler is Spieler actualSpieler)
            {
                // Prüfen ob der Spieler den Gegenstand besitzt
                if (!actualSpieler.InventarCheck(item))
                {
                    ausgabe($"{spieler.Name} hat {item.Name} nicht im Inventar.");
                    return;
                }

                if (item is Verbrauchsgegenstand verbrauchsItem)
                {
                    // Effekt des Items anwenden
                    switch (verbrauchsItem.ItemTyp)
                    {
                        case ItemTyp.Heiltrank:
                            actualSpieler.Heilen(verbrauchsItem);
                            ausgabe($"{actualSpieler.Name} verwendet {item.Name} und heilt sich.");
                            break;

                        case ItemTyp.ManaTrank:
                            actualSpieler.SetMana(actualSpieler.Mana + verbrauchsItem.Effektstaerke);
                            ausgabe($"{actualSpieler.Name} verwendet {item.Name} und regeneriert {verbrauchsItem.Effektstaerke} Mana.");
                            break;

                        default:
                            ausgabe($"{item.Name} kann nicht verwendet werden.");
                            return;
                    }

                    
                    actualSpieler.RemoveItemFromList(item);

                    
                    Attack(gegner, spieler, ausgabe);
                }
                else
                {
                    ausgabe($"{item.Name} ist kein verwendbarer Gegenstand.");
                }
            }
        }

        public bool Fliehen(Charakter spieler, Charakter gegner, Action<string> ausgabe)
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