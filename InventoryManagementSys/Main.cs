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

        private void ActiveBtn(object sender, EventArgs e)
        {
            foreach(Control control in sidePanel.Controls)
            {
                control.BackColor = Color.Gold;
                control.ForeColor = Color.Wheat;
            }
            Control click = (Control)sender;
            click.ForeColor = Color.Gold;
            click.BackColor = Color.Wheat;
        }

        void Dashboard()
        {
            prodLabel.Text = "Dashboard";
            btnLogo.Image = Properties.Resources.icons8_home_28;

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
            ActiveBtn(DashboardButton, null);
            panelHolder.Controls["Dashboard"].BringToFront();
            prodLabel.Text = "Dashboard";
            btnLogo.Image = Properties.Resources.icons8_home_28;
        }


        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelHolder.Controls.ContainsKey("Products"))
            {
                Products productsPage = new Products();
                productsPage.Dock = DockStyle.Fill;
                Instance.PanelHolder.Controls.Add(productsPage);
            }
            ActiveBtn(ProductsBtn, null);

            Instance.PanelHolder.Controls["Products"].BringToFront();
            Instance.DashboardButton.Enabled = true;
            prodLabel.Text = "Manage Products";
            btnLogo.Image = Properties.Resources.icons8_new_product_28;
        }


        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Category"))
            {

                Category categoryPage = new Category();
                categoryPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(categoryPage);
            }
            ActiveBtn(CategoryBtn, null);

            Instance.PanelHolder.Controls["Category"].BringToFront();
            Instance.DashboardButton.Enabled = true;
            prodLabel.Text = "Manage Categories";
            btnLogo.Image = Properties.Resources.icons8_supply_chain_28;
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelHolder.Controls.ContainsKey("Users"))
            {
                Users usersPage = new Users();
                usersPage.Dock = DockStyle.Fill;
                Instance.PanelHolder.Controls.Add(usersPage);
            }
            ActiveBtn(users, null);

            Main.Instance.PanelHolder.Controls["Users"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
            prodLabel.Text = "Manage Users";
            btnLogo.Image = Properties.Resources.icons8_users_30;
        }

        private void TillSale_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelHolder.Controls.ContainsKey("Sale"))
            {
                Sale SalesPage = new Sale();
                SalesPage.Dock = DockStyle.Fill;
                Instance.PanelHolder.Controls.Add(SalesPage);
            }
            ActiveBtn(TillSale, null);

            Main.Instance.PanelHolder.Controls["Sale"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
            prodLabel.Text = "Transaction Sale";
            btnLogo.Image = Properties.Resources.icons8_sale_28;
        }
    }
}