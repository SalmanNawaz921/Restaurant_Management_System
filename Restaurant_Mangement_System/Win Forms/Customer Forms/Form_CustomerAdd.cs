using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    public partial class frm_CustomerAdd : Form
    {
        private List<Product> orderList = new List<Product>();
        private int totalQuantity = 0;
        private int totalBill = 0;
        private frm_Customers customers;
        public frm_CustomerAdd(frm_Customers customer)
        {
            InitializeComponent();
            this.customers = customer;
        }

        private void Form_CustomerAdd_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            grid_NewProducts.DataSource = null;
            grid_NewProducts.DataSource = Manager.Products;
            grid_NewProducts.Columns["InitialQuantity"].Visible = false;
            grid_NewProducts.Columns["FoodName"].HeaderText = "Item";
            grid_NewProducts.Columns["FoodPrice"].HeaderText = "Price";
            grid_NewProducts.Columns["FoodQuantity"].HeaderText = "Quantity";
            Program.resizeGrid(grid_NewProducts);
            grid_NewProducts.Refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_Quantity.Text);
            Product product = grid_NewProducts.CurrentRow.DataBoundItem as Product;
            Product editedProduct = ProductsDL.SearchItem(product.FoodName);
            lbl_Surprise.Text = "";
            lbl_Surprise.Visible = true;
            if (editedProduct != null)
            {
                if (quantity <= editedProduct.FoodQuantity)
                {
                    totalQuantity += quantity;
                    editedProduct.FoodQuantity -= quantity;
                    int price = editedProduct.FoodPrice * quantity;
                    totalBill += price;
                    orderList.Add(new Product(editedProduct.FoodName, price, quantity));
                    refreshGrid();
                }
                else
                {
                    lbl_Surprise.Text = editedProduct.FoodName + " not enough in stock";
                }
            }
            else
            {
                lbl_Surprise.Text = editedProduct.FoodName + " not found";

            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txt_Id.Text);
            string customerName = txt_Name.Text;
            Customer customer = CustomerDL.FindCustomer(customerId);
            lbl_Surprise.Text = "";
            lbl_Surprise.Visible = true;
            if (customer != null)
            {
                lbl_Surprise.Text = "Sorry, Another Customer With Same Id Already Exists";
            }
            else
            {
                Customer newCustomer = new Customer(customerName, customerId, orderList, totalQuantity, totalBill);
                Cashier.addCustomer(newCustomer);
                ProductsDL.storeStock(Program.path1);
                CustomerDL.StoreCustomers(Program.path3);
                MessageBox.Show("Customer Added Successfully");
                customers.refreshGrid();
                this.Close();
            }
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
