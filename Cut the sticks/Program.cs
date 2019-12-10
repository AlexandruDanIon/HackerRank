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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr)
    {
        var l = arr.ToList();
        var r = new List<int>();
        var m = l.Min();
        

        while(l.Count > 0)
        {
            r.Add(l.Count);
            l.RemoveAll(o => o == m);
           
            for (int i = 0; i < l.Count; i++)
            {
                l[i] -= m;
            }
            m = l.Count() > 0 ? l.Min() : 0 ;
        }

        return r.ToArray();
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))        ;
        int[] result = cutTheSticks(arr);

        Console.WriteLine(string.Join("\n", result));

        Console.ReadKey();

    }
}
