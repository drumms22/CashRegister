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
    public partial class ItemsWindow : Form
    {
        public Item selectedItem = new Item();
        private List<Item> itemsLsit = new List<Item>();
        public string order_key = "";
        public bool listClicked = true;
        public ItemsWindow()
        {
            InitializeComponent();
        }

        private void ItemsWindow_Load(object sender, EventArgs e)
        {
            loadItems();
            slQuantity.Value = 1;
        }

        private void loadItems()
        {
            //Item.createItem("123", "Test1", "This is test 1", 9.99, 0, 0.00);
            itemsLsit = createItemList();

            foreach (Item item in itemsLsit)
            {
                gvAddItemList.Rows.Add(item.item_number, item.item_name, item.item_description, item.item_price);
            }
        }

        private List<Item> createItemList()
        {
            List<Item> lstAddItems = new List<Item>();
            lstAddItems.Add(Item.createItem("123", "Test1", "This is test 1", 9.99, 0, 0.00));
            lstAddItems.Add(Item.createItem("456", "Test2", "This is test 2", 19.99, 0, 0.00));
            lstAddItems.Add(Item.createItem("789", "Test3", "This is test 3", 29.99, 0, 0.00));
            return lstAddItems;
        }

        private void gvAddItemList_SelectionChanged(object sender, EventArgs e)
        {
            selectedItem = itemsLsit[gvAddItemList.CurrentRow.Index];
            itemsLsit[gvAddItemList.CurrentRow.Index].order_key = order_key;
            itemsLsit[gvAddItemList.CurrentRow.Index].quantity = (int)slQuantity.Value;
            listClicked = !listClicked;
        }

        private void btnItemsWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slQuantity_ValueChanged(object sender, EventArgs e)
        {
            itemsLsit[gvAddItemList.CurrentRow.Index].quantity = (int)slQuantity.Value;
        }
    }
}
