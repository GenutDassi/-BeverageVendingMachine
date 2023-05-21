using BeverageVendingMachine.NewFolder.FoodProducts;
using BeverageVendingMachine.supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder
{
    internal class CreatorFood : Creator
    {
        public CreatorFood(DefineType defineType) : base(defineType)
        {
        }

        internal override IProduct Create()
        {
            switch (this.type.ProductType)
            {
                case ProductType.Bisly:
                    return new Bisly();
                case ProductType.Bamba:
                    return new Bamba();
                case ProductType.Chips:
                    return new Chips();
                case ProductType.Chocolate:
                    return new Chocolate();
                case ProductType.Shuggi:
                    return new Shuggi();
                case ProductType.Crackers:
                    return new Crackers();
                case ProductType.Cookies:
                    return new Cookies();
                case ProductType.Water:
                    return new Water();
                case ProductType.OrangeJuice:
                    return new OrangeJuice();
                case ProductType.CokaCola:
                    return new CokaCola();
                    default:
                    throw new NotImplementedException("Type wasn't provided");    
            }
        }
    }
}
