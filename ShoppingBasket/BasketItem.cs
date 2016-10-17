namespace ShoppingBasket
{
    public class BasketItem
    {
        private double price;
        private string product;
        private int quantity;
        private double tPrice;
        public static double total;

        public BasketItem(string product, int quantity, double price)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
            this.tPrice = price * quantity;

            total = this.tPrice + tPrice;

            
        }


        public override string ToString()
        {
            return $"{product,-20}{quantity,-10}{"£"}{price,-10}{"£"}{tPrice, -10}";
        }

    }
}