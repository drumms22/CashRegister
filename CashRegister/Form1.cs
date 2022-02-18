using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json; // Nuget Package

namespace CashRegister
{
    public partial class Form1 : Form
    {

        private RequestHandler request = new RequestHandler();
        public string order_key = "";
        public Item currentItem = new Item();
        private Order order = new Order();
        private Timer timer = new Timer();
        private Timer processOrderTimer = new Timer();
        private int processOrderCount = 0;
        private Payment payment = new Payment();

        public Form1()
        {
            InitializeComponent();
            loadData();
            setDateTime();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            panelProcess.Visible = true;
            panelCard.Visible = true;
            payment.payment_type = "card";
            panelProcess.BringToFront();
            lblAmountDueCard.Text = order.amount_due.ToString("c");
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var form = new ItemsWindow();
            form.order_key = order_key;

            this.SendToBack();
            form.ShowDialog();

            if (form.listClicked)
            {
                currentItem = form.selectedItem;
                makeRequest("http://localhost:5000/order/item/add", form.selectedItem);
            }
           
        }

        private void loadData()
        {
            Item item = new Item();

            makeRequest("http://localhost:5000/order/start", item);
 
        }

        private async void makeRequest(string url, object obj)
        {
            string JSONresult = JsonConvert.SerializeObject(obj);

            try
            {

                string x = await request.PostCallAPI(url, JSONresult);
                
                Root resObject = JsonConvert.DeserializeObject<Root>(x);

                if(resObject.status == 200)
                {

                    setOrderKey(resObject.order_key);

                    order = resObject.order;

                    updateUI(resObject.order);

                }
                else
                {
                    Console.WriteLine(resObject.mmessage);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void setOrderKey(string key)
        {
            order_key = key;
        }

        private void updateUI(Order order)
        {
            txtOrderNumber.Text = order.order_id;
            lblOrderSubtotal.Text = order.order_subtotal.ToString("C");
            lblOrderTax.Text = order.order_tax_perc.ToString("C");
            lblTotal.Text = order.order_total.ToString("C");
            lblItemsTotal.Text = order.item_total.ToString();

            if (order.order_completed) orderProcessed(order);
                
            gvItemList.Rows.Clear();
            if(order.line_items.Count > 0)
            {
                foreach (Item item in order.line_items)
                {
                    if (item.item_number == currentItem.item_number)
                    {
                        currentItem = item;
                    }
                }

                updateItemList(order.line_items);
            }

            setCurrentItem(currentItem);
        }

        private void updateItemList(List<Item>itemList)
        {
            
           int index = -1;
           for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].item_number == currentItem.item_number) index = i;
                gvItemList.Rows.Add(itemList[i].item_number, itemList[i].item_name, itemList[i].item_price.ToString("C"), itemList[i].quantity.ToString(), itemList[i].item_total.ToString("C"));
                
            }

            if(index > -1) gvItemList.Rows[index].Selected = true;
            
        }

        private void orderProcessed(Order order)
        {
            panelCash.Visible = false;
            panelCard.Visible = false;
            panelOrderProcessed.Visible = true;

            lblAmountDue.Text = order.amount_due.ToString("c");
            lblTotalPaid.Text = order.amount_paid.ToString("c");
            lblChangeDue.Text = order.change_due.ToString("c");

            if(order.change_due > 0.00)
            {
                displayChange(order.change_currency);
            }

        }

        private void displayChange(ChangeCurrency change)
        {

            panelChangeDisplay.Visible = true;

            lblHundred.Text = change.bills[0].total.ToString();
            lblFifty.Text = change.bills[1].total.ToString();
            lblTwenty.Text = change.bills[2].total.ToString();
            lblTen.Text = change.bills[3].total.ToString();
            lblFive.Text = change.bills[4].total.ToString();
            lblOne.Text = change.bills[5].total.ToString();

            lblQuarter.Text = change.coins[0].total.ToString();
            lblDime.Text = change.coins[1].total.ToString();
            lblNickel.Text = change.coins[2].total.ToString();
            lblPenny.Text = change.coins[3].total.ToString();


        }

        private void setDateTime()
        {
            timer.Interval = (1000);
            timer.Enabled = true;
            timer.Start();
            timer.Tick += new EventHandler(getTime);
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void displayProcessingScreen()
        {
            panelProcessingPopUp.Visible = true;
            panelProcessingPopUp.BringToFront();
            processOrderTimer.Interval = (1000);
            processOrderTimer.Enabled = true;
            processOrderTimer.Start();
            processOrderTimer.Tick += new EventHandler(processTimer);

        }

        private void processTimer(object sender, EventArgs e)
        {
            if (processOrderCount < 2)
            {
                processOrderCount++;
            }
            else
            {
                processOrderTimer.Stop();
                processOrderCount = 0;
                panelProcessingPopUp.Visible = false;
                makeRequest("http://localhost:5000/order/process", payment);
            }
        }

        private void getTime(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void setCurrentItem(Item item)
        {
            lblCurrentItemNumber.Text = item.item_number;
            lblCurrentItemName.Text = item.item_name;
            lblCurrentItemPrice.Text = item.item_price.ToString("c");
            lblCurrentItemTotal.Text = item.item_total.ToString("c");
            slQuantity.Value = item.quantity;

        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {

            if(currentItem.item_number != null)
            {
                currentItem.order_key = order_key;
                currentItem.quantity = (int)slQuantity.Value;
                makeRequest("http://localhost:5000/order/item/update", currentItem);
            }
            

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (currentItem.item_id != "")
            {
                Item tempItem = new Item();

                tempItem = currentItem;

                if (order.line_items.Count > 1)
                {
                    int index = order.line_items.FindIndex(a => a.item_number == currentItem.item_number);

                    if(index == order.line_items.Count-1)
                    {
                        currentItem = order.line_items[index-1];

                    }else if(index < order.line_items.Count-1)
                    {
                        currentItem = order.line_items[order.line_items.Count - 1];
                    }
                } else
                {
                    currentItem = new Item();
                }

                tempItem.order_key = order_key;
                tempItem.quantity = 0;

                makeRequest("http://localhost:5000/order/item/remove", tempItem);

            }
        }

        private void gvItemList_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = order.line_items[gvItemList.CurrentRow.Index];
            setCurrentItem(currentItem);
        }

        private void btnPriceChange_Click(object sender, EventArgs e)
        {
            var form = new PriceChange(currentItem);
            this.SendToBack();
            form.ShowDialog();

            if (form.errors)
            {
                Console.WriteLine(form.errors);
            }
            else
            {
                currentItem = form.item;
                form.item.order_key = order_key;
                makeRequest("http://localhost:5000/order/item/update", form.item);
            }

        }

        private void btnAddItemManually_Click(object sender, EventArgs e)
        {
            var form = new AddItemManually();
            this.SendToBack();
            form.ShowDialog();

            if (form.errors)
            {
                Console.WriteLine(form.errors);
            }
            else
            {
                currentItem = form.item;
                form.item.order_key = order_key;
                makeRequest("http://localhost:5000/order/item/add", form.item);
            }
        }

        private void btnVoidOrder_Click(object sender, EventArgs e)
        {

            string message = "Do you want to void this order?";
            string title = "Void Order";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                Item item = new Item();

                makeRequest("http://localhost:5000/order/start", item);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            panelProcess.Visible = false;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            panelCard.Visible = true;
            panelCash.Visible = false;
            payment.payment_type = "card";
            lblAmountDueCard.Text = order.amount_due.ToString("c");
            panelCard.BringToFront();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            payment.payment_type = "cash";
            panelCash.Visible = true;
            lblAmountDueCash.Text = order.amount_due.ToString("c");
            panelCash.BringToFront();
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {

            if (payment.payment_type == "card")
            {
                payment.amount_to_pay = order.order_total;
                payment.order_key = order_key;
                displayProcessingScreen();
            }
            else if (payment.payment_type == "cash")
            {
                payment.amount_to_pay = (double)txtAmountToPay.Value;
                payment.order_key = order_key;
                displayProcessingScreen();
            }

        }

        private void btnStartNextOrder_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            currentItem = item;
            panelOrderProcessed.Visible = false;
            panelProcess.Visible = false;
            panelChangeDisplay.Visible = false;
            panelCheckout.Visible = true;
            lblAmountDue.Text = "";
            lblAmountDueCard.Text = "";
            lblCurrentItemName.Text = "";
            lblCurrentItemNumber.Text = "";
            lblCurrentItemPrice.Text = "";
            lblCurrentItemTotal.Text = "";
            makeRequest("http://localhost:5000/order/start", item);
        }

 
    }
}

