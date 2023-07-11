using System;

namespace LeetCode.Medium.Strings;

public class LongestPalindromicSubstring
{
    public string Solve(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            return s;

        var offset = 1;
        var startingIndex = 0;
        var maxLen = 0;
        while (s.Length - offset > 0)
        {
            for (var i = 0; i < s.Length - offset; i++)
            {
                if (!IsPalindromic(ref s, i, i + offset)) 
                    continue;

                startingIndex = i;
                maxLen = offset + 1;
                i = -1;
                offset++;
            }
            offset++;
        }
        
        return s.Substring(startingIndex, maxLen);

        bool IsPalindromic(ref string inputString, int min, int max)
        {
            var median = (max + min) / 2;
            for (var i = min; i <= median; i++)
            {
                if (inputString[i] != inputString[max])
                    return false;
                max--;
            }

            return true;
        }
    }

    public void Test()
    {
        Console.WriteLine(Solve("aabaa")); // aabaa
        Console.WriteLine(Solve("aabbaa")); // aabbaa
        Console.WriteLine(Solve("cbbd")); // bb 
    }
}