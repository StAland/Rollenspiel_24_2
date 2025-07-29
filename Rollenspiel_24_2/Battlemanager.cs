using Rollenspiel_24_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rollenspiel
{
    public static class BattleManager
    {
        public static void Attack(Charakter attacker, Charakter defender, Action<string> ausgabe)
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

        public static void UseItem(Charakter spieler, string item, Action<string> ausgabe)
        {
            if (spieler is Spieler actualSpieler && actualSpieler._inventar.Contains(item))
            {
                ausgabe($"{actualSpieler.Name} verwendet {item}.");
                actualSpieler._inventar.Remove(item);
            }
            else
            {
                ausgabe($"{spieler.Name} hat {item} nicht im Inventar.");
            }
        }
        public static bool fliehen(Charakter spieler, Charakter gegner, Action<string> ausgabe)
        {
            ausgabe($"{spieler.Name} versucht zu fliehen!");

            Random random = new Random();
            bool fluchtErfolgreich = random.Next(100) < 60; // 60% Chance erfolgreich zu fliehen

            if (fluchtErfolgreich)
            {
                ausgabe($"{spieler.Name} ist erfolgreich geflohen!");
                return true;
            }
            else
            {
                ausgabe($"Flucht fehlgeschlagen! {gegner.Name} holt {spieler.Name} ein!");
                Attack(gegner, spieler, ausgabe); // Gegner bekommt einen freien Angriff
                return false;
            }
        }
    }
}