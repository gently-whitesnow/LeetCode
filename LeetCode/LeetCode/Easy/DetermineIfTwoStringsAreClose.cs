using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;
        
        HashSet<char> s1 = new(), s2 = new();
        int[] freq1 = new int [26], freq2 = new int[26];
        for (int i = 0; i < word1.Length; i++)
        {
            s1.Add(word1[i]);
            s2.Add(word2[i]);

            freq1[word1[i]-'a']++;
            freq2[word2[i]-'a']++;
        }

        if (!s1.SetEquals(s2))
            return false;

        return freq1.OrderBy(c=>c).SequenceEqual(freq2.OrderBy(c=>c));
    }

    public void Test()
    {
        Console.WriteLine(CloseStrings("cabbba","abbccc"));
    }
}