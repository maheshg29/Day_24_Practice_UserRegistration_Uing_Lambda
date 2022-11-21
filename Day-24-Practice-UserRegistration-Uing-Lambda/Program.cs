
using System.Linq.Expressions;

namespace Day_24_Practice_UserRegistration_Uing_Lambda
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 24 UserRegistration using  LambdaExpression!");
            UserRegistration_Lambda userRegistration_Lambda = new UserRegistration_Lambda();
            userRegistration_Lambda.Validate();
        }
    }
}
