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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            DropDowncategorySelctBox();
        }

        private void addNewProd_Click(object sender, EventArgs e)
        {
            string categorynameDB = "";
            if (categorySelctBox.SelectedIndex >= 0)
                categorynameDB = categorySelctBox.Items[categorySelctBox.SelectedIndex].ToString();
            DBConnections.openConnection();
            MySqlCommand command;
            if (prodTxtBox.Text != "" & priceTxtBox.Text != "" & qtyTxtBox.Text != "")
            {
                string query = "insert into `product` (`product_name`,`categoryName`,`product_price`,`stock`,`barcode`) values ( '" + prodTxtBox.Text.Trim() + "','" + categorynameDB.Trim() + "', '" + priceTxtBox.Text.Trim() + "'" +
                    ",'" + qtyTxtBox.Text.Trim() + "', '" + barcodeTxtBox.Text.Trim() + "' )";
                command = new MySqlCommand(query, DBConnections.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                DBConnections.closeConnection();

            }
            else
            {
                MessageBox.Show("Please Complete all required fields!");
            }
            //MessageBox.Show("You have Successfully added a new product!");
            Hide();
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
                reader  = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                //conn.Close();



                while (reader.Read())
                {
                    //categorySelctBox.SelectedIndex = 0;
                    categorySelctBox.Items.Add(reader.GetString("categoryName"));
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
