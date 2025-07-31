using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public interface ICharakter
    {
        void Heilen(Verbrauchsgegenstand gegenstand);
        void SetArmor(int neueRuestung);
        void SetMana(int neueMana);
        int NimmtSchaden(int schaden);
        bool IstTot();
        void OnGestorben();
    }
}
