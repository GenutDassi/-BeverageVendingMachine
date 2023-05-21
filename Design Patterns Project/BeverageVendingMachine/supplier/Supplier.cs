using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageVendingMachine.supplier
{
    internal class Supplier : ISupplier
    {
        public void UpdateSupplier(string messg)
        {
            string message = "message for supplier: "+messg;
            MessageBox.Show(message);
        }

    }
}
