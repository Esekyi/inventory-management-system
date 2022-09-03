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
    public partial class Main : Form
    {
        public static string Modify;
        static Main _obj;
        public static Main Instance 
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Main();
                }
                return _obj;
            }
        }
        public Panel PanelHolder
        {
            get
            { return panelHolder; }
            set { panelHolder = value; }
        }
        public Button DashboardButton
        {
            get { return DashboardBtn; }
            set { DashboardBtn = value; }
        }


        public Main()
        {
            InitializeComponent();
            Dashboard();
        }
        //DASHBOARD - HOME ---------------------------START-----------------------------

        void Dashboard()
        {
            //gridView.Visible = false;
            prodLabel.Text = "Dashboard";
    
            _obj = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            panelHolder.Controls.Add(dashboard);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            panelHolder.Controls["Dashboard"].BringToFront();
            prodLabel.Text = "Dashboard";
        }

        //---------------------------------ENDS----------------------------------------------------------------------------------------



        //DASHBOARD - HOME ---------------------------START-----------------------------------------------------------------------------

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Products"))
            {
                Products productsPage = new Products();
                productsPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(productsPage);
            }
            prodLabel.Text = "Products";
            Main.Instance.PanelHolder.Controls["Products"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
        }


        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Category"))
            {
                Category categoryPage = new Category();
                categoryPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(categoryPage);
            }
            Main.Instance.PanelHolder.Controls["Category"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
        }

        //void FillgridView()
        //{
        //    this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        //    MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
        //    conn.Open();
        //    MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", conn);
        //    DataTable dataTable = new DataTable();
        //    insert.Fill(dataTable);
        //    foreach(DataRow product in dataTable.Rows)
        //    {
        //        int numberRow = gridView.Rows.Add();
        //        gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString();
        //        gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString();
        //        gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString();
        //        gridView.Rows[numberRow].Cells[3].Value = product["stock"].ToString();
        //        gridView.Rows[numberRow].Cells[4].Value = product["categoryName"].ToString();
        //        gridView.Rows[numberRow].Cells[5].Value = product["barcode"].ToString();
        //    }
        //}

        //private void reloadProducts()
        //  {

        //      MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
        //      conn.Open();
        //      MySqlDataAdapter insert = new MySqlDataAdapter("select * from product", conn);
        //      DataTable dataTable = new DataTable();
        //      insert.Fill(dataTable);

        //      foreach (DataRow product in dataTable.Rows)
        //      {
        //          int numberRow = gridView.Rows.Add();
        //          gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString();
        //          gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString();
        //          gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString();
        //          gridView.Rows[numberRow].Cells[3].Value = product["stock"].ToString();
        //          gridView.Rows[numberRow].Cells[4].Value = product["categoryName"].ToString();
        //          gridView.Rows[numberRow].Cells[5].Value = product["barcode"].ToString();
        //      }
        //  }

        //private void reload_Click(object sender, EventArgs e)
        //{
        //    gridView.DataSource = null;
        //    gridView.Rows.Clear();
        //    reloadProducts();
        //}

        //private void searchbtn_Click(object sender, EventArgs e)
        //{
        //    gridView.DataSource = null;
        //    gridView.Rows.Clear();
        //    string query = "select * from product where product_name like '"+ searchArea.Text.Trim() + "%'";
        //    DataTable ds = new DataTable();
        //    //DataView dv;
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    if (searchArea.Text != "")
        //    {

        //        try
        //        {

        //            MySqlCommand command = new MySqlCommand(query, DBConnections.connection);
        //            adapter.SelectCommand = command;
        //            adapter.Fill(ds);
        //            //DBConnections.closeConnection();
        //            //dv = ds.Tables[0].DefaultView;
        //            //gridView.DataSource = dv;
        //            foreach (DataRow product in ds.Rows)
        //            {
        //                int numberRow = gridView.Rows.Add();
        //                gridView.Rows[numberRow].Cells[0].Value = product["productID"].ToString();
        //                gridView.Rows[numberRow].Cells[1].Value = product["product_name"].ToString();
        //                gridView.Rows[numberRow].Cells[2].Value = product["product_price"].ToString();
        //                gridView.Rows[numberRow].Cells[3].Value = product["stock"].ToString();
        //                gridView.Rows[numberRow].Cells[4].Value = product["categoryName"].ToString();
        //                gridView.Rows[numberRow].Cells[5].Value = product["barcode"].ToString();
        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        FillgridView();
        //    }
        //}
        //void ModifyID()
        //{

        //    DBConnections.openConnection();
        //    MySqlCommand command;
        //    if (idTxtBox.Text != "")
        //    {
        //        try
        //        {
        //            string countQuery = "select count(*) from product where productID = '" + idTxtBox.Text + "'";
        //            command = new MySqlCommand(countQuery, DBConnections.connection);
        //            Int32 count = Convert.ToInt32(command.ExecuteScalar());
        //            if (count > 0)
        //            {
        //                Modify = idTxtBox.Text;
        //                EditProducts editProduct = new EditProducts();
        //                editProduct.Show();
        //            }
        //            else
        //            {
        //                MessageBox.Show($"Please {idTxtBox.Text} doesn't match any ID!");
        //                DBConnections.closeConnection();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        string message = "Provide id from the products table display!";
        //        string title = "Please Enter Product ID";
        //        MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
        //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        //        if (result == DialogResult.Abort)
        //        {
        //            Close();
        //        }
        //        else if(result == DialogResult.Retry) {
        //            //Close();
        //        } else
        //        {
        //            // Do something  
        //        }
        //    }
        //}

        //private void modifybtn_Click_1(object sender, EventArgs e)
        //{
        //    ModifyID();

        //}

        //DASHBOARD - HOME ---------------------------ENDS-----------------------------------------------------------------------------

    }
}