/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : Looping with Fors
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Password";
            Console.Write("Please enter your password: ");
            string passwordAttempt = Console.ReadLine();
            if (passwordAttempt != password)
            {
                while( password != passwordAttempt)
                {
                    Console.WriteLine("Incorrect password. Try again: ");
                    passwordAttempt = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Password correct");
        }
    }
}