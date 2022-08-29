using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class Users : UserControl
    {
        Timer t = new Timer();
        public Users()
        {
            InitializeComponent();
            AccoutypeCombo();
            AccountFlash.Visible = false;
            t.Interval = 3000;
            t.Tick += T_Tick;
            AccountID.Enabled = false;
            UsernameDisplay.Enabled = false;
            AccName.Enabled = false;
            AccountType.Enabled = false;
            DateOfBirth.Enabled = false;

        }

        private void T_Tick(object sender, EventArgs e)
        {
            Timer _t = sender as Timer;
            AccountFlash.Text = "";
            resetLabel.Text = "";
            _t.Stop();
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Users"))
            {
                Users usersPage = new Users();
                usersPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(usersPage);
            }
            Main.Instance.PanelHolder.Controls["Users"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
        }

        private void UpdateUsersList(string query)
        {
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            DBConnections.openConnection();
            command.CommandText = "select `account_id`, `account_name`, `account_type` from `account` where `account_type` = 0 AND `account_name` like @query ORDER BY `account_type`";
            command.Parameters.AddWithValue("@query", query + "%");

            MySqlDataReader reader = command.ExecuteReader();
            DetailsBox.Items.Clear();
            while (reader.Read())
                DetailsBox.Items.Add(new Account(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

            DBConnections.closeConnection();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            UpdateUsersList("");
        }

        private void FindNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUsersList(FindNameTxtBox.Text);
        }

        private void DetailsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int account_id;
            try
            {
                account_id = ((Account)DetailsBox.SelectedItem).getID();
            }
            catch (Exception)
            {
                return;
            }

            string query = "SELECT `user_username`, `account_name`, `account_dob`, `account_type` FROM `users`, `account` WHERE `user_userID` = `account_userID` AND `account_id` = @id";

            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            command.Parameters.AddWithValue("@id", account_id);
            DBConnections.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                AccountID.Text = account_id.ToString();
                UsernameDisplay.Text = reader.GetValue(0).ToString();
                username.Text = reader.GetValue(0).ToString();
                AccName.Text = reader.GetValue(1).ToString();
                DateOfBirth.Text = reader.GetValue(2).ToString();

                if (reader.GetInt32(3) == 0)
                    AccountType.Text = "attendant";
                else
                    AccountType.Text = "admin";

            }

            DBConnections.closeConnection();
        }
        private void AccoutypeCombo()
        {
            string query = "SELECT `account_type` FROM `account`";
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);

            MySqlDataReader reader;
            try
            {
                DBConnections.openConnection();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AccType.Items.Add(reader.GetString("account_type"));
                }

                DBConnections.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            if (UsrTxtBox.Text == "")
                return;

            string accountType = "";
            if (AccType.SelectedIndex >= 0)
            {
                accountType = AccType.Items[AccType.SelectedIndex].ToString();
            }

            string query = "INSERT INTO `users` (`user_username`, `user_password`) VALUES (@username, @password)";
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            command.Parameters.AddWithValue("@username", UsrTxtBox.Text);
            command.Parameters.AddWithValue("@password", Utilis.hashPassword(PassTxtbox.Text));
            DBConnections.openConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT `user_userID` FROM `users` WHERE user_username = @username";
                int user_id = (int)command.ExecuteScalar();

                command.CommandText = "INSERT INTO `account` (`account_userID`, `account_name`, `account_dob`, `account_type`) VALUES (@userID, @name, @dob, @type)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@userID", user_id);
                command.Parameters.AddWithValue("@name", accountName.Text);
                command.Parameters.AddWithValue("@dob", dateTimePicker.Value);
                command.Parameters.AddWithValue("@type", accountType);

                if (command.ExecuteNonQuery() > 0)
                {
                    AccountFlash.Visible = true;
                    AccountFlash.Text = "Account Succesfully Created";
                    t.Start();
                }
                else
                {
                    AccountFlash.ForeColor = Color.FromArgb(243, 32, 19);
                    AccountFlash.Visible = true;
                    AccountFlash.Text = "Error Occured! Account couldn't be created.";
                    t.Start();
                }
            }
            else
            {
                MessageBox.Show("Error! Account could not be created!");
            }
            Clear();

            DBConnections.closeConnection();
            UpdateUsersList("");
            Clear();

        }

        private void delAccBtn_Click(object sender, EventArgs e)
        {
            if (UsernameDisplay.Text == "")
                return;


            string query = "DELETE FROM `users` WHERE `user_username` = @username";
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            command.Parameters.AddWithValue("@username", UsernameDisplay.Text);
            DBConnections.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account Deleted!");
            }
            else
            {
                MessageBox.Show("Account Couldn't be deleted");
            }
            DBConnections.closeConnection();
            UpdateUsersList("");
            Clear();
        }
        void Clear()
        {
            AccountID.Clear();
            UsernameDisplay.Clear();
            AccName.Clear();
            AccountType.Clear();
            DateOfBirth.Clear();
            accountName.Clear();
            UsrTxtBox.Clear();
            PassTxtbox.Clear();
            ModifyPass.Clear();
            ConfirmPass.Clear();
        }

        private void modifyPwd_Click(object sender, EventArgs e)
        {
            if (ModifyPass.Text == "")
            {
                resetLabel.Text = "Please ensure all field has same password";
                t.Start();
                return;
            }

            string query = "UPDATE `users` SET `user_password` = @password WHERE `user_username` = @username";
            MySqlCommand command;
            command = new MySqlCommand(query, DBConnections.connection);
            if (ModifyPass.Text == ConfirmPass.Text)
            {
                DBConnections.openConnection();
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@password", Utilis.hashPassword(ModifyPass.Text));
                command.ExecuteNonQuery();
                resetLabel.Text = $"{username.Text}'s account password changed succesfully!";
                resetLabel.ForeColor = Color.Green;
            }
            else
            {
                resetLabel.Text = "Please ensure all field has same password";
                t.Start();
            }
            Clear();

            DBConnections.openConnection();
        }
    }
}
