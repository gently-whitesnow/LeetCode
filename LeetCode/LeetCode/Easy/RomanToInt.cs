using System.Collections.Generic;

namespace LeetCode.Easy;

public class RomanToInt
{
    public int Solve(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        var dict = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        var sum = 0;
        //"LVIII"
        for (var index = s.Length-1; index >= 0; index--)
        {
            var num = dict[s[index]];
            if (index > 0 && dict[s[index - 1]] < num)
            {
                sum += (num - dict[s[index - 1]]);
                index--;
            }
            else
                sum += num;
        }

        return sum;

    }

    public void Test()
    {
        var s = "MCMXCIV";
        var result = Solve(s);
        System.Console.WriteLine(result);
    }
}