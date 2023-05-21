using BeverageVendingMachine.NewFolder;
using BeverageVendingMachine.NewFolder.FoodProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace BeverageVendingMachine.supplier
{
    internal static class Notify
    {
        static ISupplier supplier=new Supplier();
        internal static bool UpdateDB(params string [] productsLst)
        {
            const string FILENAME = "..\\..\\..\\..\\BeverageVendingMachine\\supplier\\ProductsDB.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(FILENAME);
            XmlNode xmlNode; 
            foreach (var i in productsLst)
            {
                if (i != null)
                {
                    xmlNode = doc.GetElementsByTagName(i)[0];
                    if (xmlNode != null && int.Parse(xmlNode.InnerText) > 1)
                    {
                        xmlNode.InnerText = (int.Parse(xmlNode.InnerText) - 1).ToString();
                        //if (int.Parse(xmlNode.InnerText) < 5)
                        //{
                        //}
                        doc.Save(FILENAME);
                        if (int.Parse(xmlNode.InnerText)<5)
                        {
                            supplier.UpdateSupplier("worning " + i + " stock is runing low");
                        }
                    }
                    else
                    {
                        string message = "unavailable product";
                        MessageBox.Show(message);
                        return false;
                    }
                }
               
            } 
            return true;
        
        }
    }
}
