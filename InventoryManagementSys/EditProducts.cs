using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        private void EditProducts_Load(object sender, EventArgs e)
        {
            DBConnections.openConnection();
            MySqlCommand command;
            string idText = Main.Modify;
            string id = idText.ToString();
            string query = "select product_name,product_price,stock,barcode,categoryName from product where productID = '" + id + "'";
            command = new MySqlCommand(query, DBConnections.connection);
            command.ExecuteNonQuery();
            MySqlDataReader reader;
            try
            {
                DBConnections.openConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    editprodNameTxtBox.Text = reader.GetValue(0).ToString();
                    editpriceTxtBox.Text = reader.GetValue(1).ToString();
                    editqtyTxtBox.Text = reader.GetValue(2).ToString();
                    barcodeTxtBox.Text = reader.GetValue(3).ToString();
                    categorySelctBox.Text = reader.GetValue(4).ToString();
                }
                DBConnections.closeConnection();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string categorynameDB = "";
            if (categorySelctBox.SelectedIndex >= 0)
                categorynameDB = categorySelctBox.Items[categorySelctBox.SelectedIndex].ToString();
            DBConnections.openConnection();
            MySqlCommand command;
            string idText = Main.Modify;
            string id = idText.ToString();
            if (editprodNameTxtBox.Text != "" || editpriceTxtBox.Text !="" || editqtyTxtBox.Text !="" || barcodeTxtBox.Text !="")
            {
                string query = "update product set " +
                    "product_name = '"+ editprodNameTxtBox.Text + "', " +
                    "product_price = '" + editpriceTxtBox.Text + "', " +
                    "stock = '"+ editqtyTxtBox + "', " +
                    "barcode = '"+ barcodeTxtBox + "', " +
                    "categoryName='"+ categorynameDB + "' " +
                    "from product where productID = '" + id + "'";
                command = new MySqlCommand(query, DBConnections.connection);
                command.ExecuteNonQuery();
                MessageBox.Show($"Product with {id} has been updated succesfully!");
            }
            else
            {
                string message = "Provide all required fields!";
                string title = "All fields are required";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    Products back = new Products();
                    back.Show();
                }
                else if (result == DialogResult.Retry)
                {
                    //Close();
                }
                else
                {
                    // Do something  
                }
            }
        }
    }
}
