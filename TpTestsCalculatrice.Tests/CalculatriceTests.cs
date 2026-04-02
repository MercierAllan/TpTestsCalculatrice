using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpTestsCalculatrice.App;

namespace TpTestsCalculatrice.Tests;

[TestClass]
public class CalculatriceTests
{
    [TestMethod]
    public void Addition_Retourne5_Si2Plus3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(0, 0);
        Assert.AreEqual(0, resultat);
        int resultat2 = calc.Addition(-1, 1);
        Assert.AreEqual(0, resultat2);
        int resultat3 = calc.Addition(100, 200);
        Assert.AreEqual(300, resultat3);
    }
}