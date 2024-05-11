using Restaurant_Mangement_System.Win_Forms.Cashier_Forms;
using Restaurant_Mangement_System.Win_Forms.Product_Forms;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms
{
    public partial class frm_Dashboard : Form
    {
        private frm_Employees form;
        private frm_Products form1;
        private frm_Manager managerForm;
        public frm_Dashboard(frm_Manager managerForm, frm_Employees form, frm_Products form1)
        {
            InitializeComponent();
            this.form = form;
            this.form1 = form1;
            this.managerForm = managerForm;
        }

        private void btn_FireCashier_Click(object sender, EventArgs e)
        {
            frm_CashierAdd add = new frm_CashierAdd(form);
            add.Show();
        }


        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            frm_ProductAdd add = new frm_ProductAdd(form1.GetGrid());
            add.Show();
        }

        private void btn_EditCashier_Click(object sender, EventArgs e)
        {
            frm_CashierSearch find = new frm_CashierSearch();
            find.Show();
        }

        private void btn_UpdateStock_Click(object sender, EventArgs e)
        {
            frm_ProductSearch find = new frm_ProductSearch();
            find.Show();
        }

        private void pB_Next_Click(object sender, EventArgs e)
        {
            managerForm.ShowCashiersForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
