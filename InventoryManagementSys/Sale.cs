using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class Sale : UserControl
    {
        public Sale()
        {
            InitializeComponent();
            Sale_Load();
            barcodePanle.Visible = false;

        }
        void Sale_Load()
        {
            barcodeScan.Click += new EventHandler(BarcodeScan_Click);
        }

        private void BarcodeScan_Click(object sender, EventArgs e)
        {
            barcodePanle.Visible = true;
        }

    }
}
