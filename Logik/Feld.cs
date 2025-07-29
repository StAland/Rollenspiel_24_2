using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    internal class Feld
    {
        //private string _name;
        private bool _isBetretbar;

        public Feld(string name, bool isBetretbar)
        {
            Name = name;
            _isBetretbar = isBetretbar;
        }

        public bool IsBetretbar() {  return _isBetretbar; }
        public string Name { get; }
    }
}
