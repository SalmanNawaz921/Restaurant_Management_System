using Restaurant_Mangement_System.BL;
using System.Collections.Generic;
using System.IO;

namespace Restaurant_Mangement_System.DL
{
    class CredentialsDL
    {
        public static List<Credentials> usersList = new List<Credentials>();
        public static bool addUser(Credentials user, string path)
        {
            bool flag = false;
            foreach (Credentials u in usersList)
            {
                if (user.Role.ToUpper() == "MANAGER")
                {
                    if (u.UserPassword == user.UserPassword && u.UserName == user.UserName)
                    {
                        flag = false;
                        return flag;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            if (user.Role.ToUpper() == "CASHIER")
            {

                foreach (Cashier employee in Manager.Cashiers)
                {
                    if (employee.getUser().UserName == user.UserName && employee.getUser().UserPassword == user.UserPassword)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (flag == true)
            {
                usersList.Add(user);
                storeUser(path, user);
                return flag;
            }
            return flag;
        }
        public static void storeUser(string path, Credentials newUser)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (Credentials user in usersList)
            {
                writer.WriteLine(user.UserName + "," + user.UserPassword + "," + user.Role);
            }
            writer.Close();
        }
        public static void loadUser(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] userFields = line.Split(',');
                    Credentials newUser = new Credentials();
                    newUser.UserName = (userFields[0]);
                    newUser.UserPassword = (userFields[1]);
                    newUser.Role = (userFields[2]);
                    usersList.Add(newUser);
                }
                file.Close();
            }
        }
    }
}
