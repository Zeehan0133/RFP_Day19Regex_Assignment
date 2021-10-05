using System;
using System.Text.RegularExpressions;


namespace Day19_Regex_Ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Method pattern = new Method();
            UserInput user = new UserInput();

            Console.WriteLine("Enter First name :");
            user.Fname = Console.ReadLine();
            Console.WriteLine(pattern.validFirstName(user.Fname));

            Console.WriteLine("Enter Last name :");
            user.Lname = Console.ReadLine();
            Console.WriteLine(pattern.validLastName(user.Lname));

            Console.WriteLine("Enter Email :");
            user.Email = Console.ReadLine();
            Console.WriteLine(pattern.validEmail(user.Email));

            Console.WriteLine("Enter Mobile number:");
            user.MobileNum = Console.ReadLine();
            Console.WriteLine(pattern.validMobileNum(user.MobileNum));

            Console.WriteLine("Enter a password :");
            user.Passwd = Console.ReadLine();
            Console.WriteLine(pattern.validPassword(user.Lname));

        }
    }
}
