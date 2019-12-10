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
using System.Diagnostics;

internal class Solution
{
    // Complete the findDigits function below.
    private static int FindDigits(int n)
    {
        return n.ToString().ToCharArray().Where(o => n % char.GetNumericValue(o) == 0).Count();
    }

    private static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());
        var sw = new Stopwatch();
        sw.Start();

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = FindDigits(n);

            Console.WriteLine(result);
        }

        sw.Stop();

        Console.WriteLine(Environment.NewLine + " " + sw.ElapsedMilliseconds);

        Console.ReadKey();
    }
}