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

    // https://www.hackerrank.com/challenges/acm-icpc-team/problem
    static int[] acmTeam(string[] topic)
    {
        var r = new int[2] { 0, 0 };
        var l = topic.Length;
        var l2 = topic[0].Length;

        for (int i = 0; i < l; i++)
        {
            for (int j = i + 1; j < l; j++)
            {
                int curTopics = 0;

                for (int k = 0; k < l2; k++)
                {

                    curTopics += (topic[i][k] == '1' || topic[j][k] == '1') ? 1 : 0;
                }

                r[1] += curTopics == r[0] ? 1 : 0;

                if (curTopics > r[0])
                {
                    r[0] = curTopics;
                    r[1] = 1;
                }
            }
        }

        return r;
    }

    static void Main(string[] args)
    {
        string[] nm, topic;
        int n, m;

        using (StreamReader reader = new StreamReader(@"C:\input.txt"))
        {
            nm = reader.ReadLine().Split(' ');
            n = Convert.ToInt32(nm[0]);
            m = Convert.ToInt32(nm[1]);
            topic = new string[n];
            for (int i = 0; i < n; i++)
            {
                string topicItem = reader.ReadLine();
                topic[i] = topicItem;
            }
        }

        var sw = new Stopwatch();
        sw.Start();
        int[] result = acmTeam(topic);
        sw.Stop();


        Console.WriteLine(string.Join("\n", result) + Environment.NewLine + sw.ElapsedMilliseconds);

        Console.ReadKey();
    }
}
