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

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i);
                total = total + i;
            }
            Console.WriteLine(total);
        }
    }
}
