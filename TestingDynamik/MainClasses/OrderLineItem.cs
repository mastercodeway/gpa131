namespace TestingDynamik.MainClasses
{
    /// <summary>
    /// Rad på kvittot. Innehåller en eller flera produkter av samma typ. 
    /// </summary>
    public class OrderLineItem
    {
        #region Properties
        public int Quantity { get; set; }
        public Product Product { get; set; }
        #endregion

        #region Constructor

        public OrderLineItem(int quantity, Product product)
        {
            
            Quantity = quantity;
            Product = product;
        }
        #endregion

        // Räknar ut moms, rabatt, brutto och netto pris för en varu typ i en beställning

        #region Method
        public (double, double, double, double) GetOrderLineInfo()
        {
            double moms = Product.GetMoms() * Quantity; 
            double discount = Product.GetDiscount() * Quantity;
            double grossPrice = Product.CalculatePrice() * Quantity;
            double netPrice = Product.Price * Quantity;

            return (moms, discount, grossPrice, netPrice);
        }
        #endregion

    }
}
