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
                Console.Write("Enter User Email ID : ");
                string name = Console.ReadLine();
                Console.WriteLine();
                string nm = "^[a-z]+.[a-z]+@?[a-z]+.(co|com|org)|.(in|us|co|com)$";  //(Ex. abc.xyz@bl.co.in) last .in is optional
                if (Regex.IsMatch(name, nm))
                {
                    Console.WriteLine("User Email ID is : " + name);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Email ID : \n\n Ex. abc.xyz@bl.co.in : " + "\n\n");
                }

            }  
        }
    }
}
