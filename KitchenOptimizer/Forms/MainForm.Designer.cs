namespace KitchenOptimizer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientToolStripMenuItem,
            this.ingredientCategoryToolStripMenuItem,
            this.mealItemToolStripMenuItem,
            this.mealToolStripMenuItem,
            this.mealCategoryToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // ingredientToolStripMenuItem
            // 
            this.ingredientToolStripMenuItem.Name = "ingredientToolStripMenuItem";
            this.ingredientToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ingredientToolStripMenuItem.Text = "Ingredient";
            this.ingredientToolStripMenuItem.Click += new System.EventHandler(this.ingredientToolStripMenuItem_Click);
            // 
            // ingredientCategoryToolStripMenuItem
            // 
            this.ingredientCategoryToolStripMenuItem.Name = "ingredientCategoryToolStripMenuItem";
            this.ingredientCategoryToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ingredientCategoryToolStripMenuItem.Text = "Ingredient Category";
            // 
            // mealItemToolStripMenuItem
            // 
            this.mealItemToolStripMenuItem.Name = "mealItemToolStripMenuItem";
            this.mealItemToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mealItemToolStripMenuItem.Text = "Meal Item";
            // 
            // mealToolStripMenuItem
            // 
            this.mealToolStripMenuItem.Name = "mealToolStripMenuItem";
            this.mealToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mealToolStripMenuItem.Text = "Meal";
            // 
            // mealCategoryToolStripMenuItem
            // 
            this.mealCategoryToolStripMenuItem.Name = "mealCategoryToolStripMenuItem";
            this.mealCategoryToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mealCategoryToolStripMenuItem.Text = "Meal Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 524);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kitchen Optimizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mealCategoryToolStripMenuItem;
    }
}

