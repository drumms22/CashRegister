using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class PriceChange : Form
    {
        public Item item = new Item();
        public bool errors = true;
        public PriceChange(Item item)
        {
            this.item = item;
            InitializeComponent();
        }

        private void PriceChange_Load(object sender, EventArgs e)
        {
            Console.WriteLine(item.item_number);
            loadReasons();
            lblItemNumber.Text = item.item_number;
            lblItemName.Text = item.item_name;
            slItemPrice.Value = (decimal)item.item_price;
            lstReasonForChange.SelectedIndex = 0;
        }

        private void loadReasons()
        {
            lstReasonForChange.Items.Add("Wrong price on sales floor");
            lstReasonForChange.Items.Add("Customer presented a coupon");
            lstReasonForChange.Items.Add("Price match to competitors price");
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (slItemPrice.Value < 0.01M)
            {
                setError();

            } else if (lstReasonForChange.SelectedIndex < 0)
            {
                setError();
            }
            else
            {

                item.item_price = (double)slItemPrice.Value;
                errors = false;
                this.Close();
            }
        }
        private void setError()
        {
            lblError.Visible = true;
            lblError.Text = "Price and Reason for change are required!";
        }
    }
}
