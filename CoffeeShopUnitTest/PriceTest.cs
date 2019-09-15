using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

namespace CoffeeShopUnitTest
{
    [TestClass]
    public class PriceTest
    {
        [TestMethod]
        public void LattePriceTest()
        {   //Arrange: create the object, the testing environment
            Latte latte = new Latte(1, CoffeeType.Akmel);
            //Act:meghívom a metódust
            int priceOfLatte = latte.price();
            //Assert: comparing the expected value with the outcome
            Assert.AreEqual(priceOfLatte,40-latte.Discount);            
        }

        [TestMethod]
        public void CortadoPriceTest()
        {
            Cortado cortado = new Cortado(1,CoffeeType.Akmel);
            int priceOfCortado = cortado.price();
            Assert.AreEqual(priceOfCortado, 25 - cortado.Discount);
        }

        [TestMethod]
        public void FlatwhitePriceTest()
        {
            FlatWhite flatwhite = new FlatWhite(1,CoffeeType.Akmel);
            int priceOfFlatwhite = flatwhite.price();
            Assert.AreEqual(priceOfFlatwhite,50);
        }



    }
}
