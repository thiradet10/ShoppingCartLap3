namespace ShoppingCartLap3
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
            tbCoffeePrice = new TextBox();
            chbCoffee = new CheckBox();
            chbGreetea = new CheckBox();
            tbGreeTeaPrice = new TextBox();
            Total = new Label();
            tbTotal = new TextBox();
            btCheckOut = new Button();
            tbCoffeeQuantity = new TextBox();
            tbGreeTeaQuantity = new TextBox();
            tbCash = new TextBox();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            Cash = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            chbBeverage = new GroupBox();
            chybFood = new GroupBox();
            chbNoodle = new CheckBox();
            chbPizza = new CheckBox();
            tbNoodlePrice = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaQuantity = new TextBox();
            chbDiscount = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            chbDiscountFood = new CheckBox();
            tbDiscountFood = new TextBox();
            chbDiscountAll = new CheckBox();
            chbDiscountBeverage = new CheckBox();
            tbDiscountAll = new TextBox();
            tbDiscountBeverage = new TextBox();
            tb050 = new TextBox();
            tb025 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            chbBeverage.SuspendLayout();
            chybFood.SuspendLayout();
            chbDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.BackColor = Color.White;
            tbCoffeePrice.ForeColor = Color.Black;
            tbCoffeePrice.Location = new Point(147, 26);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(131, 27);
            tbCoffeePrice.TabIndex = 0;
            tbCoffeePrice.TextChanged += tbCoffeePrice_TextChanged;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.ForeColor = Color.FromArgb(128, 64, 64);
            chbCoffee.Location = new Point(6, 26);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(75, 24);
            chbCoffee.TabIndex = 1;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreetea
            // 
            chbGreetea.AutoSize = true;
            chbGreetea.ForeColor = Color.FromArgb(0, 192, 0);
            chbGreetea.Location = new Point(6, 56);
            chbGreetea.Name = "chbGreetea";
            chbGreetea.Size = new Size(90, 24);
            chbGreetea.TabIndex = 2;
            chbGreetea.Text = "Gree Tea";
            chbGreetea.UseVisualStyleBackColor = true;
            // 
            // tbGreeTeaPrice
            // 
            tbGreeTeaPrice.Location = new Point(147, 59);
            tbGreeTeaPrice.Name = "tbGreeTeaPrice";
            tbGreeTeaPrice.Size = new Size(130, 27);
            tbGreeTeaPrice.TabIndex = 3;
            tbGreeTeaPrice.TextChanged += tbGreeTeaPrice_TextChanged;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(765, 66);
            Total.Name = "Total";
            Total.Size = new Size(43, 20);
            Total.TabIndex = 4;
            Total.Text = "Total";
            Total.Click += label1_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(830, 59);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 5;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // btCheckOut
            // 
            btCheckOut.ForeColor = Color.Red;
            btCheckOut.Location = new Point(641, 84);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(108, 360);
            btCheckOut.TabIndex = 6;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(284, 26);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreeTeaQuantity
            // 
            tbGreeTeaQuantity.Location = new Point(284, 59);
            tbGreeTeaQuantity.Name = "tbGreeTeaQuantity";
            tbGreeTeaQuantity.Size = new Size(125, 27);
            tbGreeTeaQuantity.TabIndex = 8;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(830, 92);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 9;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(830, 125);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 10;
            tbChange.TextChanged += tbChange_TextChanged;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(830, 158);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 11;
            tb1000.TextChanged += textBox3_TextChanged;
            // 
            // tb500
            // 
            tb500.Location = new Point(830, 191);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 12;
            // 
            // tb100
            // 
            tb100.Location = new Point(830, 224);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 13;
            // 
            // tb50
            // 
            tb50.Location = new Point(830, 257);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 14;
            // 
            // tb20
            // 
            tb20.Location = new Point(830, 290);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 15;
            // 
            // tb10
            // 
            tb10.Location = new Point(830, 323);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 16;
            // 
            // tb5
            // 
            tb5.Location = new Point(830, 356);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 17;
            // 
            // tb1
            // 
            tb1.Location = new Point(830, 389);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 18;
            tb1.TextChanged += tb1_TextChanged;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.Location = new Point(765, 99);
            Cash.Name = "Cash";
            Cash.Size = new Size(40, 20);
            Cash.TabIndex = 19;
            Cash.Text = "Cash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(765, 132);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 20;
            label2.Text = "Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(765, 165);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 21;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 192);
            label4.Location = new Point(765, 198);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 22;
            label4.Text = "500";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(765, 231);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 23;
            label5.Text = "100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 192, 192);
            label6.Location = new Point(765, 264);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 24;
            label6.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(765, 297);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 25;
            label7.Text = "20";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DarkKhaki;
            label8.Location = new Point(765, 330);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 26;
            label8.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveBorder;
            label9.Location = new Point(765, 363);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 27;
            label9.Text = "5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.MenuHighlight;
            label10.Location = new Point(765, 392);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 28;
            label10.Text = "1";
            // 
            // chbBeverage
            // 
            chbBeverage.Controls.Add(chbCoffee);
            chbBeverage.Controls.Add(chbGreetea);
            chbBeverage.Controls.Add(tbCoffeePrice);
            chbBeverage.Controls.Add(tbGreeTeaPrice);
            chbBeverage.Controls.Add(tbCoffeeQuantity);
            chbBeverage.Controls.Add(tbGreeTeaQuantity);
            chbBeverage.Location = new Point(225, 62);
            chbBeverage.Name = "chbBeverage";
            chbBeverage.Size = new Size(409, 125);
            chbBeverage.TabIndex = 29;
            chbBeverage.TabStop = false;
            chbBeverage.Text = "Beverage";
            // 
            // chybFood
            // 
            chybFood.Controls.Add(chbNoodle);
            chybFood.Controls.Add(chbPizza);
            chybFood.Controls.Add(tbNoodlePrice);
            chybFood.Controls.Add(tbPizzaPrice);
            chybFood.Controls.Add(tbNoodleQuantity);
            chybFood.Controls.Add(tbPizzaQuantity);
            chybFood.Location = new Point(225, 197);
            chybFood.Name = "chybFood";
            chybFood.Size = new Size(409, 125);
            chybFood.TabIndex = 30;
            chybFood.TabStop = false;
            chybFood.Text = "Food";
            // 
            // chbNoodle
            // 
            chbNoodle.AutoSize = true;
            chbNoodle.ForeColor = Color.Black;
            chbNoodle.Location = new Point(6, 26);
            chbNoodle.Name = "chbNoodle";
            chbNoodle.Size = new Size(81, 24);
            chbNoodle.TabIndex = 1;
            chbNoodle.Text = "Noodle";
            chbNoodle.UseVisualStyleBackColor = true;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.ForeColor = Color.Black;
            chbPizza.Location = new Point(6, 56);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(65, 24);
            chbPizza.TabIndex = 2;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.BackColor = Color.White;
            tbNoodlePrice.ForeColor = Color.Black;
            tbNoodlePrice.Location = new Point(147, 26);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(131, 27);
            tbNoodlePrice.TabIndex = 0;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(147, 59);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(130, 27);
            tbPizzaPrice.TabIndex = 3;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(284, 26);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(125, 27);
            tbNoodleQuantity.TabIndex = 7;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(284, 59);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(125, 27);
            tbPizzaQuantity.TabIndex = 8;
            // 
            // chbDiscount
            // 
            chbDiscount.Controls.Add(label12);
            chbDiscount.Controls.Add(label11);
            chbDiscount.Controls.Add(label1);
            chbDiscount.Controls.Add(chbDiscountFood);
            chbDiscount.Controls.Add(tbDiscountFood);
            chbDiscount.Controls.Add(chbDiscountAll);
            chbDiscount.Controls.Add(chbDiscountBeverage);
            chbDiscount.Controls.Add(tbDiscountAll);
            chbDiscount.Controls.Add(tbDiscountBeverage);
            chbDiscount.Location = new Point(225, 336);
            chbDiscount.Name = "chbDiscount";
            chbDiscount.Size = new Size(409, 125);
            chbDiscount.TabIndex = 31;
            chbDiscount.TabStop = false;
            chbDiscount.Text = "Discount";
            chbDiscount.Enter += groupBox3_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(388, 57);
            label12.Name = "label12";
            label12.Size = new Size(21, 20);
            label12.TabIndex = 13;
            label12.Text = "%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 91);
            label11.Name = "label11";
            label11.Size = new Size(21, 20);
            label11.TabIndex = 12;
            label11.Text = "%";
            label11.Click += label11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 28);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 11;
            label1.Text = "%";
            // 
            // chbDiscountFood
            // 
            chbDiscountFood.AutoSize = true;
            chbDiscountFood.ForeColor = Color.Black;
            chbDiscountFood.Location = new Point(6, 86);
            chbDiscountFood.Name = "chbDiscountFood";
            chbDiscountFood.Size = new Size(65, 24);
            chbDiscountFood.TabIndex = 10;
            chbDiscountFood.Text = "Food";
            chbDiscountFood.UseVisualStyleBackColor = true;
            // 
            // tbDiscountFood
            // 
            tbDiscountFood.Location = new Point(259, 88);
            tbDiscountFood.Name = "tbDiscountFood";
            tbDiscountFood.Size = new Size(125, 27);
            tbDiscountFood.TabIndex = 9;
            // 
            // chbDiscountAll
            // 
            chbDiscountAll.AutoSize = true;
            chbDiscountAll.ForeColor = Color.Black;
            chbDiscountAll.Location = new Point(6, 26);
            chbDiscountAll.Name = "chbDiscountAll";
            chbDiscountAll.Size = new Size(49, 24);
            chbDiscountAll.TabIndex = 1;
            chbDiscountAll.Text = "All";
            chbDiscountAll.UseVisualStyleBackColor = true;
            chbDiscountAll.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chbDiscountBeverage
            // 
            chbDiscountBeverage.AutoSize = true;
            chbDiscountBeverage.ForeColor = Color.Black;
            chbDiscountBeverage.Location = new Point(6, 56);
            chbDiscountBeverage.Name = "chbDiscountBeverage";
            chbDiscountBeverage.Size = new Size(93, 24);
            chbDiscountBeverage.TabIndex = 2;
            chbDiscountBeverage.Text = "Beverage";
            chbDiscountBeverage.UseVisualStyleBackColor = true;
            // 
            // tbDiscountAll
            // 
            tbDiscountAll.Location = new Point(259, 23);
            tbDiscountAll.Name = "tbDiscountAll";
            tbDiscountAll.Size = new Size(125, 27);
            tbDiscountAll.TabIndex = 7;
            tbDiscountAll.TextChanged += tbDiscountAll_TextChanged;
            // 
            // tbDiscountBeverage
            // 
            tbDiscountBeverage.Location = new Point(259, 55);
            tbDiscountBeverage.Name = "tbDiscountBeverage";
            tbDiscountBeverage.Size = new Size(125, 27);
            tbDiscountBeverage.TabIndex = 8;
            // 
            // tb050
            // 
            tb050.Location = new Point(830, 422);
            tb050.Name = "tb050";
            tb050.Size = new Size(125, 27);
            tb050.TabIndex = 32;
            // 
            // tb025
            // 
            tb025.Location = new Point(830, 455);
            tb025.Name = "tb025";
            tb025.Size = new Size(125, 27);
            tb025.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.MenuHighlight;
            label13.Location = new Point(765, 425);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 34;
            label13.Text = "0.50";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.MenuHighlight;
            label14.Location = new Point(765, 455);
            label14.Name = "label14";
            label14.Size = new Size(36, 20);
            label14.TabIndex = 35;
            label14.Text = "0.25";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 501);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(tb025);
            Controls.Add(tb050);
            Controls.Add(chbDiscount);
            Controls.Add(chybFood);
            Controls.Add(chbBeverage);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cash);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(btCheckOut);
            Controls.Add(tbTotal);
            Controls.Add(Total);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            chbBeverage.ResumeLayout(false);
            chbBeverage.PerformLayout();
            chybFood.ResumeLayout(false);
            chybFood.PerformLayout();
            chbDiscount.ResumeLayout(false);
            chbDiscount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private CheckBox chbCoffee;
        private CheckBox chbGreetea;
        private TextBox tbGreeTeaPrice;
        private Label Total;
        private TextBox tbTotal;
        private Button btCheckOut;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreeTeaQuantity;
        private TextBox tbCash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private Label Cash;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox chbBeverage;
        private GroupBox chybFood;
        private CheckBox chbNoodle;
        private CheckBox chbPizza;
        private TextBox tbNoodlePrice;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaQuantity;
        private GroupBox chbDiscount;
        private CheckBox chbDiscountAll;
        private CheckBox chbDiscountBeverage;
        private TextBox tbDiscountAll;
        private TextBox tbDiscountBeverage;
        private CheckBox chbDiscountFood;
        private TextBox tbDiscountFood;
        private Label label12;
        private Label label11;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tb050;
        private TextBox tb025;
        private Label label13;
        private Label label14;
    }
}
