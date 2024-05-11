using Restaurant_Mangement_System.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_CashierAnalytics : Form
    {
        private frm_Cashier cashierForm;
        public frm_CashierAnalytics(frm_Cashier cashierForm)
        {
            InitializeComponent();
            this.cashierForm = cashierForm;
        }

        private void frm_CashierAnalytics_Load(object sender, EventArgs e)
        {
            orderView();
            lbl_Pending.Text = "";
            lbl_Pending.Text = Customer.PendingOrders().ToString();
            lbl_Items.Text = "";
            lbl_Items.Text = hotItemNames();

        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            cashierForm.ShowCustomerForm();
        }
        private void pB_Next_Click(object sender, EventArgs e)
        {
            cashierForm.ShowDashboard();
        }

        private string hotItemNames()
        {
            string name = "";
            List<Product> hotItems = Customer.HotItems();
            for (int i = 0; i < hotItems.Count; i++)
            {
                if (i < 3)
                {
                    name += hotItems[i].FoodName + "\n\n";
                }
            }
            return name;
        }

        private void orderView()
        {
            lbl_CustomerNo.Text = Customer.Customers.Count.ToString();
            lbl_OrderNo.Text = Customer.AllOrders().ToString();
            int totalCustomers = Customer.Customers.Count;
            int customersWithMultipleOrders = Customer.Orders();
            int progressValue = (int)((float)customersWithMultipleOrders / (totalCustomers) * 100);
            pBar_Orders.Value = progressValue;
            pBar_Orders.Text = totalCustomers.ToString();
        }
    }
}
