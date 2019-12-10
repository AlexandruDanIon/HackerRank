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

class Solution
{

    // Complete the squares function below.
    static int Squares(int a, int b)
    {
        int S = (int)Math.Ceiling(Math.Sqrt(a));
        int E = (int)Math.Floor(Math.Sqrt(b));

        return E - S + 1;
    }

    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            int result = Squares(a, b);

            Console.WriteLine(result);
        }

        Console.ReadKey();
    }
}
