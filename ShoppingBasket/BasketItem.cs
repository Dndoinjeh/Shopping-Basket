namespace ShoppingBasket
{
    public class BasketItem
    {
        public static double total;
        public static int quant;
      
      
        public double price { get; set; }
        public int quantity { get; set; }
        public string product  { get; set; }
        public object Items { get; internal set; }
        public double tPrice { get; set; }

        public BasketItem(string product, int quantity, double price, double tPrice)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
            this.tPrice = price * quantity;
            total = tPrice;
            quant = quantity;
        }

        public override string ToString()
        {
            return $"{product,-20}{quantity,-10}{"£"}{price,-10}{"£"}{tPrice, -10}";
        }

    }
}