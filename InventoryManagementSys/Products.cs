using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSys
{
    public partial class Products : Form
    {
        public static string Modify;
        public Products()
        {
            InitializeComponent();
            FillgridView();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void addProd_Click(object sender, EventArgs e)
        {
            AddProduct editProduct = new AddProduct();
            editProduct.Show();
        }
        void FillgridView()
        {
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
            conn.Open();
            MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", conn);
            DataTable dataTable = new DataTable();
            insert.Fill(dataTable);
            foreach(DataRow product in dataTable.Rows)
            {
                int numberRow = gridView.Rows.Add();
                gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString();
                gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString();
                gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString();
                gridView.Rows[numberRow].Cells[3].Value = product["stock"].ToString();
                gridView.Rows[numberRow].Cells[4].Value = product["categoryName"].ToString();
                gridView.Rows[numberRow].Cells[5].Value = product["barcode"].ToString();
            }
        }

      private void reloadProducts()
        {
            
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
            conn.Open();
            MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", conn);
            DataSet dataTable = new DataSet();
             insert.Fill(dataTable, "product");
            gridView.DataSource = dataTable.Tables[0];
        }

        private void reload_Click(object sender, EventArgs e)
        {
            reloadProducts();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query = "select * from product where product_name like '"+ searchArea.Text.Trim() + "%'";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (searchArea.Text != "")
            {

                try
                {
                    
                    MySqlCommand command = new MySqlCommand(query, DBConnections.connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    DBConnections.closeConnection();
                    dv = ds.Tables[0].DefaultView;
                    gridView.DataSource = dv;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                FillgridView();
            }
        }
        void ModifyID()
        {

            DBConnections.openConnection();
            MySqlCommand command;
            if (idTxtBox.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from product where productID = '" + idTxtBox.Text + "'";
                    command = new MySqlCommand(countQuery, DBConnections.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        Modify = idTxtBox.Text;
                        EditProducts editProduct = new EditProducts();
                        editProduct.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Please {idTxtBox.Text} doesn't match any ID!");
                        DBConnections.closeConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string message = "Provide id from the products table display!";
                string title = "Please Enter Product ID";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    Close();
                }
                else if(result == DialogResult.Retry) {
                    //Close();
                } else
                {
                    // Do something  
                }
            }
        }

        private void modifybtn_Click_1(object sender, EventArgs e)
        {
            ModifyID();
           
        }
    }
}