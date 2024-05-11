using System.Collections.Generic;

namespace Restaurant_Mangement_System.BL
{
    class Cashier : Employee
    {
        private int cashierSalary = 0;

        public Cashier()
        {

        }
        public Cashier(int cashierSalary, Credentials user) : base(user)
        {
            this.user = user;
            this.CashierSalary = cashierSalary;
        }

        private static List<Customer> customers = new List<Customer>();

        public int CashierSalary { get => cashierSalary; set => cashierSalary = value; }
        public static List<Customer> Customers { get => customers; set => customers = value; }

        public static void addCustomer(Customer customer)
        {
            if (customer != null)
            {
                Customers.Add(customer);
            }
            else
            {
                return;
            }
        }
        public override string toString()
        {
            return $"{base.toString()}{getUser().UserId,-20}{CashierSalary,-20}";
        }

    }
}
