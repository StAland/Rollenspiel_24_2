using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public interface ISpieler : ICharakter
    {
        bool UseItem(Gegenstand item);
        List<Gegenstand> GetVerbauchsgegenstaende();
        void Bewegen(Point neuePosition);
        void ErfahrungErhalten(int erfahrung);
        bool LevelUp();
    }
}
