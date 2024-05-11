using System.Collections.Generic;

namespace Restaurant_Mangement_System.BL
{
    class Manager : Employee
    {
        private static List<Cashier> cashiers = new List<Cashier>();
        private static List<Product> products = new List<Product>();

        public static List<Cashier> Cashiers { get => cashiers; set => cashiers = value; }
        public static List<Product> Products { get => products; set => products = value; }

        public static void addCashier(Cashier emp)
        {
            if (emp != null)
            {
                Cashiers.Add(emp);
            }
            else
            {
                return;
            }
        }
        public static void addProduct(Product product)
        {
            if (product != null)
            {
                Products.Add(product);
            }
            else
            {
                return;
            }
        }
        public Manager()
        {

        }
        public Manager(Credentials user) : base(user)
        {
            this.user = user;
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
