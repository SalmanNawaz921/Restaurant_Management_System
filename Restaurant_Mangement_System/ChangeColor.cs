//using System.Drawing;
//using System.Drawing.Imaging;

//namespace Restaurant_Mangement_System
//{
//    class ChangeColor
//    {

//        public static void ChangeImageColor(Image originalImage, Color newColor)
//        {
//            // Create a new color matrix
//            ColorMatrix colorMatrix = new ColorMatrix();

//            // Set the color matrix values for changing color
//            colorMatrix.Matrix00 = newColor.R / 255f;
//            colorMatrix.Matrix11 = newColor.G / 255f;
//            colorMatrix.Matrix22 = newColor.B / 255f;

//            // Create an image attributes object and set the color matrix
//            ImageAttributes imageAttributes = new ImageAttributes();
//            imageAttributes.SetColorMatrix(colorMatrix);

//            // Create a destination rectangle for the modified image
//            Rectangle destRect = new Rectangle(0, 0, originalImage.Width, originalImage.Height);

//            // Create a graphics object and draw the modified image
//            using (Graphics graphics = Graphics.FromImage(originalImage))
//            {
//                graphics.DrawImage(originalImage, destRect, 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, imageAttributes);
//            }
//        }

//        public static Image originalImage = Image.FromFile("Assets\\customers.png"); // Replace with the path to your image file
//        public static Image home = Image.FromFile("Assets\\home.png"); // Replace with the path to your image file
//        public static Image restaurant = Image.FromFile("Assets\\restaurants.png"); // Replace with the path to your image file
//        public static Image logout = Image.FromFile("Assets\\logout.png"); // Replace with the path to your image file
//        public static Image analytics = Image.FromFile("Assets\\analytics.png"); // Replace with the path to your image file
//        public static Image manager = Image.FromFile("Assets\\manager.png"); // Replace with the path to your image file
//        public static Image employee = Image.FromFile("Assets\\employee.png"); // Replace with the path to your image file
//        public static Image product = Image.FromFile("Assets\\cooks.png"); // Replace with the path to your image file
//        public static Image menu = Image.FromFile("Assets\\menu-list.png"); // Replace with the path to your image file

//        // Change the color of the image

//        public static Image getImage(string name)
//        {
//            if (name == "Home")
//            {
//                ChangeImageColor(home, Color.FromArgb(122, 67, 47));
//                return home;
//            }
//            else if (name == "Customers")
//            {
//                ChangeImageColor(originalImage, Color.FromArgb(122, 67, 47));
//                return originalImage;

//            }
//            else if (name == "Restaurants")
//            {

//                ChangeImageColor(restaurant, Color.FromArgb(122, 67, 47));
//                return restaurant;
//            }

//            else if (name == "logout")
//            {

//                ChangeImageColor(logout, Color.FromArgb(122, 67, 47));
//                return logout;
//            }
//            else if (name == "analytics")
//            {

//                ChangeImageColor(analytics, Color.FromArgb(122, 67, 47));
//                return analytics;
//            }
//            else if (name == "employee")
//            {
//                ChangeImageColor(employee, Color.FromArgb(122, 67, 47));
//                return employee;
//            }
//            else if (name == "manager")
//            {
//                ChangeImageColor(manager, Color.FromArgb(122, 67, 47));
//                return manager;
//            }
//            else if (name == "product")
//            {
//                ChangeImageColor(product, Color.FromArgb(122, 67, 47));
//                return product;
//            }
//            else if (name == "menu")
//            {
//                ChangeImageColor(menu, Color.FromArgb(122, 67, 47));
//                return menu;
//            }
//            return originalImage;
//        }
//    }
//}
