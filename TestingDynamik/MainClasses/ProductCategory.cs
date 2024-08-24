using System.Linq;
using TestingDynamik.ChoiceTypes;

namespace TestingDynamik.MainClasses
{
    /// <summary>
    /// Kategori för de olika produkterna.
    /// Hanterar moms för produkt kategorier. 
    /// </summary>
    public class ProductCategory
    {
        #region Attributes
        
        public string Name { get; set; } = string.Empty;
        public MomsType Moms { get; set; }
        #endregion

        public List<Product> Products { get; set; } = new List<Product>();
        
        #region Constructor
       
        public ProductCategory(string name, MomsType moms)
        {
            
            Name = name;
            Moms = moms;
        }
        #endregion

        // Skriver ut en kategori och alla dess produkter polymorphism
        public override string ToString()
        {
            return $"kategori: {Name} \r\n\t{string.Join("\r\n\t", Products)}";
        }
    }
}
