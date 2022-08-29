using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InventoryManagementSys.AttendantControls
{
    public partial class SalesPage : UserControl
    {
        public static string stockAvail, TotalAmountPaid, prodID;
        Timer t = new Timer();
        public SalesPage()
        {
            InitializeComponent();
            Empty();
            t.Interval = 3000;
            t.Tick += T_Tick;
            Time.Text = DateTime.UtcNow.ToString("G");
            attendant.Text = "'" + Login.userName + "'";
            QtyBox.Enabled = false;

        }
        private void T_Tick(object sender, EventArgs e)
        {
            Timer _t = sender as Timer;
            _t.Stop();
        }


        private void BarcodeReader(string barcode)
        {
            if (BarcodeTxtBox.Text != "")
            {
                QtyBox.Enabled = true;
                MySqlCommand command;
                command = new MySqlCommand(barcode, DBConnections.connection);
                command.CommandText = "SELECT `categoryName`,`product_name`, `product_price`, `stock`, `productID` FROM `product` WHERE `barcode` regexp @barcode";
                command.Parameters.AddWithValue("@barcode", "[[:<:]]" + barcode + "[[:>:]]");
                DBConnections.openConnection();

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ProdCategory.Text = reader.GetValue(0).ToString();
                    ProdName.Text = reader.GetValue(1).ToString();
                    UnitPrice.Text = reader.GetValue(2).ToString();
                    qtyLabel.Text = reader.GetValue(3).ToString();
                    prodID = reader.GetValue(4).ToString();
                }
                DBConnections.closeConnection();
            }
            else
            {

                QtyBox.Enabled = false;

            }

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


        private void QtyBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                QtyBox.Text = "";
                e.Handled = true;
            }
        }

        private void QtyBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool result = int.TryParse(QtyBox.Text, out value);
            if (!result)
            {
                QtyBox.Text = null;
            }
            else
            {
                if (QtyBox.Text != null & Convert.ToDouble(QtyBox.Text) > 0)
                {
                    DBConnections.openConnection();
                    MySqlCommand command;
                    try
                    {
                        string query = "Select `product_price`, `stock` from product where product_name = '" + ProdName.Text + "'";
                        command = new MySqlCommand(query, DBConnections.connection);
                        MySqlDataReader price = command.ExecuteReader();
                        price.Read();

                        double getQuantity = Convert.ToDouble(price.GetValue(1).ToString());
                        if (getQuantity < Convert.ToInt32(QtyBox.Text))
                        {
                            CommitBtn.Enabled = false;
                            AddPurchase.Enabled = false;
                            errorLabel.Visible = true;
                            errorLabel.Text = ProdName.Text + " is out of stock";
                        }
                        else
                        {
                            CommitBtn.Enabled = true;
                            AddPurchase.Enabled = true;
                            errorLabel.Visible = false;
                            double setPrice = Convert.ToDouble(price.GetValue(0).ToString()) * Convert.ToInt32(QtyBox.Text);
                            TotalPrice.Text = setPrice.ToString();
                        }
                        DBConnections.closeConnection();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    TotalPrice.Text = "0.00";
                }
            }
        }

        private void AmtPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                AmtPaid.Text = "";
                e.Handled = true;
            }
        }

        private void AmtPaid_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool result = int.TryParse(AmtPaid.Text, out value);
            if (!result)
            {
                AmtPaid.Text = null;
            }
            else
            {
                if (AmtPaid.Text != null & Convert.ToDouble(AmtPaid.Text) > 0)
                {
                    try
                    {
                        if (Convert.ToDouble(AmtPaid.Text) < Convert.ToDouble(TotalPrice.Text))
                        {
                            cashError.Visible = true;
                            cashError.Text = "Please the amount is insufficient";
                        }
                        else
                        {
                            cashError.Visible = false;
                            double Amount = Convert.ToDouble(AmtPaid.Text);
                            double CashBalnce = Amount - Convert.ToDouble(TotalPrice.Text);
                            CashBalance.Text = Convert.ToDouble(CashBalnce).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    CashBalance.Text = "0.00";
                }
            }
        }

        private void AddPurchase_Click(object sender, EventArgs e)
        {
            if (QtyBox.Text != "")
            {
                TotalAmountPaid = TotalPricePaid.Text;
                TotalPricePaid.Text = TotalPrice.Text;
                customer.Text = CusName.Text;
                QtyBought.Text = QtyBox.Text;
                productName.Text = ProdName.Text;
                id.Text = prodID;

            }
            else
            {

            }
        }
        private void CommitBtn_Click(object sender, EventArgs e)
        {
            DBConnections.openConnection();
            string query = "SELECT `productID`, `stock` FROM `product` WHERE `barcode` regexp @Barcode";
            MySqlCommand command = new MySqlCommand(query, DBConnections.connection);
            command.Parameters.AddWithValue("@Barcode", "[[:<:]]" + BarcodeTxtBox.Text + "[[:>:]]");

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            

            int product = Convert.ToInt32(reader.GetValue(0).ToString());
            int getStockUpdate = Convert.ToInt32(reader.GetValue(1).ToString());

            reader.Close();
            int boughtQuantity = Convert.ToInt32(QtyBought.Text);
            string attendantName = Login.userName;
            int newStock;
            string dbDate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                command.CommandText = "INSERT INTO `transaction` (`productID`, `quantityBought`, `amount_paid`,`date_transacted`," +
                    "`customer_name`, `soldBy`) VALUES (@product, @quantity, @amtPaid, @date, @cusName, @soldBy)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@product", product);
                command.Parameters.AddWithValue("@quantity", boughtQuantity);
                command.Parameters.AddWithValue("@amtPaid", Convert.ToDouble(TotalPricePaid.Text));
                command.Parameters.AddWithValue("@date", dbDate);
                command.Parameters.AddWithValue("@cusName", customer.Text);
                command.Parameters.AddWithValue("@soldBy", attendantName);

                if(command.ExecuteNonQuery() > 0 && getStockUpdate >= boughtQuantity)
                {
                    newStock = getStockUpdate - boughtQuantity;
                    DBConnections.openConnection();
                    command.CommandText = "update product set `stock` = @newStock where barcode regexp @barcode";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@newStock", newStock);
                    command.Parameters.AddWithValue("@barcode", "[[:<:]]" + BarcodeTxtBox.Text + "[[:>:]]");

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Product has been updated succesfully!");
                        DBConnections.closeConnection();
                    }
                    else
                    {
                        erroDB.Visible = true;
                        erroDB.Text = "Error updating Product!";
                        t.Start();
                    }

                }
                else
                {
                    MessageBox.Show("Error!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            DBConnections.closeConnection();
        }
    }
}
