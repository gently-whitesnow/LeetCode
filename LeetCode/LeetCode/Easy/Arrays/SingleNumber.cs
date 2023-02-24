using System;

namespace LeetCode.Easy.Arrays;

public class SingleNumber
{
    public int Solution(int[] nums)
    {
        var single = 0;
        foreach (var num in nums)
        {
            single ^= num;
        }

        return single;
    }

    public void Test()
    {
        Console.WriteLine(Solution(new []{1,2,2,4,1,5,5}));
    }
}