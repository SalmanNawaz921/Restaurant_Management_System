using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    public partial class frm_CustomerSearch : Form
    {
        public frm_CustomerSearch()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            Customer customer = CustomerDL.FindCustomer(id);
            lbl_Surprise.Visible = true;
            if (customer != null)
            {
                lbl_Surprise.ForeColor = Color.Green;
                lbl_Surprise.Text = customer.CustomerName + " Exists";
            }
            else
            {
                lbl_Surprise.ForeColor = Color.Red;
                lbl_Surprise.Text = "You Have Entered Wrong Id";
            }
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);
        }
    }
}
