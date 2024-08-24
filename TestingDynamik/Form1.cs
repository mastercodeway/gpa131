using System.Diagnostics;
using System.Text;
using TestingDynamik.ChoiceTypes;
using TestingDynamik.MainClasses;
using TestingDynamik.HelpMethods;
using TestingDynamik.Display;

namespace TestingDynamik
{
    public partial class Form1 : Form
    {
        #region Properties
        // skapar properties f�r nya product kategorier
        public ProductCategory Meat { get; set; }
        public ProductCategory Greens { get; set; }
        public ProductCategory Candy { get; set; }
        public ProductCategory DairyProducts { get; set; }

        // skapar propierties f�r order och en ny form f�r att ta bort varor
        public Order Order { get; set; }
        public RemoveProductForm RemoveProductForm { get; set; }
        #endregion
       
        #region Constructor Form1 
        public Form1()
        {
            InitializeComponent();
            // Skapar nya objekt av product kategorier som sedan s�tt till properties med constructor v�rlden
            Meat = new ProductCategory("K�ttprodukter", ChoiceTypes.MomsType.Livsmedel);
            Greens = new ProductCategory("Frukt och gr�nt", ChoiceTypes.MomsType.Livsmedel);
            Candy = new ProductCategory("Godis", ChoiceTypes.MomsType.Livsmedel);
            DairyProducts = new ProductCategory("Mejeriprodukter", ChoiceTypes.MomsType.Livsmedel);
            // test data 
            PopulateExampelData();
            // skapar ett nytt order objekt och remove produkt form
            Order = new Order();
            
            RemoveProductForm = new RemoveProductForm();
        }
        #endregion
        
        #region UpdateReceipe
        private void UpdateReceipeUi()
        {
            // laddar om kvitto textboxen och anv�nder try catch f�r att f�nga eventuella fel.
            try
            {
                TBReceipe.Text = string.Empty;
                StringBuilder sb = new StringBuilder();
                
                sb.Append("\t-= Rickys storhandel =-\t");
                //Date time Source: https://stackoverflow.com/questions/4097127/getting-date-or-time-only-from-a-datetime-object
                sb.AppendLine("Trollh�ttan\t\t" + DateTime.Now.ToString("yyyy-MM-dd"));
                sb.AppendLine("".PadLeft(45, '-'));
                foreach (var lineItem in Order.LineItems)
                {
                    // Skriver ut line items p� ett s�tt som simulerar ett kvitto. 
                    sb.AppendLine(OrderLineItemDisplay.MapDisplayItem(lineItem).ToString());
                    sb.AppendLine();
                }
                sb.AppendLine("".PadLeft(45, '-'));
                sb.AppendLine($"Total\t\t\t{Math.Round(Order.TotalAmount, 2)} Kr\r\n");
                sb.AppendLine("Moms%\tMoms\tNetto\tBrutto");
                sb.AppendLine($"{(int)MomsType.Livsmedel}\t{Math.Round(Order.TotalMoms, 2)}\t{Math.Round(Order.TotalNet, 2)}\t{Math.Round(Order.TotalAmount, 2)}");
                TBReceipe.Text = sb.ToString();
                sb.Clear();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        
        #region Loading Category 

        /// <summary>
        /// Tar bort alla knappar fr�n flowlayoutpanel. Tar en list produkter och skapar knappar
        /// dessa och l�gger de i en list med button objekt. D�r efter l�gger till eventhandler 
        /// F�r till knapparna f�r att de ska kunna anv�ndas och l�gger sedan till knappar i layoutpanel
        /// </summary>
        /// <param name="products"></param>
        public void LoadProductCategory(List<Product> products)
        {
            flowLayoutPanel1.Controls.Clear();

            List<Button> buttons = products.MapToButtons();

            for (int i = 0; i < buttons.Count; i++)
            {
                int buttonIndex = i; // eftersom event triggas i efterhand beh�vs denna

                // L�gger till metoden productOnClickBehaviour som eventhandler f�r onClick eventet f�r knappen
                buttons[i].Click += (senderBtn, eArgs) =>
                {
                    productOnClickBehaviour(senderBtn, eArgs, products[buttonIndex]);
                };
                // L�gger till knapp objektet i flowlayoutpanelen. 
                flowLayoutPanel1.Controls.Add(buttons[i]);
            }


        }
        private void BtnLoadCategoryOne_Click(object sender, EventArgs e)
        {
            LoadProductCategory(Meat.Products);

        }

        private void BtnLoadCategory2_Click(object sender, EventArgs e)
        {
            LoadProductCategory(Greens.Products);

        }

        private void BtnLoadCategory4_Click(object sender, EventArgs e)
        {
            LoadProductCategory(Candy.Products);

        }

        private void BtnLoadCategory_Click(object sender, EventArgs e)
        {

            LoadProductCategory(DairyProducts.Products);

        }
        #endregion
       

        #region Menu Option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        public void taBortVarorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProductForm removeProductForm = new RemoveProductForm();
            removeProductForm.Show();
        }
        
        private void l�ggTillVarorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
        #endregion
       
        #region Events
        // Ett event betende som s�tts till alla skapade dynamiska knappar.
        public void productOnClickBehaviour(object sender, EventArgs e, Product product)
        {
            listBox1.Items.Add(product.ProductName);

            //ifall det finns en OrderLineItem med r�tt produktnamn plussa kvantitet annars skapa en ny lineitem.
            //Vi anv�nder FirstOrDefault ist�llet f�r first linq f�r att inte f� exception n�r det inte finns n�gon matchning-
            OrderLineItem lineItem = Order.LineItems.FirstOrDefault(item => item.Product.ProductName == product.ProductName);

            if (lineItem != default)
            {
                lineItem.Quantity++;
            }
            else
            {
                Order.LineItems.Add(new OrderLineItem(1, product));
            }
            Order.CalculateOrderTotal();

            UpdateReceipeUi();

        }

        // Raderar vara fr�n order och r�knar om totalsumman och updaterar kvittot efter
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex != -1)
            {
                var productName = listBox1?.SelectedItem?.ToString();
                listBox1?.Items.RemoveAt(listBox1.SelectedIndex);
                if (!string.IsNullOrEmpty(productName))
                {
                    int foundIndex = -1;

                    for (int i = 0; i < Order.LineItems.Count(); i++)
                    {
                        if (Order.LineItems[i].Product.ProductName == productName)
                        {
                            foundIndex = i;
                        }
                    }

                    if (foundIndex == -1) return;

                    if (Order.LineItems[foundIndex].Quantity <= 1) Order.LineItems.RemoveAt(foundIndex);
                    else Order.LineItems[foundIndex].Quantity--;
                }
                Order.CalculateOrderTotal();
                UpdateReceipeUi();

            }
        }

        /*Anv�nder array f�r att lagra str�ngarna fr�n textboxen f�r kvittot
         Str�ngarna skapas genom att splita str�ngen f�r varje rad bryt och */
       
        private void Recipe_Click(object sender, EventArgs e)
        {
            
            string[] receipt = TBReceipe.Text.Split("\r");
            string filePath = FileHandler.Setup("Receipts", "kvitto");
            bool saveSuccesful = filePath.PrintToFile(receipt);

            if (saveSuccesful)
            {
                TBReceipe.Text = $"Kvittot sparat till: {filePath}";
            }
            else
            {
                Debug.WriteLine("Something went wrong");
            }
            listBox1.Items.Clear();
            Order = new Order();
        }
        #endregion

        #region Test data
        private void PopulateExampelData()
        {
            Meat.Products.AddRange(new List<Product>
            {
                new Product(Meat, "Fl�skfile", 100, DiscountType.Small),
                new Product(Meat, "K�ttbullar", 50, DiscountType.Medium),
                new Product(Meat, "Falukorv", 30, DiscountType.None),
                new Product(Meat, "Julskinka", 60, DiscountType.Small),
                new Product(Meat, "PrinsKorv", 80, DiscountType.None),
            });
            Greens.Products.AddRange(new List<Product>
            {
                new Product(Greens, "Banan", 100, DiscountType.Small),
                new Product(Greens, "Tomat", 50, DiscountType.Medium),
                new Product(Greens, "Gurka", 30, DiscountType.Large),
                new Product(Greens, "Kiwi", 60, DiscountType.Small),
                new Product(Greens, "Citron", 80, DiscountType.None),
            });
            Candy.Products.AddRange(new List<Product>
            {
                new Product(Candy, "Choklad", 20, DiscountType.Small),
                new Product(Candy, "Polkagris", 15, DiscountType.Medium),
                new Product(Candy, "Lakrits", 2, DiscountType.Large),
                new Product(Candy, "Sega r�ttor",8, DiscountType.Small),
                new Product(Candy, "Nappar", 10, DiscountType.None),
            });
            DairyProducts.Products.AddRange(new List<Product>
            {
                new Product(DairyProducts, "Pucko", 20, DiscountType.Small),
                new Product(DairyProducts, "Sm�r", 50, DiscountType.Medium),
                new Product(DairyProducts, "Gr�dde", 30, DiscountType.Large),
                new Product(DairyProducts, "Mj�lk", 60, DiscountType.Small),
                new Product(DairyProducts, "Yoghurt", 80, DiscountType.None),
            });

            #endregion
        }
    }
}