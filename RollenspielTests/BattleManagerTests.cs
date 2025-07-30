using Logik;
using Moq;

namespace RollenspielTests;

public class BattleManagerTests
{
    private BattleManager _battleManager;
    private Gegenstand _heiltrank = new Heiltrank();
    private Gegenstand _manatrank = new Manatrank();

    [SetUp]
    public void Setup()
    {
        Gegner gegner = new Gegner("", 2, 3, 4, 2, 1, "", 1, new System.Drawing.Point(1, 2));
        var spieler = new Mock<ISpieler>();
        spieler.Setup(s => s.UseItem(_heiltrank)).Returns(true);
        spieler.Setup(s => s.UseItem(_manatrank)).Returns(false);
    }

    private void test(string message)
    {

    }

    [Test]
    public void UseItemInInventory()
    {
        //Assert.AreEqual(true, _battleManager.UseItem(_heiltrank));
    }
}
