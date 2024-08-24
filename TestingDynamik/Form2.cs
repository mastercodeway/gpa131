using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestingDynamik.ChoiceTypes;
using TestingDynamik.MainClasses;

namespace TestingDynamik
{
    public partial class Form2 : Form
    {

        #region constructor
        public Form2()
        {
            // Lägger till items i en Combobox för produktkategorier och Rabatt och skriver ut kategorierna
            InitializeComponent();
            CBMenyCategory.Items.Add("Köttprodukter");
            CBMenyCategory.Items.Add("Frukt och grönt");
            CBMenyCategory.Items.Add("Godis");
            CBMenyCategory.Items.Add("Mejeriprodukter");

            CBDiscount.Items.Add("Ingen");
            CBDiscount.Items.Add("Liten");
            CBDiscount.Items.Add("Medium");
            CBDiscount.Items.Add("Stor");
            PrintCategories();
        }
        #endregion

        #region Input ComboBox

        // kollar vilket är det index som selected i Comboboxen returnar en discount och en produktcategori
        private DiscountType GetDiscountInput(int index)
        {
            switch (index)
            {
                case 0:
                    return DiscountType.None;
                case 1:
                    return DiscountType.Small;
                case 2:
                    return DiscountType.Medium;
                case 3:
                    return DiscountType.Large;
                default:
                    return DiscountType.None;
            }

        }
        private ProductCategory GetProductCat(int selectedIndex, Form1 form1)
        {
            switch (selectedIndex)
            {
                case 0:
                    return form1.Meat;
                case 1:
                    return form1.Greens;
                case 2:
                    return form1.Candy;
                case 3:
                    return form1.DairyProducts;
                default:
                    return default;

            }
            #endregion
        }
        private void PrintCategories()
        {

            MtbCategories.Clear();
            StringBuilder sb = new StringBuilder();

            // Källa Chat gpt komma åt Form1
            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                try
                {
                    sb.AppendLine(form1.Meat.ToString());
                    sb.AppendLine(form1.Greens.ToString());
                    sb.AppendLine(form1.Candy.ToString());
                    sb.AppendLine(form1.DairyProducts.ToString());
                    MtbCategories.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            sb.Clear();
        }

        #region Add and Create new products

        /* Skapar en produkt som med en produktkategory och dess värden i constructor för att
         sedan ladda den från form1 */

        private void CreateProduct(Form1 form1, string productCatName, MomsType moms, string name, int price)
        {
            ProductCategory prodCat = GetProductCat(CBMenyCategory.SelectedIndex, form1);

            prodCat.Products.Add(new Product(new ProductCategory(productCatName, moms), name, price,
                GetDiscountInput(CBDiscount.SelectedIndex)));

            form1.LoadProductCategory(prodCat.Products);
        }

        private void AddNewProduct()
        {
            //ta inmatning för pris och produktnamm

            int price = int.TryParse(textBox1.Text, out int result)
                ? result
                : 0;

            string name = textBox2.Text;

            // Chat Gpt Ge tillgänglighet till funktioner i form1

            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                // Kollar vilket index användaren har satt produkten på i cbkategori
                // skapar en ny Produkt object som tar argumenten pris, id och namn från inmatning
                switch (CBMenyCategory.SelectedIndex)
                {
                    case 0:
                        CreateProduct(form1, "Köttprodukter", ChoiceTypes.MomsType.Livsmedel, name, price);
                        break;
                    case 1:
                        CreateProduct(form1, "Frukt och grönt", ChoiceTypes.MomsType.Livsmedel, name, price);
                        break;
                    case 2:
                        CreateProduct(form1, "Godis", ChoiceTypes.MomsType.Livsmedel, name, price);
                        break;
                    case 3:
                        CreateProduct(form1, "Mejeriprodukter", ChoiceTypes.MomsType.Livsmedel, name, price);
                        break;
                    default:
                        break;
                }
            }

            // tömmer inmatning textboxen för pris och produktnamn
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            PrintCategories();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lägger till produkten
            AddNewProduct();
        }
        #endregion 

        #region menu Options
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taBortVarorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProductForm removeProductForm = new RemoveProductForm();
            removeProductForm.Show();
        }
        #endregion
    }
}
