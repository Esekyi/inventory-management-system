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
        }

        private void BarcodeReader(string barcode)
        {
            MySqlCommand command;
            command = new MySqlCommand(barcode, DBConnections.connection);
            DBConnections.openConnection();
            command.CommandText = "SELECT `categoryName`,`product_name`, `product_price`, `stock`, `barcode`, `amount_paid` FROM `product`, `transaction` WHERE `barcode` = @barcode AND `trans_ID` = @id";
            command.Parameters.AddWithValue("@barcode", barcode + "%");

            DBConnections.closeConnection();
        }
    }
}
