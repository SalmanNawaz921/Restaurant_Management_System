using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_CashierAdd : Form
    {
        private frm_Employees employees;
        public frm_CashierAdd(frm_Employees employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            int id = int.Parse(txt_Id.Text);
            string pass = txt_Pass.Text;
            int salary = int.Parse(txt_Salary.Text);
            Cashier cashier = CashierDL.FindCashier(id);
            if (cashier != null)
            {
                MessageBox.Show("Sorry, Another Cashier With Same Id Exists");
            }
            else
            {
                Cashier newCashier = new Cashier(salary, new Credentials(name, id, pass));
                Manager.addCashier(newCashier);
                CashierDL.storeCashier(Program.path);
                MessageBox.Show("Cashier Added Successfully");

            }
            employees.refreshGrid();

        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.stringValidation(e);
        }
    }
}
