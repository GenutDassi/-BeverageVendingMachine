using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder
{
    internal class DefineType
    {
        public ProductType ProductType { get; set; }
        public DefineType(ProductType productType)
        {
            ProductType = productType;
        }

    }
}
