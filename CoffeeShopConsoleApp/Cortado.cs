namespace CoffeeShopConsoleApp
{
    internal class Cortado : Coffee, IMilk
    {
        public Cortado(int discount, CoffeeType coffeeType) : base(discount, coffeeType)
        {
        }

        public int mlMilk()
        {
            return 40;
        }

        public override int price()
        {
            return 25-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
