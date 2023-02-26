using System;

namespace LeetCode.Easy.Bits;

public class NumberOf1Bits
{
    public int HammingWeight(uint n)
    {
        uint cursor = 1;
        var counter = 0;
        for (int i = 0; i < 32; i++)
        {
            uint c = n & cursor;
            if (c!=0)
                counter++;
            cursor <<=1;
        }

        return counter;
    }
    
    public int HammingWeightBetter(uint n)
    {
        int counter = 0;
        for (int i = 0; i < 32; i++)
        {
            uint c = n & 1;
            if (c!=0)
                counter++;
            n >>=1;
        }

        return counter;
    }

    public void Test()
    {
        Console.WriteLine(HammingWeightBetter(10));
    }
}