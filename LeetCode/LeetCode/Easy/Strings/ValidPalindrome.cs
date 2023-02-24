using System;
using System.Linq;

namespace LeetCode.Easy.Strings;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;
        var firstIndex = 0;
        var lastIndex = s.Length - 1;

        while (true)
        {
            if (firstIndex > lastIndex)
                break;
            if (!char.IsLetterOrDigit(s[firstIndex]))
            {
                firstIndex++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[lastIndex]))
            {
                lastIndex--;
                continue;
            }

            if (char.ToLowerInvariant(s[firstIndex]) != char.ToLowerInvariant(s[lastIndex]))
                return false;
            firstIndex++;
            lastIndex--;
        }

        return true;
    }

    public void Test()
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(char.IsLetter('0'));
        Console.WriteLine(char.IsLetterOrDigit('0'));
    }
}