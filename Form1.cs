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
            itemCoffee.Name = "coffee";
            itemCoffee.Price = 60;
            itemCoffee.Quantity = 0;

            itemGreeTea.Name = "GreeTea";
            itemGreeTea.Price = 50;
            itemGreeTea.Quantity = 0;

            itemNoodle.Name = "Noodle";
            itemNoodle.Price = 100;
            itemNoodle.Quantity = 0;

            itemPizza.Name = "Pizza";
            itemPizza.Price = 159;
            itemPizza.Quantity = 0;

            // dispiay data
            tbCoffeePrice.Text = itemCoffee.Price.ToString();
            tbCoffeeQuantity.Text =  itemCoffee.Quantity.ToString();

            tbGreeTeaPrice.Text = itemGreeTea.Price.ToString();
            tbGreeTeaQuantity.Text = itemGreeTea.Quantity.ToString();

            tbNoodlePrice.Text = itemNoodle.Price.ToString();
            tbNoodleQuantity.Text = itemNoodle.Quantity.ToString();

            tbPizzaPrice.Text = itemPizza.Price.ToString();
            tbPizzaQuantity.Text = itemPizza.Quantity.ToString();

        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                double dCash = double.Parse(tbCash.Text);

                double dBeverageTotal = 0;
                double dFoodTotal = 0;

                if (chbCoffee.Checked) 
                {
                    itemCoffee.Quantity = int.Parse(tbCoffeeQuantity.Text);
                    dBeverageTotal += itemCoffee.GetTotalPrice();
                }
                if (chbGreetea.Checked)
                {
                    itemGreeTea.Quantity = int.Parse(tbGreeTeaQuantity.Text);
                    dBeverageTotal += itemGreeTea.GetTotalPrice();
                }
                if (chbNoodle.Checked)
                {
                    itemNoodle.Quantity = int.Parse(tbNoodleQuantity.Text);
                    dFoodTotal += itemNoodle.GetTotalPrice();
                }
                if (chbPizza.Checked)
                {
                    itemPizza.Quantity = int.Parse(tbPizzaQuantity.Text);
                    dFoodTotal += itemPizza.GetTotalPrice();
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
    }
}
