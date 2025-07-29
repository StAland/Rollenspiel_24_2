using Logik;
using System.Drawing;

namespace RollenspielTests
{
    public class Tests
    {
        private Spieler _spieler;
        private string spielername = "Test";
        private int leben = 15;
        private int mana = 5;
        private int angriff = 7;
        private int ruestung = 7;
        private int level = 1;
        private string klasse = "Testklasse";
        private int erfahrung = 0;
        Point position = new Point(1, 3);
        List<Gegenstand> inventar = new List<Gegenstand>();

        [SetUp]
        public void Setup()
        {
            

            _spieler = new Spieler(spielername,
                leben,
                mana,
                angriff,
                ruestung,
                level,
                klasse,
                erfahrung,
                inventar,
                position);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual(leben, _spieler.Leben);
            Assert.AreEqual(level, _spieler.Level);
        }

        [Test]
        public void TestBewegen()
        {
            _spieler.Bewegen("rechts");
            var erwartetX = 2;
            var erwartetY = 3;
            Assert.AreEqual(erwartetX, _spieler.Position.X);
            Assert.AreEqual(erwartetY, _spieler.Position.Y);           
        }

        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void Test_SetArmor(int value, int erwartet)
        {
            _spieler.SetArmor(value);
            Assert.AreEqual(erwartet, _spieler.Ruestung);
        }

        [Test]
        public void SetArmor_Kleiner0_WirftException()
        {
            Assert.Throws<ArgumentException>(() => _spieler.SetArmor(-2));
        }

        [Test]
        public void ErfahrungErhalten_Kleiner0_WirftException()
        {
            Assert.Throws<ArgumentException>(() => _spieler.ErfahrungErhalten(-10));
        }
    }
}