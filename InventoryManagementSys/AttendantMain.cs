using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSys
{
    public partial class AttendantMain : Form
    {
        public AttendantMain()
        {
            InitializeComponent();
            ActiveBtn(SalesBtn, null);
            AttendantControls.SalesPage salesPage = new AttendantControls.SalesPage();
            AttachUserControls(salesPage);
            userLabel.Text = Login.userName;
            userLabel.ForeColor = Color.Gold;
        }

        private void ActiveBtn(object sender, EventArgs e)
        {
            foreach (Control control in btnPanel.Controls)
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }
            Control click = (Control)sender;
            click.ForeColor = Color.WhiteSmoke;
            click.BackColor = Color.Navy;
        }


        private void AttachUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            hostPanel.Controls.Clear();
            hostPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(SalesBtn, null);
            AttendantControls.SalesPage salesPage = new AttendantControls.SalesPage();
            AttachUserControls(salesPage);
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            ActiveBtn(LogsBtn, null);
            AttendantControls.LogReports logsPage = new AttendantControls.LogReports();
            AttachUserControls(logsPage);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
