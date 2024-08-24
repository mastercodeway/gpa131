using TestingDynamik.MainClasses;

namespace TestingDynamik.Display
{
    /// <summary>
    /// SKapar text innehåll till kvitto
    /// 
    /// </summary>
    internal class OrderLineItemDisplay
    {
       
        #region Properties OrderlineItemDispplay
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double PriceTotal { get; set; }
        public double Price { get; set; }

        public  double Moms { get; set; }
        public double Discount { get; set; }
        #endregion

        #region Method

        // Samlar alla värden som ska visas i gränsnitte för varje orderline item 

        public static OrderLineItemDisplay MapDisplayItem(OrderLineItem model)
        {
            var (moms, discount, priceTotal, _) = model.GetOrderLineInfo();
            return new OrderLineItemDisplay
            {
                ProductName = model.Product.ProductName,
                Quantity = model.Quantity,
                PriceTotal = Math.Round(priceTotal,2),
                Price = Math.Round(model.Product.CalculatePrice(),2),
                Moms = Math.Round(moms,2),
                Discount = Math.Round(discount,2)
            }; 
        }

        /// <summary>
        /// Utskrift till kvitto beroende på om varan har lagt till 1 gånger eller flera gånger. 
        /// Skriver sedan ut beroende om quantitet är större av en eller bara 1 av en vara override ToStringMetod
        /// Använder polymorhpism
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            if(Quantity == 1)
            {
                return $"{ProductName}\t\t\t {PriceTotal}\r\n" +
                    $"moms  \t\t\t {Moms}\r\n" +
                    $"rabatt\t\t\t-{Discount}";
            }
            else
            {
                return $"{ProductName}\t {Quantity}st * {Price}\t{PriceTotal}\r\n" +
                    $"moms  \t\t\t {Moms}\r\n" +
                    $"rabatt\t\t\t-{Discount}";

            }
            #endregion
        }
    }
}
