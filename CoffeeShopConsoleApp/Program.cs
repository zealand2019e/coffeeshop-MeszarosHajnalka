namespace CoffeeShopConsoleApp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        internal static void Main(string[] args)
        {

            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(4, CoffeeType.Akmel),
                new BlackCoffee(3, CoffeeType.Kieni),
                new Cortado(4, CoffeeType.Halo)
            };

            List<IMilk> milkylist = new List<IMilk>();
            milkylist.Add(new Latte(1, CoffeeType.Akmel));
            milkylist.Add(new Cortado(2, CoffeeType.Halo));

            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : " + coffee.price() + ", the strength of the coffe is: " + coffee.Strength() + ", the type of the coffee is " + coffee.CoffeeType);
            }

            foreach (var coffee in milkylist)
            {
                String type;

                if (coffee.GetType().ToString() == "CoffeeShopConsoleApp.Latte")
                {
                    type = "Latte";
                }
                else if (coffee.GetType().ToString() == "CoffeeShopConsoleApp.Cortado")
                {
                    type = "Cortado";
                }
                else
                {
                    type = "tugyaafaszom";
                }

                Console.WriteLine("The " + type + " contains " + coffee.mlMilk().ToString() + " ml milk.");
            }

            Console.ReadKey();
        }
    }
}
