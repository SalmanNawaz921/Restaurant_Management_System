using Restaurant_Mangement_System.DL;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.BL
{
    class Customer
    {
        private string customerName = "";
        private int customerId;
        private int customerQuantity;
        private int totalBill;

        private List<Product> ordersList = new List<Product>();
        private static List<Customer> customers = new List<Customer>();
        public string CustomerName { get => customerName; set => customerName = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int CustomerQuantity { get => customerQuantity; set => customerQuantity = value; }
        public int TotalBill { get => totalBill; set => totalBill = value; }
        public List<Product> OrdersList { get => ordersList; set => ordersList = value; }
        internal static List<Customer> Customers { get => customers; set => customers = value; }

        public void AddInOrderList(Product order)
        {
            OrdersList.Add(order);
        }
        public void UpdateOrder(string orderToUpdate, int newQuantity, int newPrice)
        {
            Product order = OrdersList.Find(o => o.FoodName == orderToUpdate);
            if (order != null)
            {
                int index = OrdersList.IndexOf(order);
                order.FoodName = (orderToUpdate);
                order.FoodQuantity = (newQuantity);
                order.FoodPrice = (newPrice);
                string name = order.FoodName;
                int quantity = order.FoodQuantity;
                int price = order.FoodPrice;
                OrdersList.Insert(index, new Product(name, quantity, price));
                MessageBox.Show("Order '{0}' updated successfully!", orderToUpdate);
            }
            else
            {
                MessageBox.Show("Error: Order '{0}' not found for the customer.", orderToUpdate);
            }
        }

        public string getAllOrders()
        {
            string orderName = "";
            if (OrdersList != null)
            {
                for (int i = 0; i < OrdersList.Count; i++)
                {
                    if (i < OrdersList.Count - 1)
                    {

                        orderName = orderName + OrdersList[i].FoodName + ",";
                    }
                    else
                    {
                        orderName = orderName + OrdersList[i].FoodName;
                    }
                }
            }
            return orderName;
        }

        public Customer()
        {
            CustomerName = "No Name";
            this.OrdersList = null;
            CustomerId = 0;
            CustomerQuantity = 0;
            TotalBill = 0;
        }
        public Customer(string name, int id, List<Product> orderList, int quantity, int bill)
        {
            CustomerName = name;
            this.OrdersList = orderList;
            CustomerId = id;
            CustomerQuantity = quantity;
            TotalBill = bill;
            Customers.Add(this);
        }

        public new string toString()
        {

            return $"{CustomerName,-20}{CustomerId,-20}{getAllOrders(),-20}{CustomerQuantity,-20}{TotalBill,-20}";

        }
        public static void previousQuantity(Customer customer)
        {

            foreach (Product item in customer.OrdersList)
            {
                foreach (Product item1 in Manager.Products)
                {
                    if (item.FoodName == item1.FoodName)
                    {
                        int quantity = item.FoodQuantity + item1.FoodQuantity;
                        item1.FoodQuantity = quantity;
                        ProductsDL.storeStock(Program.path1);
                    }
                }
            }

        }

        public static int getCustomerBill(Customer customer)
        {
            int total = 0;
            foreach (Product item in customer.ordersList)
            {
                total += item.FoodPrice;
            }
            return total;
        }
        public static int AllOrders()
        {
            int count = 0;
            foreach (Customer customer in Customers)
            {
                foreach (Product item in customer.OrdersList)
                {
                    Product exist = Manager.Products.FirstOrDefault(f => f.FoodName == item.FoodName);
                    if (exist != null)
                    {
                        count++;
                    }

                }
            }
            return count;
        }

        public static int TotalRevenue()
        {
            int total = 0;
            foreach (Customer customer in Customer.Customers)
            {
                total += customer.TotalBill;
            }
            return total;
        }

        public static List<Product> HotItems()
        {
            List<Product> products = new List<Product>();

            foreach (Customer customer in Customers)
            {
                foreach (Product item in customer.ordersList)
                {
                    Product product = products.FirstOrDefault(e => e.FoodName == item.FoodName);
                    if (product == null)
                    {
                        products.Add(item);
                    }
                }
            }

            return products;

        }

        public static int Orders()
        {
            int count = 0;
            foreach (Customer customer in Customers)
            {
                if (customer.OrdersList.Count > 1)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PendingOrders()
        {
            int count = 0;
            foreach (Customer customer in Cashier.Customers)
            {

                count++;

            }
            return count;
        }
    }
}
