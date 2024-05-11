using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.DL
{
    class ProductsDL
    {
        private static List<Product> sortedList = new List<Product>();

        internal static List<Product> SortedList { get => sortedList; set => sortedList = value; }

        public static Product SearchItem(string name)
        {

            Product product = Manager.Products.Find(e => e.FoodName == name);
            return product;
        }
        public static void RemoveItem(string name)
        {

            Product product = SearchItem(name);
            if (product != null)
            {
                MessageBox.Show($"\n\tYOU HAVE REMOVED {product.FoodName}");
                Manager.Products.Remove(product);
            }
            else
            {
                MessageBox.Show("Product Not Found");
            }
        }
        public static List<Product> sortProducts()
        {
            MessageBox.Show("1. PRICE LOW TO HIGH");
            MessageBox.Show("2. PRICE HIGH TO LOW");
            Console.Write("    YOUR OPTION: ");
            int option = MiscUI.ValidateInteger();
            if (option == 1)
            {
                SortedList = Manager.Products.OrderBy(o => o.FoodPrice).ToList();
            }
            else if (option == 2)
            {
                SortedList = Manager.Products.OrderByDescending(o => o.FoodPrice).ToList();
            }
            else
            {
                SortedList = Manager.Products;
            }
            return SortedList;

        }
        public static void UpdateStock(string name, int price, int quanity)
        {
            foreach (Product item in Manager.Products)
            {
                if (name == item.FoodName)
                {

                    item.FoodPrice = price;
                    item.FoodQuantity = quanity;
                    item.InitialQuantity = quanity;
                    storeStock(Program.path1);
                    break;
                }

            }
        }

        public static void loadStock(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] userFields = line.Split(',');
                    string name = userFields[0];
                    int price = int.Parse(userFields[1]);
                    int quantity = int.Parse(userFields[2]);
                    Product product = new Product(name, price, quantity);
                    product.InitialQuantity = int.Parse(userFields[3]);
                    Manager.Products.Add(product);
                }
                file.Close();
            }
            else
            {
                MessageBox.Show("Path Not Found");
            }
        }

        //****************** STORE STOCK *****************

        public static void storeStock(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Product product in Manager.Products)
            {

                file.WriteLine(product.FoodName + "," + product.FoodPrice + "," + product.FoodQuantity + "," + product.InitialQuantity);
            }
            file.Flush();
            file.Close();
        }
    }
}
