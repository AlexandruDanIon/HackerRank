using System.IO;
using System;

internal class Solution
{
    // Complete the circularArrayRotation function below.
    private static int[] circularArrayRotation(int[] a, int k, int[] queries)
    {
        var r = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            r[i] = a[a.Length - 1 - k + i];
        }
        return r;
    }

    private static void Main(string[] args)
    {
        string[] nkq = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkq[0]);

        int k = Convert.ToInt32(nkq[1]);

        int q = Convert.ToInt32(nkq[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] queries = new int[q];

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = circularArrayRotation(a, k, queries);

        Console.WriteLine(string.Join("\n", result));
    }
}