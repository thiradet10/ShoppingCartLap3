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
            //get amount
            string strCoffeePrice = tbCoffeePrice.Text;
            string strGreeTeaPrice = tbGreeTeaPrice.Text;

            //get price
            string strCoffeeQuantity = tbCoffeeQuantity.Text;
            string strGreeTeaQuantity = tbGreeTeaQuantity.Text;

            double iCoffeePrice = 0;
            double iGreeTeaPrice = 0;
            double iCoffeeQuantity = 0;
            double iGreeTeaQuantity = 0;
            try
            {
                //convert string to ing
                if (chbCoffee.Checked)
                {
                    iCoffeePrice = double.Parse(strCoffeePrice);
                    iCoffeeQuantity = double.Parse(strCoffeeQuantity);
                }
                if (chbGreetea.Checked)
                {
                    iGreeTeaPrice = double.Parse(strGreeTeaPrice);
                    iGreeTeaQuantity = double.Parse(strGreeTeaQuantity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iGreeTeaPrice = 0;
                iCoffeeQuantity = 0;
                iGreeTeaQuantity = 0;
            }
            //calculate total
            double iCoffee = iCoffeePrice * iCoffeeQuantity;
            double iGreeTea = iGreeTeaPrice * iGreeTeaQuantity;
            double iTotal = iCoffee + iGreeTea;

            //display totall
            tbTotal.Text = iTotal.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
