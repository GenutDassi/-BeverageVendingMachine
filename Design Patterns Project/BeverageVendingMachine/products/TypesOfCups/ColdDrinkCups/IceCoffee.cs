namespace BeverageVendingMachine.NewFolder.TypesOfCups.ColdDrinkCups
{
    internal class IceCoffee : CupOfCoffee, IColdDrink
    {
        public IceCoffee()
        {
            AddIce();
        }
        public void AddIce()
        {
            logger.InsertLog("adding ice cubes");
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 0.5;
        }
    }
}