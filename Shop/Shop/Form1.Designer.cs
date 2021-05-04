
namespace Shop
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPriceUAH = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 20;
            this.lbProducts.Location = new System.Drawing.Point(13, 13);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(575, 404);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(594, 51);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(193, 77);
            this.btnEditSelected.TabIndex = 1;
            this.btnEditSelected.Text = "Edit";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(113, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 404);
            this.listBox1.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(595, 304);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(193, 77);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add ";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblAmount);
            this.panel.Controls.Add(this.lblDescription);
            this.panel.Controls.Add(this.lblPriceUAH);
            this.panel.Controls.Add(this.lblNameProduct);
            this.panel.Controls.Add(this.pbImageProduct);
            this.panel.Location = new System.Drawing.Point(822, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(564, 404);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.CausesValidation = false;
            this.lblAmount.Location = new System.Drawing.Point(16, 306);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 20);
            this.lblAmount.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(235, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 23);
            this.lblDescription.TabIndex = 8;
            // 
            // lblPriceUAH
            // 
            this.lblPriceUAH.AutoSize = true;
            this.lblPriceUAH.Location = new System.Drawing.Point(16, 263);
            this.lblPriceUAH.Name = "lblPriceUAH";
            this.lblPriceUAH.Size = new System.Drawing.Size(0, 20);
            this.lblPriceUAH.TabIndex = 6;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameProduct.Location = new System.Drawing.Point(235, 17);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(0, 41);
            this.lblNameProduct.TabIndex = 7;
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.Location = new System.Drawing.Point(16, 17);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(185, 223);
            this.pbImageProduct.TabIndex = 0;
            this.pbImageProduct.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddProduct;
        protected internal System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPriceUAH;
        private System.Windows.Forms.PictureBox pbImageProduct;
        private System.Windows.Forms.Label lblAmount;
    }
}

