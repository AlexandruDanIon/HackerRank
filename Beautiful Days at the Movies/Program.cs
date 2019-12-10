using System;
using System.Diagnostics;

internal class Solution
{
    // Complete the beautifulDays function below.
    private static int BeautifulDays(int i, int j, int k)
    {
        int res = 0;

        for (int a = i; a <= j; a++)
        {
            int n = a;
            int r = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                r = (r * 10) + remainder;
                n /= 10;
            }

            if ((a - r) % k == 0)
                res++;
        }

        return res;
    }

    private static void Main(string[] args)
    {
        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        var sw = new Stopwatch();
        sw.Start();
        int result = BeautifulDays(i, j, k);
        sw.Stop();
        Console.WriteLine(result + Environment.NewLine + sw.ElapsedMilliseconds);
        Console.ReadKey();
    }
}