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

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int average = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Enter your test score: ");
                int test_score = int.Parse(Console.ReadLine());
                total = total + test_score;
                average = total / i;
            }
            Console.WriteLine();
            Console.WriteLine("The average score is {0}", average);
        }
    }
}
