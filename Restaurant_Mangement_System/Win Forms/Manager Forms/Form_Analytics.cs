using Restaurant_Mangement_System.BL;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms
{
    public partial class frm_Analytics : Form
    {
        private frm_Manager managerForm;
        public frm_Analytics(frm_Manager managerForm)
        {
            InitializeComponent();
            lbl_Items.Text = "";
            lbl_Items.Text = hotItemNames(); ;
            lbl_revenue.Text = "$ " + Convert.ToString(Customer.TotalRevenue());
            this.managerForm = managerForm;
        }

        private void frm_Analytics_Load(object sender, System.EventArgs e)
        {
            lbl_CashierNo.Text = Convert.ToString(Manager.Cashiers.Count);
            lbl_ProductNo.Text = Convert.ToString(Manager.Products.Count);
            int progressValue = (int)((float)Product.totalSoldQuantity() / (Product.totalQuantity()) * 100);
            circularProgressBar1.Value = progressValue;
            circularProgressBar1.Text = Convert.ToString((Product.totalQuantity()));

        }

        private void pB_Back_Click(object sender, EventArgs e)
        {
            managerForm.ShowProductsForm();
        }


        private void pB_Next_Click(object sender, EventArgs e)
        {
            managerForm.ShowDashboard();
        }

        private string hotItemNames()
        {
            string name = "";
            for (int i = 0; i < Customer.HotItems().Count; i++)
            {
                if (i < 3)
                {

                    name += Customer.HotItems()[i].FoodName + "\n\n";

                }
            }
            return name;
        }
    }
}
