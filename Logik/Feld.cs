using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class Feld
    {
        public enum Feldtyp
        {
            Berg,
            Feld,
            Wasser,
            Strasse
        }
        //private string _name;
        private bool _isBetretbar;
        public List<EreignisWahrscheinlichkeit> Ereignisse { get; }

        public Feld(string name, bool isBetretbar, List<EreignisWahrscheinlichkeit>? ereignisse = null)
        {
            Name = name;
            _isBetretbar = isBetretbar;
            Ereignisse = ereignisse == null ? new List<EreignisWahrscheinlichkeit>() : ereignisse;          
        }

        public bool IsBetretbar() {  return _isBetretbar; }
        public string Name { get; }
    }
}
