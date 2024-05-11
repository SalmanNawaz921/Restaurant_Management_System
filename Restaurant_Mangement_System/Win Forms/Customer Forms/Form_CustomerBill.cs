using Restaurant_Mangement_System.BL;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    partial class frm_CustomerBill : Form
    {
        private Customer customer;
        public frm_CustomerBill(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

        }

        private void frm_CustomerBill_Load(object sender, System.EventArgs e)
        {
            lbl_CustomerName.Text = customer.CustomerName;
            lbl_CustomerOrders.Text = customer.getAllOrders();
            lbl_CustomerQuantity.Text = (customer.CustomerQuantity).ToString();
            lbl_TotalBill.Text = (customer.TotalBill).ToString();
            Cashier.Customers.Remove(customer);
        }
    }
}
