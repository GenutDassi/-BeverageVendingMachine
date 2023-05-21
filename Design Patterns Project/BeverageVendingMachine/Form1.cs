using BeverageVendingMachine.logger;
using BeverageVendingMachine.NewFolder;
using BeverageVendingMachine.NewFolder.FoodProducts;
using BeverageVendingMachine.NewFolder.TypesOfCups;
using BeverageVendingMachine.NewFolder.TypesOfCups.Decorator;
using BeverageVendingMachine.products.TypesOfCups.Decorator;
using BeverageVendingMachine.singleton;
using BeverageVendingMachine.State;
using BeverageVendingMachine.supplier;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeverageVendingMachine
{
    public enum CreatorTypes
    {
        cup,
        food,
        decorator
    }
    internal class Assist
    {
        public ProductType SpesificType { get; set; }
        public CreatorTypes Type { get; set; }
        public Assist(ProductType productType, CreatorTypes creatorTypes)
        {
            this.Type = creatorTypes;
            this.SpesificType = productType;
        }
    }
    public partial class Form1 : Form
    {
        bool isCupOrder = false;
        Creator creator;
        List<Assist> productLst = new List<Assist>();
        List<IProduct> orderProductsLst = new List<IProduct>();
        Logging logging = SingletonLogger.GetLoggerInstance();
        Context contex = new Context();
        double price = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SumTextBox.Text = "Total sum: " + price.ToString() + " ¤";
            OrderProductPictureBox.Image = Image.FromFile($"..\\..\\..\\..\\pictures\\Non.jpg");
            contex.AddBtn(new List<ButtonBase>() {IceCoffeeBtn,HotCoffeeBtn,ColdChocolateMilkBtn,HotChocolateMilkBtn,
                                                    BislyBtn,BambaBtn,ChipsBtn,ChocolateBtn,ShuggiBtn,CrackersBtn,CookiesBtn,WaterBtn,CocaColaBtn,OrangeJuiceBtn,
                                                    DecorateCoffeBtn,DecorateSugarBtn,
                                                    AddGiftWarpBtn,AddBagBtn,FinishBtn
            });
        }
        private void IceCoffeeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCoffeeBtn.Checked)
            {
                bool b = Notify.UpdateDB("Milk","Sugar", "Coffee");
                if (b) { 
                    isCupOrder = true;
                productLst.Add(new Assist(ProductType.IceCoffee, CreatorTypes.cup));
                }
            }
            else
            {
                isCupOrder = false;
                productLst.Remove(new Assist(ProductType.IceCoffee, CreatorTypes.cup));
            }
        }

        private void HotCoffeeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HotCoffeeBtn.Checked)
            {
                bool b = Notify.UpdateDB("Milk","Sugar","Coffee");
                if (b)
                {
                    isCupOrder = true;
                    productLst.Add(new Assist(ProductType.HotCupOfCoffee, CreatorTypes.cup));
                }
                }
            else
            {
                isCupOrder = false;
                productLst.Remove(new Assist(ProductType.HotCupOfCoffee, CreatorTypes.cup));
            }

        }

        private void ColdChocolateMilkBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ColdChocolateMilkBtn.Checked)
            {
                bool b = Notify.UpdateDB("Milk","Sugar", "ChocolateMilkPowder");
                if (b)
                {
                    isCupOrder = true;
                    productLst.Add(new Assist(ProductType.ColdCupOfChocolateMilk, CreatorTypes.cup));
                }
            }
            else
            {
                isCupOrder = false;
                productLst.Remove(new Assist(ProductType.ColdCupOfChocolateMilk, CreatorTypes.cup));
            }

        }

        private void HotChocolateMilkBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HotChocolateMilkBtn.Checked)
            {
                bool b = Notify.UpdateDB("Milk","Sugar", "ChocolateMilkPowder");
                if (b)
                {
                    isCupOrder = true;
                    productLst.Add(new Assist(ProductType.HotCupOfChocolateMilk, CreatorTypes.cup));
                }
            }
            else
            {
                isCupOrder = true;
                productLst.Remove(new Assist(ProductType.HotCupOfChocolateMilk, CreatorTypes.cup));
            }

        }

        private void DecorateSugarBtn_Click(object sender, EventArgs e)
        {
            if (isCupOrder)
            {
                bool b = Notify.UpdateDB("Sugar");
                if (b)
                    productLst.Add(new Assist(ProductType.Sugar, CreatorTypes.decorator));
            }
            else
            {
                MessageBox.Show("please choose your cup and then choose your addition");
            }
        }

        private void DecorateCoffeBtn_Click(object sender, EventArgs e)
        {
            if(isCupOrder)
            {
                bool b = Notify.UpdateDB("Coffee");
                if (b)
                    productLst.Add(new Assist(ProductType.Coffee, CreatorTypes.decorator));
            }
            else
            {
                MessageBox.Show("please choose your cup and then choose your addition");
            }
        }

        private void BambaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BambaBtn.Checked)
            {
                bool b = Notify.UpdateDB("Bamba");
                if(b)
                    productLst.Add(new Assist(ProductType.Bamba, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Bamba, CreatorTypes.food));
            }
        }

        private void BislyBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BislyBtn.Checked)
            {
                bool b = Notify.UpdateDB("Bisly");
                if (b)
                    productLst.Add(new Assist(ProductType.Bisly, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Bisly, CreatorTypes.food));
            }

        }

        private void ChipsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChipsBtn.Checked)
            {
                bool b = Notify.UpdateDB("Chips");
                if (b)
                    productLst.Add(new Assist(ProductType.Chips, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Chips, CreatorTypes.food));
            }
        }

        private void CookiesBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CookiesBtn.Checked)
            {
                bool b = Notify.UpdateDB("Cookies");
                if (b)
                    productLst.Add(new Assist(ProductType.Cookies, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Cookies, CreatorTypes.food));
            }

        }

        private void CrackersBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CrackersBtn.Checked)
            {
                bool b = Notify.UpdateDB("Crackers");
                if (b)
                    productLst.Add(new Assist(ProductType.Crackers, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Crackers, CreatorTypes.food));
            }

        }

        private void ChocolateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateBtn.Checked)
            {
                bool b = Notify.UpdateDB("chocolate");
                if (b)
                    productLst.Add(new Assist(ProductType.Chocolate, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Chocolate, CreatorTypes.food));
            }
        }

        private void ShuggiBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ShuggiBtn.Checked)
            {
                bool b = Notify.UpdateDB("Shuggi");
                if (b)
                    productLst.Add(new Assist(ProductType.Shuggi, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.Shuggi, CreatorTypes.food));

            }

        }

        private void WaterBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterBtn.Checked)
            {
                bool b = Notify.UpdateDB("Water");
                if (b)
                    productLst.Add(new Assist(ProductType.Water, CreatorTypes.food));

            }
            else
            {
                productLst.Remove(new Assist(ProductType.Water, CreatorTypes.food));
            }
        }

        private void OrangeJuiceBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeJuiceBtn.Checked)
            {
                bool b = Notify.UpdateDB("OrangeJuice");
                if (b)
                    productLst.Add(new Assist(ProductType.OrangeJuice, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.OrangeJuice, CreatorTypes.food));
            }
        }

        private void CocaColaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaColaBtn.Checked)
            {
                bool b = Notify.UpdateDB("CocaCola");
                if (b)
                    productLst.Add(new Assist(ProductType.CokaCola, CreatorTypes.food));
            }
            else
            {
                productLst.Remove(new Assist(ProductType.CokaCola, CreatorTypes.food));
            }
        }

        private async void FinishBtn_Click(object sender, EventArgs e)
        {

            contex.SetState(new DisabledState());
            Cup lastCup = null;
            IProduct product = null;
            foreach (var item in productLst)
            {
                switch (item.Type)
                {
                    case CreatorTypes.cup:
                        creator = new CreatorCup((new DefineType(item.SpesificType)));
                        product = creator.Create();
                        lastCup = (Cup)product;
                        break;
                    case CreatorTypes.food:
                        creator = new CreatorFood((new DefineType(item.SpesificType)));
                        product = creator.Create();
                        break;
                    case CreatorTypes.decorator:
                        if (item.SpesificType == ProductType.Coffee)
                        {
                            product = new CoffeeDecorator(lastCup);
                        }
                        else
                        {
                            product = new SugarDecorator(lastCup);
                        }
                        orderProductsLst.Remove(lastCup);
                        //product = null;
                        price -= lastCup.GetPrice();
                        break;
                }
                if (product != null) 
                {
                    orderProductsLst.Add(product);
                    price += product.GetPrice();
                }
            }
            if (price == 0)
            {
                MessageBox.Show("plese choose products before paying");
            }
            else
            {
                SumTextBox.Text = "Total sum: " + price.ToString() + " ¤";
            }
            foreach (var item in productLst)
            {
                if (item.SpesificType != ProductType.Coffee && item.SpesificType != ProductType.Sugar)
                {
                    OrderProductPictureBox.Image = Image.FromFile($"..\\..\\..\\..\\pictures\\{item.SpesificType}.jpg");
                    await Task.Delay(1800);
                }
            }
            price = 0;
            SumTextBox.Text = "Total sum: " + price.ToString() + " ¤";
            OrderProductPictureBox.Image = Image.FromFile($"..\\..\\..\\..\\pictures\\Non.jpg");
            orderProductsLst = new List<IProduct>();
            productLst = new List<Assist>();
            contex.SetState(new UnCheckedState());
            contex.SetState(new EnabledState());

        }

        private void AddGiftWarp_CheckedChanged(object sender, EventArgs e)
        {
            if (AddGiftWarpBtn.Checked)
            {
                price += 4.5;
            }
            else
            {
                price -= 4.5;
            }
        }

        private void AddBag_CheckedChanged(object sender, EventArgs e)
        {
            if (AddBagBtn.Checked)
            {
                price += 0.5;
            }
            else
            {
                price -= 0.5;
            }
        }

    }
}