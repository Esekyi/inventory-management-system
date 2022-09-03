
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
            this.catTable = new System.Windows.Forms.DataGridView();
            this.cagegoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.catTable)).BeginInit();
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
            this.catTable.Location = new System.Drawing.Point(0, 0);
            this.catTable.Name = "catTable";
            this.catTable.ReadOnly = true;
            this.catTable.RowHeadersWidth = 82;
            this.catTable.RowTemplate.Height = 41;
            this.catTable.Size = new System.Drawing.Size(1530, 955);
            this.catTable.TabIndex = 0;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.catTable);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1530, 955);
            ((System.ComponentModel.ISupportInitialize)(this.catTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView catTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagegoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    }
}
