using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder.TypesOfCups.Decorator
{
    public class CupDecorator : Cup
    {
        protected Cup cup;
        public CupDecorator(Cup cup):base(true)
        {
            this.cup = cup;
        }
        
    }
}
