using System;

namespace LeetCode.Easy;

public class KasperVerifyString
{
    bool Solve(string[] str1, string[] str2)
    {
        if (str1.Length < str2.Length)
            (str1, str2) = (str2, str1);
        var twoIndex = 0;
        var thoChar = 0;
        foreach (var firstWord in str1)
        {
            foreach (var firstChar in firstWord)
            {
                if (str2[twoIndex].Length == thoChar)
                {
                    twoIndex++;
                    thoChar = 0;
                }

                if (str2[twoIndex][thoChar] != firstChar)
                {
                    return false;
                }

                thoChar++;
            }
        }

        return true;
    }


    public void Test()
    {
        // test
        Console.WriteLine(Solve(new string[] {"Vasia", "priv", "et"}, new string[] {"Va", "sia", "pri", "ve", "t"}));
        Console.WriteLine(Solve(new string[] {"Va", "sia", "privet"}, new string[] {"Vasiaprivet"}));
        Console.WriteLine(Solve(new string[] {"Va", "sia", "pri vet"}, new string[] {"Vasiapri vet"}));
        Console.WriteLine(Solve(new string[] {"a", "a", "a", "a", "a", "a", "a"}, new string[] {"aa", "a", "aa", "a", "aa"}));
        Console.WriteLine(Solve(new string[] {"aa", "a", "aa", "a", "aa"}, new string[] {"a", "a", "a", "a", "a", "a", "a"}));
    }
}