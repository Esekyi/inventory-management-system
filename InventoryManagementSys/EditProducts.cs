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
            DropDowncategorySelctBox();
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
            int id = Convert.ToInt32(idText);
            if (editprodNameTxtBox.Text != "" & editpriceTxtBox.Text !="" & editqtyTxtBox.Text !="" & barcodeTxtBox.Text !="")
            {
                string query = "update product set `product_name` = '"+ editprodNameTxtBox.Text.Trim() + "', `product_price` = '" + editpriceTxtBox.Text.Trim() + "', `stock` = '"+ editqtyTxtBox.Text.Trim() + "',`reoderLevel` = '"+ reoderTxtbox.Text.Trim() + "', `barcode` = '"+ barcodeTxtBox.Text.Trim() + "', `categoryName` ='"+ categorynameDB.ToString() + "' where `productID` = '" + id + "'";
                command = new MySqlCommand(query, DBConnections.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Product has been updated succesfully!");
                DBConnections.closeConnection();
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
        private void DropDowncategorySelctBox()
        {

            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
            string query = "SELECT * FROM prodcategories";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            //categorySelctBox.SelectedIndex = -1;

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                //conn.Close();



                while (reader.Read())
                {
                    //categorySelctBox.SelectedIndex = 0;
                    categorySelctBox.Items.Add(reader.GetString("categoryName"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DBConnections.openConnection();
            MySqlCommand command;
            string idText = Main.Modify;
            int id = Convert.ToInt32(idText);
            
            string query = "delete from `product` where `productID`='"+id+"'";
            command = new MySqlCommand(query, DBConnections.connection);
            command.ExecuteNonQuery();
            MessageBox.Show($"Product with {id} has been deleted succesfully!");
            Close();
        }
    }
}
