using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.NewFolder
{
     abstract class Creator
    {
        protected DefineType type;
        public Creator(DefineType defineType)
        {
            this.type= defineType;
        }
        internal abstract IProduct Create();

    }
}
