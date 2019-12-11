using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr)
    {
        var d = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (d.ContainsKey(arr[i]))
            {
                d[arr[i]]++;
            }
            else
            {
                d.Add(arr[i], 1);
            }

        }

        return d.Values.Sum() - d.Values.Max();
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = equalizeArray(arr);

        Console.WriteLine(result);

    }
}
