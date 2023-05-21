using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups
{
    public class CupOfCoffee : Cup
    {
        
        protected double coffeeTeaspoons;
        public CupOfCoffee()
        {
            this.sugarTeaspoons = 2;
            this.coffeeTeaspoons = 2;
            logger.InsertLog("adding 2 ts of sugar and 2 ts of coffee");
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 1;
        }

    }
}
