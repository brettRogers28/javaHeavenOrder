namespace Project_1
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surchargeCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.freshBrewRadioButton = new System.Windows.Forms.RadioButton();
            this.coffeeBeansHalfRadioButton = new System.Windows.Forms.RadioButton();
            this.coffeeBeansOneRadioButton = new System.Windows.Forms.RadioButton();
            this.latteButton = new System.Windows.Forms.RadioButton();
            this.espressoButton = new System.Windows.Forms.RadioButton();
            this.cappuccinoButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.netOrderLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.surchargesLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flavorListBox = new System.Windows.Forms.ListBox();
            this.flavorComboBox = new System.Windows.Forms.ComboBox();
            this.totalFlavorsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.removeAllFlavorsButton = new System.Windows.Forms.Button();
            this.addFlavorAltButton = new System.Windows.Forms.Button();
            this.addFlavorButton = new System.Windows.Forms.Button();
            this.removeFlavorButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.volumeDiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.itemAmountLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.surchargeCheckBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(208, 137);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 58);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear for Next Item";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(34, 137);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 58);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate Selection";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // itemAmountLabel
            // 
            this.itemAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemAmountLabel.Location = new System.Drawing.Point(131, 214);
            this.itemAmountLabel.Name = "itemAmountLabel";
            this.itemAmountLabel.Size = new System.Drawing.Size(129, 29);
            this.itemAmountLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item amount:";
            // 
            // surchargeCheckBox
            // 
            this.surchargeCheckBox.AutoSize = true;
            this.surchargeCheckBox.Location = new System.Drawing.Point(6, 83);
            this.surchargeCheckBox.Name = "surchargeCheckBox";
            this.surchargeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.surchargeCheckBox.TabIndex = 2;
            this.surchargeCheckBox.Text = "S&urcharge?";
            this.surchargeCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(131, 41);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(125, 27);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Quantity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.freshBrewRadioButton);
            this.groupBox2.Controls.Add(this.coffeeBeansHalfRadioButton);
            this.groupBox2.Controls.Add(this.coffeeBeansOneRadioButton);
            this.groupBox2.Controls.Add(this.latteButton);
            this.groupBox2.Controls.Add(this.espressoButton);
            this.groupBox2.Controls.Add(this.cappuccinoButton);
            this.groupBox2.Location = new System.Drawing.Point(399, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Selections";
            // 
            // freshBrewRadioButton
            // 
            this.freshBrewRadioButton.AutoSize = true;
            this.freshBrewRadioButton.Location = new System.Drawing.Point(203, 122);
            this.freshBrewRadioButton.Name = "freshBrewRadioButton";
            this.freshBrewRadioButton.Size = new System.Drawing.Size(101, 24);
            this.freshBrewRadioButton.TabIndex = 5;
            this.freshBrewRadioButton.TabStop = true;
            this.freshBrewRadioButton.Text = "Fresh &Brew";
            this.freshBrewRadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeBeansHalfRadioButton
            // 
            this.coffeeBeansHalfRadioButton.AutoSize = true;
            this.coffeeBeansHalfRadioButton.Location = new System.Drawing.Point(203, 82);
            this.coffeeBeansHalfRadioButton.Name = "coffeeBeansHalfRadioButton";
            this.coffeeBeansHalfRadioButton.Size = new System.Drawing.Size(200, 24);
            this.coffeeBeansHalfRadioButton.TabIndex = 3;
            this.coffeeBeansHalfRadioButton.TabStop = true;
            this.coffeeBeansHalfRadioButton.Text = "Coffee Beans (1/&2 lb bag)";
            this.coffeeBeansHalfRadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeBeansOneRadioButton
            // 
            this.coffeeBeansOneRadioButton.AutoSize = true;
            this.coffeeBeansOneRadioButton.Location = new System.Drawing.Point(203, 38);
            this.coffeeBeansOneRadioButton.Name = "coffeeBeansOneRadioButton";
            this.coffeeBeansOneRadioButton.Size = new System.Drawing.Size(186, 24);
            this.coffeeBeansOneRadioButton.TabIndex = 1;
            this.coffeeBeansOneRadioButton.TabStop = true;
            this.coffeeBeansOneRadioButton.Text = "Coffee Beans (&1 lb bag)";
            this.coffeeBeansOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // latteButton
            // 
            this.latteButton.AutoSize = true;
            this.latteButton.Location = new System.Drawing.Point(52, 122);
            this.latteButton.Name = "latteButton";
            this.latteButton.Size = new System.Drawing.Size(63, 24);
            this.latteButton.TabIndex = 4;
            this.latteButton.TabStop = true;
            this.latteButton.Text = "La&tte";
            this.latteButton.UseVisualStyleBackColor = true;
            // 
            // espressoButton
            // 
            this.espressoButton.AutoSize = true;
            this.espressoButton.Location = new System.Drawing.Point(52, 82);
            this.espressoButton.Name = "espressoButton";
            this.espressoButton.Size = new System.Drawing.Size(87, 24);
            this.espressoButton.TabIndex = 2;
            this.espressoButton.TabStop = true;
            this.espressoButton.Text = "&Espresso";
            this.espressoButton.UseVisualStyleBackColor = true;
            // 
            // cappuccinoButton
            // 
            this.cappuccinoButton.AutoSize = true;
            this.cappuccinoButton.Checked = true;
            this.cappuccinoButton.Location = new System.Drawing.Point(52, 38);
            this.cappuccinoButton.Name = "cappuccinoButton";
            this.cappuccinoButton.Size = new System.Drawing.Size(108, 24);
            this.cappuccinoButton.TabIndex = 0;
            this.cappuccinoButton.TabStop = true;
            this.cappuccinoButton.Text = "C&appuccino";
            this.cappuccinoButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.netOrderLabel);
            this.groupBox3.Controls.Add(this.taxLabel);
            this.groupBox3.Controls.Add(this.surchargesLabel);
            this.groupBox3.Controls.Add(this.subtotalLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(416, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 253);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Totals";
            // 
            // netOrderLabel
            // 
            this.netOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netOrderLabel.Location = new System.Drawing.Point(214, 181);
            this.netOrderLabel.Name = "netOrderLabel";
            this.netOrderLabel.Size = new System.Drawing.Size(129, 29);
            this.netOrderLabel.TabIndex = 7;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(214, 139);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(129, 29);
            this.taxLabel.TabIndex = 5;
            // 
            // surchargesLabel
            // 
            this.surchargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surchargesLabel.Location = new System.Drawing.Point(214, 95);
            this.surchargesLabel.Name = "surchargesLabel";
            this.surchargesLabel.Size = new System.Drawing.Size(129, 29);
            this.surchargesLabel.TabIndex = 3;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(214, 53);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(129, 29);
            this.subtotalLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Net order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surcharges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal:";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(848, 346);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(110, 40);
            this.newOrderButton.TabIndex = 11;
            this.newOrderButton.Text = "&New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(848, 412);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(110, 40);
            this.summaryButton.TabIndex = 12;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(848, 474);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 40);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Discount amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total:";
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountAmountLabel.Location = new System.Drawing.Point(630, 549);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(129, 29);
            this.discountAmountLabel.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(630, 587);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(129, 29);
            this.totalLabel.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flavorListBox);
            this.groupBox4.Controls.Add(this.flavorComboBox);
            this.groupBox4.Controls.Add(this.totalFlavorsLabel);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.removeAllFlavorsButton);
            this.groupBox4.Controls.Add(this.addFlavorAltButton);
            this.groupBox4.Controls.Add(this.addFlavorButton);
            this.groupBox4.Controls.Add(this.removeFlavorButton);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 253);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fresh Brewed Flavors and Syrups";
            // 
            // flavorListBox
            // 
            this.flavorListBox.FormattingEnabled = true;
            this.flavorListBox.ItemHeight = 20;
            this.flavorListBox.Items.AddRange(new object[] {
            "Chocolate",
            "Hazel Nut",
            "Irish Cream"});
            this.flavorListBox.Location = new System.Drawing.Point(6, 139);
            this.flavorListBox.Name = "flavorListBox";
            this.flavorListBox.Size = new System.Drawing.Size(150, 104);
            this.flavorListBox.TabIndex = 6;
            // 
            // flavorComboBox
            // 
            this.flavorComboBox.FormattingEnabled = true;
            this.flavorComboBox.Items.AddRange(new object[] {
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend",
            "Vanilla Hazelnut"});
            this.flavorComboBox.Location = new System.Drawing.Point(6, 34);
            this.flavorComboBox.Name = "flavorComboBox";
            this.flavorComboBox.Size = new System.Drawing.Size(228, 28);
            this.flavorComboBox.TabIndex = 0;
            this.flavorComboBox.SelectedIndexChanged += new System.EventHandler(this.flavorComboBox_SelectedIndexChanged);
            // 
            // totalFlavorsLabel
            // 
            this.totalFlavorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFlavorsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalFlavorsLabel.Location = new System.Drawing.Point(105, 73);
            this.totalFlavorsLabel.Name = "totalFlavorsLabel";
            this.totalFlavorsLabel.Size = new System.Drawing.Size(129, 29);
            this.totalFlavorsLabel.TabIndex = 3;
            this.totalFlavorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Syrup Flavors:";
            // 
            // removeAllFlavorsButton
            // 
            this.removeAllFlavorsButton.Location = new System.Drawing.Point(247, 196);
            this.removeAllFlavorsButton.Name = "removeAllFlavorsButton";
            this.removeAllFlavorsButton.Size = new System.Drawing.Size(136, 48);
            this.removeAllFlavorsButton.TabIndex = 8;
            this.removeAllFlavorsButton.Text = "Remove All &Flavors";
            this.removeAllFlavorsButton.UseVisualStyleBackColor = true;
            this.removeAllFlavorsButton.Click += new System.EventHandler(this.removeAllFlavorsButton_Click);
            // 
            // addFlavorAltButton
            // 
            this.addFlavorAltButton.Location = new System.Drawing.Point(247, 142);
            this.addFlavorAltButton.Name = "addFlavorAltButton";
            this.addFlavorAltButton.Size = new System.Drawing.Size(136, 48);
            this.addFlavorAltButton.TabIndex = 7;
            this.addFlavorAltButton.Text = "A&dd Flavor - Alt";
            this.addFlavorAltButton.UseVisualStyleBackColor = true;
            // 
            // addFlavorButton
            // 
            this.addFlavorButton.Location = new System.Drawing.Point(247, 88);
            this.addFlavorButton.Name = "addFlavorButton";
            this.addFlavorButton.Size = new System.Drawing.Size(136, 48);
            this.addFlavorButton.TabIndex = 4;
            this.addFlavorButton.Text = "&Add Flavor";
            this.addFlavorButton.UseVisualStyleBackColor = true;
            this.addFlavorButton.Click += new System.EventHandler(this.addFlavorButton_Click);
            // 
            // removeFlavorButton
            // 
            this.removeFlavorButton.Location = new System.Drawing.Point(247, 34);
            this.removeFlavorButton.Name = "removeFlavorButton";
            this.removeFlavorButton.Size = new System.Drawing.Size(136, 48);
            this.removeFlavorButton.TabIndex = 1;
            this.removeFlavorButton.Text = "&Remove Flavor";
            this.removeFlavorButton.UseVisualStyleBackColor = true;
            this.removeFlavorButton.Click += new System.EventHandler(this.removeFlavorButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total flavors:";
            // 
            // volumeDiscountCheckBox
            // 
            this.volumeDiscountCheckBox.AutoSize = true;
            this.volumeDiscountCheckBox.Location = new System.Drawing.Point(18, 567);
            this.volumeDiscountCheckBox.Name = "volumeDiscountCheckBox";
            this.volumeDiscountCheckBox.Size = new System.Drawing.Size(143, 24);
            this.volumeDiscountCheckBox.TabIndex = 2;
            this.volumeDiscountCheckBox.Text = "&Volume Discount";
            this.volumeDiscountCheckBox.UseVisualStyleBackColor = true;
            this.volumeDiscountCheckBox.CheckedChanged += new System.EventHandler(this.volumeDiscountCheckBox_CheckedChanged);
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(18, 596);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(124, 20);
            this.discountPercentLabel.TabIndex = 3;
            this.discountPercentLabel.Text = "Enter Discount %:";
            this.discountPercentLabel.Visible = false;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(166, 596);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(125, 27);
            this.discountTextBox.TabIndex = 4;
            this.discountTextBox.Visible = false;
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(313, 582);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(109, 48);
            this.discountButton.TabIndex = 5;
            this.discountButton.Text = "Discount Button";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Visible = false;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1020, 642);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.volumeDiscountCheckBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Java Heaven Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button clearButton;
        private Button calculateButton;
        private Label itemAmountLabel;
        private Label label2;
        private CheckBox surchargeCheckBox;
        private TextBox quantityTextBox;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton freshBrewRadioButton;
        private RadioButton coffeeBeansHalfRadioButton;
        private RadioButton coffeeBeansOneRadioButton;
        private RadioButton latteButton;
        private RadioButton espressoButton;
        private RadioButton cappuccinoButton;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label netOrderLabel;
        private Label taxLabel;
        private Label surchargesLabel;
        private Label subtotalLabel;
        private Button newOrderButton;
        private Button summaryButton;
        private Button exitButton;
        private Label label7;
        private Label label8;
        private Label discountAmountLabel;
        private Label totalLabel;
        private GroupBox groupBox4;
        private Button removeAllFlavorsButton;
        private Button addFlavorAltButton;
        private Button addFlavorButton;
        private Button removeFlavorButton;
        private Label label9;
        private Label label10;
        private CheckBox volumeDiscountCheckBox;
        private Label totalFlavorsLabel;
        private ListBox flavorListBox;
        private ComboBox flavorComboBox;
        private Label discountPercentLabel;
        private TextBox discountTextBox;
        private Button discountButton;
    }
}