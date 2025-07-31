using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public interface ICharakter
    {
        event EventHandler? Gestorben;
        int Heilen(Verbrauchsgegenstand gegenstand);
        void SetArmor(int neueRuestung);
        int SetMana(int neueMana);
        int NimmtSchaden(int schaden);
    }
}
