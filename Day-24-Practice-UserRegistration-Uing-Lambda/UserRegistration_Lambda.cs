using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_24_Practice_UserRegistration_Uing_Lambda
{
    public class UserRegistration_Lambda
    {
        public void Validate()
        {
            string[] RegexPattern = new string[6];

            //For First name
            RegexPattern[0] = "^[A-Z]{1}[a-z]{2}[a-z]*";

            //For Last Name
            RegexPattern[1] = "^[A-Z]{1}[a-z]{2}[a-z]*";

            //For Email id
            RegexPattern[2] = "[a-zA-Z0-9_\\-\\.]+[@][a-z]+[\\.][a-z]{2,3}";

            //For Phone Number
            RegexPattern[3] = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}?";

            //For Password
            RegexPattern[4] = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

            string[] UserInput = new string[6];

            //Geting User in
            Console.WriteLine("Enter First Name:");
            UserInput[0] = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            UserInput[1] = Console.ReadLine();

            Console.WriteLine("Enter Email Id:");
            UserInput[2] = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            UserInput[3] = Console.ReadLine();

            Console.WriteLine("Enter passward:");
            UserInput[4] = Console.ReadLine();

            Console.WriteLine("\nResults are: ");
            //Lambda Expression
            for (int i = 0; i < 5; i++)
            {
                Func<string, bool> nameValidater = UserInput => Regex.IsMatch(UserInput, RegexPattern[i]);
                bool result = nameValidater(UserInput[i]);
                Console.WriteLine(($"{i + 1} {UserInput[i]} : {result}"));

            }

        }
    }
}
