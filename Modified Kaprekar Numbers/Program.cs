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

    // Complete the kaprekarNumbers function below.
    static void kaprekarNumbers(int p, int q)
    {
        bool invalid = true;
        string s;
        int h, r, l;

        if (p == 1)
        {
            Console.Write(1 + " " );
            p = 9;
            invalid = false;
        }


        for (int i = p; i <= q; i++)
        {
            s = Math.Pow(i, 2).ToString();
            h = (int)Math.Floor((decimal)s.Length / 2);
            r = int.Parse(s.Substring(0, h));
            l = int.Parse(s.Substring(h));

            if (r + l == i)
            {
                Console.Write(i + " ");
                invalid = false;
            }
        }

        if (invalid)
            Console.Write("INVALID RANGE");

    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());

        int q = Convert.ToInt32(Console.ReadLine());

        kaprekarNumbers(p, q);

        Console.ReadKey();
    }
}
