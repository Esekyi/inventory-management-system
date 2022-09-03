
namespace InventoryManagementSys
{
    partial class Dashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.inventoryDash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryDash
            // 
            this.inventoryDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDash.BackColor = System.Drawing.Color.SkyBlue;
            this.inventoryDash.Controls.Add(this.label3);
            this.inventoryDash.Controls.Add(this.label1);
            this.inventoryDash.Controls.Add(this.button1);
            this.inventoryDash.Location = new System.Drawing.Point(0, 0);
            this.inventoryDash.Name = "inventoryDash";
            this.inventoryDash.Size = new System.Drawing.Size(751, 296);
            this.inventoryDash.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(516, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 128);
            this.label3.TabIndex = 2;
            this.label3.Text = "290";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 85);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(778, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 296);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(516, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 128);
            this.label4.TabIndex = 2;
            this.label4.Text = "290";
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
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.White;
            this.chart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chart.Location = new System.Drawing.Point(-1, 347);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1530, 825);
            this.chart.TabIndex = 1;
            this.chart.Text = "Sales Chart";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inventoryDash);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1530, 1177);
            this.inventoryDash.ResumeLayout(false);
            this.inventoryDash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inventoryDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private LiveCharts.WinForms.CartesianChart chart;
    }
}
