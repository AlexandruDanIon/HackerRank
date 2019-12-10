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

class Solution
{

    // Complete the libraryFine function below.
    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (new DateTime(y2, m2, d2) > new DateTime(y1, m1, d1))
            return 0;

        if (y2 < y1)
            return 10000;
        else
        {
            if (m2 < m1)
                return (m1 - m2) * 500;
            {
                if (d2 < d1)
                    return (d1 - d2) * 15;
            }
        }

        return 0;
    }

    static void Main(string[] args)
    {

        string[] d1M1Y1 = Console.ReadLine().Split(' ');

        int d1 = Convert.ToInt32(d1M1Y1[0]);

        int m1 = Convert.ToInt32(d1M1Y1[1]);

        int y1 = Convert.ToInt32(d1M1Y1[2]);

        string[] d2M2Y2 = Console.ReadLine().Split(' ');

        int d2 = Convert.ToInt32(d2M2Y2[0]);

        int m2 = Convert.ToInt32(d2M2Y2[1]);

        int y2 = Convert.ToInt32(d2M2Y2[2]);

        var sw = new Stopwatch();
        int result = 0;
        sw.Start();
        for (int i = 0; i < 10000000; i++)
        {

            result = libraryFine(d1, m1, y1, d2, m2, y2);
        }

        sw.Stop();

        Console.WriteLine(result + Environment.NewLine + sw.ElapsedMilliseconds);

        Console.ReadKey();
    }
}
