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
                Console.WriteLine("Enter User Password, should be Minimum 8 char,at least one UpperCase: ");
                string password = Console.ReadLine();
                Console.WriteLine();
                string pass = "[A-Za-z]+[A-Za-z]{7,}";
                if (Regex.IsMatch(password, pass))
                {
                    Console.WriteLine("User Password is : " + password);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid password should be Minimum 8 char, at least one UpperCase: " + "\n\n");
                }

            }  
        }
    }
}
