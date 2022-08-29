
namespace InventoryManagementSys
{
    partial class AttendantMain
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
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.LogsBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.BtnClose);
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Controls.Add(this.textLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1740, 87);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSys.Properties.Resources.icons8_shopify_60;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnClose.Image = global::InventoryManagementSys.Properties.Resources.icons8_close_35;
            this.BtnClose.Location = new System.Drawing.Point(1600, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(111, 80);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(763, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textLabel.Location = new System.Drawing.Point(101, 19);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(171, 50);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Shoprite";
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.White;
            this.SalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesBtn.FlatAppearance.BorderSize = 0;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalesBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_total_sales_50;
            this.SalesBtn.Location = new System.Drawing.Point(1, 1);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Padding = new System.Windows.Forms.Padding(10);
            this.SalesBtn.Size = new System.Drawing.Size(224, 81);
            this.SalesBtn.TabIndex = 1;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // LogsBtn
            // 
            this.LogsBtn.BackColor = System.Drawing.Color.White;
            this.LogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsBtn.FlatAppearance.BorderSize = 0;
            this.LogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogsBtn.Image = global::InventoryManagementSys.Properties.Resources.icons8_graph_report_50;
            this.LogsBtn.Location = new System.Drawing.Point(231, 1);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.LogsBtn.Size = new System.Drawing.Size(224, 81);
            this.LogsBtn.TabIndex = 1;
            this.LogsBtn.Text = "Logs";
            this.LogsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogsBtn.UseVisualStyleBackColor = false;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.White;
            this.btnPanel.Controls.Add(this.SalesBtn);
            this.btnPanel.Controls.Add(this.LogsBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.Location = new System.Drawing.Point(0, 87);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(1740, 82);
            this.btnPanel.TabIndex = 2;
            // 
            // hostPanel
            // 
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(0, 169);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(1740, 1030);
            this.hostPanel.TabIndex = 3;
            // 
            // AttendantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 1199);
            this.Controls.Add(this.hostPanel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendantMain";
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button LogsBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel hostPanel;
    }
}