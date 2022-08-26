
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
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HomeLogo);
            this.panel1.Location = new System.Drawing.Point(2, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 762);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HomeLogo
            // 
            this.HomeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeLogo.Image = global::InventoryManagementSys.Properties.Resources.Capture;
            this.HomeLogo.Location = new System.Drawing.Point(9, 19);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(200, 124);
            this.HomeLogo.TabIndex = 1;
            this.HomeLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Location = new System.Drawing.Point(10, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 72);
            this.panel2.TabIndex = 2;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(46, 14);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(150, 46);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(10, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 72);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(9, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 72);
            this.panel4.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 752);
            this.Controls.Add(this.panel1);
            this.Name = "HomeScreen";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.PictureBox HomeLogo;
    }
}