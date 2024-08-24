using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TestingDynamik.MainClasses;

namespace TestingDynamik
{
    public static class ButtonExtensions
    {    
        // Går igenom alla produkter i en lista och skapar
        // därefter knappar med rätt storlek färg och product namnet text
        public static List<Button> MapToButtons(this List<Product> products)
        {
            //för varje produkt skapas en ny button
            return products.Select(MapToButton).ToList();
            
        }
        // Ritning för knappar dess och text och utseende
        public static Button MapToButton(this Product product)
        {
            return new Button
            {
                Width = 150,
                Height = 51,
                BackColor = Color.MediumTurquoise,
                Text = product.ProductName
            }; 
        }
    }
}
