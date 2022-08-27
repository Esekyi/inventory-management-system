
namespace InventoryManagementSys
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.catTable = new System.Windows.Forms.DataGridView();
            this.cagegoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewCat = new System.Windows.Forms.Button();
            this.addProdTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prodName = new System.Windows.Forms.Label();
            this.prodTxtBox = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.Button();
            this.enterIDLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catTable
            // 
            this.catTable.AllowUserToAddRows = false;
            this.catTable.AllowUserToDeleteRows = false;
            this.catTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cagegoryID,
            this.categoryName});
            this.catTable.Location = new System.Drawing.Point(0, 309);
            this.catTable.Margin = new System.Windows.Forms.Padding(5);
            this.catTable.Name = "catTable";
            this.catTable.ReadOnly = true;
            this.catTable.RowHeadersWidth = 82;
            this.catTable.RowTemplate.Height = 41;
            this.catTable.Size = new System.Drawing.Size(1530, 887);
            this.catTable.TabIndex = 0;
            this.catTable.Tag = "";
            // 
            // cagegoryID
            // 
            this.cagegoryID.HeaderText = "Category ID";
            this.cagegoryID.MinimumWidth = 10;
            this.cagegoryID.Name = "cagegoryID";
            this.cagegoryID.ReadOnly = true;
            this.cagegoryID.Width = 200;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.MinimumWidth = 10;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 200;
            // 
            // addNewCat
            // 
            this.addNewCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addNewCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewCat.ForeColor = System.Drawing.Color.White;
            this.addNewCat.Image = ((System.Drawing.Image)(resources.GetObject("addNewCat.Image")));
            this.addNewCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewCat.Location = new System.Drawing.Point(11, 215);
            this.addNewCat.Name = "addNewCat";
            this.addNewCat.Size = new System.Drawing.Size(211, 61);
            this.addNewCat.TabIndex = 21;
            this.addNewCat.Text = "Add Category";
            this.addNewCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewCat.UseVisualStyleBackColor = false;
            this.addNewCat.Click += new System.EventHandler(this.addNewCat_Click);
            // 
            // addProdTxt
            // 
            this.addProdTxt.AutoSize = true;
            this.addProdTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.addProdTxt.Location = new System.Drawing.Point(8, 45);
            this.addProdTxt.Name = "addProdTxt";
            this.addProdTxt.Size = new System.Drawing.Size(254, 50);
            this.addProdTxt.TabIndex = 23;
            this.addProdTxt.Text = "Add Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prodTxtBox);
            this.panel1.Location = new System.Drawing.Point(11, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 74);
            this.panel1.TabIndex = 22;
            // 
            // prodName
            // 
            this.prodName.AutoSize = true;
            this.prodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.prodName.Location = new System.Drawing.Point(8, 17);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(193, 32);
            this.prodName.TabIndex = 0;
            this.prodName.Text = "Category Name: ";
            // 
            // prodTxtBox
            // 
            this.prodTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodTxtBox.Location = new System.Drawing.Point(216, 20);
            this.prodTxtBox.Name = "prodTxtBox";
            this.prodTxtBox.Size = new System.Drawing.Size(337, 32);
            this.prodTxtBox.TabIndex = 0;
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reload.BackColor = System.Drawing.Color.RoyalBlue;
            this.reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reload.Location = new System.Drawing.Point(1351, 229);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(176, 47);
            this.reload.TabIndex = 24;
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
            this.enterIDLabel.Location = new System.Drawing.Point(796, 170);
            this.enterIDLabel.Name = "enterIDLabel";
            this.enterIDLabel.Size = new System.Drawing.Size(397, 28);
            this.enterIDLabel.TabIndex = 27;
            this.enterIDLabel.Text = "Please Enter Category ID to Delete Category";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.DarkRed;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(1071, 125);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 39);
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTxtBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxtBox.Location = new System.Drawing.Point(802, 125);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PlaceholderText = "Category ID";
            this.idTxtBox.Size = new System.Drawing.Size(264, 39);
            this.idTxtBox.TabIndex = 25;
            this.idTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(812, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "Delete Category";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.enterIDLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.addNewCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProdTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.catTable);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(1530, 1197);
            ((System.ComponentModel.ISupportInitialize)(this.catTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagegoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.Button addNewCat;
        private System.Windows.Forms.Label addProdTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prodName;
        private System.Windows.Forms.TextBox prodTxtBox;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label enterIDLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label1;
    }
}
