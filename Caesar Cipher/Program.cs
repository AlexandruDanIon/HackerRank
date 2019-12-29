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

    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k)
    {
        var result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                result += GetChar(s[i], k).ToString();
            }
            else
                result += s[i];
        }


        return result;
    }

    private static char GetChar(char ch, int k)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        var low = char.IsLower(ch);
        var letter = char.ToLower(ch);
        var index = alphabet.IndexOf(letter);

        if (index + k > 25)
        {
            return low ? alphabet[(index + k) % 26] : char.ToUpper(alphabet[(index + k) % 26]);
        }
        else
        {
            return low ? alphabet[index + k] : char.ToUpper(alphabet[index + k]);
        }

    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher(s, k);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}
