using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using Restaurant_Mangement_System.Win_Forms.Product_Forms;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_Products : Form
    {
        private frm_Manager managerForm;
        public frm_Products(frm_Manager managerForm)
        {
            InitializeComponent();
            this.managerForm = managerForm;
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
        public void refreshGrid()
        {
            grid_Products.DataSource = null;
            grid_Products.DataSource = Manager.Products;
            grid_Products.Columns["InitialQuantity"].Visible = false;
            Program.resizeGrid(grid_Products);
            grid_Products.Refresh();

        }

        public DataGridView GetGrid()
        {
            return grid_Products;
        }
        private void pB_Add_Click(object sender, EventArgs e)
        {
            frm_ProductAdd add = new frm_ProductAdd(grid_Products);
            add.Show();
        }

        private void pB_Delete_Click(object sender, EventArgs e)
        {
            Product product = grid_Products.CurrentRow.DataBoundItem as Product;
            Manager.Products.Remove(product);
            refreshGrid();
            ProductsDL.storeStock(Program.path1);
        }

        private void pB_Edit_Click(object sender, EventArgs e)
        {
            Product product = grid_Products.CurrentRow.DataBoundItem as Product;
            frm_ProductEdit edit = new frm_ProductEdit(product.FoodName, grid_Products);
            edit.Show();
        }

        private void pB_Find_Click(object sender, EventArgs e)
        {
            frm_ProductSearch search = new frm_ProductSearch();
            search.Show();
        }

        private void pB_Next_Click(object sender, EventArgs e)
        {
            managerForm.ShowAnalyticsForm();
        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            managerForm.ShowCashiersForm();
        }
    }
}
