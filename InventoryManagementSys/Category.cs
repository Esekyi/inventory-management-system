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
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
            FillgridView();
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

        void FillgridView()
        {
            catTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = inventory_shoprite; Uid = root; pwd =\"\";");
            conn.Open();
            MySqlDataAdapter insert = new MySqlDataAdapter("select * from prodcategories", conn);
            DataTable dataTable = new DataTable();
            insert.Fill(dataTable);
            foreach (DataRow product in dataTable.Rows)
            {
                int numberRow = catTable.Rows.Add();
                catTable.Rows[numberRow].Cells[0].Value = product["catID"].ToString();
                catTable.Rows[numberRow].Cells[1].Value = product["categoryName"].ToString();
            }
        }
    }

}
