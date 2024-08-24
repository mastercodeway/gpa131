using TestingDynamik.ChoiceTypes;

namespace TestingDynamik.MainClasses
{
    /// <summary>
    /// Artikel som kan köpa av en kund. 
    /// Innehåller pris, Produktnamn, discount type
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Attribute för produkt vilket innehåller produktnamn, pris, discount type 
        /// </summary>
        #region Attributes
       
        public double Price { get; set; }
        public string ProductName { get; set; }
        public DiscountType Discount { get; set; }
        #endregion

        /// <summary>
        /// ProduktKategory
        /// </summary>
        #region Ref Attributes
       
        public ProductCategory Category { get; set; }
        #endregion

        #region Constructor
        public Product(ProductCategory category,
            string productName,
            double price,
            DiscountType discount = DiscountType.None)  
        {
            Category = category;
            ProductName = productName;
            Price = price;
            Discount = discount;
        }

        #endregion


        #region Utträknings metoder för produkt
        // Räknar ut momsen på varan
        public double GetMoms()
        {
            return (Price * (int)Category.Moms) / 100;
        }
        // räknar ut rabatten  efter moms
        public double GetDiscount()
        {
            return ((Price + GetMoms()) * (int)Discount) / 100;
        }
        // Räknar ut den priset på vara efter moms och rabatt
        public double CalculatePrice()
        {
            return Price + GetMoms() - GetDiscount(); 
        }
        #endregion

        // Utskrift När lägger till en ny vara i kassan i i formen för lägga till vara

        public override string ToString()
        {
            return $"Artikel: {ProductName}, " +
                $"Moms: {Math.Round(GetMoms(), 2)}kr," +
                $" Rabatt: {Math.Round(GetDiscount(), 2)}kr, " +
                $"Pris: {Math.Round(CalculatePrice(), 2)}kr";
        }
    }
}
