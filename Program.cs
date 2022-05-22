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
                Console.WriteLine("Enter Your First Name : ");
                string name = Console.ReadLine();
                string nm = "^[A-Z][a-z]{2,}$";
                if (Regex.IsMatch(name, nm))
                {
                    Console.WriteLine("Your Name is : " + name);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter First name start with Capital and minimum Three characters : " +false);
                }
            }  
        }
    }
}
