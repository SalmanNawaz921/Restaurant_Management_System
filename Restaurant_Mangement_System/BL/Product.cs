namespace Restaurant_Mangement_System.BL
{
    class Product
    {
        private string foodName = "";
        private int foodPrice;
        private int foodQuantity;
        private int initialQuantity = 0;
        public Product()
        {
            FoodName = "No Name";
            FoodPrice = 0;
            FoodQuantity = 0;
        }

        public Product(string name, int price, int quantity)
        {
            FoodName = name;
            FoodPrice = price;
            FoodQuantity = quantity;
            InitialQuantity = quantity;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int FoodPrice { get => foodPrice; set => foodPrice = value; }
        public int FoodQuantity { get => foodQuantity; set => foodQuantity = value; }
        public int InitialQuantity { get => initialQuantity; set => initialQuantity = value; }

        public static string getAllNames()
        {
            string names = "";
            foreach (Product item in Manager.Products)
            {
                names += item.foodName + "\n";
            }
            return names;
        }

        public string toString()
        {
            return ($"{FoodName,-20}{FoodPrice,-15}" +
                                  $"{FoodQuantity,-20}");
        }


        public static int totalSoldQuantity()
        {
            int total = 0;
            foreach (Product item in Manager.Products)
            {
                total += item.InitialQuantity - item.FoodQuantity;
            }
            return total;

        }
        public static int totalQuantity()
        {
            int total = 0;
            foreach (Product item in Manager.Products)
            {
                total += item.InitialQuantity;
            }
            return total;
        }


    }
}
