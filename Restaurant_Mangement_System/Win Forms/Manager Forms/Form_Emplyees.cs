using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using Restaurant_Mangement_System.Win_Forms.Cashier_Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_Employees : Form
    {
        private frm_Manager managerForm;
        public frm_Employees(frm_Manager managerForm)
        {
            InitializeComponent();
            this.managerForm = managerForm;
        }

        private void frm_Employees_Load(object sender, EventArgs e)
        {
            refreshGrid();

        }


        public void refreshGrid()
        {
            grid_Cashiers.DataSource = null;
            grid_Cashiers.DataSource = Manager.Cashiers.Select(c => new
            {
                CashierName = c.getUser().UserName,
                CashierId = c.getUser().UserId,
                c.CashierSalary
            }).ToList();
            Program.resizeGrid(grid_Cashiers);
            grid_Cashiers.Refresh();
        }


        public DataGridView GetCashierGrid()
        {
            return grid_Cashiers;
        }



        private void pB_Add_Click(object sender, EventArgs e)
        {
            frm_CashierAdd add = new frm_CashierAdd(this);
            add.Show();
        }

        private void pB_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Cashiers.CurrentRow.Cells[1].Value.ToString());
            Cashier cashier = CashierDL.FindCashier(id);
            if (cashier != null)
            {
                frm_CashierEdit edit = new frm_CashierEdit(cashier);
                edit.Show();

            }
            else
            {
                MessageBox.Show("You Have Entered Wrong Id");
            }
        }

        private void pB_Find_Click(object sender, EventArgs e)
        {
            frm_CashierSearch search = new frm_CashierSearch();
            search.ShowDialog();
        }

        private void pB_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(grid_Cashiers.CurrentRow.Cells[1].Value.ToString());
            CashierDL.FireCashier(id);
            CashierDL.storeCashier(Program.path);
            refreshGrid();
        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            managerForm.ShowDashboard();
        }

        private void pB_Next_Click(object sender, EventArgs e)
        {
            managerForm.ShowProductsForm();
        }
    }
}
