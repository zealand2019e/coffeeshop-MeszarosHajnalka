using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

namespace CoffeeShopUnitTest
{
    [TestClass]
    public class StrengthTest
    {
    [TestMethod]
     public void StrengthTestForAllCoffee()
        {
            Latte latte = new Latte(1,CoffeeType.Akmel);
            Cortado cortado = new Cortado(1,CoffeeType.Akmel);
            BlackCoffee blackCoffee = new BlackCoffee(1, CoffeeType.Akmel);
            FlatWhite flatWhite = new FlatWhite(1, CoffeeType.Akmel);

            string strengthOfLatte = latte.Strength();
            string strengthOfCortado = cortado.Strength();
            string strengthOfBlackCoffee = blackCoffee.Strength();
            string strengthOfFlatWhite = flatWhite.Strength();

            Assert.AreEqual(strengthOfLatte,"Weak");
            Assert.AreEqual(strengthOfCortado, "Medium");
            Assert.AreEqual(strengthOfBlackCoffee, "Strong");
            Assert.AreEqual(strengthOfFlatWhite, "Medium");
        }
    }
}
