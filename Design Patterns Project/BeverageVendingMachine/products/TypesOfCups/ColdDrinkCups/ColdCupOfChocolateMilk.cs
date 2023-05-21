using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups.ColdDrinkCups
{
    internal class ColdCupOfChocolateMilk : CupOfChocolateMilk, IColdDrink
    {
        public ColdCupOfChocolateMilk()
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
