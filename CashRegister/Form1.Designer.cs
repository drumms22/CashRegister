namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.item_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderSubtotal = new System.Windows.Forms.Label();
            this.lblOrderTax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCurrentItemNumber = new System.Windows.Forms.Label();
            this.lblCurrentItemName = new System.Windows.Forms.Label();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurrentItemPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCoupon = new System.Windows.Forms.Button();
            this.btnVoidOrder = new System.Windows.Forms.Button();
            this.btnAddItemManually = new System.Windows.Forms.Button();
            this.btnPriceChange = new System.Windows.Forms.Button();
            this.slQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelCash = new System.Windows.Forms.Panel();
            this.lblAmountDueCash = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblItemsTotal = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.txtCardNumber = new System.Windows.Forms.NumericUpDown();
            this.txtCardCVV = new System.Windows.Forms.NumericUpDown();
            this.txtCardYear = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCardMonth = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAmountDueCard = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelOrderProcessed = new System.Windows.Forms.Panel();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.btnEmailReciept = new System.Windows.Forms.Button();
            this.btnPrintReciept = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStartNextOrder = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblCurrentItemTotal = new System.Windows.Forms.Label();
            this.panelChangeDisplay = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblHundred = new System.Windows.Forms.Label();
            this.lblFifty = new System.Windows.Forms.Label();
            this.lblTwenty = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.lblDime = new System.Windows.Forms.Label();
            this.lblNickel = new System.Windows.Forms.Label();
            this.lblPenny = new System.Windows.Forms.Label();
            this.panelProcessingPopUp = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            this.panelCheckout.SuspendLayout();
            this.panelProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slQuantity)).BeginInit();
            this.panelCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountToPay)).BeginInit();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardCVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardMonth)).BeginInit();
            this.panelOrderProcessed.SuspendLayout();
            this.panelChangeDisplay.SuspendLayout();
            this.panelProcessingPopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckout.FlatAppearance.BorderSize = 2;
            this.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCheckout.Location = new System.Drawing.Point(179, 1431);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(676, 186);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuantity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuantity.FlatAppearance.BorderSize = 2;
            this.btnUpdateQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdateQuantity.Location = new System.Drawing.Point(711, 1271);
            this.btnUpdateQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(144, 69);
            this.btnUpdateQuantity.TabIndex = 3;
            this.btnUpdateQuantity.Text = "Update";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveItem.FlatAppearance.BorderSize = 2;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveItem.Location = new System.Drawing.Point(380, 913);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(300, 64);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Void Item ";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.FlatAppearance.BorderSize = 2;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddItem.Location = new System.Drawing.Point(294, 149);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(502, 113);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // gvItemList
            // 
            this.gvItemList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            this.gvItemList.AllowUserToResizeColumns = false;
            this.gvItemList.AllowUserToResizeRows = false;
            this.gvItemList.BackgroundColor = System.Drawing.Color.MintCream;
            this.gvItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_number,
            this.item_name,
            this.item_price,
            this.quantity,
            this.item_total});
            this.gvItemList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gvItemList.Location = new System.Drawing.Point(31, 149);
            this.gvItemList.MultiSelect = false;
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.RowHeadersWidth = 82;
            this.gvItemList.RowTemplate.Height = 33;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.ShowCellErrors = false;
            this.gvItemList.ShowCellToolTips = false;
            this.gvItemList.ShowEditingIcon = false;
            this.gvItemList.ShowRowErrors = false;
            this.gvItemList.Size = new System.Drawing.Size(2400, 1107);
            this.gvItemList.TabIndex = 10;
            this.gvItemList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvItemList_MouseClick);
            // 
            // item_number
            // 
            this.item_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.item_number.HeaderText = "Item Number";
            this.item_number.MinimumWidth = 225;
            this.item_number.Name = "item_number";
            this.item_number.ReadOnly = true;
            this.item_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item_number.Width = 225;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.MinimumWidth = 10;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item_name.Width = 230;
            // 
            // item_price
            // 
            this.item_price.HeaderText = "Item Price";
            this.item_price.MinimumWidth = 10;
            this.item_price.Name = "item_price";
            this.item_price.ReadOnly = true;
            this.item_price.Width = 220;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Item Quantity";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 220;
            // 
            // item_total
            // 
            this.item_total.HeaderText = "Item Total";
            this.item_total.MinimumWidth = 10;
            this.item_total.Name = "item_total";
            this.item_total.ReadOnly = true;
            this.item_total.Width = 220;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(767, 66);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 37);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(104, 78);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(288, 44);
            this.lblOrderNumber.TabIndex = 12;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.AutoSize = true;
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(431, 85);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(98, 37);
            this.txtOrderNumber.TabIndex = 13;
            this.txtOrderNumber.Text = "None";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(60, 1366);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(340, 51);
            this.lblText.TabIndex = 14;
            this.lblText.Text = "Order Subtotal: ";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(141, 1475);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(248, 51);
            this.lblText2.TabIndex = 15;
            this.lblText2.Text = "Order Tax: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 1593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 51);
            this.label2.TabIndex = 16;
            this.label2.Text = "Discount Total: ";
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateQuantity.Location = new System.Drawing.Point(55, 1279);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(292, 46);
            this.lblUpdateQuantity.TabIndex = 18;
            this.lblUpdateQuantity.Text = "Item Quantity: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 55);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Selected Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 1131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "Item Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 991);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 46);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item Number: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 1697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 67);
            this.label6.TabIndex = 22;
            this.label6.Text = "Order Total: ";
            // 
            // lblOrderSubtotal
            // 
            this.lblOrderSubtotal.AutoSize = true;
            this.lblOrderSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSubtotal.Location = new System.Drawing.Point(439, 1373);
            this.lblOrderSubtotal.Name = "lblOrderSubtotal";
            this.lblOrderSubtotal.Size = new System.Drawing.Size(115, 44);
            this.lblOrderSubtotal.TabIndex = 23;
            this.lblOrderSubtotal.Text = "$0.00";
            // 
            // lblOrderTax
            // 
            this.lblOrderTax.AutoSize = true;
            this.lblOrderTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTax.Location = new System.Drawing.Point(439, 1482);
            this.lblOrderTax.Name = "lblOrderTax";
            this.lblOrderTax.Size = new System.Drawing.Size(115, 44);
            this.lblOrderTax.TabIndex = 24;
            this.lblOrderTax.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 1600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 44);
            this.label8.TabIndex = 25;
            this.label8.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(437, 1707);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(145, 55);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "$0.00";
            // 
            // lblCurrentItemNumber
            // 
            this.lblCurrentItemNumber.AutoSize = true;
            this.lblCurrentItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentItemNumber.Location = new System.Drawing.Point(385, 991);
            this.lblCurrentItemNumber.Name = "lblCurrentItemNumber";
            this.lblCurrentItemNumber.Size = new System.Drawing.Size(0, 46);
            this.lblCurrentItemNumber.TabIndex = 27;
            // 
            // lblCurrentItemName
            // 
            this.lblCurrentItemName.AutoSize = true;
            this.lblCurrentItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentItemName.Location = new System.Drawing.Point(385, 1131);
            this.lblCurrentItemName.Name = "lblCurrentItemName";
            this.lblCurrentItemName.Size = new System.Drawing.Size(0, 46);
            this.lblCurrentItemName.TabIndex = 28;
            // 
            // panelCheckout
            // 
            this.panelCheckout.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCheckout.Controls.Add(this.lblCurrentItemTotal);
            this.panelCheckout.Controls.Add(this.label7);
            this.panelCheckout.Controls.Add(this.lblCurrentItemPrice);
            this.panelCheckout.Controls.Add(this.label1);
            this.panelCheckout.Controls.Add(this.btnAddCoupon);
            this.panelCheckout.Controls.Add(this.btnVoidOrder);
            this.panelCheckout.Controls.Add(this.btnAddItemManually);
            this.panelCheckout.Controls.Add(this.btnPriceChange);
            this.panelCheckout.Controls.Add(this.lblCurrentItemName);
            this.panelCheckout.Controls.Add(this.btnAddItem);
            this.panelCheckout.Controls.Add(this.lblCurrentItemNumber);
            this.panelCheckout.Controls.Add(this.label3);
            this.panelCheckout.Controls.Add(this.btnCheckout);
            this.panelCheckout.Controls.Add(this.btnRemoveItem);
            this.panelCheckout.Controls.Add(this.lblUpdateQuantity);
            this.panelCheckout.Controls.Add(this.label4);
            this.panelCheckout.Controls.Add(this.label5);
            this.panelCheckout.Controls.Add(this.slQuantity);
            this.panelCheckout.Controls.Add(this.btnUpdateQuantity);
            this.panelCheckout.Controls.Add(this.lblTime);
            this.panelCheckout.Location = new System.Drawing.Point(2579, 0);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(1142, 1960);
            this.panelCheckout.TabIndex = 29;
            // 
            // panelProcess
            // 
            this.panelProcess.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelProcess.Controls.Add(this.panelOrderProcessed);
            this.panelProcess.Controls.Add(this.btnCash);
            this.panelProcess.Controls.Add(this.panelCard);
            this.panelProcess.Controls.Add(this.btnCard);
            this.panelProcess.Controls.Add(this.btnProcessOrder);
            this.panelProcess.Controls.Add(this.btnGoBack);
            this.panelProcess.Location = new System.Drawing.Point(2579, 149);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(1139, 1808);
            this.panelProcess.TabIndex = 37;
            this.panelProcess.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCash.FlatAppearance.BorderSize = 2;
            this.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCash.Location = new System.Drawing.Point(656, 203);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(347, 101);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCard.FlatAppearance.BorderSize = 2;
            this.btnCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCard.Location = new System.Drawing.Point(134, 203);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(347, 101);
            this.btnCard.TabIndex = 2;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProcessOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcessOrder.FlatAppearance.BorderSize = 2;
            this.btnProcessOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnProcessOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcessOrder.Location = new System.Drawing.Point(228, 1224);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(676, 186);
            this.btnProcessOrder.TabIndex = 1;
            this.btnProcessOrder.Text = "Pay Now";
            this.btnProcessOrder.UseVisualStyleBackColor = false;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGoBack.FlatAppearance.BorderSize = 2;
            this.btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(228, 1498);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(676, 186);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 1210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 46);
            this.label7.TabIndex = 35;
            this.label7.Text = "Item Total:";
            // 
            // lblCurrentItemPrice
            // 
            this.lblCurrentItemPrice.AutoSize = true;
            this.lblCurrentItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentItemPrice.Location = new System.Drawing.Point(385, 1059);
            this.lblCurrentItemPrice.Name = "lblCurrentItemPrice";
            this.lblCurrentItemPrice.Size = new System.Drawing.Size(0, 46);
            this.lblCurrentItemPrice.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 1059);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 46);
            this.label1.TabIndex = 33;
            this.label1.Text = "Item Price: ";
            // 
            // btnAddCoupon
            // 
            this.btnAddCoupon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCoupon.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCoupon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCoupon.FlatAppearance.BorderSize = 2;
            this.btnAddCoupon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnAddCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoupon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCoupon.Location = new System.Drawing.Point(294, 661);
            this.btnAddCoupon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCoupon.Name = "btnAddCoupon";
            this.btnAddCoupon.Size = new System.Drawing.Size(502, 113);
            this.btnAddCoupon.TabIndex = 32;
            this.btnAddCoupon.Text = "Add Coupon";
            this.btnAddCoupon.UseVisualStyleBackColor = false;
            // 
            // btnVoidOrder
            // 
            this.btnVoidOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoidOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoidOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoidOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoidOrder.FlatAppearance.BorderSize = 2;
            this.btnVoidOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVoidOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoidOrder.Location = new System.Drawing.Point(179, 1677);
            this.btnVoidOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoidOrder.Name = "btnVoidOrder";
            this.btnVoidOrder.Size = new System.Drawing.Size(676, 184);
            this.btnVoidOrder.TabIndex = 31;
            this.btnVoidOrder.Text = "Void Order";
            this.btnVoidOrder.UseVisualStyleBackColor = false;
            this.btnVoidOrder.Click += new System.EventHandler(this.btnVoidOrder_Click);
            // 
            // btnAddItemManually
            // 
            this.btnAddItemManually.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItemManually.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddItemManually.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItemManually.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddItemManually.FlatAppearance.BorderSize = 2;
            this.btnAddItemManually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnAddItemManually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemManually.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddItemManually.Location = new System.Drawing.Point(294, 320);
            this.btnAddItemManually.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItemManually.Name = "btnAddItemManually";
            this.btnAddItemManually.Size = new System.Drawing.Size(502, 113);
            this.btnAddItemManually.TabIndex = 30;
            this.btnAddItemManually.Text = "Add Item Manually";
            this.btnAddItemManually.UseVisualStyleBackColor = false;
            this.btnAddItemManually.Click += new System.EventHandler(this.btnAddItemManually_Click);
            // 
            // btnPriceChange
            // 
            this.btnPriceChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPriceChange.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPriceChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceChange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPriceChange.FlatAppearance.BorderSize = 2;
            this.btnPriceChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnPriceChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceChange.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPriceChange.Location = new System.Drawing.Point(294, 490);
            this.btnPriceChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceChange.Name = "btnPriceChange";
            this.btnPriceChange.Size = new System.Drawing.Size(502, 113);
            this.btnPriceChange.TabIndex = 29;
            this.btnPriceChange.Text = "Price Change";
            this.btnPriceChange.UseVisualStyleBackColor = false;
            this.btnPriceChange.Click += new System.EventHandler(this.btnPriceChange_Click);
            // 
            // slQuantity
            // 
            this.slQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slQuantity.Location = new System.Drawing.Point(393, 1285);
            this.slQuantity.Name = "slQuantity";
            this.slQuantity.Size = new System.Drawing.Size(250, 44);
            this.slQuantity.TabIndex = 17;
            // 
            // panelCash
            // 
            this.panelCash.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCash.Controls.Add(this.label24);
            this.panelCash.Controls.Add(this.lblAmountDueCash);
            this.panelCash.Controls.Add(this.label12);
            this.panelCash.Controls.Add(this.label11);
            this.panelCash.Controls.Add(this.txtAmountToPay);
            this.panelCash.Controls.Add(this.label10);
            this.panelCash.Location = new System.Drawing.Point(0, 0);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(1142, 691);
            this.panelCash.TabIndex = 4;
            this.panelCash.Visible = false;
            // 
            // lblAmountDueCash
            // 
            this.lblAmountDueCash.AutoSize = true;
            this.lblAmountDueCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueCash.Location = new System.Drawing.Point(372, 182);
            this.lblAmountDueCash.Name = "lblAmountDueCash";
            this.lblAmountDueCash.Size = new System.Drawing.Size(155, 46);
            this.lblAmountDueCash.TabIndex = 4;
            this.lblAmountDueCash.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(80, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 46);
            this.label12.TabIndex = 3;
            this.label12.Text = "Amount Due:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 46);
            this.label11.TabIndex = 2;
            this.label11.Text = "$";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.DecimalPlaces = 2;
            this.txtAmountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToPay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtAmountToPay.Location = new System.Drawing.Point(430, 382);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(366, 44);
            this.txtAmountToPay.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Amount Paid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1683, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 44);
            this.label9.TabIndex = 30;
            this.label9.Text = "Items Total:";
            // 
            // lblItemsTotal
            // 
            this.lblItemsTotal.AutoSize = true;
            this.lblItemsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsTotal.Location = new System.Drawing.Point(1956, 91);
            this.lblItemsTotal.Name = "lblItemsTotal";
            this.lblItemsTotal.Size = new System.Drawing.Size(98, 37);
            this.lblItemsTotal.TabIndex = 31;
            this.lblItemsTotal.Text = "None";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCard.Controls.Add(this.panelCash);
            this.panelCard.Controls.Add(this.label25);
            this.panelCard.Controls.Add(this.txtCardNumber);
            this.panelCard.Controls.Add(this.txtCardCVV);
            this.panelCard.Controls.Add(this.txtCardYear);
            this.panelCard.Controls.Add(this.label19);
            this.panelCard.Controls.Add(this.label18);
            this.panelCard.Controls.Add(this.txtCardMonth);
            this.panelCard.Controls.Add(this.label15);
            this.panelCard.Controls.Add(this.lblAmountDueCard);
            this.panelCard.Controls.Add(this.label14);
            this.panelCard.Controls.Add(this.label16);
            this.panelCard.Location = new System.Drawing.Point(3, 439);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(1142, 688);
            this.panelCard.TabIndex = 5;
            this.panelCard.Visible = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(380, 278);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(563, 44);
            this.txtCardNumber.TabIndex = 13;
            // 
            // txtCardCVV
            // 
            this.txtCardCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardCVV.Location = new System.Drawing.Point(383, 482);
            this.txtCardCVV.Name = "txtCardCVV";
            this.txtCardCVV.Size = new System.Drawing.Size(182, 44);
            this.txtCardCVV.TabIndex = 12;
            // 
            // txtCardYear
            // 
            this.txtCardYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardYear.Location = new System.Drawing.Point(761, 374);
            this.txtCardYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.txtCardYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.txtCardYear.Name = "txtCardYear";
            this.txtCardYear.Size = new System.Drawing.Size(182, 44);
            this.txtCardYear.TabIndex = 11;
            this.txtCardYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(600, 374);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 46);
            this.label19.TabIndex = 10;
            this.label19.Text = "YYYY:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(278, 374);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 46);
            this.label18.TabIndex = 9;
            this.label18.Text = "M:";
            // 
            // txtCardMonth
            // 
            this.txtCardMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardMonth.Location = new System.Drawing.Point(383, 380);
            this.txtCardMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtCardMonth.Name = "txtCardMonth";
            this.txtCardMonth.Size = new System.Drawing.Size(182, 44);
            this.txtCardMonth.TabIndex = 7;
            this.txtCardMonth.ThousandsSeparator = true;
            this.txtCardMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(241, 482);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 46);
            this.label15.TabIndex = 5;
            this.label15.Text = "CVV:";
            // 
            // lblAmountDueCard
            // 
            this.lblAmountDueCard.AutoSize = true;
            this.lblAmountDueCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueCard.Location = new System.Drawing.Point(372, 182);
            this.lblAmountDueCard.Name = "lblAmountDueCard";
            this.lblAmountDueCard.Size = new System.Drawing.Size(155, 46);
            this.lblAmountDueCard.TabIndex = 4;
            this.lblAmountDueCard.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(80, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 46);
            this.label14.TabIndex = 3;
            this.label14.Text = "Amount Due:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(63, 278);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(281, 46);
            this.label16.TabIndex = 0;
            this.label16.Text = "Card Number:";
            // 
            // panelOrderProcessed
            // 
            this.panelOrderProcessed.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelOrderProcessed.Controls.Add(this.lblChangeDue);
            this.panelOrderProcessed.Controls.Add(this.lblTotalPaid);
            this.panelOrderProcessed.Controls.Add(this.lblAmountDue);
            this.panelOrderProcessed.Controls.Add(this.btnEmailReciept);
            this.panelOrderProcessed.Controls.Add(this.btnPrintReciept);
            this.panelOrderProcessed.Controls.Add(this.label23);
            this.panelOrderProcessed.Controls.Add(this.label22);
            this.panelOrderProcessed.Controls.Add(this.label21);
            this.panelOrderProcessed.Controls.Add(this.label20);
            this.panelOrderProcessed.Controls.Add(this.label17);
            this.panelOrderProcessed.Controls.Add(this.label13);
            this.panelOrderProcessed.Controls.Add(this.btnStartNextOrder);
            this.panelOrderProcessed.Location = new System.Drawing.Point(3, 0);
            this.panelOrderProcessed.Name = "panelOrderProcessed";
            this.panelOrderProcessed.Size = new System.Drawing.Size(1142, 1811);
            this.panelOrderProcessed.TabIndex = 5;
            this.panelOrderProcessed.Visible = false;
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.AutoSize = true;
            this.lblChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeDue.Location = new System.Drawing.Point(661, 579);
            this.lblChangeDue.Name = "lblChangeDue";
            this.lblChangeDue.Size = new System.Drawing.Size(135, 39);
            this.lblChangeDue.TabIndex = 14;
            this.lblChangeDue.Text = "label25";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.Location = new System.Drawing.Point(661, 469);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(135, 39);
            this.lblTotalPaid.TabIndex = 13;
            this.lblTotalPaid.Text = "label24";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(661, 353);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(135, 39);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "label24";
            // 
            // btnEmailReciept
            // 
            this.btnEmailReciept.BackColor = System.Drawing.Color.Linen;
            this.btnEmailReciept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmailReciept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmailReciept.FlatAppearance.BorderSize = 3;
            this.btnEmailReciept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEmailReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailReciept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailReciept.ForeColor = System.Drawing.Color.Black;
            this.btnEmailReciept.Location = new System.Drawing.Point(633, 796);
            this.btnEmailReciept.Name = "btnEmailReciept";
            this.btnEmailReciept.Size = new System.Drawing.Size(308, 106);
            this.btnEmailReciept.TabIndex = 11;
            this.btnEmailReciept.Text = "Email Reciept";
            this.btnEmailReciept.UseVisualStyleBackColor = false;
            // 
            // btnPrintReciept
            // 
            this.btnPrintReciept.BackColor = System.Drawing.Color.Linen;
            this.btnPrintReciept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReciept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrintReciept.FlatAppearance.BorderSize = 3;
            this.btnPrintReciept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrintReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReciept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReciept.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReciept.Location = new System.Drawing.Point(257, 796);
            this.btnPrintReciept.Name = "btnPrintReciept";
            this.btnPrintReciept.Size = new System.Drawing.Size(308, 106);
            this.btnPrintReciept.TabIndex = 9;
            this.btnPrintReciept.Text = "Print Reciept";
            this.btnPrintReciept.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(533, 1158);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 63);
            this.label23.TabIndex = 8;
            this.label23.Text = "OR";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(392, 1008);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(395, 63);
            this.label22.TabIndex = 7;
            this.label22.Text = "Start Scanning";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(285, 579);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(265, 46);
            this.label21.TabIndex = 6;
            this.label21.Text = "Change Due:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(286, 348);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(264, 46);
            this.label20.TabIndex = 5;
            this.label20.Text = "Amount Due:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(327, 464);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(222, 46);
            this.label17.TabIndex = 4;
            this.label17.Text = "Total Paid:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(573, 76);
            this.label13.TabIndex = 3;
            this.label13.Text = "Order Processed!";
            // 
            // btnStartNextOrder
            // 
            this.btnStartNextOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStartNextOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartNextOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartNextOrder.FlatAppearance.BorderSize = 2;
            this.btnStartNextOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnStartNextOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNextOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNextOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartNextOrder.Location = new System.Drawing.Point(257, 1306);
            this.btnStartNextOrder.Name = "btnStartNextOrder";
            this.btnStartNextOrder.Size = new System.Drawing.Size(676, 264);
            this.btnStartNextOrder.TabIndex = 2;
            this.btnStartNextOrder.Text = "Sart Next Order";
            this.btnStartNextOrder.UseVisualStyleBackColor = false;
            this.btnStartNextOrder.Click += new System.EventHandler(this.btnStartNextOrder_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(204, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(698, 37);
            this.label24.TabIndex = 5;
            this.label24.Text = "Enter the amount given and press \"Pay Now\"";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(242, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(623, 37);
            this.label25.TabIndex = 6;
            this.label25.Text = "Press \"Pay Now\" or enter card manually";
            // 
            // lblCurrentItemTotal
            // 
            this.lblCurrentItemTotal.AutoSize = true;
            this.lblCurrentItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentItemTotal.Location = new System.Drawing.Point(385, 1210);
            this.lblCurrentItemTotal.Name = "lblCurrentItemTotal";
            this.lblCurrentItemTotal.Size = new System.Drawing.Size(43, 46);
            this.lblCurrentItemTotal.TabIndex = 36;
            this.lblCurrentItemTotal.Text = "h";
            // 
            // panelChangeDisplay
            // 
            this.panelChangeDisplay.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelChangeDisplay.Controls.Add(this.lblPenny);
            this.panelChangeDisplay.Controls.Add(this.lblNickel);
            this.panelChangeDisplay.Controls.Add(this.lblDime);
            this.panelChangeDisplay.Controls.Add(this.lblQuarter);
            this.panelChangeDisplay.Controls.Add(this.label54);
            this.panelChangeDisplay.Controls.Add(this.label53);
            this.panelChangeDisplay.Controls.Add(this.label52);
            this.panelChangeDisplay.Controls.Add(this.label51);
            this.panelChangeDisplay.Controls.Add(this.label50);
            this.panelChangeDisplay.Controls.Add(this.label49);
            this.panelChangeDisplay.Controls.Add(this.label48);
            this.panelChangeDisplay.Controls.Add(this.label47);
            this.panelChangeDisplay.Controls.Add(this.label46);
            this.panelChangeDisplay.Controls.Add(this.label45);
            this.panelChangeDisplay.Controls.Add(this.lblOne);
            this.panelChangeDisplay.Controls.Add(this.lblFive);
            this.panelChangeDisplay.Controls.Add(this.lblTen);
            this.panelChangeDisplay.Controls.Add(this.lblTwenty);
            this.panelChangeDisplay.Controls.Add(this.lblFifty);
            this.panelChangeDisplay.Controls.Add(this.lblHundred);
            this.panelChangeDisplay.Controls.Add(this.label38);
            this.panelChangeDisplay.Controls.Add(this.label37);
            this.panelChangeDisplay.Controls.Add(this.label36);
            this.panelChangeDisplay.Controls.Add(this.label35);
            this.panelChangeDisplay.Controls.Add(this.label34);
            this.panelChangeDisplay.Controls.Add(this.label33);
            this.panelChangeDisplay.Controls.Add(this.label32);
            this.panelChangeDisplay.Controls.Add(this.label31);
            this.panelChangeDisplay.Controls.Add(this.label30);
            this.panelChangeDisplay.Controls.Add(this.label29);
            this.panelChangeDisplay.Controls.Add(this.label28);
            this.panelChangeDisplay.Controls.Add(this.label27);
            this.panelChangeDisplay.Controls.Add(this.label26);
            this.panelChangeDisplay.Location = new System.Drawing.Point(1034, 1296);
            this.panelChangeDisplay.Name = "panelChangeDisplay";
            this.panelChangeDisplay.Size = new System.Drawing.Size(1397, 565);
            this.panelChangeDisplay.TabIndex = 38;
            this.panelChangeDisplay.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(485, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(433, 63);
            this.label26.TabIndex = 39;
            this.label26.Text = "Change To Give";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(103, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 46);
            this.label27.TabIndex = 40;
            this.label27.Text = "$100";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(125, 207);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 46);
            this.label28.TabIndex = 41;
            this.label28.Text = "$50";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(125, 265);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 46);
            this.label29.TabIndex = 42;
            this.label29.Text = "$20";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(125, 324);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 46);
            this.label30.TabIndex = 43;
            this.label30.Text = "$10";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(147, 381);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 46);
            this.label31.TabIndex = 44;
            this.label31.Text = "$5";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(147, 441);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 46);
            this.label32.TabIndex = 45;
            this.label32.Text = "$1";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(239, 144);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 46);
            this.label33.TabIndex = 46;
            this.label33.Text = "x";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(239, 265);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 46);
            this.label34.TabIndex = 47;
            this.label34.Text = "x";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(239, 207);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 46);
            this.label35.TabIndex = 48;
            this.label35.Text = "x";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(239, 324);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 46);
            this.label36.TabIndex = 49;
            this.label36.Text = "x";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(239, 381);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 46);
            this.label37.TabIndex = 50;
            this.label37.Text = "x";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(239, 441);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 46);
            this.label38.TabIndex = 51;
            this.label38.Text = "x";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHundred
            // 
            this.lblHundred.AutoSize = true;
            this.lblHundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHundred.Location = new System.Drawing.Point(326, 144);
            this.lblHundred.Name = "lblHundred";
            this.lblHundred.Size = new System.Drawing.Size(42, 46);
            this.lblHundred.TabIndex = 52;
            this.lblHundred.Text = "0";
            this.lblHundred.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFifty
            // 
            this.lblFifty.AutoSize = true;
            this.lblFifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifty.Location = new System.Drawing.Point(326, 207);
            this.lblFifty.Name = "lblFifty";
            this.lblFifty.Size = new System.Drawing.Size(42, 46);
            this.lblFifty.TabIndex = 53;
            this.lblFifty.Text = "0";
            this.lblFifty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTwenty
            // 
            this.lblTwenty.AutoSize = true;
            this.lblTwenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwenty.Location = new System.Drawing.Point(326, 265);
            this.lblTwenty.Name = "lblTwenty";
            this.lblTwenty.Size = new System.Drawing.Size(42, 46);
            this.lblTwenty.TabIndex = 54;
            this.lblTwenty.Text = "0";
            this.lblTwenty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(326, 324);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(42, 46);
            this.lblTen.TabIndex = 55;
            this.lblTen.Text = "0";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(326, 381);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(42, 46);
            this.lblFive.TabIndex = 56;
            this.lblFive.Text = "0";
            this.lblFive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(326, 441);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(42, 46);
            this.lblOne.TabIndex = 57;
            this.lblOne.Text = "0";
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(210, 77);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(108, 51);
            this.label45.TabIndex = 58;
            this.label45.Text = "Bills";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(1118, 77);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(138, 51);
            this.label46.TabIndex = 59;
            this.label46.Text = "Coins";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(1015, 144);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(86, 46);
            this.label47.TabIndex = 60;
            this.label47.Text = "25¢";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(1015, 207);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(86, 46);
            this.label48.TabIndex = 61;
            this.label48.Text = "10¢";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(1037, 265);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 46);
            this.label49.TabIndex = 62;
            this.label49.Text = "5¢";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(1037, 324);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(64, 46);
            this.label50.TabIndex = 63;
            this.label50.Text = "1¢";
            this.label50.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(1164, 144);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 46);
            this.label51.TabIndex = 64;
            this.label51.Text = "x";
            this.label51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(1164, 207);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(41, 46);
            this.label52.TabIndex = 65;
            this.label52.Text = "x";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(1164, 265);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(41, 46);
            this.label53.TabIndex = 66;
            this.label53.Text = "x";
            this.label53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(1164, 324);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 46);
            this.label54.TabIndex = 67;
            this.label54.Text = "x";
            this.label54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarter.Location = new System.Drawing.Point(1275, 144);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(42, 46);
            this.lblQuarter.TabIndex = 68;
            this.lblQuarter.Text = "0";
            this.lblQuarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDime
            // 
            this.lblDime.AutoSize = true;
            this.lblDime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDime.Location = new System.Drawing.Point(1275, 207);
            this.lblDime.Name = "lblDime";
            this.lblDime.Size = new System.Drawing.Size(42, 46);
            this.lblDime.TabIndex = 69;
            this.lblDime.Text = "0";
            this.lblDime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNickel
            // 
            this.lblNickel.AutoSize = true;
            this.lblNickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickel.Location = new System.Drawing.Point(1275, 265);
            this.lblNickel.Name = "lblNickel";
            this.lblNickel.Size = new System.Drawing.Size(42, 46);
            this.lblNickel.TabIndex = 70;
            this.lblNickel.Text = "0";
            this.lblNickel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPenny
            // 
            this.lblPenny.AutoSize = true;
            this.lblPenny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenny.Location = new System.Drawing.Point(1275, 324);
            this.lblPenny.Name = "lblPenny";
            this.lblPenny.Size = new System.Drawing.Size(42, 46);
            this.lblPenny.TabIndex = 71;
            this.lblPenny.Text = "0";
            this.lblPenny.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelProcessingPopUp
            // 
            this.panelProcessingPopUp.BackColor = System.Drawing.Color.DarkGray;
            this.panelProcessingPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcessingPopUp.Controls.Add(this.label39);
            this.panelProcessingPopUp.Location = new System.Drawing.Point(703, 236);
            this.panelProcessingPopUp.Name = "panelProcessingPopUp";
            this.panelProcessingPopUp.Size = new System.Drawing.Size(2158, 1188);
            this.panelProcessingPopUp.TabIndex = 39;
            this.panelProcessingPopUp.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(504, 479);
            this.label39.Name = "label39";
            this.label39.Padding = new System.Windows.Forms.Padding(50);
            this.label39.Size = new System.Drawing.Size(1076, 220);
            this.label39.TabIndex = 0;
            this.label39.Text = "Order Processing...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(3723, 1958);
            this.Controls.Add(this.panelProcessingPopUp);
            this.Controls.Add(this.panelChangeDisplay);
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.lblItemsTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOrderTax);
            this.Controls.Add(this.lblOrderSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.gvItemList);
            this.Controls.Add(this.panelCheckout);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.panelProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slQuantity)).EndInit();
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountToPay)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardCVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardMonth)).EndInit();
            this.panelOrderProcessed.ResumeLayout(false);
            this.panelOrderProcessed.PerformLayout();
            this.panelChangeDisplay.ResumeLayout(false);
            this.panelChangeDisplay.PerformLayout();
            this.panelProcessingPopUp.ResumeLayout(false);
            this.panelProcessingPopUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label txtOrderNumber;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrderSubtotal;
        private System.Windows.Forms.Label lblOrderTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurrentItemNumber;
        private System.Windows.Forms.Label lblCurrentItemName;
        private System.Windows.Forms.Panel panelCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_total;
        private System.Windows.Forms.NumericUpDown slQuantity;
        private System.Windows.Forms.Button btnPriceChange;
        private System.Windows.Forms.Button btnAddCoupon;
        private System.Windows.Forms.Button btnVoidOrder;
        private System.Windows.Forms.Button btnAddItemManually;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblItemsTotal;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtAmountToPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label lblAmountDueCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAmountDueCard;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown txtCardNumber;
        private System.Windows.Forms.NumericUpDown txtCardCVV;
        private System.Windows.Forms.NumericUpDown txtCardYear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown txtCardMonth;
        private System.Windows.Forms.Panel panelOrderProcessed;
        private System.Windows.Forms.Button btnEmailReciept;
        private System.Windows.Forms.Button btnPrintReciept;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStartNextOrder;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblCurrentItemTotal;
        private System.Windows.Forms.Panel panelChangeDisplay;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTwenty;
        private System.Windows.Forms.Label lblFifty;
        private System.Windows.Forms.Label lblHundred;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblPenny;
        private System.Windows.Forms.Label lblNickel;
        private System.Windows.Forms.Label lblDime;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panelProcessingPopUp;
        private System.Windows.Forms.Label label39;
    }
}

