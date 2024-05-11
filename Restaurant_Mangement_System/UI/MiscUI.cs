using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System.UI
{
    class MiscUI
    {
        public static string NameValidation()
        {
            string name = Console.ReadLine();
            bool invalid = true;
            while (invalid || string.IsNullOrWhiteSpace(name))
            {
                invalid = false;
                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]) && name[i] != ' ')
                    {
                        invalid = true;
                        break;
                    }
                }
                if (invalid == true || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("\tENTER VALID NAME: ");
                    //name = Console.ReadLine();
                }
            }
            return name;
        }

        public static int ValidateInteger()
        {
            string number = Console.ReadLine();
            bool flag = false;
            while (!flag)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] > '9' || number[i] < '0')
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("\tEnter Valid Integer: ");
                    //number = Console.ReadLine();
                }
            }
            return int.Parse(number);
        }
    }
}