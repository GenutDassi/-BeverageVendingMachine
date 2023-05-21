using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.FoodProducts
{
    public class BreadProduct :Food
    {
        public override double GetPrice()
        {
            return base.GetPrice() + 6;
        }
    }
    public class Cookies : BreadProduct
    {
        public Cookies()
        {
            logger.InsertLog("cookies have been orderd");

        }
    }
    public class Crackers : BreadProduct
    {
        public Crackers()
        {
            logger.InsertLog("crackers have been orderd");

        }
    }

}
