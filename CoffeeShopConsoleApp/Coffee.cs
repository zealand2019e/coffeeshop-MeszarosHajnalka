using System;

namespace CoffeeShopConsoleApp
{
   public enum CoffeeType
    {
        Akmel,
        Halo,
        Kieni
    };

    public abstract class Coffee
    {
        private int discount;
        private CoffeeType coffeeType;     

        public Coffee(int discount, CoffeeType coffeeType)
        {
            this.coffeeType = coffeeType;
            this.discount = discount;
            if (discount > 5)
            {
                Console.WriteLine("Discount cannot be more than 5");
                throw new Exception("Discount cannot be more than 5");
            }
        }

        public int Discount { get => discount; set => discount = value; }
        public CoffeeType CoffeeType { get => coffeeType; set => coffeeType = value; }

        public virtual int price()
        {
            return 20;
        }

        public virtual string Strength()
        {
            return "string";
        }
    }
}
