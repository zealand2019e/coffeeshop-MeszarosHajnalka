using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class FlatWhite : Coffee
    {
     
        public FlatWhite(int discount, CoffeeType coffeeType) : base(discount, coffeeType)
        {
        }

        public override int price()
        {
            return 50;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
