using BeverageVendingMachine.logger;
using BeverageVendingMachine.NewFolder.TypesOfCups;
using BeverageVendingMachine.NewFolder.TypesOfCups.ColdDrinkCups;
using BeverageVendingMachine.NewFolder.TypesOfCups.HotDrinks;
using BeverageVendingMachine.singleton;
using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder
{
    internal class CreatorCup : Creator
    {
        Logging logger;
        public CreatorCup(DefineType defineType) : base(defineType)
        {
            this.logger = SingletonLogger.GetLoggerInstance();
        }

        internal override IProduct Create()
        {
            switch (this.type.ProductType)
            {
                case ProductType.HotCupOfCoffee:
                    return new HotCupOfCoffee();
                    logger.InsertLog("hot cup of coffee begiging order");
                case ProductType.IceCoffee:
                    logger.InsertLog("ice coffee has begiging order");
                    return new IceCoffee();
                case ProductType.HotCupOfChocolateMilk:
                    logger.InsertLog("hot cup of chocolatemilk has begiging order");
                    return new HotCupOfChocolateMilk();
                case ProductType.ColdCupOfChocolateMilk:
                    logger.InsertLog("cold cup of chocolatemilk has begiging order");
                    return new ColdCupOfChocolateMilk();
                    default:
                    throw new NotImplementedException("Type wasn't provided");
            }

        }
    }
}
