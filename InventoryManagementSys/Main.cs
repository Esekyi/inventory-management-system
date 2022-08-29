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
                control.BackColor = Color.FromArgb(54, 79, 107);
                control.ForeColor = Color.WhiteSmoke;
            }
            Control click = (Control)sender;
            click.ForeColor = Color.WhiteSmoke;
            click.BackColor = Color.Navy;
        }

        void Dashboard()
        {
            prodLabel.Text = "Dashboard";
            btnLogo.Image = Properties.Resources.icons8_home_45;

            _obj = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            panelHolder.Controls.Add(dashboard);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Dashboard();
            ActiveBtn(DashboardButton, null);

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            panelHolder.Controls["Dashboard"].BringToFront();
            prodLabel.Text = "Dashboard";
            btnLogo.Image = Properties.Resources.icons8_home_45;
            ActiveBtn(DashboardButton, null);
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
            btnLogo.Image = Properties.Resources.icons8_product_45;
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
            btnLogo.Image = Properties.Resources.icons8_supply_chain_45;
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (!Instance.PanelHolder.Controls.ContainsKey("Users"))
            {
                Users usersPage = new Users();
                usersPage.Dock = DockStyle.Fill;
                Instance.PanelHolder.Controls.Add(usersPage);
            }

            Main.Instance.PanelHolder.Controls["Users"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
            prodLabel.Text = "Manage Users";
            btnLogo.Image = Properties.Resources.icons8_select_users_64;
            ActiveBtn(users, null);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Close();
            Login Admin = new Login();
            Admin.Show();
        }
    }
}