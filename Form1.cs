namespace ShoppingCartLap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbCoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            string strCash = tbCash.Text;
            //get amount
            string strCoffeePrice = tbCoffeePrice.Text;
            string strGreeTeaPrice = tbGreeTeaPrice.Text;

            //get price
            string strCoffeeQuantity = tbCoffeeQuantity.Text;
            string strGreeTeaQuantity = tbGreeTeaQuantity.Text;

            int iCoffeePrice = 0;
            int iGreeTeaPrice = 0;
            int iCoffeeQuantity = 0;
            int iGreeTeaQuantity = 0;
            int iCash = 0; 
            try
            {
                //convert string to ing
                iCash = int.Parse(strCash);
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
                if (chbGreetea.Checked)
                {
                    iGreeTeaPrice = int.Parse(strGreeTeaPrice);
                    iGreeTeaQuantity = int.Parse(strGreeTeaQuantity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iGreeTeaPrice = 0;
                iCoffeeQuantity = 0;
                iGreeTeaQuantity = 0;
                iCash = 0;
            }
            //calculate total
            int iCoffee = iCoffeePrice * iCoffeeQuantity;
            int iGreeTea = iGreeTeaPrice * iGreeTeaQuantity;
            int iTotal = iCoffee + iGreeTea;
            int iChange = iCash - iTotal;

            //display totall
            tbTotal.Text = iTotal.ToString();
            tbChange.Text = iChange.ToString();

            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] changeCount = new int[denominations.Length];
            int remainingChange = iChange;

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = remainingChange / denominations[i];
                remainingChange %= denominations[i];
            }


            tb1000.Text = changeCount[0].ToString();
            tb500.Text = changeCount[1].ToString();
            tb100.Text = changeCount[2].ToString();
            tb50.Text = changeCount[3].ToString();
            tb20.Text = changeCount[4].ToString();
            tb10.Text = changeCount[5].ToString();
            tb5.Text = changeCount[6].ToString();
            tb1.Text = changeCount[7].ToString();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbChange_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
