using System;

internal class Solution
{
    // https://www.hackerrank.com/challenges/halloween-sale/problem
    private static int howManyGames(int p, int d, int m, int s)
    {
        if (p > s)
            return 0;
        if (p - d > s - p)
            return 1;

        var o = 1 + (int)Math.Floor((double)(p - m) / d);
        var c = o * (2 * p - (o - 1) * d) / 2;
        if (s >= c)
            o += (int)Math.Floor((double)(s - c) / m);

        return o;
    }

    private static void Main(string[] args)
    {
        string[] pdms = Console.ReadLine().Split(' ');

        int p = Convert.ToInt32(pdms[0]);

        int d = Convert.ToInt32(pdms[1]);

        int m = Convert.ToInt32(pdms[2]);

        int s = Convert.ToInt32(pdms[3]);

        int answer = howManyGames(p, d, m, s);

        Console.WriteLine(answer);

        Console.ReadKey();
    }
}