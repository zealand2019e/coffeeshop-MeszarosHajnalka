using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee:Coffee
    {
        public BlackCoffee(int discount, CoffeeType coffeeType) : base(discount, coffeeType)
        {
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
