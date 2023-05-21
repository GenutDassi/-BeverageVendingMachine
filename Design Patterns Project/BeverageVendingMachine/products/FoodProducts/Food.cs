using BeverageVendingMachine.logger;
using BeverageVendingMachine.singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.FoodProducts
{
    public class Food : IProduct
    {
        protected Logging logger;
        public Food()
        {
            this.logger = SingletonLogger.GetLoggerInstance();
        }
        public virtual double GetPrice()
        {
            return 1.5;
        }
    }
}
