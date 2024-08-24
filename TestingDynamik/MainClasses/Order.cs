using System.Diagnostics;

namespace TestingDynamik.MainClasses
{
    /// <summary>
    /// Kundens beställning, utträkningar och order specifik funktionalitet
    /// </summary>
    public class Order
    {
        #region Properties
        public List<OrderLineItem> LineItems { get; set; } = new List<OrderLineItem>();
        #endregion

        #region Derrived Attribute
        public double TotalAmount { get; set; }
        public double TotalMoms { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalNet { get; set; }
        #endregion

        #region Method
        /* Räknar ut det total värdet i order. Återställer priserna innan går igenom listan med orderlineItems
         * Checkar priset och dess mängd*/

        public void CalculateOrderTotal()
        {
            TotalAmount = 0;
            TotalMoms = 0;
            TotalDiscount = 0;
            TotalNet = 0;
            foreach (var item in LineItems)
            {
                var (moms, discount, price, net) = item.GetOrderLineInfo();
                TotalDiscount += discount;
                TotalMoms += moms;
                TotalAmount += price; 
                TotalNet += net;
            }

        }
        #endregion



    }
}
