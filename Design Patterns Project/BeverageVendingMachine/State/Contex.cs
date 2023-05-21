using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.State
{
    internal class Context
    {
        private State currentState;
        private List<ButtonBase> btnLst;

        public Context()
        {
            btnLst = new List<ButtonBase>();
            currentState = new EnabledState(); 
        }

        public void SetState(State state)
        {
            currentState = state;
            currentState.Update(btnLst);
        }

        public void AddBtn(List<ButtonBase> btns)
        {
            foreach (var btn in btns)
            {
                btnLst.Add(btn);
            }
        }
    }
}
