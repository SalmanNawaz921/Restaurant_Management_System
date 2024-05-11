using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.Win_Forms.Customer_Forms
{
    partial class frm_CustomerEdit : Form
    {

        private Customer customer;
        private List<Product> orderList = new List<Product>();
        private frm_Customers customerForm;
        private int totalQuantity = 0;
        public frm_CustomerEdit(Customer customer, frm_Customers customersForm)
        {
            InitializeComponent();
            this.customer = customer;
            this.customerForm = customersForm;
        }

        private void frm_CustomerEdit_Load(object sender, EventArgs e)
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
            int newQuantity = int.Parse(txt_Quantity.Text);


            Product product = grid_NewProducts.CurrentRow.DataBoundItem as Product;
            Product editedProduct = ProductsDL.SearchItem(product.FoodName);
            lbl_Surprise.Text = "";
            lbl_Surprise.Visible = true;
            if (editedProduct != null)
            {
                if (newQuantity <= editedProduct.FoodQuantity)
                {

                    Product exist = orderList.FirstOrDefault(f => f.FoodName == editedProduct.FoodName);
                    editedProduct.FoodQuantity = (editedProduct.FoodQuantity - newQuantity);
                    refreshGrid();
                    totalQuantity += newQuantity;
                    if (exist != null)
                    {
                        exist.FoodName = product.FoodName;
                        exist.FoodPrice = newQuantity * editedProduct.FoodPrice;
                        exist.FoodQuantity += newQuantity;
                    }
                    else
                    {
                        Product newProduct = new Product(editedProduct.FoodName, editedProduct.FoodPrice * newQuantity, newQuantity);
                        orderList.Add(newProduct);
                        lbl_Surprise.Text = "Product Added Successfully";

                    }
                }
                else
                {
                    lbl_Surprise.Text = editedProduct.FoodName + " not enough in stock";
                }
            }
            else
            {
                lbl_Surprise.Text = "Product Does Not Exists";

            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            int newId = int.Parse(txt_Id.Text);
            int newQuantity = int.Parse(txt_Quantity.Text);
            Customer editedCustomer = CustomerDL.FindCustomer(newId);
            lbl_Surprise.Text = "";
            lbl_Surprise.Visible = true;
            if (editedCustomer != null)
            {
                lbl_Surprise.Text = "Try Another Id, already assigned";
            }
            else
            {
                if (orderList != null)
                {
                    customer.CustomerId = newId;
                    Customer.previousQuantity(customer);
                    grid_NewProducts.Refresh();
                    customer.OrdersList = null;
                    customer.OrdersList = orderList;
                    customer.CustomerQuantity = totalQuantity;
                    customer.TotalBill = Customer.getCustomerBill(customer);
                    ProductsDL.storeStock(Program.path1);
                    CustomerDL.StoreCustomers(Program.path3);
                    customerForm.refreshGrid();
                    this.Close();
                }
                else
                {
                    lbl_Surprise.Text = "Add Order";
                }
            }
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);

        }
    }
}
