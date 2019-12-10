using System.Linq;
using System;

class Solution
{

    static int[] PermutationEquation(int[] p)
    {
        var y = new int[p.Length];

        for (int i = 1; i <= p.Length; i++)
        {
            y[i - 1] = Array.IndexOf(p, Array.IndexOf(p, i) + 1) + 1 ;
        }

        return y;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = PermutationEquation(p);

        Console.WriteLine(string.Join("\n", result));

        Console.ReadKey();

    }
}
