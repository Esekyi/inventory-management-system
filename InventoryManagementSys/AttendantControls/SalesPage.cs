using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSys.AttendantControls
{
    public partial class SalesPage : UserControl
    {
        public SalesPage()
        {
            InitializeComponent();
            //UnitPrice.ForeColor = Color.Red;
            Empty();
        }

        private void BarcodeReader(string barcode)
        {
            MySqlCommand command;
            command = new MySqlCommand(barcode, DBConnections.connection);
            DBConnections.openConnection();
            command.CommandText = "SELECT `categoryName`,`product_name`, `product_price`, `stock` FROM `product` WHERE `barcode` regexp @barcode";
            command.Parameters.AddWithValue("@barcode", "[[:<:]]" + barcode + "[[:>:]]");

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ProdCategory.Text = reader.GetValue(0).ToString();
                ProdName.Text = reader.GetValue(1).ToString();
                UnitPrice.Text = reader.GetValue(2).ToString();
                qtyLabel.Text = reader.GetValue(3).ToString();
            }

            DBConnections.closeConnection();
        }
        void Empty()
        {
            if (BarcodeTxtBox.Text == "")
            {
                ProdCategory.Text = "Null";
                ProdName.Text = "Null";
                UnitPrice.Text = "Null";
                qtyLabel.Text = "Null";
            }
        }

        private void BarcodeTxtBox_TextChanged(object sender, EventArgs e)
        {
            BarcodeReader(BarcodeTxtBox.Text);
            Empty();
        }
    }
}
