
namespace InventoryManagementSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.users = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchArea = new System.Windows.Forms.TextBox();
            this.prodLabel = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addProd = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.modifybtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.users);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HomeLogo);
            this.panel1.Controls.Add(this.CategoryBtn);
            this.panel1.Controls.Add(this.ProductsBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1294);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // users
            // 
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.users.FlatAppearance.BorderSize = 0;
            this.users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.users.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.users.Image = ((System.Drawing.Image)(resources.GetObject("users.Image")));
            this.users.Location = new System.Drawing.Point(1, 534);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(252, 88);
            this.users.TabIndex = 10;
            this.users.Text = "User";
            this.users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.users.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoprite";
            // 
            // HomeLogo
            // 
            this.HomeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("HomeLogo.Image")));
            this.HomeLogo.Location = new System.Drawing.Point(5, 20);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(123, 125);
            this.HomeLogo.TabIndex = 1;
            this.HomeLogo.TabStop = false;
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("CategoryBtn.Image")));
            this.CategoryBtn.Location = new System.Drawing.Point(0, 417);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(252, 88);
            this.CategoryBtn.TabIndex = 9;
            this.CategoryBtn.Text = "Categories";
            this.CategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CategoryBtn.UseVisualStyleBackColor = true;
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductsBtn.Image")));
            this.ProductsBtn.Location = new System.Drawing.Point(0, 316);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(252, 88);
            this.ProductsBtn.TabIndex = 8;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.AccessibleName = "home button";
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(0, 215);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(252, 88);
            this.HomeBtn.TabIndex = 7;
            this.HomeBtn.Text = " Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.searchbtn);
            this.panel5.Controls.Add(this.searchArea);
            this.panel5.Controls.Add(this.prodLabel);
            this.panel5.Location = new System.Drawing.Point(255, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1589, 165);
            this.panel5.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(464, 103);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(163, 39);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchArea
            // 
            this.searchArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchArea.Location = new System.Drawing.Point(83, 103);
            this.searchArea.Name = "searchArea";
            this.searchArea.Size = new System.Drawing.Size(365, 39);
            this.searchArea.TabIndex = 1;
            this.searchArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodLabel.ForeColor = System.Drawing.Color.Snow;
            this.prodLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.prodLabel.Location = new System.Drawing.Point(146, 9);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(227, 65);
            this.prodLabel.TabIndex = 0;
            this.prodLabel.Text = "Products";
            this.prodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeight = 46;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod_name,
            this.prod_price,
            this.prod_stock,
            this.prod_category,
            this.prod_code,
            this.edit});
            this.gridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView.Location = new System.Drawing.Point(338, 316);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.RowTemplate.Height = 41;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView.ShowCellToolTips = false;
            this.gridView.ShowRowErrors = false;
            this.gridView.Size = new System.Drawing.Size(1450, 935);
            this.gridView.TabIndex = 11;
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
            this.prod_price.HeaderText = "Price (GHC)";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "Action";
            this.edit.MinimumWidth = 10;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 200;
            // 
            // addProd
            // 
            this.addProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProd.ForeColor = System.Drawing.Color.White;
            this.addProd.Image = ((System.Drawing.Image)(resources.GetObject("addProd.Image")));
            this.addProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProd.Location = new System.Drawing.Point(1575, 211);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(211, 61);
            this.addProd.TabIndex = 6;
            this.addProd.Text = "New Product";
            this.addProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProd.UseVisualStyleBackColor = false;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.RoyalBlue;
            this.reload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reload.Location = new System.Drawing.Point(336, 211);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(211, 61);
            this.reload.TabIndex = 3;
            this.reload.Text = "Reload Products";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtBox.Location = new System.Drawing.Point(820, 215);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(264, 39);
            this.idTxtBox.TabIndex = 4;
            this.idTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modifybtn
            // 
            this.modifybtn.BackColor = System.Drawing.Color.DarkRed;
            this.modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifybtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.modifybtn.ForeColor = System.Drawing.Color.Transparent;
            this.modifybtn.Location = new System.Drawing.Point(1104, 211);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(138, 49);
            this.modifybtn.TabIndex = 5;
            this.modifybtn.Text = "Modify";
            this.modifybtn.UseVisualStyleBackColor = false;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(800, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please Enter Product ID to Modify Product Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1844, 1294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifybtn);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchArea;
        private System.Windows.Forms.Button addProd;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_code;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Button modifybtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}