using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class DashboardPage : UserControl
    {
        public void GetProductAvailable()
        {
            DBConnections.openConnection();
            MySqlCommand command;
            try
            {
                string query = "SELECT SUM(product_price * stock) from product";
                command = new MySqlCommand(query, DBConnections.connection);
                var totalProducts = command.ExecuteScalar();
                productAvailable.Text = totalProducts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBConnections.closeConnection();
        }
        
        public DashboardPage()
        {
            InitializeComponent();
            GetProductAvailable();
            chartName.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Sales",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(9,3),
                        new ObservablePoint(0,10),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Title = "skert",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(2,5),
                        new ObservablePoint(3,6),
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 20
                },
        };
            chartName.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July","August", "September", "October", "November" },
            });
            chartName.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });
            chartName.LegendLocation = LegendLocation.Right;
        }
        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Products"))
            {
                Products productsPage = new Products();
                productsPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(productsPage);
            }
            Main.Instance.PanelHolder.Controls["Products"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;

        }

        private void productsAvailBtn_Click(object sender, EventArgs e)
        {
            GetProductAvailable();
        }
    }
}
