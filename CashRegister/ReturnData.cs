using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CashRegister
{
    public class ChangeCurrency
    {
        public string exchange { get; set; }
        public List<Bill> bills { get; set; }
        public List<Coin> coins { get; set; }
    }


    public class Bill
    {
        public string name { get; set; }
        public int total { get; set; }
    }

    public class Coin
    {
        public string name { get; set; }
        public int total { get; set; }
    }

    public class Order
    {
        public string order_id { get; set; }
        public DateTime order_date { get; set; }
        public double order_subtotal { get; set; }
        public double order_tax_perc { get; set; }
        public double order_total { get; set; }
        public int item_total { get; set; }
        public string payment_type { get; set; }
        public double amount_due { get; set; }
        public double amount_paid { get; set; }
        public double change_due { get; set; }
        public bool order_completed { get; set; }
        public string status { get; set; }
        public ChangeCurrency change_currency { get; set; }
        public List<Item> line_items { get; set; }
    }

    public class Item
    {
        public string order_key { get; set; }
        public string item_id { get; set; }
        public string item_number { get; set; }
        public string item_name { get; set; }
        public string item_description { get; set; }
        public double item_price { get; set; }
        public int quantity { get; set; }
        public double item_total { get; set; }
        public static Item createItem(string item_number, string item_name, string item_description, double item_price, int quantity, double item_total)
        {
            Item item = new Item();
            item.item_number = item_number;
            item.item_name = item_name;
            item.item_description = item_description;
            item.item_price = item_price;
            item.quantity = quantity;
            item.item_total = item_total;
            item.order_key = "";
            return item;
        }
    }

    public class Root
    {
        public int status { get; set; }
        public string mmessage { get; set; }
        public string order_key { get; set; }
        public Order order { get; set; }
    }

    public class Payment
    {
        public string order_key { get; set; }
        public double amount_to_pay { get; set; }
        public int card_number { get; set; }
        public int card_cvv { get; set; }
        public int card_month { get; set; }
        public int card_year { get; set; }
        public string payment_type { get; set; }
    }

}
