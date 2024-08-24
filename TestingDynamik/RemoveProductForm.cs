using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingDynamik.MainClasses;
using static System.Windows.Forms.DataFormats;

namespace TestingDynamik
{
    public partial class RemoveProductForm : Form
    {

        #region Constructor RemoveProductFOrm
        public RemoveProductForm()
        {
            InitializeComponent();
            // lägger till meny alternativ i Combobox
            CBRemoveProducts.Items.Add("Kött");
            CBRemoveProducts.Items.Add("Frukt och Grönt");
            CBRemoveProducts.Items.Add("Godis");
            CBRemoveProducts.Items.Add("MejeriProdukter");

           
        }
        #endregion

        #region Laddar Kategorier
        private void LoadCategory(ProductCategory category)
        {
            
            LbRemoveProducts.Items.Clear();
            // Väljer enbart namnenen ifrån produktlistan i en kategori och lägger till dessa i en listbox 
            LbRemoveProducts.Items.AddRange(category.Products.Select(prod => prod.ProductName).ToArray());
        }
        

        #endregion

        #region Event Remove Product
        private void RemoveProductBtn_Click(object sender, EventArgs e)
        {
            if (LbRemoveProducts.Items.Count > 0 && LbRemoveProducts.SelectedIndex != -1)
            {
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    switch (CBRemoveProducts.SelectedItem.ToString())
                    {
                        
                        case "Kött":
                            
                                //Tar bort första produkten med samma namn som valt produktnamn i Listboxen
                                //kan inte välja någon ifall det saknas en produkt därför används first eftersom vi vet att det alltid kommer att finnas en.
                                form1.Meat.Products.Remove(
                                form1.Meat.Products.First(Product =>
                                Product.ProductName == LbRemoveProducts?.SelectedItem?
                                .ToString()));

                            form1.LoadProductCategory(form1.Meat.Products);

                            LoadCategory(form1.Meat);
                            break;
                        
                        
                        case "Frukt och Grönt":
                            
                            form1.Greens.Products.Remove(
                                form1.Greens.Products.First(Product =>
                                Product.ProductName == LbRemoveProducts?.SelectedItem?
                                .ToString()));

                            form1.LoadProductCategory(form1.Greens.Products);

                            LoadCategory(form1.Greens);
                            break;
                        
                        
                        case "Godis":
                            
                            form1.Candy.Products.Remove(
                                form1.Candy.Products.First(Product =>
                                Product.ProductName == LbRemoveProducts?.SelectedItem?
                                .ToString()));

                            form1.LoadProductCategory(form1.Candy.Products);

                            LoadCategory(form1.Candy);
                            break;
                        
                        
                        case "MejeriProdukter":
                            
                            form1.DairyProducts.Products.Remove(
                                form1.DairyProducts.Products.First(Product =>
                                Product.ProductName == LbRemoveProducts?.SelectedItem?
                                .ToString()));

                            form1.LoadProductCategory(form1.DairyProducts.Products);

                            LoadCategory(form1.DairyProducts);
                            break;
                    }
                }

            }

        }
        #endregion

        #region Loadcategory of Products
        private void CBRemoveProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                switch (CBRemoveProducts.SelectedIndex)
                {
                    case 0:
                        LoadCategory(form1.Meat);
                        break;
                    case 1:
                        LoadCategory(form1.Greens);
                        break;
                    case 2:
                        LoadCategory(form1.Candy);
                        break;
                    case 3:
                        LoadCategory(form1.DairyProducts);
                        break;
                }
            }
        }
        #endregion
       
        #region menu Options
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void läggTillVarorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        #endregion
    }
}
