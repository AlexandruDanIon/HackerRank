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

    // https://www.hackerrank.com/challenges/acm-icpc-team/problem
    static int[] acmTeam(string[] topic)
    {
        var r = new int[2] { 0, 0 };

        for (int i = 0; i < topic.Length; i++)
        {
            for (int j = i+1; j < topic.Length; j++)
            {
                Add(topic[i], topic[j], ref r[0], ref r[1]);
            }
        }

        return r;
    }

    static void Add(string a, string b, ref int maxTopics, ref int teams)
    {
        int curTopics = 0;

        for (int i = 0; i < a.Length; i++)
        {

            curTopics += (a[i] == '1' || b[i] == '1') ? 1 : 0;
        }

        teams += curTopics == maxTopics ? 1 : 0;
        
        if (curTopics > maxTopics)
        {
            maxTopics = curTopics;
            teams = 1;
        }

    }

    static void Main(string[] args)
    {

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        string[] topic = new string[n];

        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic[i] = topicItem;
        }

        int[] result = acmTeam(topic);

        Console.WriteLine(string.Join("\n", result));

        Console.ReadKey();
    }
}
