using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.State
{
    internal class EnabledState : State
    {
        internal override void Update(List<ButtonBase> checkboxes)
        {
            foreach (var checkbox in checkboxes)
            {
                checkbox.Enabled = true;
            }
        }
    }

    internal class DisabledState : State
    {
        internal override void Update(List<ButtonBase> checkboxes)
        {
            foreach (var checkbox in checkboxes)
            {
                checkbox.Enabled = false;
            }
        }
    }

}
