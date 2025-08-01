using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public interface IEreignis
    {
        void ausloesen(Spieler spieler);
    }
}
