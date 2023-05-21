using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.FoodProducts
{
    public class Bottle:Food
    {
       public override double GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
    public class Water: Bottle
    {
        public Water()
        {
            logger.InsertLog("water bottole has been orderd");

        }
    }
    public class OrangeJuice : Bottle
    {
        public OrangeJuice()
        {
            logger.InsertLog("orange juice bottole has been orderd");

        }
        public override double GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
    public class CokaCola : Bottle
    {
        public CokaCola()
        {
            logger.InsertLog("coka-cola bottole has been orderd");

        }
        public override double GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
}
