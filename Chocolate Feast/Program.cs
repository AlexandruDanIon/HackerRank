using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

internal class Solution
{
    // Complete the chocolateFeast function below.
    private static int chocolateFeast(int n, int c, int m)
    {
        var f = n / c;
        var r = f;

        while (f >= m)
        {
            var t = (int)Math.Floor((double)f / m);
            f -= t;
            r += t;
        }

        return r;
    }

    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] ncm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(ncm[0]);

            int c = Convert.ToInt32(ncm[1]);

            int m = Convert.ToInt32(ncm[2]);

            int result = chocolateFeast(n, c, m);

            Console.WriteLine(result);
        }
        Console.ReadKey();
    }
}