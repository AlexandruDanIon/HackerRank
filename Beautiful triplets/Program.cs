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
    // Complete the beautifulTriplets function below.
    private static int beautifulTriplets(int d, int[] arr)
    {
        var r = 0;
        var l = arr.Length;

        for (int i = 0; i < l; i++)
        {
            for (int j = i + 1; j < l; j++)
            {
                if (arr[j] - arr[i] == d)
                {
                    for (int k = j + 1; k < l; k++)
                    {
                        if (arr[k] - arr[j] == d)
                        {
                            r++;
                        }
                    }
                }
            }
        }
        return r;
    }

    private static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = beautifulTriplets(d, arr);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}