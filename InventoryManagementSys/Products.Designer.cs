
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchArea = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.Button();
            this.enterIDLabel = new System.Windows.Forms.Label();
            this.modifybtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.addProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.prod_category,
            this.prod_code,
            this.prod_stock,
            this.stockStatus});
            this.gridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView.GridColor = System.Drawing.SystemColors.GrayText;
            this.gridView.Location = new System.Drawing.Point(0, 113);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.RowTemplate.Height = 41;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView.ShowCellToolTips = false;
            this.gridView.ShowRowErrors = false;
            this.gridView.Size = new System.Drawing.Size(1530, 1000);
            this.gridView.TabIndex = 13;
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
            // prod_stock
            // 
            this.prod_stock.HeaderText = "Stock";
            this.prod_stock.MinimumWidth = 10;
            this.prod_stock.Name = "prod_stock";
            this.prod_stock.ReadOnly = true;
            this.prod_stock.Width = 200;
            // 
            // stockStatus
            // 
            this.stockStatus.HeaderText = "Stock Status";
            this.stockStatus.MinimumWidth = 10;
            this.stockStatus.Name = "stockStatus";
            this.stockStatus.ReadOnly = true;
            this.stockStatus.Width = 200;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.Location = new System.Drawing.Point(331, 23);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(163, 43);
            this.searchbtn.TabIndex = 17;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchArea
            // 
            this.searchArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchArea.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchArea.Location = new System.Drawing.Point(1, 23);
            this.searchArea.Name = "searchArea";
            this.searchArea.PlaceholderText = "Search";
            this.searchArea.Size = new System.Drawing.Size(327, 43);
            this.searchArea.TabIndex = 16;
            this.searchArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reload.BackColor = System.Drawing.Color.RoyalBlue;
            this.reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reload.Location = new System.Drawing.Point(1327, 19);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(176, 47);
            this.reload.TabIndex = 18;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // enterIDLabel
            // 
            this.enterIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterIDLabel.AutoSize = true;
            this.enterIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterIDLabel.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel);
            this.enterIDLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.enterIDLabel.Location = new System.Drawing.Point(656, 59);
            this.enterIDLabel.Name = "enterIDLabel";
            this.enterIDLabel.Size = new System.Drawing.Size(442, 28);
            this.enterIDLabel.TabIndex = 21;
            this.enterIDLabel.Text = "Please Enter Product ID to Modify Product Details";
            // 
            // modifybtn
            // 
            this.modifybtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifybtn.BackColor = System.Drawing.Color.DarkRed;
            this.modifybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifybtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.modifybtn.ForeColor = System.Drawing.Color.Transparent;
            this.modifybtn.Location = new System.Drawing.Point(931, 19);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(138, 39);
            this.modifybtn.TabIndex = 20;
            this.modifybtn.Text = "Modify";
            this.modifybtn.UseVisualStyleBackColor = false;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTxtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtBox.Location = new System.Drawing.Point(662, 19);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PlaceholderText = "Product ID";
            this.idTxtBox.Size = new System.Drawing.Size(264, 39);
            this.idTxtBox.TabIndex = 19;
            this.idTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addProd
            // 
            this.addProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProd.ForeColor = System.Drawing.Color.White;
            this.addProd.Image = global::InventoryManagementSys.Properties.Resources.icons8_add_32;
            this.addProd.Location = new System.Drawing.Point(1292, 1127);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(211, 52);
            this.addProd.TabIndex = 22;
            this.addProd.Text = "New Product";
            this.addProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProd.UseVisualStyleBackColor = false;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.enterIDLabel);
            this.Controls.Add(this.modifybtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchArea);
            this.Controls.Add(this.gridView);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1530, 1202);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchArea;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label enterIDLabel;
        private System.Windows.Forms.Button modifybtn;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Button addProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockStatus;
    }
}
