namespace TestingDynamik
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pris = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            taBortVarorToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            CBMenyCategory = new ComboBox();
            CBCategory = new Label();
            MtbCategories = new TextBox();
            CBDiscount = new ComboBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "ProduktNamn";
            // 
            // pris
            // 
            pris.AutoSize = true;
            pris.Location = new Point(249, 46);
            pris.Name = "pris";
            pris.Size = new Size(32, 20);
            pris.TabIndex = 1;
            pris.Text = "Pris";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(875, 41);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taBortVarorToolStripMenuItem, exitToolStripMenuItem });
            optionToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(125, 24);
            optionToolStripMenuItem.Text = "Meny alternativ";
            // 
            // taBortVarorToolStripMenuItem
            // 
            taBortVarorToolStripMenuItem.Name = "taBortVarorToolStripMenuItem";
            taBortVarorToolStripMenuItem.Size = new Size(176, 26);
            taBortVarorToolStripMenuItem.Text = "Ta bort varor";
            taBortVarorToolStripMenuItem.Click += taBortVarorToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(176, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CBMenyCategory
            // 
            CBMenyCategory.FormattingEnabled = true;
            CBMenyCategory.Location = new Point(493, 42);
            CBMenyCategory.Name = "CBMenyCategory";
            CBMenyCategory.Size = new Size(151, 28);
            CBMenyCategory.TabIndex = 6;
            // 
            // CBCategory
            // 
            CBCategory.AutoSize = true;
            CBCategory.Location = new Point(418, 47);
            CBCategory.Name = "CBCategory";
            CBCategory.Size = new Size(69, 20);
            CBCategory.TabIndex = 7;
            CBCategory.Text = "Kategory";
            // 
            // MtbCategories
            // 
            MtbCategories.Location = new Point(12, 76);
            MtbCategories.Multiline = true;
            MtbCategories.Name = "MtbCategories";
            MtbCategories.ScrollBars = ScrollBars.Vertical;
            MtbCategories.Size = new Size(957, 254);
            MtbCategories.TabIndex = 8;
            // 
            // CBDiscount
            // 
            CBDiscount.FormattingEnabled = true;
            CBDiscount.Location = new Point(718, 42);
            CBDiscount.Name = "CBDiscount";
            CBDiscount.Size = new Size(151, 28);
            CBDiscount.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 46);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 10;
            label2.Text = "Rabbatt";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 340);
            Controls.Add(label2);
            Controls.Add(CBDiscount);
            Controls.Add(MtbCategories);
            Controls.Add(CBCategory);
            Controls.Add(CBMenyCategory);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pris);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label pris;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox CBMenyCategory;
        private Label CBCategory;
        private TextBox MtbCategories;
        private ComboBox CBDiscount;
        private Label label2;
        private ToolStripMenuItem taBortVarorToolStripMenuItem;
    }
}