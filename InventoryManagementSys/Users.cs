using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void users_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.PanelHolder.Controls.ContainsKey("Users"))
            {
                Users usersPage = new Users();
                usersPage.Dock = DockStyle.Fill;
                Main.Instance.PanelHolder.Controls.Add(usersPage);
            }
            Main.Instance.PanelHolder.Controls["Users"].BringToFront();
            Main.Instance.DashboardButton.Enabled = true;
        }
    }
}
