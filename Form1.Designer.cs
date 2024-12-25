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
            Total.Location = new Point(768, 72);
            Total.Name = "Total";
            Total.Size = new Size(43, 20);
            Total.TabIndex = 4;
            Total.Text = "Total";
            Total.Click += label1_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(833, 65);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 5;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // btCheckOut
            // 
            btCheckOut.Location = new Point(634, 62);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(108, 360);
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
            // tbCash
            // 
            tbCash.Location = new Point(833, 98);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 9;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(833, 131);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 10;
            tbChange.TextChanged += tbChange_TextChanged;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(833, 164);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 11;
            tb1000.TextChanged += textBox3_TextChanged;
            // 
            // tb500
            // 
            tb500.Location = new Point(833, 197);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 12;
            // 
            // tb100
            // 
            tb100.Location = new Point(833, 230);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 13;
            // 
            // tb50
            // 
            tb50.Location = new Point(833, 263);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 14;
            // 
            // tb20
            // 
            tb20.Location = new Point(833, 296);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 15;
            // 
            // tb10
            // 
            tb10.Location = new Point(833, 329);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 16;
            // 
            // tb5
            // 
            tb5.Location = new Point(833, 362);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 17;
            // 
            // tb1
            // 
            tb1.Location = new Point(833, 395);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 18;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.Location = new Point(768, 105);
            Cash.Name = "Cash";
            Cash.Size = new Size(40, 20);
            Cash.TabIndex = 19;
            Cash.Text = "Cash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(768, 138);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 20;
            label2.Text = "Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 171);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 21;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 204);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 22;
            label4.Text = "500";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 237);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 23;
            label5.Text = "100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 270);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 24;
            label6.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(768, 303);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 25;
            label7.Text = "20";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(768, 336);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 26;
            label8.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(768, 369);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 27;
            label9.Text = "5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(768, 398);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 28;
            label10.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
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
    }
}
