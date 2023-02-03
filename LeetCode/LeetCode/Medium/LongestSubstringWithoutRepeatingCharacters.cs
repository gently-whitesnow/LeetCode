using System;

namespace LeetCode.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    int Solve(string s)
    {
        var news = "";
        var counter = 0;
        foreach (var c in s)
        {
            if (!news.Contains(c))
            {
                news += c;
            }
            else
            {
                counter = Math.Max(counter, news.Length);
                var i = news.IndexOf(c);
                news = news.Substring(i+1, news.Length-i-1);
                news =news+ c;
            }
        }

        return Math.Max(counter, news.Length);;
    }

    

    public void Test()
    {
        // test
        var str = " ";
        var result = Solve(str);
        Console.WriteLine(result);
    }
}