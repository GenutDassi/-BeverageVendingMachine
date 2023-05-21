using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.State
{
    internal abstract class State
    {
        internal abstract void Update(List<ButtonBase> btnLst);
    }
}
