using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.FoodProducts
{
    public class Sweet : Food
    {
        
    }
    public class Chocolate : Sweet
    {
        public Chocolate()
        {
            logger.InsertLog("choclote has been orderd");

        }
        public virtual double GetPrice()
        {
            return base.GetPrice()+5;
        }
    }
    public class Shuggi: Sweet
    {
        public Shuggi()
        {
            logger.InsertLog("shuggi has been orderd");

        }
        public virtual double GetPrice()
        {
            return base.GetPrice() + 2;
        }
    }
}
