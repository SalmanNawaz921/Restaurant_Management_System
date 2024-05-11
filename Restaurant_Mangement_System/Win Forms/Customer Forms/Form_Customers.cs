using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using Restaurant_Mangement_System.Win_Forms.Cashier_Forms;
using Restaurant_Mangement_System.Win_Forms.Customer_Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms
{
    public partial class frm_Customers : Form
    {
        private frm_Cashier cashierForm;
        public frm_Customers(frm_Cashier cashierForm)
        {
            InitializeComponent();
            this.cashierForm = cashierForm;
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void grid_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Customers.CurrentRow.Cells[1].Value?.ToString());
            CustomerDL.RemoveCustomer(id);
            CustomerDL.StoreCustomers(Program.path3);
            refreshGrid();
        }
        public void refreshGrid()
        {
            grid_Customers.DataSource = null;
            grid_Customers.DataSource = Cashier.Customers.Select(c => new
            {
                Name = c.CustomerName,
                Id = c.CustomerId,
                Order = c.getAllOrders(),
                Quantity = c.CustomerQuantity,
                Bill = c.TotalBill
            }).ToList();
            Program.resizeGrid(grid_Customers);
            grid_Customers.Refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_CustomerSearch search = new frm_CustomerSearch();
            search.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Customers.CurrentRow.Cells[1].Value?.ToString());
            Customer customer = CustomerDL.FindCustomer(id);
            if (customer != null)
            {
                frm_CustomerEdit edit = new frm_CustomerEdit(customer, this);
                edit.Show();
            }
        }



        private void btn_Bill_Click(object sender, EventArgs e)
        {

        }
        public DataGridView GetCustomerGrid()
        {
            return grid_Customers;
        }

        private void pB_Add_Click(object sender, EventArgs e)
        {
            frm_CustomerAdd add = new frm_CustomerAdd(this);
            add.Show();
        }

        private void pB_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Customers.CurrentRow.Cells[1].Value?.ToString());
            Customer customer = CustomerDL.FindCustomer(id);
            if (customer != null)
            {
                frm_CustomerEdit edit = new frm_CustomerEdit(customer, this);
                edit.Show();
            }
        }

        private void pB_Find_Click(object sender, EventArgs e)
        {

            frm_CustomerSearch search = new frm_CustomerSearch();
            search.Show();
        }

        private void pB_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Customers.CurrentRow.Cells[1].Value?.ToString());
            CustomerDL.RemoveCustomer(id);
            CustomerDL.StoreCustomers(Program.path3);
            refreshGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Customers.CurrentRow.Cells[1].Value?.ToString());
            Customer customer = CustomerDL.FindCustomer(id);
            if (customer != null)
            {
                frm_CustomerBill bill = new frm_CustomerBill(customer);
                CustomerDL.RemoveCustomer(id);
                bill.Show();
                CustomerDL.StoreCustomers(Program.path3);
                refreshGrid();
            }
        }

        private void pB_Next_Click(object sender, EventArgs e)
        {
            cashierForm.ShowAnalytics();
        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            cashierForm.ShowMenu();
        }
    }
}
