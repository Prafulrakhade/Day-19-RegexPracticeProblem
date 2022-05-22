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
                Console.WriteLine("Enter User Password, should be Minimum 8 char,at least one UpperCase, at least one Number: ");
                string password = Console.ReadLine();
                Console.WriteLine();
                string pass = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@&*!#$%])[0-9A-Za-z]{8,}$";
                if (Regex.IsMatch(password, pass))
                {
                    Console.WriteLine("User Password is : " + password);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid password\n should be Minimum 8 char,\n at least one UpperCase,\n at least one Number, one spaecial character: " + "\n\n");
                }
            }  
        }
    }
}