using System.Windows.Forms.VisualStyles;

namespace BeverageVendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IceCoffeeBtn = new System.Windows.Forms.CheckBox();
            this.HotCoffeeBtn = new System.Windows.Forms.CheckBox();
            this.ColdChocolateMilkBtn = new System.Windows.Forms.CheckBox();
            this.HotChocolateMilkBtn = new System.Windows.Forms.CheckBox();
            this.DecorateSugarBtn = new System.Windows.Forms.Button();
            this.DecorateCoffeBtn = new System.Windows.Forms.Button();
            this.BambaBtn = new System.Windows.Forms.CheckBox();
            this.BislyBtn = new System.Windows.Forms.CheckBox();
            this.ChipsBtn = new System.Windows.Forms.CheckBox();
            this.CookiesBtn = new System.Windows.Forms.CheckBox();
            this.CrackersBtn = new System.Windows.Forms.CheckBox();
            this.ChocolateBtn = new System.Windows.Forms.CheckBox();
            this.ShuggiBtn = new System.Windows.Forms.CheckBox();
            this.WaterBtn = new System.Windows.Forms.CheckBox();
            this.OrangeJuiceBtn = new System.Windows.Forms.CheckBox();
            this.CocaColaBtn = new System.Windows.Forms.CheckBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.SumTextBox = new System.Windows.Forms.Label();
            this.AddBagBtn= new System.Windows.Forms.CheckBox();
            this.AddGiftWarpBtn = new System.Windows.Forms.CheckBox();
            this.PaymentInput=new System.Windows.Forms.TextBox();
            this.OrderProductPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IceCoffeeBtn
            // 
            this.IceCoffeeBtn.AutoSize = true;
            this.IceCoffeeBtn.Location = new System.Drawing.Point(61, 67);
            this.IceCoffeeBtn.Name = "IceCoffeeBtn";
            this.IceCoffeeBtn.Size = new System.Drawing.Size(117, 29);
            this.IceCoffeeBtn.TabIndex = 2;
            this.IceCoffeeBtn.Text = "Ice Coffee";
            this.IceCoffeeBtn.UseVisualStyleBackColor = true;
            this.IceCoffeeBtn.CheckedChanged += new System.EventHandler(this.IceCoffeeBtn_CheckedChanged);
            // 
            // HotCoffeeBtn
            // 
            this.HotCoffeeBtn.AutoSize = true;
            this.HotCoffeeBtn.Location = new System.Drawing.Point(61, 152);
            this.HotCoffeeBtn.Name = "HotCoffeeBtn";
            this.HotCoffeeBtn.Size = new System.Drawing.Size(116, 29);
            this.HotCoffeeBtn.TabIndex = 3;
            this.HotCoffeeBtn.Text = "Hot Coffe";
            this.HotCoffeeBtn.UseVisualStyleBackColor = true;
            this.HotCoffeeBtn.CheckedChanged += new System.EventHandler(this.HotCoffeeBtn_CheckedChanged);
            // 
            // ColdChocolateMilkBtn
            // 
            this.ColdChocolateMilkBtn.AutoSize = true;
            this.ColdChocolateMilkBtn.Location = new System.Drawing.Point(61, 225);
            this.ColdChocolateMilkBtn.Name = "ColdChocolateMilkBtn";
            this.ColdChocolateMilkBtn.Size = new System.Drawing.Size(197, 29);
            this.ColdChocolateMilkBtn.TabIndex = 4;
            this.ColdChocolateMilkBtn.Text = "Cold Chocolate Milk";
            this.ColdChocolateMilkBtn.UseVisualStyleBackColor = true;
            this.ColdChocolateMilkBtn.CheckedChanged += new System.EventHandler(this.ColdChocolateMilkBtn_CheckedChanged);
            // 
            // HotChocolateMilkBtn
            // 
            this.HotChocolateMilkBtn.AutoSize = true;
            this.HotChocolateMilkBtn.Location = new System.Drawing.Point(61, 305);
            this.HotChocolateMilkBtn.Name = "HotChocolateMilkBtn";
            this.HotChocolateMilkBtn.Size = new System.Drawing.Size(190, 29);
            this.HotChocolateMilkBtn.TabIndex = 5;
            this.HotChocolateMilkBtn.Text = "Hot Chocolate Milk";
            this.HotChocolateMilkBtn.UseVisualStyleBackColor = true;
            this.HotChocolateMilkBtn.CheckedChanged += new System.EventHandler(this.HotChocolateMilkBtn_CheckedChanged);
            // 
            // DecorateSugarBtn
            // 
            this.DecorateSugarBtn.Location = new System.Drawing.Point(315, 106);
            this.DecorateSugarBtn.Name = "DecorateSugarBtn";
            this.DecorateSugarBtn.Size = new System.Drawing.Size(160, 34);
            this.DecorateSugarBtn.TabIndex = 6;
            this.DecorateSugarBtn.Text = "Add More Sugar";
            this.DecorateSugarBtn.UseVisualStyleBackColor = true;
            this.DecorateSugarBtn.Click += new System.EventHandler(this.DecorateSugarBtn_Click);
            // 
            // DecorateCoffeBtn
            // 
            this.DecorateCoffeBtn.Location = new System.Drawing.Point(315, 178);
            this.DecorateCoffeBtn.Name = "DecorateCoffeBtn";
            this.DecorateCoffeBtn.Size = new System.Drawing.Size(160, 34);
            this.DecorateCoffeBtn.TabIndex = 7;
            this.DecorateCoffeBtn.Text = "Add More Coffee";
            this.DecorateCoffeBtn.UseVisualStyleBackColor = true;
            this.DecorateCoffeBtn.Click += new System.EventHandler(this.DecorateCoffeBtn_Click);
            // 
            // BambaBtn
            // 
            this.BambaBtn.AutoSize = true;
            this.BambaBtn.Location = new System.Drawing.Point(528, 67);
            this.BambaBtn.Name = "BambaBtn";
            this.BambaBtn.Size = new System.Drawing.Size(93, 29);
            this.BambaBtn.TabIndex = 8;
            this.BambaBtn.Text = "Bamba";
            this.BambaBtn.UseVisualStyleBackColor = true;
            this.BambaBtn.CheckedChanged += new System.EventHandler(this.BambaBtn_CheckedChanged);
            // 
            // BislyBtn
            // 
            this.BislyBtn.AutoSize = true;
            this.BislyBtn.Location = new System.Drawing.Point(528, 127);
            this.BislyBtn.Name = "BislyBtn";
            this.BislyBtn.Size = new System.Drawing.Size(73, 29);
            this.BislyBtn.TabIndex = 10;
            this.BislyBtn.Text = "Bisly";
            this.BislyBtn.UseVisualStyleBackColor = true;
            this.BislyBtn.CheckedChanged += new System.EventHandler(this.BislyBtn_CheckedChanged);
            // 
            // ChipsBtn
            // 
            this.ChipsBtn.AutoSize = true;
            this.ChipsBtn.Location = new System.Drawing.Point(528, 183);
            this.ChipsBtn.Name = "ChipsBtn";
            this.ChipsBtn.Size = new System.Drawing.Size(82, 29);
            this.ChipsBtn.TabIndex = 11;
            this.ChipsBtn.Text = "Chips";
            this.ChipsBtn.UseVisualStyleBackColor = true;
            this.ChipsBtn.CheckedChanged += new System.EventHandler(this.ChipsBtn_CheckedChanged);
            // 
            // CookiesBtn
            // 
            this.CookiesBtn.AutoSize = true;
            this.CookiesBtn.Location = new System.Drawing.Point(660, 67);
            this.CookiesBtn.Name = "CookiesBtn";
            this.CookiesBtn.Size = new System.Drawing.Size(101, 29);
            this.CookiesBtn.TabIndex = 12;
            this.CookiesBtn.Text = "Cookies";
            this.CookiesBtn.UseVisualStyleBackColor = true;
            this.CookiesBtn.CheckedChanged += new System.EventHandler(this.CookiesBtn_CheckedChanged);
            // 
            // CrackersBtn
            // 
            this.CrackersBtn.AutoSize = true;
            this.CrackersBtn.Location = new System.Drawing.Point(664, 127);
            this.CrackersBtn.Name = "CrackersBtn";
            this.CrackersBtn.Size = new System.Drawing.Size(104, 29);
            this.CrackersBtn.TabIndex = 13;
            this.CrackersBtn.Text = "Crackers";
            this.CrackersBtn.UseVisualStyleBackColor = true;
            this.CrackersBtn.CheckedChanged += new System.EventHandler(this.CrackersBtn_CheckedChanged);
            // 
            // ChocolateBtn
            // 
            this.ChocolateBtn.AutoSize = true;
            this.ChocolateBtn.Location = new System.Drawing.Point(807, 68);
            this.ChocolateBtn.Name = "ChocolateBtn";
            this.ChocolateBtn.Size = new System.Drawing.Size(117, 29);
            this.ChocolateBtn.TabIndex = 14;
            this.ChocolateBtn.Text = "Chocolate";
            this.ChocolateBtn.UseVisualStyleBackColor = true;
            this.ChocolateBtn.CheckedChanged += new System.EventHandler(this.ChocolateBtn_CheckedChanged);
            // 
            // ShuggiBtn
            // 
            this.ShuggiBtn.AutoSize = true;
            this.ShuggiBtn.Location = new System.Drawing.Point(810, 127);
            this.ShuggiBtn.Name = "ShuggiBtn";
            this.ShuggiBtn.Size = new System.Drawing.Size(94, 29);
            this.ShuggiBtn.TabIndex = 15;
            this.ShuggiBtn.Text = "Shuggi";
            this.ShuggiBtn.UseVisualStyleBackColor = true;
            this.ShuggiBtn.CheckedChanged += new System.EventHandler(this.ShuggiBtn_CheckedChanged);
            // 
            // WaterBtn
            // 
            this.WaterBtn.AutoSize = true;
            this.WaterBtn.Location = new System.Drawing.Point(960, 67);
            this.WaterBtn.Name = "WaterBtn";
            this.WaterBtn.Size = new System.Drawing.Size(135, 29);
            this.WaterBtn.TabIndex = 16;
            this.WaterBtn.Text = "Water Bottle";
            this.WaterBtn.UseVisualStyleBackColor = true;
            this.WaterBtn.CheckedChanged += new System.EventHandler(this.WaterBtn_CheckedChanged);
            // 
            // OrangeJuiceBtn
            // 
            this.OrangeJuiceBtn.AutoSize = true;
            this.OrangeJuiceBtn.Location = new System.Drawing.Point(960, 127);
            this.OrangeJuiceBtn.Name = "OrangeJuiceBtn";
            this.OrangeJuiceBtn.Size = new System.Drawing.Size(190, 29);
            this.OrangeJuiceBtn.TabIndex = 17;
            this.OrangeJuiceBtn.Text = "Orange Juice Bottle";
            this.OrangeJuiceBtn.UseVisualStyleBackColor = true;
            this.OrangeJuiceBtn.CheckedChanged += new System.EventHandler(this.OrangeJuiceBtn_CheckedChanged);
            // 
            // CocaColaBtn
            // 
            this.CocaColaBtn.AutoSize = true;
            this.CocaColaBtn.Location = new System.Drawing.Point(960, 183);
            this.CocaColaBtn.Name = "CocaColaBtn";
            this.CocaColaBtn.Size = new System.Drawing.Size(170, 29);
            this.CocaColaBtn.TabIndex = 18;
            this.CocaColaBtn.Text = "Coca-Cola Bottle";
            this.CocaColaBtn.UseVisualStyleBackColor = true;
            this.CocaColaBtn.CheckedChanged += new System.EventHandler(this.CocaColaBtn_CheckedChanged);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(508, 448);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(251, 34);
            this.FinishBtn.TabIndex = 19;
            this.FinishBtn.Text = "Finish And Payment";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            //
            //AddBag
            //
            this.AddBagBtn.Location = new System.Drawing.Point(508, 304);
            this.AddBagBtn.Name = "AddBagBtn";
            this.AddBagBtn.Size = new System.Drawing.Size(150, 34);
            this.AddBagBtn.TabIndex = 19;
            this.AddBagBtn.Text = "Add Bag";
            this.AddBagBtn.UseVisualStyleBackColor = true;
            this.AddBagBtn.CheckedChanged += new System.EventHandler(this.AddBag_CheckedChanged);
            //
            //AddGiftWarp
            //
            this.AddGiftWarpBtn.Location = new System.Drawing.Point(508, 374);
            this.AddGiftWarpBtn.Name = "AddGiftWarpBtn";
            this.AddGiftWarpBtn.Size = new System.Drawing.Size(250, 34);
            this.AddGiftWarpBtn.TabIndex = 19;
            this.AddGiftWarpBtn.Text = "Add Gift Warper";
            this.AddGiftWarpBtn.UseVisualStyleBackColor = true;
            this.AddGiftWarpBtn.CheckedChanged += new System.EventHandler(this.AddGiftWarp_CheckedChanged);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(508, 504);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(250, 31);
            this.SumTextBox.TabIndex = 20;
            //
            //PaymentInput
            //
            this.SumTextBox.Location = new System.Drawing.Point(500,500);
            this.SumTextBox.Name = "PaymentInput";
            this.SumTextBox.Size = new System.Drawing.Size(100, 100);
            this.SumTextBox.TabIndex = 20;
            // 
            // OrderProductPictureBox
            // 
            this.OrderProductPictureBox.Location = new System.Drawing.Point(945, 351);
            this.OrderProductPictureBox.Name = "OrderProductPictureBox";
            this.OrderProductPictureBox.Size = new System.Drawing.Size(200, 200);
            this.OrderProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrderProductPictureBox.TabIndex = 21;
            this.OrderProductPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 594);
            this.Controls.Add(this.OrderProductPictureBox);
            this.Controls.Add(this.AddBagBtn);
            this.Controls.Add(this.AddGiftWarpBtn);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.CocaColaBtn);
            this.Controls.Add(this.OrangeJuiceBtn);
            this.Controls.Add(this.WaterBtn);
            this.Controls.Add(this.ShuggiBtn);
            this.Controls.Add(this.ChocolateBtn);
            this.Controls.Add(this.CrackersBtn);
            this.Controls.Add(this.CookiesBtn);
            this.Controls.Add(this.ChipsBtn);
            this.Controls.Add(this.BislyBtn);
            this.Controls.Add(this.BambaBtn);
            this.Controls.Add(this.DecorateCoffeBtn);
            this.Controls.Add(this.DecorateSugarBtn);
            this.Controls.Add(this.HotChocolateMilkBtn);
            this.Controls.Add(this.ColdChocolateMilkBtn);
            this.Controls.Add(this.HotCoffeeBtn);
            this.Controls.Add(this.IceCoffeeBtn);
            //this.Controls.Add(this.PaymentInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox IceCoffeeBtn;
        private CheckBox HotCoffeeBtn;
        private CheckBox ColdChocolateMilkBtn;
        private CheckBox HotChocolateMilkBtn;
        private Button DecorateSugarBtn;
        private Button DecorateCoffeBtn;
        private CheckBox BambaBtn;
        private CheckBox BislyBtn;
        private CheckBox ChipsBtn;
        private CheckBox CookiesBtn;
        private CheckBox CrackersBtn;
        private CheckBox ChocolateBtn;
        private CheckBox ShuggiBtn;
        private CheckBox WaterBtn;
        private CheckBox OrangeJuiceBtn;
        private CheckBox CocaColaBtn;
        private Button FinishBtn;
        private Label SumTextBox;
        private TextBox PaymentInput;
        private CheckBox AddGiftWarpBtn;
        private CheckBox AddBagBtn;
        private PictureBox OrderProductPictureBox;

    }
}