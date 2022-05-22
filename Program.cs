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
                Console.Write("Enter User Mobile Number with Contry Code: ");
                string mobile = Console.ReadLine();
                Console.WriteLine();
                string mo = "^[9][1][ ]+[6-9][0-9]{9}$";
                if (Regex.IsMatch(mobile, mo))
                {
                    Console.WriteLine("User Mobile Number is : " + mobile);
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Valid mobile Number with Country Code : " + "\n\n");
                }

            }  
        }
    }
}
