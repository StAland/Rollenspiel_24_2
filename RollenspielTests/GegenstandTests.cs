using Logik;
using NUnit.Framework;

namespace RollenspielTests
{
    public class GegenstandTests
    {
        [Test]
        public void Heiltrank_IstVerbrauchsgegenstand()
        {
            var heiltrank = new Heiltrank();
            Assert.IsInstanceOf<Verbrauchsgegenstand>(heiltrank);
            Assert.That(heiltrank.Leben, Is.EqualTo(10));
            Assert.That(heiltrank.Mana, Is.EqualTo(0));
        }

        [Test]
        public void Manatrank_IstVerbrauchsgegenstand()
        {
            var manatrank = new Manatrank();
            Assert.IsInstanceOf<Verbrauchsgegenstand>(manatrank);
            Assert.That(manatrank.Leben, Is.EqualTo(0));
            Assert.That(manatrank.Mana, Is.EqualTo(10));
        }

        [Test]
        public void Schwert_IstAusruestung()
        {
            var schwert = new Schwert();
            Assert.IsInstanceOf<Ausruestung>(schwert);
            Assert.That(schwert.Angriff, Is.EqualTo(7));
            Assert.That(schwert.Ruestung, Is.EqualTo(0));
        }

        [Test]
        public void Schild_IstAusruestung()
        {
            var schild = new Schild();
            Assert.IsInstanceOf<Ausruestung>(schild);
            Assert.That(schild.Angriff, Is.EqualTo(0));
            Assert.That(schild.Ruestung, Is.EqualTo(5));
        }
    }
}