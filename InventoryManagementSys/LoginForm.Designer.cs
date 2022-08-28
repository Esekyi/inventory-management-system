
namespace InventoryManagementSys
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginUsrname = new System.Windows.Forms.Label();
            this.LoginPwd = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsrTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginUsrname
            // 
            this.LoginUsrname.AutoSize = true;
            this.LoginUsrname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginUsrname.Location = new System.Drawing.Point(8, 17);
            this.LoginUsrname.Name = "LoginUsrname";
            this.LoginUsrname.Size = new System.Drawing.Size(136, 37);
            this.LoginUsrname.TabIndex = 0;
            this.LoginUsrname.Text = "Username";
            this.LoginUsrname.Click += new System.EventHandler(this.LoginUsrname_Click);
            // 
            // LoginPwd
            // 
            this.LoginPwd.AutoSize = true;
            this.LoginPwd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginPwd.Location = new System.Drawing.Point(8, 17);
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.Size = new System.Drawing.Size(128, 37);
            this.LoginPwd.TabIndex = 0;
            this.LoginPwd.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(400, 376);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(284, 69);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsrTxtBox
            // 
            this.UsrTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsrTxtBox.Location = new System.Drawing.Point(157, 17);
            this.UsrTxtBox.Name = "UsrTxtBox";
            this.UsrTxtBox.Size = new System.Drawing.Size(470, 36);
            this.UsrTxtBox.TabIndex = 1;
            // 
            // PassTxtbox
            // 
            this.PassTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTxtbox.Location = new System.Drawing.Point(157, 20);
            this.PassTxtbox.Name = "PassTxtbox";
            this.PassTxtbox.Size = new System.Drawing.Size(470, 36);
            this.PassTxtbox.TabIndex = 2;
            this.PassTxtbox.TextChanged += new System.EventHandler(this.PassTxtbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LoginUsrname);
            this.panel1.Controls.Add(this.UsrTxtBox);
            this.panel1.Location = new System.Drawing.Point(207, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 74);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PassTxtbox);
            this.panel2.Controls.Add(this.LoginPwd);
            this.panel2.Location = new System.Drawing.Point(207, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 82);
            this.panel2.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1126, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1152, 568);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1152, 568);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginUsrname;
        private System.Windows.Forms.Label LoginPwd;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsrTxtBox;
        private System.Windows.Forms.TextBox PassTxtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

