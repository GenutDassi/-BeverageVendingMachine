using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups.HotDrinks
{
    internal class HotCupOfChocolateMilk : CupOfChocolateMilk, IHotDrink
    {
        public HotCupOfChocolateMilk()
        {
            Boil();
        }
        public void Boil()
        {
            logger.InsertLog("water is boiling");
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 1;
        }
    }
}
