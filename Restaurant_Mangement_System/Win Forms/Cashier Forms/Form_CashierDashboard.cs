using Restaurant_Mangement_System.Win_Forms.Customer_Forms;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_CashierDashboard : Form
    {

        private frm_Customers customer;
        private frm_Cashier cashierForm;
        public frm_CashierDashboard(frm_Cashier cashierForm, frm_Customers customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.cashierForm = cashierForm;
        }

        private void btn_AddCashier_Click(object sender, EventArgs e)
        {
            frm_CustomerAdd add = new frm_CustomerAdd(customer);
            add.Show();
        }

        private void btn_SortCustomer_Click(object sender, EventArgs e)
        {
            frm_SortCustomers sort = new frm_SortCustomers();
            sort.Show();
        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            cashierForm.ShowAnalytics();
        }
        private void pB_Next_Click(object sender, EventArgs e)
        {
            cashierForm.ShowMenu();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
