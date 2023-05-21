using BeverageVendingMachine.logger;
using BeverageVendingMachine.singleton;
using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups
{
    public class Cup : IProduct
    {
       internal Logging logger;
       public int sugarTeaspoons;
       public int waterMl;
       public int milkMl;
        public Cup(bool isDecorator=false)
        {
            this.logger = SingletonLogger.GetLoggerInstance();
            if(!isDecorator)
            {
                Prepaering();
            }
        }
        internal void Prepaering()
        {
            waterMl = 100;
            milkMl = 100;
            Notify.UpdateDB("Milk", "Water");
            logger.InsertLog("puring water and milk into a cup");
        }



        public virtual double GetPrice()
        {
            return 1;
        }
    }
}
