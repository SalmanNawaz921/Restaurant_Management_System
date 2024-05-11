using Restaurant_Mangement_System.BL;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.DL
{
    class CashierDL
    {
        public static Cashier FindCashier(int id)
        {
            Cashier employee = Manager.Cashiers.FirstOrDefault(e => e.getUser().UserId == id);
            return employee;
        }
        public static void FireCashier(int id)
        {

            Cashier employee = FindCashier(id);
            if (employee != null)
            {
                Manager.Cashiers.Remove(employee);
            }

        }
        public static void UpdateInfo(Cashier editedCashier)
        {
            int id = 0;
            Cashier employee = FindCashier(id);
            if (employee != null)
            {
                int index = Manager.Cashiers.IndexOf(employee);
                Cashier updateCashier = editedCashier;
                if (updateCashier != null)
                {
                    string name = employee.getUser().UserName;
                    updateCashier.getUser().UserName = (name);
                    Manager.Cashiers.RemoveAt(index);
                    Manager.Cashiers.Insert(index, updateCashier);
                }
            }
            else
            {
                return;
            }
        }

        public static void storeCashier(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (Cashier emp in Manager.Cashiers)
            {
                file.WriteLine(emp.getUser().UserName + "," + (emp.getUser().UserId) + "," + (emp.CashierSalary) + "," + emp.getUser().UserPassword);
            }
            file.Close();

        }
        public static void loadCashier(string path)
        {

            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] userFields = line.Split(',');
                    string name = userFields[0];
                    int id = int.Parse(userFields[1]);
                    int salary = int.Parse(userFields[2]);
                    string password = userFields[3];
                    Cashier employee = new Cashier(salary, new Credentials(name, id, password));
                    Manager.addCashier(employee);
                }
                file.Close();
            }
            else
            {
                MessageBox.Show("File Not Exists");
            }
        }
    }
}
