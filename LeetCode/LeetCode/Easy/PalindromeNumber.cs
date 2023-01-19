using System;

namespace LeetCode.Easy;

public class PalindromeNumber
{
    // 101010
    bool Solve(int x)
    {
        var str = x.ToString();
        var start = 0;
        var end = str.Length - 1;
        while (start < end)
        {
            if (str[start] != str[end])
                return false;
            end--;
            start++;
        }

        return true;
    }

    public void Test()
    {
        var result = Solve(11);
        Console.WriteLine(result);

        // next test
        result = Solve(101011);
        Console.WriteLine(result);
        
        result = Solve(1010101);
        Console.WriteLine(result);

    }
}