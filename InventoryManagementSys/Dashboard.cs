using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace InventoryManagementSys
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(0,10),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(2,5),
                        new ObservablePoint(3,6),
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                }
            };
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
    }
}
