﻿using System.CodeDom.Compiler;
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

class Result
{

    //https://www.hackerrank.com/challenges/taum-and-bday/problem
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        if (wc - bc > z)
            return (long)b * bc + (long)w * (bc + z);
        if (bc - wc > z)
            return (long)b * (wc + z) + (long)w * wc;


        return (long)w * wc + (long)b * bc;
    }

}

class Solution
{
    public static void Main(string[] args)
    { 
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int b = Convert.ToInt32(firstMultipleInput[0]);

            int w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int bc = Convert.ToInt32(secondMultipleInput[0]);

            int wc = Convert.ToInt32(secondMultipleInput[1]);

            int z = Convert.ToInt32(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            Console.WriteLine(result + Environment.NewLine);
        }
        Console.ReadKey();
    }
}
