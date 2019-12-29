using System;

internal class Solution
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        Console.WriteLine(result);

        Console.ReadKey();
    }

    // https://www.hackerrank.com/challenges/minimum-distances/problem
    private static int minimumDistances(int[] a)
    {
        var l = a.Length;
        var r = l * 2;

        for (int i = 0; i < l; i++)
        {
            for (int j = i + 1; j < l; j++)
            {
                if (a[i] == a[j] && r > j - i)
                {
                    r = j - i;
                }
            }
        }

        return r == l * 2 ? -1 : r;
    }
}