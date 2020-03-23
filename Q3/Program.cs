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

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int c;
            Console.WriteLine("Enter the first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for ( c = a; c<= b ; c++)
            {
                Console.WriteLine(c);
                total = total + c;
            }
            Console.WriteLine();
            Console.WriteLine("the sum of all the values between {0} and {1} is {2}", a, b, total);
        }
    }
}
