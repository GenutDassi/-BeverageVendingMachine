using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups
{
    public class CupOfChocolateMilk:Cup
    {
        protected int chocolateMilkPowderTeaspoons;
        public CupOfChocolateMilk()
        {
            this.sugarTeaspoons = 2;
            this.chocolateMilkPowderTeaspoons = 2;
            logger.InsertLog("adding 2 ts of sugar and 2 ts of chocolate milk powder");
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 1.5;
        }
        
    }
}
