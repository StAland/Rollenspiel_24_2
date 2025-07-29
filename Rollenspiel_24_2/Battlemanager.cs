using Rollenspiel_24_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollenspiel
{
    public  class BattleManager
    {
        public  void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
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
                    MessageBox.Show("Du wurdest besiegt!");
                    Application.Restart();
                }
                else if (attacker is Spieler spieler && defender is Gegner gegner)
                {
                    spieler.ErfahrungErhalten(gegner.Erfahrungszuwachs, ausgabe);
                    ausgabe($"{spieler.Name} erhält {gegner.Erfahrungszuwachs} XP!");
                }
            }
        }

        public  void UseItem(Charakter spieler,Charakter gegner, string item, Action<string> ausgabe)
        {
            if (spieler is Spieler actualSpieler && actualSpieler._inventar.Contains(item))
            {
                if (item == "Heiltrank")
                {
                    actualSpieler.Heilen(10);
                    ausgabe($"{actualSpieler.Name} verwendet {item} und heilt 10 HP.");
                    actualSpieler._inventar.Remove(item);
                    Attack(gegner, spieler, ausgabe);
                }
                else if (item == "Mana-Trank")
                {
                    actualSpieler.SetMana(actualSpieler.Mana + 5); 
                    ausgabe($"{actualSpieler.Name} verwendet {item} und regeneriert 5 Mana.");
                    actualSpieler._inventar.Remove(item);
                    Attack(gegner, spieler, ausgabe);
                }


            }
            else
            {
                ausgabe($"{spieler.Name} hat {item} nicht im Inventar.");
            }
        }
        public  bool fliehen(Charakter spieler, Charakter gegner, Action<string> ausgabe)
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