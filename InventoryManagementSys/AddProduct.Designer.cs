
namespace InventoryManagementSys
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.addNewProd = new System.Windows.Forms.Button();
            this.addProdTxt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.categorylabel = new System.Windows.Forms.Label();
            this.categorySelctBox = new System.Windows.Forms.ComboBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barcode = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prodName = new System.Windows.Forms.Label();
            this.prodTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reoderTxtbox = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewProd
            // 
            this.addNewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewProd.ForeColor = System.Drawing.Color.White;
            this.addNewProd.Image = ((System.Drawing.Image)(resources.GetObject("addNewProd.Image")));
            this.addNewProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewProd.Location = new System.Drawing.Point(376, 677);
            this.addNewProd.Name = "addNewProd";
            this.addNewProd.Size = new System.Drawing.Size(211, 61);
            this.addNewProd.TabIndex = 5;
            this.addNewProd.Text = "Add Product";
            this.addNewProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewProd.UseVisualStyleBackColor = false;
            this.addNewProd.Click += new System.EventHandler(this.addNewProd_Click);
            // 
            // addProdTxt
            // 
            this.addProdTxt.AutoSize = true;
            this.addProdTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addProdTxt.Location = new System.Drawing.Point(445, 48);
            this.addProdTxt.Name = "addProdTxt";
            this.addProdTxt.Size = new System.Drawing.Size(319, 50);
            this.addProdTxt.TabIndex = 12;
            this.addProdTxt.Text = "Add New Product";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.categorylabel);
            this.panel5.Controls.Add(this.categorySelctBox);
            this.panel5.Controls.Add(this.catLabel);
            this.panel5.Location = new System.Drawing.Point(303, 554);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(659, 74);
            this.panel5.TabIndex = 7;
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.categorylabel.Location = new System.Drawing.Point(14, 20);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(122, 32);
            this.categorylabel.TabIndex = 2;
            this.categorylabel.Text = "Category: ";
            // 
            // categorySelctBox
            // 
            this.categorySelctBox.FormattingEnabled = true;
            this.categorySelctBox.Location = new System.Drawing.Point(142, 17);
            this.categorySelctBox.Name = "categorySelctBox";
            this.categorySelctBox.Size = new System.Drawing.Size(501, 40);
            this.categorySelctBox.TabIndex = 4;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.catLabel.Location = new System.Drawing.Point(8, 17);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(0, 32);
            this.catLabel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.barcode);
            this.panel3.Controls.Add(this.barcodeTxtBox);
            this.panel3.Location = new System.Drawing.Point(303, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 74);
            this.panel3.TabIndex = 8;
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.barcode.Location = new System.Drawing.Point(8, 17);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(112, 32);
            this.barcode.TabIndex = 0;
            this.barcode.Text = "Barcode: ";
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcodeTxtBox.Location = new System.Drawing.Point(124, 20);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.PlaceholderText = "Barcode";
            this.barcodeTxtBox.Size = new System.Drawing.Size(518, 32);
            this.barcodeTxtBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.qtyLabel);
            this.panel4.Controls.Add(this.qtyTxtBox);
            this.panel4.Location = new System.Drawing.Point(654, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 74);
            this.panel4.TabIndex = 9;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.qtyLabel.Location = new System.Drawing.Point(8, 17);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(76, 32);
            this.qtyLabel.TabIndex = 0;
            this.qtyLabel.Text = "Stock:";
            // 
            // qtyTxtBox
            // 
            this.qtyTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qtyTxtBox.Location = new System.Drawing.Point(90, 19);
            this.qtyTxtBox.Name = "qtyTxtBox";
            this.qtyTxtBox.PlaceholderText = "Quantity";
            this.qtyTxtBox.Size = new System.Drawing.Size(198, 32);
            this.qtyTxtBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.priceLabel);
            this.panel2.Controls.Add(this.priceTxtBox);
            this.panel2.Location = new System.Drawing.Point(303, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 74);
            this.panel2.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.priceLabel.Location = new System.Drawing.Point(8, 17);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(77, 32);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price: ";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTxtBox.Location = new System.Drawing.Point(91, 18);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.PlaceholderText = "price";
            this.priceTxtBox.Size = new System.Drawing.Size(156, 32);
            this.priceTxtBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prodTxtBox);
            this.panel1.Location = new System.Drawing.Point(303, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 74);
            this.panel1.TabIndex = 11;
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.prodName.Location = new System.Drawing.Point(8, 17);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(179, 32);
            this.prodName.TabIndex = 0;
            this.prodName.Text = "Product Name: ";
            // 
            // prodTxtBox
            // 
            this.prodTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodTxtBox.Location = new System.Drawing.Point(192, 19);
            this.prodTxtBox.Name = "prodTxtBox";
            this.prodTxtBox.PlaceholderText = "Name";
            this.prodTxtBox.Size = new System.Drawing.Size(444, 32);
            this.prodTxtBox.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Maroon;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(688, 677);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(211, 61);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.reoderTxtbox);
            this.panel6.Location = new System.Drawing.Point(303, 344);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(659, 74);
            this.panel6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reorder Level: ";
            // 
            // reoderTxtbox
            // 
            this.reoderTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reoderTxtbox.Location = new System.Drawing.Point(185, 18);
            this.reoderTxtbox.Name = "reoderTxtbox";
            this.reoderTxtbox.PlaceholderText = "Reoder Level";
            this.reoderTxtbox.Size = new System.Drawing.Size(451, 32);
            this.reoderTxtbox.TabIndex = 1;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addNewProd);
            this.Controls.Add(this.addProdTxt);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewProd;
        private System.Windows.Forms.Label addProdTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox categorySelctBox;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox qtyTxtBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.TextBox prodTxtBox;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reoderTxtbox;
    }
}