using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class EreignisWahrscheinlichkeit(int gewichtung, IEreignis? ereignis = null)
    {
        public int Gewichtung { get; } = gewichtung;
        public IEreignis? Ereignis { get; } = ereignis;
    }
}
