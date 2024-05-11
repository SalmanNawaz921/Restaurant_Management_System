using Restaurant_Mangement_System.Win_Forms;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_Manager : Form
    {
        frm_Employees employees;
        frm_Products products;
        frm_Analytics analytics;
        frm_Dashboard dashbiard;
        private static bool LoadImage = true;
        public frm_Manager(string name)
        {
            InitializeComponent();
            lbl_personName.Text = name;
            lbl_personName.Visible = true;
            dashbiard = new frm_Dashboard(this, employees, products) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            analytics = new frm_Analytics(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            products = new frm_Products(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employees = new frm_Employees(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        }


        private void Form_Manager_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btn_Cashiers_Click(object sender, EventArgs e)
        {
            ShowCashiersForm();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            ShowProductsForm();
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {

            ShowAnalyticsForm();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void img_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        public void ShowDashboard()
        {
            this.lbl_pnlHeader.Text = "Dashboard";
            this.pnl_Info.Controls.Clear();
            this.pnl_Info.Controls.Add(dashbiard);
            dashbiard.Show();
        }

        public void ShowCashiersForm()
        {
            this.lbl_pnlHeader.Text = "Cashiers";
            this.pnl_Info.Controls.Clear();
            this.pnl_Info.Controls.Add(employees);
            employees.Show();
        }

        public void ShowProductsForm()
        {
            this.lbl_pnlHeader.Text = "Products";
            this.pnl_Info.Controls.Clear();
            this.pnl_Info.Controls.Add(products);
            products.Show();
        }

        public void ShowAnalyticsForm()
        {
            this.lbl_pnlHeader.Text = "Analytics";
            this.pnl_Info.Controls.Clear();
            this.pnl_Info.Controls.Add(analytics);
            analytics.Show();
        }

        private void pnl_Info_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
