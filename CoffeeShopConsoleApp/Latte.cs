using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte:Coffee, IMilk
    {
        public Latte(int discount, CoffeeType coffeeType) : base(discount, coffeeType)
        {
        }

        public int mlMilk()
        {
            return 200;
        }

        public override int price()
        {
            return 40-Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
