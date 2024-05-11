using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Cashier_Forms
{
    public partial class frm_CashierSearch : Form
    {
        public frm_CashierSearch()
        {
            InitializeComponent();
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            Cashier cashier = CashierDL.FindCashier(id);
            lbl_Surprise.Visible = true;
            if (cashier != null)
            {
                lbl_Surprise.ForeColor = Color.FromArgb(127, 67, 47);
                lbl_Surprise.Text = cashier.getUser().UserName + " exists";
            }
            else
            {
                lbl_Surprise.ForeColor = Color.White;
                lbl_Surprise.Text = "You Have Entered Wrong Id";
            }
            txt_Id.Text = "";
        }
    }
}
