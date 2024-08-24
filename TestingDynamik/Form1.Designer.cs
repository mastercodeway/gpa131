namespace TestingDynamik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            BtnRemove = new Button();
            BtnLoadCategoryOne = new Button();
            BtnLoadCategory2 = new Button();
            BtnLoadCategory = new Button();
            BtnLoadCategory4 = new Button();
            menuStrip1 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            läggTillVarorToolStripMenuItem = new ToolStripMenuItem();
            taBortVarorToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            TBReceipe = new TextBox();
            Recipe = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(235, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(747, 422);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 424);
            listBox1.TabIndex = 5;
            // 
            // BtnRemove
            // 
            BtnRemove.ForeColor = Color.SlateBlue;
            BtnRemove.Location = new Point(12, 459);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(103, 51);
            BtnRemove.TabIndex = 6;
            BtnRemove.Text = "Ta bort";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnLoadCategoryOne
            // 
            BtnLoadCategoryOne.BackColor = SystemColors.ButtonHighlight;
            BtnLoadCategoryOne.BackgroundImageLayout = ImageLayout.None;
            BtnLoadCategoryOne.FlatStyle = FlatStyle.Popup;
            BtnLoadCategoryOne.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoadCategoryOne.Location = new Point(384, 31);
            BtnLoadCategoryOne.Name = "BtnLoadCategoryOne";
            BtnLoadCategoryOne.Size = new Size(143, 51);
            BtnLoadCategoryOne.TabIndex = 7;
            BtnLoadCategoryOne.Text = "Köttprodukter";
            BtnLoadCategoryOne.UseVisualStyleBackColor = false;
            BtnLoadCategoryOne.Click += BtnLoadCategoryOne_Click;
            // 
            // BtnLoadCategory2
            // 
            BtnLoadCategory2.BackColor = SystemColors.ControlLightLight;
            BtnLoadCategory2.FlatStyle = FlatStyle.Popup;
            BtnLoadCategory2.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoadCategory2.Location = new Point(533, 31);
            BtnLoadCategory2.Name = "BtnLoadCategory2";
            BtnLoadCategory2.Size = new Size(151, 51);
            BtnLoadCategory2.TabIndex = 8;
            BtnLoadCategory2.Text = "Frukt och Grönt";
            BtnLoadCategory2.UseVisualStyleBackColor = false;
            BtnLoadCategory2.Click += BtnLoadCategory2_Click;
            // 
            // BtnLoadCategory
            // 
            BtnLoadCategory.BackColor = SystemColors.ControlLightLight;
            BtnLoadCategory.FlatStyle = FlatStyle.Popup;
            BtnLoadCategory.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoadCategory.Location = new Point(690, 31);
            BtnLoadCategory.Name = "BtnLoadCategory";
            BtnLoadCategory.Size = new Size(156, 51);
            BtnLoadCategory.TabIndex = 9;
            BtnLoadCategory.Text = "MejeriProdukter";
            BtnLoadCategory.UseVisualStyleBackColor = false;
            BtnLoadCategory.Click += BtnLoadCategory_Click;
            // 
            // BtnLoadCategory4
            // 
            BtnLoadCategory4.BackColor = SystemColors.ControlLightLight;
            BtnLoadCategory4.FlatStyle = FlatStyle.Popup;
            BtnLoadCategory4.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoadCategory4.Location = new Point(852, 31);
            BtnLoadCategory4.Name = "BtnLoadCategory4";
            BtnLoadCategory4.Size = new Size(130, 51);
            BtnLoadCategory4.TabIndex = 10;
            BtnLoadCategory4.Text = "Godis";
            BtnLoadCategory4.UseVisualStyleBackColor = false;
            BtnLoadCategory4.Click += BtnLoadCategory4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1323, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { läggTillVarorToolStripMenuItem, taBortVarorToolStripMenuItem, exitToolStripMenuItem });
            optionToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(69, 24);
            optionToolStripMenuItem.Text = "Option";
            // 
            // läggTillVarorToolStripMenuItem
            // 
            läggTillVarorToolStripMenuItem.Name = "läggTillVarorToolStripMenuItem";
            läggTillVarorToolStripMenuItem.Size = new Size(224, 26);
            läggTillVarorToolStripMenuItem.Text = "Lägg till varor";
            läggTillVarorToolStripMenuItem.Click += läggTillVarorToolStripMenuItem_Click;
            // 
            // taBortVarorToolStripMenuItem
            // 
            taBortVarorToolStripMenuItem.Name = "taBortVarorToolStripMenuItem";
            taBortVarorToolStripMenuItem.Size = new Size(224, 26);
            taBortVarorToolStripMenuItem.Text = "Ta bort Varor";
            taBortVarorToolStripMenuItem.Click += taBortVarorToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(246, 46);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 15;
            label1.Text = "Produkt kategorier";
            // 
            // TBReceipe
            // 
            TBReceipe.Location = new Point(987, 31);
            TBReceipe.Margin = new Padding(2);
            TBReceipe.Multiline = true;
            TBReceipe.Name = "TBReceipe";
            TBReceipe.ScrollBars = ScrollBars.Vertical;
            TBReceipe.Size = new Size(328, 480);
            TBReceipe.TabIndex = 16;
            // 
            // Recipe
            // 
            Recipe.ForeColor = SystemColors.ActiveCaptionText;
            Recipe.Location = new Point(115, 459);
            Recipe.Name = "Recipe";
            Recipe.Size = new Size(114, 49);
            Recipe.TabIndex = 17;
            Recipe.Text = "Kvitto";
            Recipe.UseVisualStyleBackColor = true;
            Recipe.Click += Recipe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1323, 671);
            Controls.Add(Recipe);
            Controls.Add(TBReceipe);
            Controls.Add(label1);
            Controls.Add(BtnLoadCategory4);
            Controls.Add(BtnLoadCategory);
            Controls.Add(BtnLoadCategory2);
            Controls.Add(BtnLoadCategoryOne);
            Controls.Add(BtnRemove);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBox1;
        private Button BtnRemove;
        private Button BtnLoadCategoryOne;
        private Button BtnLoadCategory2;
        private Button BtnLoadCategory;
        private Button BtnLoadCategory4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem läggTillVarorToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem taBortVarorToolStripMenuItem;
        private TextBox TBReceipe;
        private Button Recipe;
    }
}