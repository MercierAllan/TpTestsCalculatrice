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
        int resultat = calc.Max(3, 7);
        Assert.AreEqual(7, resultat);
        int resultat2 = calc.Max(10, 2);
        Assert.AreEqual(10, resultat2);
        int resultat3 = calc.Max(5, 5);
        Assert.AreEqual(5, resultat3);
    }
}