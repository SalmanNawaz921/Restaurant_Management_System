using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_ProductSearch : Form
    {
        public frm_ProductSearch()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string itemName = txt_Name.Text;
            Product product = ProductsDL.SearchItem(itemName);
            lbl_Surprise.Text = "";
            lbl_Surprise.Visible = true;
            if (product != null)
            {
                lbl_Surprise.ForeColor = Color.FromArgb(122, 67, 47);
                lbl_Surprise.Text = product.FoodName + " exits";
            }
            else
            {
                lbl_Surprise.ForeColor = Color.White;
                lbl_Surprise.Text = itemName + " does not exists";
            }
            txt_Name.Text = "";
        }
    }
}
