namespace CashRegister
{
    class Product
    {
        public string product_id = "";
        public int product_number = 0;
        public string product_name = "";
        public string product_description = "";
        public float product_price = 0.00f;
        public int quantity = 0;

        public Product(string product_id, int product_number, string product_name, string product_description, float product_price, int quantity)
        {
            this.product_id = product_id;
            this.Product_number = product_number;
            this.product_name = product_name;
            this.product_description = product_description;
            this.product_price = product_price;
            this.quantity = quantity;
        }

        public string Product_id
        {
            get { return this.product_id; }
            set { this.product_id = value; }
        }

        public int Product_number { get; set; } = 0;

        public string Product_name
        {
            get { return this.product_name; }
            set { this.product_name = value; }
        }

        public string Product_description
        {
            get { return this.product_description; }
            set { this.product_description = value; }
        }

        public float Product_price
        {
            get { return this.product_price; }
            set { this.product_price = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }


    }
}
