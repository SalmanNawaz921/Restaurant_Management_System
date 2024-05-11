using Restaurant_Mangement_System.DL;
namespace Restaurant_Mangement_System.BL
{
    class Credentials
    {
        protected string userName = "";
        protected string userPassword = "";
        protected int userId = 0;
        protected string role = "";

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Role { get => role; set => role = value; }

        public Credentials()
        {
        }

        public Credentials(string userName, int userId, string userPassword, string role)
        {
            this.UserName = userName;
            this.UserId = userId;
            this.UserPassword = userPassword;
            this.Role = role;
        }
        public Credentials(string userName, string userPassword, string role)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.Role = role;
        }
        public Credentials(string userName, int userId, string userPassword)
        {
            this.UserName = userName;
            this.UserId = userId;
            this.UserPassword = userPassword;
        }
        public Credentials(string userName, string userPassword)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
        }
        public Credentials(int userId)
        {
            this.UserId = userId;
        }
        public static string validUser(Credentials existingUser)
        {
            string name = "";
            foreach (Credentials user in CredentialsDL.usersList)
            {
                foreach (Employee cashier in Manager.Cashiers)
                {
                    if (cashier.getUser().UserId == existingUser.UserId)
                    {
                        name = cashier.getUser().UserName;
                    }
                }
                if ((user.UserName == existingUser.UserName && user.UserPassword == existingUser.UserPassword) || user.UserName == name)
                {
                    existingUser.UserName = user.UserName;
                    existingUser.UserPassword = user.UserPassword;
                    return user.Role;
                }

            }
            return "User Not Found";
        }

        public virtual string toString()
        {
            return $"{UserName,-25}";
        }
    }
}
