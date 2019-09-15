using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;

namespace CoffeeShopUnitTest
{
    [TestClass]
    public class ExceptionTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExceptionTestMethod()
        {
            Latte latte = new Latte(12,CoffeeType.Halo);
        }
    }
}
