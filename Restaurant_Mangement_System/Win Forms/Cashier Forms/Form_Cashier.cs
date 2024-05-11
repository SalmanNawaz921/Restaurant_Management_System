using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_Cashier : Form
    {
        frm_Customers customers;
        frm_CashierDashboard dashboard;

        public frm_Cashier(string name)
        {
            InitializeComponent();
            lbl_personName.Text = name;
            lbl_personName.Visible = true;
            customers = new frm_Customers(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        }

        private void img_Customers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            ShowCustomerForm();
        }

        private void img_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            ShowAnalytics();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }


        private void frm_Cashier_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        public void ShowDashboard()
        {
            this.lbl_pnlHeader.Text = "Dashboard";
            this.pnl_Info.Controls.Clear();
            dashboard = new frm_CashierDashboard(this, customers) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Info.Controls.Add(dashboard);
            dashboard.Show();
        }

        public void ShowMenu()
        {
            this.lbl_pnlHeader.Text = "Menu List";
            this.pnl_Info.Controls.Clear();
            frm_CashierMenu menu = new frm_CashierMenu(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Info.Controls.Add(menu);
            menu.Show();
        }

        public void ShowAnalytics()
        {
            this.lbl_pnlHeader.Text = "Analytics";
            this.pnl_Info.Controls.Clear();
            frm_CashierAnalytics analytics = new frm_CashierAnalytics(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl_Info.Controls.Add(analytics);
            analytics.Show();
        }

        public void ShowCustomerForm()
        {
            this.lbl_pnlHeader.Text = "Customers";
            this.pnl_Info.Controls.Clear();
            this.pnl_Info.Controls.Add(customers);
            customers.Show();
        }
    }
}
