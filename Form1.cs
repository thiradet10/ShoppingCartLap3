namespace ShoppingCartLap3
{
    public partial class Form1 : Form
    {
        Item itemCoffee = new Item();
        Item itemGreeTea = new Item();
        Item itemNoodle = new Item();
        Item itemPizza = new Item();
        public Form1()
        {
            // add data to object
            InitializeComponent();
            itemCoffee.name = "coffee";
            itemCoffee.price = 60;
            itemCoffee.quantity = 0;

            itemGreeTea.name = "GreeTea";
            itemGreeTea.price = 50;
            itemGreeTea.quantity = 0;

            itemNoodle.name = "Noodle";
            itemNoodle.price = 100;
            itemNoodle.quantity = 0;

            itemPizza.name = "Pizza";
            itemPizza.price = 159;
            itemPizza.quantity = 0;

            // dispiay data
            tbCoffeePrice.Text =
                itemCoffee.price.ToString();
            tbCoffeeQuantity.Text =
                itemCoffee.quantity.ToString();

            tbGreeTeaPrice.Text =
                itemGreeTea.price.ToString();
            tbGreeTeaQuantity.Text =
                itemGreeTea.quantity.ToString();

            tbNoodlePrice.Text =
                itemNoodle.price.ToString();
            tbNoodleQuantity.Text =
                itemNoodle.quantity.ToString();

            tbPizzaPrice.Text =
                itemPizza.price.ToString();
            tbPizzaQuantity.Text =
                itemPizza.quantity.ToString();

        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                double dCash = double.Parse(tbCash.Text);

                double dBeverageTotal = 0;
                double dFoodTotal = 0;

                if (itemCoffee.isCheck) ;
                {
                    dBeverageTotal += GetItemTotal(tbCoffeePrice.Text, tbCoffeeQuantity.Text);
                }
                if (itemGreeTea.isCheck)
                {
                    dBeverageTotal += GetItemTotal(tbGreeTeaPrice.Text, tbGreeTeaQuantity.Text);
                }
                if (itemNoodle.isCheck)
                {
                    dFoodTotal += GetItemTotal(tbNoodlePrice.Text, tbNoodleQuantity.Text);
                }
                if (itemPizza.isCheck)
                {
                    dFoodTotal += GetItemTotal(tbPizzaPrice.Text, tbPizzaQuantity.Text);
                }
                double dGrandTotal = dBeverageTotal + dFoodTotal;

                double dTotalDiscount = CalculateTotalDiscount(dBeverageTotal, dFoodTotal, dGrandTotal);

                dGrandTotal -= dTotalDiscount;
                if (dCash < dGrandTotal)
                {
                    MessageBox.Show("เงินสดไม่เพียงพอ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double dChange = dCash - dGrandTotal;

                tbTotal.Text = dGrandTotal.ToString("F2");
                tbChange.Text = dChange.ToString("F2");

                CalculateChangeDenominations(dChange);
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกข้อมูลตัวเลขให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double GetItemTotal(string priceText, string quantityText)
        {

            double price = 0, quantity = 0;
            try
            {
                price = double.Parse(priceText);
                quantity = double.Parse(quantityText);
            }
            catch (Exception)
            {
                price = 0;
                quantity = 0;
            }
            return price * quantity;
        }
        private double CalculateTotalDiscount(double dBeverageTotal, double dFoodTotal, double dGrandTotal)
        {
            double dDiscountBev = chbDiscountBeverage.Checked ? double.Parse(tbDiscountBeverage.Text) : 0;
            double dDiscountFood = chbDiscountFood.Checked ? double.Parse(tbDiscountFood.Text) : 0;
            double dDiscountAll = chbDiscountAll.Checked ? double.Parse(tbDiscountAll.Text) : 0;

            double dTotalDiscount = (dBeverageTotal * dDiscountBev / 100) + (dFoodTotal * dDiscountFood / 100) + (dGrandTotal * dDiscountAll / 100);

            return dTotalDiscount;
        }
        private void CalculateChangeDenominations(double change)
        {
            double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25 };
            int[] changeCount = new int[denominations.Length];
            double remainChange = change;

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = (int)(remainChange / denominations[i]);
                remainChange %= denominations[i];
            }

            tb1000.Text = changeCount[0].ToString();
            tb500.Text = changeCount[1].ToString();
            tb100.Text = changeCount[2].ToString();
            tb50.Text = changeCount[3].ToString();
            tb20.Text = changeCount[4].ToString();
            tb10.Text = changeCount[5].ToString();
            tb5.Text = changeCount[6].ToString();
            tb1.Text = changeCount[7].ToString();
            tb050.Text = changeCount[8].ToString();
            tb025.Text = changeCount[9].ToString();
        }

        private void chbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            itemCoffee.isCheck = chbCoffee.Checked;
        }

        private void chbGreetea_CheckedChanged(object sender, EventArgs e)
        {
            itemGreeTea.isCheck = chbGreetea.Checked;
        }

        private void chbNoodle_CheckedChanged(object sender, EventArgs e)
        {
            itemNoodle.isCheck = chbNoodle.Checked;
        }

        private void chbPizza_CheckedChanged(object sender, EventArgs e)
        {
            itemPizza.isCheck = chbPizza.Checked;
        }
    }
}
