using Logik;
using System.Drawing;

namespace RollenspielTests
{
    public class Spielertests
    {
        private Spieler _spieler;
        private string spielername = "Test";
        private int leben = 15;
        private int mana = 5;
        private int angriff = 7;
        private int ruestung = 7;
        private int level = 1;
        private string klasse = "Testklasse";
        private int erfahrung = 5;
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
            Assert.That(_spieler.Leben, Is.EqualTo(leben));
            Assert.That(_spieler.Level, Is.EqualTo(level));
            Assert.That(_spieler.Klasse, Is.EqualTo(klasse));
            Assert.That(_spieler.Erfahrung, Is.EqualTo(erfahrung));
            Assert.That(_spieler.Position.X, Is.EqualTo(1));
            Assert.That(_spieler.Position.Y, Is.EqualTo(3));
            Assert.That(_spieler.Ruestung, Is.EqualTo(7));
            Assert.That(_spieler.Angriff, Is.EqualTo(7));
            Assert.That(_spieler.Mana, Is.EqualTo(5));
            Assert.That(_spieler.Name, Is.EqualTo(spielername));

            Assert.IsInstanceOf<Point>(_spieler.Position);
            Assert.IsInstanceOf<Spieler>(_spieler);
        }

        [Test]
        public void TestBewegen()
        {
            _spieler.Bewegen("rechts");
            var erwartetX = 2;
            var erwartetY = 3;
            Assert.That(_spieler.Position.X, Is.EqualTo(erwartetX));
            Assert.That(_spieler.Position.Y, Is.EqualTo(erwartetY));           
        }

        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void Test_SetArmor(int value, int erwartet)
        {
            _spieler.SetArmor(value);
            Assert.That(_spieler.Ruestung, Is.EqualTo(erwartet));
        }

        [Test]
        public void SetArmor_Kleiner0_WirftException()
        {
            Assert.Throws<ArgumentException>(() => _spieler.SetArmor(-2));
        }

        [Test]
        public void TestErfahrungErhalten()
        {
            int bestehendeErfahrung = _spieler.Erfahrung;
            int neueErfahrung = 10;
            int gesamteErfahrung = bestehendeErfahrung + neueErfahrung;
            _spieler.ErfahrungErhalten(neueErfahrung);
            Assert.That(_spieler.Erfahrung, Is.EqualTo(gesamteErfahrung));
        }

        [Test]
        public void TestLevelUp()
        {
            bool istLevelUp = _spieler.LevelUp();
            Assert.IsFalse(istLevelUp);

            typeof(Spieler).GetProperty("Erfahrung").SetValue(_spieler, 100);
            typeof(Spieler).GetProperty("Level").SetValue(_spieler, 1);
            Assert.IsTrue(_spieler.LevelUp());
        }
    }
}