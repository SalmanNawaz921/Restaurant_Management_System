using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    public partial class frm_SortCustomers : Form
    {
        public frm_SortCustomers()
        {
            InitializeComponent();
        }

        private void Form_SortCustomers_Load(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerDL.sortedCustomers();
            grid_SortedCustomers.DataSource = null;
            grid_SortedCustomers.DataSource = customers;
            Program.resizeGrid(grid_SortedCustomers);
            grid_SortedCustomers.Refresh();
        }
    }
}
