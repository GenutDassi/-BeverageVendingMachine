using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups.Decorator
{
    internal class SugarDecorator : CupDecorator
    {

        public SugarDecorator(Cup cup) : base(cup)
        {
            cup.sugarTeaspoons+=2;
            logger.InsertLog("addind 2 teaspoons of sugar");
        }
        public override double GetPrice()
        {
            return cup.GetPrice() + 1;
        }
    }
}
