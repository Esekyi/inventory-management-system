
namespace InventoryManagementSys
{
    partial class DashboardPage
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
            this.inventoryDash = new System.Windows.Forms.Panel();
            this.productAvailable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsAvailBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chartName = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventoryDash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryDash
            // 
            this.inventoryDash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDash.BackColor = System.Drawing.Color.SkyBlue;
            this.inventoryDash.Controls.Add(this.productAvailable);
            this.inventoryDash.Controls.Add(this.label1);
            this.inventoryDash.Controls.Add(this.productsAvailBtn);
            this.inventoryDash.Location = new System.Drawing.Point(0, 0);
            this.inventoryDash.Name = "inventoryDash";
            this.inventoryDash.Size = new System.Drawing.Size(754, 300);
            this.inventoryDash.TabIndex = 0;
            // 
            // productAvailable
            // 
            this.productAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productAvailable.AutoEllipsis = true;
            this.productAvailable.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productAvailable.Location = new System.Drawing.Point(251, 167);
            this.productAvailable.MaximumSize = new System.Drawing.Size(500, 128);
            this.productAvailable.Name = "productAvailable";
            this.productAvailable.Size = new System.Drawing.Size(500, 128);
            this.productAvailable.TabIndex = 2;
            this.productAvailable.Text = "290";
            this.productAvailable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(126, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products Available";
            // 
            // productsAvailBtn
            // 
            this.productsAvailBtn.FlatAppearance.BorderSize = 0;
            this.productsAvailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsAvailBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_purchase_581;
            this.productsAvailBtn.Location = new System.Drawing.Point(39, 20);
            this.productsAvailBtn.Name = "productsAvailBtn";
            this.productsAvailBtn.Size = new System.Drawing.Size(81, 85);
            this.productsAvailBtn.TabIndex = 0;
            this.productsAvailBtn.UseVisualStyleBackColor = true;
            this.productsAvailBtn.Click += new System.EventHandler(this.productsAvailBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(779, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 300);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(249, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 128);
            this.label4.TabIndex = 2;
            this.label4.Text = "290";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(126, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Products Available";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 85);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chartName
            // 
            this.chartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartName.BackColor = System.Drawing.Color.White;
            this.chartName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartName.Location = new System.Drawing.Point(0, 334);
            this.chartName.Name = "chartName";
            this.chartName.Size = new System.Drawing.Size(1530, 856);
            this.chartName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.inventoryDash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 300);
            this.panel1.TabIndex = 3;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.chartName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardPage";
            this.Size = new System.Drawing.Size(1530, 1182);
            this.inventoryDash.ResumeLayout(false);
            this.inventoryDash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inventoryDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productsAvailBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private LiveCharts.WinForms.CartesianChart chartName;
        private System.Windows.Forms.Label productAvailable;
        private System.Windows.Forms.Panel panel1;
    }
}
