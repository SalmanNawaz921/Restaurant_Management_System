using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_ProductEdit : Form
    {
        private string name;
        private DataGridView grid;
        public frm_ProductEdit(string name, DataGridView grid)
        {
            InitializeComponent();
            this.name = name;
            this.grid = grid;

        }
        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            ProductsDL.UpdateStock(name, int.Parse(txt_Price.Text), int.Parse(txt_Quantity.Text));
            ProductsDL.storeStock(Program.path1);
            grid.DataSource = null;
            grid.DataSource = Manager.Products;
            grid.Refresh();
            Close();
        }

        private void txt_Price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);
        }

        private void frm_ProductEdit_Load(object sender, System.EventArgs e)
        {

        }
    }
}
