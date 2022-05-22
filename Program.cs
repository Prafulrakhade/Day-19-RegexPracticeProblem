using System;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n----------------WELCOME TO THE REGULAR EXPRESSION (REGEX) PROGRAM------------------------\n\n");
            while (true)
            {
                Console.Write("Enter User Email ID : ");
                string name = Console.ReadLine();
                Console.WriteLine();
                string nm = "^[A-Za-z0-9.+-]{1,}[a-zA-Z0-9]@[a-z0-9]{1,}.(co|org|com|in|us|net|au|com.com|com.au)$"; 
                if (Regex.IsMatch(name, nm))
                {
                    Console.WriteLine("User Email ID is : " + name);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Email ID  : " + "\n\n");
                }
            }
        }
    }
}