namespace Project_1
{
    //Brett Rogers
    //BUS442
    //Assignment: Project 1
    //Date: 03/01/2023
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit Confirmation 
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        //Declaring global variables
        int quantity;
        double itemAmount, subTotal, surCharges, tax, netOrder, taxCalculater, discountDisplay;
        //Declaring global Variables
        int totalNumberOfOrders = 0;
        double dailyOrderTotal = 0, averageTotalAmountPerOrder = 0, discount, discountAmount, totalAmount;
        //Declaring Global Variables
        int flavorCount;
        const double coffeeSyrupCharge = 0.50;
        string flavors;

        private void newOrderButton_Click(object sender, EventArgs e)
        {

            //Reset the radio buttons to default positions
            cappuccinoButton.Checked = true;
            espressoButton.Checked = false;
            latteButton.Checked = false;
            coffeeBeansHalfRadioButton.Checked = false;
            coffeeBeansOneRadioButton.Checked = false;
            freshBrewRadioButton.Checked = false;

            //Reseting all labels on the order form
            quantityTextBox.Clear();
            surchargeCheckBox.Checked = false;
            itemAmountLabel.Text = null;
            subtotalLabel.Text = null;
            taxLabel.Text = null;
            netOrderLabel.Text = null;
            surchargesLabel.Text = null;
            discountAmountLabel.Text = null;
            totalLabel.Text = null;
            discountPercentLabel.Text = null;
            discountTextBox.Clear();
            volumeDiscountCheckBox.Checked = false;
            flavorComboBox.Text = null;
            flavorListBox.SelectedIndex = -1;

            //Reseting the discount information
            discountPercentLabel.Visible = false;
            discountButton.Visible = false;
            discountTextBox.Visible = false;

            //Reset subtotal back to zero
            subTotal = 0;
            surCharges = 0;
            
            //Calculating the count of orders
            totalNumberOfOrders += 1;

            //Calculating the accumulator of total cost
            dailyOrderTotal += totalAmount;

            //Calculate the average total amount per order
            if (totalNumberOfOrders > 0)
                averageTotalAmountPerOrder = dailyOrderTotal / totalNumberOfOrders;

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            //Outputting the messagebox for the summary button
            DialogResult dialog = MessageBox.Show("The total number of order is: " + totalNumberOfOrders + "\n" + 
                "The daily order total is: " + dailyOrderTotal.ToString("C2") + "\n" + "The average total amount per order is: " 
                + averageTotalAmountPerOrder.ToString("C2"), "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flavorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void addFlavorButton_Click(object sender, EventArgs e)
        {

            //Outputting the flavor into the combo box
            flavors = flavorComboBox.Text;
            flavorComboBox.Items.Add(flavors);

            flavorCount = flavorComboBox.Items.Count;
            totalFlavorsLabel.Text = flavorCount.ToString("N0");



        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
           //Clearing item amount label when text is changed
            itemAmountLabel.Text = null;
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing any input not a digit or control button
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallowing any input not a digit or control button
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void removeFlavorButton_Click(object sender, EventArgs e)
        {
            //Remove a flavor
            flavorComboBox.Items.Remove(flavorComboBox.SelectedItem);

            //Recount the number of flavors
            flavorCount = flavorComboBox.Items.Count;
            totalFlavorsLabel.Text = flavorCount.ToString("N0");

        }

        private void removeAllFlavorsButton_Click(object sender, EventArgs e)
        {
            //Clear all flavors from the combo box
            flavorComboBox.Items.Clear();

            //Recount the number of flavors
            flavorCount = flavorComboBox.Items.Count;
            totalFlavorsLabel.Text = flavorCount.ToString("N0");
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            //Declaring the constant for calculating discount percentage
            const int discountCalculate = 100;

            //Gathering the input for Discount
            double.TryParse(discountTextBox.Text, out discount);
            

            //Discount Calculations
            discountAmount = discount / discountCalculate;
            discountDisplay = netOrder * discountAmount;
            totalAmount = netOrder - discountDisplay;

            

            //Display the discount
            discountAmountLabel.Text = discountDisplay.ToString("C2");
            totalLabel.Text = totalAmount.ToString("C2");

            
        }

        private void volumeDiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Displaying the discount options
                discountPercentLabel.Visible = true;
                discountButton.Visible = true;
                discountTextBox.Visible = true;
                discountTextBox.Focus();


        }

        

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the labels in the top portion of the Form
            quantityTextBox.Clear();
            surchargeCheckBox.Checked = false;
            itemAmountLabel.Text = null;

            //Reset the radio buttons to default positions
            cappuccinoButton.Checked = true;
            espressoButton.Checked = false;
            latteButton.Checked = false;
            coffeeBeansHalfRadioButton.Checked = false;
            coffeeBeansOneRadioButton.Checked = false;
            freshBrewRadioButton.Checked = false;

            //Reseting the combo box and list box options
            flavorComboBox.Text = null;
            flavorListBox.SelectedIndex = -1;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           
            //Declaring constant variables for calculate button
            const double taxRate = 0.08;
            const double cappuccinoPrice = 3.25;
            const double espressoPrice = 3.50;
            const double lattePrice = 3;
            const double onePoundCoffeePrice = 9.99;
            const double halfPoundCoffeePrice = 5.99;
            const double freshBrewPrice = 2.50;
            const double surchargePrice = 1.50;


            //Tryparsing the quantity textbox
            int.TryParse(quantityTextBox.Text, out quantity);

            if (quantity >= 10)
                volumeDiscountCheckBox.Checked = true;

            //Using if statement to find selected menu selections
            if (cappuccinoButton.Checked)
                itemAmount = quantity * cappuccinoPrice;
            else if (espressoButton.Checked)
                itemAmount = quantity * espressoPrice;
            else if (latteButton.Checked)
                itemAmount = quantity * lattePrice;
            else if (coffeeBeansOneRadioButton.Checked)
                itemAmount = quantity * onePoundCoffeePrice;
            else if (coffeeBeansHalfRadioButton.Checked)
                itemAmount = quantity * halfPoundCoffeePrice;
            else
                itemAmount = quantity * freshBrewPrice;

            //Calculate the 50 cent cost of coffee brew flavor or syrup
            if (freshBrewRadioButton.Checked)
                if (flavorComboBox.SelectedIndex > -1) itemAmount += quantity * coffeeSyrupCharge;
                if (flavorListBox.SelectedIndex > -1) itemAmount += quantity * coffeeSyrupCharge;

            //Creating the acumulator amounts
            subTotal += itemAmount;
            if (surchargeCheckBox.Checked && coffeeBeansHalfRadioButton.Checked)
                surCharges += surchargePrice * quantity;

            //Calculating Tax
            taxCalculater = subTotal + surCharges;
            tax = taxRate * taxCalculater;

            //Calculating Net Order
            netOrder = tax + taxCalculater;

            //Calculating Total Cost
            totalAmount = netOrder - discountDisplay;

            

            //Display the outputs
            itemAmountLabel.Text = itemAmount.ToString("C2");
            subtotalLabel.Text = subTotal.ToString("C2");
            taxLabel.Text = tax.ToString("C2");
            surchargesLabel. Text = surCharges.ToString("C2");
            netOrderLabel.Text = netOrder.ToString("C2");
            discountAmountLabel.Text = discountAmount.ToString("C2");
            totalLabel.Text = totalAmount.ToString("C2");

            //Show the clear button on UI
            clearButton.Enabled = true;


        }
    }
}