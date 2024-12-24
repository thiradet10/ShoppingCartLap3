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
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(366, 62);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(131, 27);
            tbCoffeePrice.TabIndex = 0;
            tbCoffeePrice.TextChanged += tbCoffeePrice_TextChanged;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(219, 65);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(75, 24);
            chbCoffee.TabIndex = 1;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreetea
            // 
            chbGreetea.AutoSize = true;
            chbGreetea.Location = new Point(219, 111);
            chbGreetea.Name = "chbGreetea";
            chbGreetea.Size = new Size(90, 24);
            chbGreetea.TabIndex = 2;
            chbGreetea.Text = "Gree Tea";
            chbGreetea.UseVisualStyleBackColor = true;
            // 
            // tbGreeTeaPrice
            // 
            tbGreeTeaPrice.Location = new Point(367, 108);
            tbGreeTeaPrice.Name = "tbGreeTeaPrice";
            tbGreeTeaPrice.Size = new Size(130, 27);
            tbGreeTeaPrice.TabIndex = 3;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(441, 184);
            Total.Name = "Total";
            Total.Size = new Size(43, 20);
            Total.TabIndex = 4;
            Total.Text = "Total";
            Total.Click += label1_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(497, 177);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(131, 27);
            tbTotal.TabIndex = 5;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // btCheckOut
            // 
            btCheckOut.Location = new Point(634, 62);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(108, 142);
            btCheckOut.TabIndex = 6;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(503, 62);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreeTeaQuantity
            // 
            tbGreeTeaQuantity.Location = new Point(503, 108);
            tbGreeTeaQuantity.Name = "tbGreeTeaQuantity";
            tbGreeTeaQuantity.Size = new Size(125, 27);
            tbGreeTeaQuantity.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(tbGreeTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(btCheckOut);
            Controls.Add(tbTotal);
            Controls.Add(Total);
            Controls.Add(tbGreeTeaPrice);
            Controls.Add(chbGreetea);
            Controls.Add(chbCoffee);
            Controls.Add(tbCoffeePrice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
