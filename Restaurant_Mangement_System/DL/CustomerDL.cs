using Restaurant_Mangement_System.BL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.DL
{
    class CustomerDL
    {
        private static List<Customer> sortedCustomersList = new List<Customer>();

        internal static List<Customer> SortedCustomersList { get => sortedCustomersList; set => sortedCustomersList = value; }


        public static Customer FindCustomer(int id)
        {
            Customer customer = Cashier.Customers.FirstOrDefault(e => e.CustomerId == id);
            return customer;
        }
        public static void RemoveCustomer(int id)
        {

            Customer customer = FindCustomer(id);
            if (customer != null)
            {
                foreach (Product item in customer.OrdersList)
                {
                    foreach (Product item1 in Manager.Products)
                    {
                        if (item.FoodName == item1.FoodName)
                        {
                            MessageBox.Show((item.FoodQuantity).ToString());
                            MessageBox.Show((item1.FoodQuantity).ToString());
                            int quantity = item.FoodQuantity + item1.FoodQuantity;
                            item1.FoodQuantity = quantity;
                            ProductsDL.storeStock(Program.path1);
                        }
                    }
                }
                MessageBox.Show("\n\tYOU HAVE REMOVED " + customer.CustomerName);
                Cashier.Customers.Remove(customer);
            }
            else
            {
                MessageBox.Show("Customer Not Found");
            }
        }
        public static void UpdateCustomerInfo(Product editedProduct, List<Product> orderList, int newQuantity, string text, int totalQuantity)
        {
            if (editedProduct != null)
            {
                if (newQuantity <= editedProduct.FoodQuantity)
                {

                    Product exist = orderList.FirstOrDefault(f => f.FoodName == editedProduct.FoodName);
                    editedProduct.FoodQuantity = (editedProduct.FoodQuantity - newQuantity);
                    //refreshGrid();
                    totalQuantity += newQuantity;
                    if (exist != null)
                    {
                        exist.FoodName = editedProduct.FoodName;
                        exist.FoodPrice = newQuantity * editedProduct.FoodPrice;
                        exist.FoodQuantity += newQuantity;
                    }
                    else
                    {
                        Product newProduct = new Product(editedProduct.FoodName, editedProduct.FoodPrice * newQuantity, newQuantity);
                        orderList.Add(newProduct);
                        text = "Product Added Successfully";

                    }
                }
                else
                {
                    text = editedProduct.FoodName + " not enough in stock";
                }
            }
            else
            {
                text = "Product Does Not Exists";

            }
        }

        public static List<Customer> sortedCustomers()
        {
            SortedCustomersList = Cashier.Customers.OrderBy(o => o.CustomerId).ToList();
            return SortedCustomersList;
        }

        public static void LoadCustomers(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] usersField = line.Split(',');
                string name = usersField[0];
                int id = int.Parse(usersField[1]);

                string[] orderDetails = usersField[2].Split(';');
                List<Product> orders = new List<Product>();

                foreach (string orderDetail in orderDetails)
                {
                    string[] orderData = orderDetail.Split(':');
                    string itemName = orderData[0];
                    int itemQuantity = int.Parse(orderData[2]);
                    int itemPrice = int.Parse(orderData[1]);

                    Product product = new Product(itemName, itemPrice, itemQuantity);
                    orders.Add(product);
                }

                int quantity = int.Parse(usersField[3]);
                int bill = int.Parse(usersField[4]);

                Customer customer = new Customer(name, id, orders, quantity, bill);
                Cashier.Customers.Add(customer);
            }

            file.Close();
        }

        /****************** STORE CUSTOMERS *****************/
        public static void StoreCustomers(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Customer customer in Cashier.Customers)
            {
                string orderNames = "";
                if (customer.OrdersList != null)
                {
                    for (int x = 0; x < customer.OrdersList.Count; x++)
                    {

                        if (x == customer.OrdersList.Count - 1)
                        {
                            orderNames += customer.OrdersList[x].FoodName + ":" + customer.OrdersList[x].FoodQuantity + ":" + customer.OrdersList[x].FoodPrice;
                        }
                        else
                        {
                            orderNames += customer.OrdersList[x].FoodName + ":" + customer.OrdersList[x].FoodQuantity + ":" + customer.OrdersList[x].FoodPrice + ";";
                        }

                    }
                    file.Write(customer.CustomerName + ",");
                    file.Write(customer.CustomerId + ",");
                    file.Write(orderNames + ",");
                    file.Write(customer.CustomerQuantity + ",");
                    file.Write(customer.TotalBill + "\n");
                }


            }
            file.AutoFlush = true;
            file.Close();
        }
    }
}
