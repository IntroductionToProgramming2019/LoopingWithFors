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
            int i;
            string password = "Password";
            Console.Write("Please enter your password: ");
            string passwordAttempt = Console.ReadLine();
            if (passwordAttempt != password)
            {
                for (i = 1; i < 6; i++)
                {
                    Console.WriteLine("Incorrect password. Try again: ");
                    passwordAttempt = Console.ReadLine();
                }
                Console.WriteLine("You have been locked out!");
            }
            else
            {
                Console.WriteLine("Password Correct");
            }
        }
    }
}