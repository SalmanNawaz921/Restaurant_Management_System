using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    partial class frm_CashierEdit : Form
    {
        private Cashier cashier;
        public frm_CashierEdit(Cashier cashier)
        {
            InitializeComponent();
            this.cashier = cashier;
        }

        private void btn_Confirm_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            Cashier editedCashier = CashierDL.FindCashier(id);
            if (editedCashier != null)
            {
                MessageBox.Show("Cashier With Same Id Already Exists");
            }
            else
            {
                int salary = int.Parse(txt_Salary.Text);
                string password = txt_Password.Text;
                cashier.CashierSalary = salary;
                cashier.getUser().UserPassword = password;
                cashier.getUser().UserId = id;
                CashierDL.storeCashier(Program.path);
            }

        }

        private void txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);
        }
    }
}
