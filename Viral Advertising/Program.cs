using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viral_Advertising
{
    internal class Program
    {
        /// <summary>
        /// Solution for this: https://www.hackerrank.com/challenges/strange-advertising/problem
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(ViralAdvertising(Convert.ToInt32(Console.ReadLine())));
        }

        private static int ViralAdvertising(int n)
        {
            int r = 0, x = 5;
            for (int i = 0; i < n; i++)
            {
                r += x / 2;
                x = x / 2 * 3;
            }

            return r;
        }
    }
}