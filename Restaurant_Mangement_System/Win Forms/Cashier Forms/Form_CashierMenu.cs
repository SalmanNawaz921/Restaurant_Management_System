using Restaurant_Mangement_System.BL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_CashierMenu : Form
    {
        private frm_Cashier cashierForm;
        public frm_CashierMenu(frm_Cashier cashierForm)
        {
            InitializeComponent();
            this.cashierForm = cashierForm;
        }

        private void Form_CashierMenu_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
        public void refreshGrid()
        {
            grid_Products.DataSource = null;
            grid_Products.DataSource = Manager.Products.Select(c => new
            {
                c.FoodName,
                c.FoodPrice
            }).ToList();
            Program.resizeGrid(grid_Products);
            grid_Products.Refresh();
        }

        private void grid_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            cashierForm.ShowDashboard();
        }

        private void pB_Next_Click(object sender, EventArgs e)
        {
            cashierForm.ShowCustomerForm();
        }
    }
}
