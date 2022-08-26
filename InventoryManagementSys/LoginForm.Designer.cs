
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
            this.LoginUsrname.Location = new System.Drawing.Point(7, 15);
            this.LoginUsrname.Name = "LoginUsrname";
            this.LoginUsrname.Size = new System.Drawing.Size(121, 32);
            this.LoginUsrname.TabIndex = 0;
            this.LoginUsrname.Text = "Username";
            this.LoginUsrname.Click += new System.EventHandler(this.LoginUsrname_Click);
            // 
            // LoginPwd
            // 
            this.LoginPwd.AutoSize = true;
            this.LoginPwd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginPwd.Location = new System.Drawing.Point(7, 15);
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.Size = new System.Drawing.Size(111, 32);
            this.LoginPwd.TabIndex = 0;
            this.LoginPwd.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(398, 306);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 46);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // UsrTxtBox
            // 
            this.UsrTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsrTxtBox.Location = new System.Drawing.Point(136, 15);
            this.UsrTxtBox.Name = "UsrTxtBox";
            this.UsrTxtBox.Size = new System.Drawing.Size(407, 32);
            this.UsrTxtBox.TabIndex = 2;
            // 
            // PassTxtbox
            // 
            this.PassTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTxtbox.Location = new System.Drawing.Point(136, 17);
            this.PassTxtbox.Name = "PassTxtbox";
            this.PassTxtbox.Size = new System.Drawing.Size(407, 32);
            this.PassTxtbox.TabIndex = 2;
            this.PassTxtbox.TextChanged += new System.EventHandler(this.PassTxtbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LoginUsrname);
            this.panel1.Controls.Add(this.UsrTxtBox);
            this.panel1.Location = new System.Drawing.Point(179, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 64);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PassTxtbox);
            this.panel2.Controls.Add(this.LoginPwd);
            this.panel2.Location = new System.Drawing.Point(179, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 71);
            this.panel2.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(976, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1002, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1002, 501);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
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

