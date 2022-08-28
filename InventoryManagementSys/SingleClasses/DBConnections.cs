using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSys.SingleClasses
{
    internal class DBConnections
    {
        public static string connectionString = "server=localhost; database=inventory_shoprite," +
            "uid=root,pwd=\"\"";
        
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //    string query = "select * from prodcategories";
        //MySqlCommand cmd = new MySqlCommand(query, connection);
        //MySqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Console.WriteLine(reader["catID"]);
        //        Console.WriteLine(reader["categoryName"]);

        //    }
    }
}
