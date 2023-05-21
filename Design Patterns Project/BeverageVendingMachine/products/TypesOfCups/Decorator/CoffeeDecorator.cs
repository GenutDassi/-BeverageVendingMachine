using BeverageVendingMachine.NewFolder.TypesOfCups;
using BeverageVendingMachine.NewFolder.TypesOfCups.Decorator;
using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.products.TypesOfCups.Decorator
{
    internal class CoffeeDecorator: CupDecorator
    {
        public CoffeeDecorator(Cup cup):base(cup)
        {
            cup.sugarTeaspoons+=2;
            logger.InsertLog("addind 2 teaspoons of coffee");
        }
        public override double GetPrice()
        {
            return cup.GetPrice()+ 1.5;
        }
    }
}
