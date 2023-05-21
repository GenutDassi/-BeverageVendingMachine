using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.State
{
    internal class UnCheckedState : State
    {
        internal override void Update(List<ButtonBase> btnLst)
        {
            foreach (ButtonBase btn in btnLst)
            {
                if(btn is CheckBox)
                {
                    (btn as CheckBox).Checked = false;
                }

            }
        }
    }
}
