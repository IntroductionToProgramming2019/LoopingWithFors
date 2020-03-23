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
            int i = 0;
            int test_score = 0;
            Console.WriteLine("Please enter your score: ");
            test_score = int.Parse(Console.ReadLine());
            while (test_score != -999)
            {
                if (test_score < 0)
                {
                    Console.WriteLine("Error. Try again");
                }
                else if (test_score > 100 )
                {
                    Console.WriteLine("Error. Try again");
                }
                else
                {
                    i = i + 1;
                    total = total + test_score;
                }
             Console.WriteLine("Please enter your score: ");
             test_score = int.Parse(Console.ReadLine());
            }
            int average_test_score = total / i;
            Console.WriteLine("The average test score is {0}", average_test_score);
        }
    }
}


