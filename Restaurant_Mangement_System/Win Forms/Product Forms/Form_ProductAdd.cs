using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Product_Forms
{
    public partial class frm_ProductAdd : Form
    {
        private DataGridView grid;
        public frm_ProductAdd(DataGridView grid)
        {
            InitializeComponent();
            this.grid = grid;

        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);

        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            string name = txt_Name.Text;
            int price = int.Parse(txt_Price.Text);
            int quantity = int.Parse(txt_Quantity.Text);
            Product product = ProductsDL.SearchItem(name);
            if (product != null)
            {
                MessageBox.Show("Product Already Exists!");
            }
            else
            {
                Product newProduct = new Product(name, price, quantity);
                Manager.addProduct(newProduct);
                ProductsDL.storeStock(Program.path1);
                grid.DataSource = null;
                grid.DataSource = Manager.Products;
                grid.Refresh();
                MessageBox.Show("Product Added!");
            }

        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.stringValidation(e);
        }
    }
}
