using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace InventoryManagementSys
{
    public partial class Login : Form
    {
        Timer t = new Timer();
        public Login()
        {
            InitializeComponent();
            errorLabel.Visible = false;
            t.Interval = 5000;
            t.Tick += T_Tick;
        }
        private void T_Tick(object sender, EventArgs e)
        {
            Timer _t = sender as Timer;
            errorLabel.Text = "";
            _t.Stop();
        }

        private void LoginUsrname_Click(object sender, EventArgs e)
        {

        }

        private void PassTxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string query = "select user_userID from `users` where user_username=@username AND user_password=@password";
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            command.Parameters.AddWithValue("@username", UsrTxtBox.Text);
            command.Parameters.AddWithValue("@password", Utilis.hashPassword(PassTxtbox.Text));
            DBConnections.openConnection();
            var result = command.ExecuteScalar();
            DBConnections.closeConnection();
            if (result != null)
            {
                if(UsrTxtBox.Text == "admin")
                {
                    // Grant Admin Priviledges!!!

                    Hide();
                    Main Admin = new Main();
                    Admin.Show();

                }
                else
                {
                    DBConnections.openConnection();
                    command.CommandText = "select `account_id`, `account_type` from `account` where `account_useID`=@userID";
                    command.Parameters.AddWithValue("@userID", result.ToString());
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int account_id = reader.GetInt32(0);
                        int account_type = reader.GetInt32(1);

                        DBConnections.closeConnection();

                        if(account_type == 0)
                        {
                            //attendant panel
                        }
                    }

                }
                //Passs
            }
            else
            {
                errorLabel.Visible = true;
                //not passed try again
                errorLabel.Text = "Wrong username or password. Try again!";
                t.Start();
            }
            UsrTxtBox.Clear();
            PassTxtbox.Clear();

        }
    }
}
