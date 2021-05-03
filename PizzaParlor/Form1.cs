/*
 * Maeve Wheaton
 * Mr. T
 * May 3, 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlor
{
    public partial class Form1 : Form
    {
        //variables
        double basePizzaPrice = 7.00;
        double perToppingPrice = 1.25;
        double numberTopping;
        double totalPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //input number of toppings
            try
            {
                numberTopping = Convert.ToDouble(numberToppingInput.Text);

                //calculate price of pizza
                totalPrice = basePizzaPrice + numberTopping * perToppingPrice;

                //display total price
                priceOutputLabel.ForeColor = Color.Black;
                priceOutputLabel.Text = $"The price of a pizza with {numberTopping} toppings is:";
                priceOutputLabel.Text += $"\n{totalPrice.ToString("C")}";
            }
            //error message if letters entered
            catch
            {
                priceOutputLabel.ForeColor = Color.Red;
                priceOutputLabel.Text = "Error: Value entered is not a number.";
            }
        }
    }
}
