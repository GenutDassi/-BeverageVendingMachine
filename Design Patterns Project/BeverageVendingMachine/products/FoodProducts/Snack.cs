using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.FoodProducts
{
    public class Snack : Food
    {
        public override double GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
    public class Bamba : Snack
    {
        public Bamba()
        {
            logger.InsertLog("bamba has been orderd");
        }
    }
    public class Chips : Snack
    {
        public Chips()
        {
            logger.InsertLog("chips has been orderd");

        }
    }
    public class Bisly : Snack
    {
        public Bisly()
        {
            logger.InsertLog("bisly has been orderd");

        }
    }
}
