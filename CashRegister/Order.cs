/*namespace CashRegister
{
    class Order
    {
        public string order_id = "";
        public int order_number = 0;
        public string order_date = "";
        public float order_subtotal = 0.00f;
        public float order_tax_perc = 0.00f;
        public float order_total = 0.00f;
        public int item_total = 0;
        public float amount_due = 0.00f;
        public float amount_paid = 0.00f;
        public float change_due = 0.00f;
        public bool order_completed = false;
        public string status = "";
        public Order(
            string order_id, 
            string order_date, 
            float order_subtotal, 
            float order_tax_perc, 
            float order_total, 
            int item_total, 
            float amount_due, 
            float amount_paid,
            float change_due,
            bool order_completed,
            string status
            )
        {
            this.order_id = order_id;
            this.order_date = order_date;
            this.order_subtotal = order_subtotal;
            this.order_tax_perc = order_tax_perc;
            this.order_total = order_total;
            this.item_total = item_total;
            this.amount_due = amount_due;
            this.amount_paid = amount_paid;
            this.change_due = change_due;
            this.order_completed = order_completed;
            this.status = status;
        }
        public string Order_id
        {
            get { return this.order_id; }
            set { this.order_id = value; }
        }
        public string Order_date
        {
            get { return this.order_date; }
            set { this.order_date = value; }
        }
        public int Order_number
        {
            get { return this.order_number; }
            set { this.order_number = value; }
        }
        public float Order_tax_perc
        {
            get { return this.order_tax_perc; }
            set { this.order_tax_perc = value; }
        }
        public float Order_subtotal
        {
            get { return this.order_subtotal; }
            set { this.order_subtotal = value; }
        }
        public float Order_total
        {
            get { return this.order_subtotal; }
            set { this.order_subtotal = value; }
        }
        public float Amount_due
        {
            get { return this.amount_due; }
            set { this.amount_due = value; }
        }
        public float Amount_paid
        {
            get { return this.amount_paid; }
            set { this.amount_paid = value; }
        }
        public float Change_due
        {
            get { return this.change_due; }
            set { this.change_due = value; }
        }
        public int Item_total
        {
            get { return this.item_total; }
            set { this.item_total = value; }
        }
        public bool Order_completed
        {
            get { return this.order_completed; }
            set { this.order_completed = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
    }
}*/
