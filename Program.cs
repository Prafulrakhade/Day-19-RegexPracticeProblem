using System;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n----------------WELCOME TO THE REGULAR EXPRESSION (REGEX) PROGRAM------------------------\n\n");
            while(true)
            {
                Console.Write("Enter User Password, should be Minimum 8 char: ");
                string password = Console.ReadLine();
                Console.WriteLine();
                string pass = "^[a-zA-Z 0-9]{8,}$";
                if (Regex.IsMatch(password, pass))
                {
                    Console.WriteLine("User Password is : " + password);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid password should be Minimum 8 char: " + "\n\n");
                }

            }  
        }
    }
}
