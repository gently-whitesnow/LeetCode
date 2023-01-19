using System;
using System.Linq;

namespace LeetCode.Medium;

public class FlipStringToMonotoneIncreasing
{
    public int MinFlipsMonoIncr(string s)
    {
        var array = new int[s.Length];
        var ones = 0;
        var zeros = 0;
        for (var i = 0; i < s.Length; i++)
        {
            array[i] += ones;
            
            if(s[i]=='1')
                ones++;
        }

        for (int i = s.Length - 1; i >= 0; i--)
        {
            array[i] += zeros;
            
            if(s[i]=='0')
                zeros++;
        }

        return array.Min();
    }
    
    public int MinFlipsMonoIncrBest(string s)
    {
        var m = 0;

        foreach (var c in s)
        {
            if (c == '0')
                m++;
        }

        var ans = m;
        foreach (var c in s)
        {
            if (c == '0')
            {
                ans = Math.Min(ans,--m);
            }
            else
            {
                m++;
            }
        }

        return ans;
    }
    
    public void Test()
    {
        // количество единиц в левой части и количество нулей в правой части должно быть минимальным
        // 0+2
        // 0+2
        // 0+1
        // 1+1
        // 2+0
        Console.WriteLine(MinFlipsMonoIncr("00110"));
        // 0+2
        // 0+2
        // 1+1
        // 1+1
        // 2+1
        // 3+0
        Console.WriteLine(MinFlipsMonoIncr("010110"));
        Console.WriteLine(MinFlipsMonoIncr("00011000"));
    }
}