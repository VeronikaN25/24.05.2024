namespace _24._05._2024
{
    partial class Products
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameProducts = new System.Windows.Forms.Label();
            this.priceProducts = new System.Windows.Forms.Label();
            this.quantityProducts = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.textBoxNameProducts = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(453, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться к меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameProducts
            // 
            this.nameProducts.AutoSize = true;
            this.nameProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProducts.Location = new System.Drawing.Point(107, 74);
            this.nameProducts.Name = "nameProducts";
            this.nameProducts.Size = new System.Drawing.Size(231, 29);
            this.nameProducts.TabIndex = 1;
            this.nameProducts.Text = "Название продукта";
            // 
            // priceProducts
            // 
            this.priceProducts.AutoSize = true;
            this.priceProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceProducts.Location = new System.Drawing.Point(107, 128);
            this.priceProducts.Name = "priceProducts";
            this.priceProducts.Size = new System.Drawing.Size(180, 29);
            this.priceProducts.TabIndex = 2;
            this.priceProducts.Text = "Цена продукта";
            // 
            // quantityProducts
            // 
            this.quantityProducts.AutoSize = true;
            this.quantityProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityProducts.Location = new System.Drawing.Point(107, 189);
            this.quantityProducts.Name = "quantityProducts";
            this.quantityProducts.Size = new System.Drawing.Size(148, 29);
            this.quantityProducts.TabIndex = 3;
            this.quantityProducts.Text = "Количество";
            this.quantityProducts.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCost.Location = new System.Drawing.Point(322, 261);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(220, 29);
            this.labelTotalCost.TabIndex = 4;
            this.labelTotalCost.Text = "Общая стоимость";
            // 
            // textBoxNameProducts
            // 
            this.textBoxNameProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameProducts.Location = new System.Drawing.Point(378, 74);
            this.textBoxNameProducts.Name = "textBoxNameProducts";
            this.textBoxNameProducts.Size = new System.Drawing.Size(195, 34);
            this.textBoxNameProducts.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(378, 128);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 34);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.Location = new System.Drawing.Point(378, 189);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(195, 34);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(103, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Рассчитать ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNameProducts);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.quantityProducts);
            this.Controls.Add(this.priceProducts);
            this.Controls.Add(this.nameProducts);
            this.Controls.Add(this.button1);
            this.Name = "Products";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameProducts;
        private System.Windows.Forms.Label priceProducts;
        private System.Windows.Forms.Label quantityProducts;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.TextBox textBoxNameProducts;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button button2;
    }
}