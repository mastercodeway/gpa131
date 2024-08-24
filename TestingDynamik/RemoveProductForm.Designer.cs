namespace TestingDynamik
{
    partial class RemoveProductForm
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
            LbRemoveProducts = new ListBox();
            menuStrip1 = new MenuStrip();
            alternativToolStripMenuItem = new ToolStripMenuItem();
            läggTillVarorToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            RemoveProductBtn = new Button();
            CBRemoveProducts = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LbRemoveProducts
            // 
            LbRemoveProducts.FormattingEnabled = true;
            LbRemoveProducts.ItemHeight = 20;
            LbRemoveProducts.Location = new Point(12, 58);
            LbRemoveProducts.Name = "LbRemoveProducts";
            LbRemoveProducts.Size = new Size(416, 504);
            LbRemoveProducts.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alternativToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1154, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // alternativToolStripMenuItem
            // 
            alternativToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { läggTillVarorToolStripMenuItem, exitToolStripMenuItem });
            alternativToolStripMenuItem.Name = "alternativToolStripMenuItem";
            alternativToolStripMenuItem.Size = new Size(125, 24);
            alternativToolStripMenuItem.Text = "Meny alternativ";
            // 
            // läggTillVarorToolStripMenuItem
            // 
            läggTillVarorToolStripMenuItem.Name = "läggTillVarorToolStripMenuItem";
            läggTillVarorToolStripMenuItem.Size = new Size(224, 26);
            läggTillVarorToolStripMenuItem.Text = "Lägg till varor";
            läggTillVarorToolStripMenuItem.Click += läggTillVarorToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // RemoveProductBtn
            // 
            RemoveProductBtn.Location = new Point(434, 127);
            RemoveProductBtn.Name = "RemoveProductBtn";
            RemoveProductBtn.Size = new Size(94, 29);
            RemoveProductBtn.TabIndex = 2;
            RemoveProductBtn.Text = "Ta bort";
            RemoveProductBtn.UseVisualStyleBackColor = true;
            RemoveProductBtn.Click += RemoveProductBtn_Click;
            // 
            // CBRemoveProducts
            // 
            CBRemoveProducts.FormattingEnabled = true;
            CBRemoveProducts.Location = new Point(434, 93);
            CBRemoveProducts.Name = "CBRemoveProducts";
            CBRemoveProducts.Size = new Size(151, 28);
            CBRemoveProducts.TabIndex = 3;
            CBRemoveProducts.SelectedIndexChanged += CBRemoveProducts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 58);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Categories";
            // 
            // RemoveProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 581);
            Controls.Add(label1);
            Controls.Add(CBRemoveProducts);
            Controls.Add(RemoveProductBtn);
            Controls.Add(LbRemoveProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RemoveProductForm";
            Text = "RemoveProductForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbRemoveProducts;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alternativToolStripMenuItem;
        private ToolStripMenuItem läggTillVarorToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button RemoveProductBtn;
        private ComboBox CBRemoveProducts;
        private Label label1;
    }
}