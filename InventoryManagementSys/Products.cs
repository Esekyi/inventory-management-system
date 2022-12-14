using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            FillgridView();
        }
        public static string Modify;

        private void addProd_Click(object sender, EventArgs e)
        {
            AddProduct editProduct = new AddProduct();
            editProduct.Show();
        }
        
        void FillgridView()
        {
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DBConnections.openConnection();

           

           
            MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", DBConnections.connection);
            
            DataTable dataTable = new DataTable();
            insert.Fill(dataTable);
            foreach (DataRow product in dataTable.Rows)
            {
                int numberRow = gridView.Rows.Add();
                gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[5].Value = product["stock"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[3].Value = product["categoryName"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[4].Value = product["barcode"].ToString().ToUpper();
                int productStock = Convert.ToInt32(product["stock"].ToString());
                int productReorder = Convert.ToInt32(product["reoderLevel"].ToString());

                if (productStock == 0 || productStock < productReorder)
                {
                    gridView.Rows[numberRow].Cells[6].Value = "Restock!!";
                    gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.Red;
                }
                else if(productStock == productReorder)
                {
                    gridView.Rows[numberRow].Cells[6].Value = "Low in Stock!";
                    gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.DarkOrange;
                }
                else
                {
                    gridView.Rows[numberRow].Cells[6].Value = "In Stock";
                    gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.DarkMagenta;

                }
            }

            DBConnections.closeConnection();
        }


        private void reloadProducts()
        {
            FillgridView();

            /*
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
            conn.Open();
            MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", conn);
            DataTable dataTable = new DataTable();
            insert.Fill(dataTable);

            foreach (DataRow product in dataTable.Rows)
            {
                int numberRow = gridView.Rows.Add();
                gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[3].Value = product["stock"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[4].Value = product["categoryName"].ToString().ToLower();
                gridView.Rows[numberRow].Cells[5].Value = product["barcode"].ToString().ToUpper();
            }
            */
        }

        private void reload_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            gridView.Rows.Clear();
            reloadProducts();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            gridView.DataSource = null;
            gridView.Rows.Clear();
            string query = "select * from product where product_name like '" + searchArea.Text.Trim() + "%'";
            DataTable ds = new DataTable();
            //DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (searchArea.Text != "")
            {

                try
                {

                    MySqlCommand command = new MySqlCommand(query, DBConnections.connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    //DBConnections.closeConnection();
                    //dv = ds.Tables[0].DefaultView;
                    //gridView.DataSource = dv;
                    foreach (DataRow product in ds.Rows)
                    {
                        int numberRow = gridView.Rows.Add();
                        gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString().ToLower();
                        gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString().ToLower();
                        gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString().ToLower();
                        gridView.Rows[numberRow].Cells[5].Value = product["stock"].ToString().ToLower();
                        gridView.Rows[numberRow].Cells[3].Value = product["categoryName"].ToString().ToLower();
                        gridView.Rows[numberRow].Cells[4].Value = product["barcode"].ToString().ToUpper();
                        int productStock = Convert.ToInt32(product["stock"].ToString());
                        int productReorder = Convert.ToInt32(product["reoderLevel"].ToString());

                        if (productStock == 0 || productStock < productReorder)
                        {
                            gridView.Rows[numberRow].Cells[6].Value = "Restock!!";
                            gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.Red;
                        }
                        else if (productStock == productReorder)
                        {
                            gridView.Rows[numberRow].Cells[6].Value = "Low in Stock!";
                            gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.DarkOrange;
                        }
                        else
                        {
                            gridView.Rows[numberRow].Cells[6].Value = "In Stock";
                            gridView.Rows[numberRow].Cells[6].Style.ForeColor = Color.DarkMagenta;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                FillgridView();
            }
            searchArea.Clear();

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
                        Main.Modify = idTxtBox.Text;
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
                idTxtBox.Clear();

            }

            else
            {
                string message = "Provide id from the products table display!";
                string title = "Please Enter Product ID";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    DashboardPage dashboard = new DashboardPage();
                    dashboard.Show();
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

        private void modifybtn_Click(object sender, EventArgs e)
        {
            ModifyID();
        }

        //DASHBOARD - HOME ---------------------------ENDS-----------------------------------------------------------------------------

    }
}
