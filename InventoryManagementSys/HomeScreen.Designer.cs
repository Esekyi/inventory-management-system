
namespace InventoryManagementSys
{
    partial class HomeScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.CategoryBtn);
            this.panel1.Controls.Add(this.ProductsBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.HomeLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 761);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.Location = new System.Drawing.Point(0, 356);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(252, 88);
            this.CategoryBtn.TabIndex = 0;
            this.CategoryBtn.Text = "Categories";
            this.CategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryBtn.UseVisualStyleBackColor = true;
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 263);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(252, 88);
            this.ProductsBtn.TabIndex = 0;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.AccessibleName = "home button";
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 170);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(252, 88);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // HomeLogo
            // 
            this.HomeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeLogo.Image = global::InventoryManagementSys.Properties.Resources.Capture;
            this.HomeLogo.Location = new System.Drawing.Point(0, 0);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(252, 124);
            this.HomeLogo.TabIndex = 1;
            this.HomeLogo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(255, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1588, 94);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod_name,
            this.prod_price,
            this.prod_stock,
            this.prod_category,
            this.prod_code,
            this.edit});
            this.dataGridView1.Location = new System.Drawing.Point(307, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1483, 498);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "Product ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // prod_name
            // 
            this.prod_name.HeaderText = "Name";
            this.prod_name.MinimumWidth = 10;
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            this.prod_name.Width = 200;
            // 
            // prod_price
            // 
            this.prod_price.HeaderText = "Price";
            this.prod_price.MinimumWidth = 10;
            this.prod_price.Name = "prod_price";
            this.prod_price.ReadOnly = true;
            this.prod_price.Width = 200;
            // 
            // prod_stock
            // 
            this.prod_stock.HeaderText = "Quantity";
            this.prod_stock.MinimumWidth = 10;
            this.prod_stock.Name = "prod_stock";
            this.prod_stock.ReadOnly = true;
            this.prod_stock.Width = 200;
            // 
            // prod_category
            // 
            this.prod_category.HeaderText = "Category";
            this.prod_category.MinimumWidth = 10;
            this.prod_category.Name = "prod_category";
            this.prod_category.ReadOnly = true;
            this.prod_category.Width = 200;
            // 
            // prod_code
            // 
            this.prod_code.HeaderText = "Barcode";
            this.prod_code.MinimumWidth = 10;
            this.prod_code.Name = "prod_code";
            this.prod_code.ReadOnly = true;
            this.prod_code.Width = 200;
            // 
            // edit
            // 
            this.edit.HeaderText = "Action";
            this.edit.MinimumWidth = 10;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Modify";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 200;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1844, 752);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "HomeScreen";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_code;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}