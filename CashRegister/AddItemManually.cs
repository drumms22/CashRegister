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
    public partial class AddItemManually : Form
    {
        public bool errors = true;
        public Item item = new Item();
        public AddItemManually()
        {
            InitializeComponent();
        }

        private void AddItemManually_Load(object sender, EventArgs e)
        {
            slItemPrice.Value = 0.01M;
            slItemQuantity.Value = 1;
        }

        private void setError()
        {
            lblError.Visible = true;
            lblError.Text = "Required fields must be filled out!";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (txtItemNumber.Text == "" || txtItemName.Text == "")
            {
                setError();

            } 
            else if((double)slItemPrice.Value < 0.00)
            {
                setError();
            }
            else if (slItemQuantity.Value < 0)
            {
                setError();
            }
            else
            {
                errors = false;
                if (txtItemDescription.Text == "") item.item_description = "N/A";
                item.item_number = txtItemNumber.Text;
                item.item_name = txtItemName.Text;
                item.item_description = txtItemDescription.Text;
                item.item_price = (double)slItemPrice.Value;
                item.quantity = (int)slItemQuantity.Value;

                this.Close();
            }
        }
    }
}
