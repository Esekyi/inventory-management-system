
namespace InventoryManagementSys
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.hr = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.TillSale = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.prodLabel = new System.Windows.Forms.Label();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.sidePanel.Controls.Add(this.hr);
            this.sidePanel.Controls.Add(this.Logout);
            this.sidePanel.Controls.Add(this.HomeLogo);
            this.sidePanel.Controls.Add(this.TillSale);
            this.sidePanel.Controls.Add(this.users);
            this.sidePanel.Controls.Add(this.CategoryBtn);
            this.sidePanel.Controls.Add(this.ProductsBtn);
            this.sidePanel.Controls.Add(this.DashboardBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(255, 1559);
            this.sidePanel.TabIndex = 0;
            // 
            // hr
            // 
            this.hr.BackColor = System.Drawing.Color.White;
            this.hr.Location = new System.Drawing.Point(0, 164);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(255, 3);
            this.hr.TabIndex = 12;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Navy;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Image = global::InventoryManagementSys.Properties.Resources.icons8_logout_64;
            this.Logout.Location = new System.Drawing.Point(0, 1455);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(255, 104);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Logout";
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // HomeLogo
            // 
            this.HomeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeLogo.Image = global::InventoryManagementSys.Properties.Resources.icons8_shopify_120;
            this.HomeLogo.Location = new System.Drawing.Point(12, 21);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(98, 103);
            this.HomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeLogo.TabIndex = 1;
            this.HomeLogo.TabStop = false;
            // 
            // TillSale
            // 
            this.TillSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TillSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TillSale.FlatAppearance.BorderSize = 0;
            this.TillSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TillSale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TillSale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TillSale.Image = global::InventoryManagementSys.Properties.Resources.icons8_sale_28;
            this.TillSale.Location = new System.Drawing.Point(0, 707);
            this.TillSale.Name = "TillSale";
            this.TillSale.Size = new System.Drawing.Size(252, 104);
            this.TillSale.TabIndex = 10;
            this.TillSale.Text = "Sale/Till";
            this.TillSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TillSale.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.users.FlatAppearance.BorderSize = 0;
            this.users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.users.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.users.Image = global::InventoryManagementSys.Properties.Resources.icons8_users_30;
            this.users.Location = new System.Drawing.Point(0, 843);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(252, 104);
            this.users.TabIndex = 10;
            this.users.Text = "User";
            this.users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_supply_chain_28;
            this.CategoryBtn.Location = new System.Drawing.Point(0, 568);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(252, 107);
            this.CategoryBtn.TabIndex = 9;
            this.CategoryBtn.Text = "Categories";
            this.CategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CategoryBtn.UseVisualStyleBackColor = true;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_new_product_28;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 429);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(252, 107);
            this.ProductsBtn.TabIndex = 8;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AccessibleName = "home button";
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DashboardBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_home_28;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 290);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(252, 107);
            this.DashboardBtn.TabIndex = 7;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel5.Controls.Add(this.btnLogo);
            this.panel5.Controls.Add(this.prodLabel);
            this.panel5.Location = new System.Drawing.Point(281, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1535, 165);
            this.panel5.TabIndex = 1;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(43, 39);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(50, 40);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 3;
            this.btnLogo.TabStop = false;
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodLabel.ForeColor = System.Drawing.Color.Snow;
            this.prodLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.prodLabel.Location = new System.Drawing.Point(98, 21);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(227, 65);
            this.prodLabel.TabIndex = 0;
            this.prodLabel.Text = "Products";
            this.prodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHolder
            // 
            this.panelHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHolder.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHolder.Location = new System.Drawing.Point(286, 234);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1530, 1202);
            this.panelHolder.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1844, 1559);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.sidePanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel hr;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Button TillSale;
        private System.Windows.Forms.Button Logout;
    }
}