using System;

namespace LeetCode.Easy;

public class Sqrt
{
    public int Solution(int x)
    {
        if (x <= 0)
            return x;

        return BinarySearch(0, x);

        int BinarySearch(int start, int end)
        {
            if (start > end)
                return 0;

            double middle = (start + end) / 2;

            if (middle * middle <= x && x < (middle + 1) * (middle + 1))
                return (int)middle;

            if (middle * middle > x)
                return BinarySearch(start, (int)middle - 1);
            return BinarySearch((int)middle + 1, end);
        }
    }

    public int SolutionForDummy(int x)
    {
        if (x <= 0)
            return x;
        var c = 1;
        while (x / c >= c)
        {
            c++;
        }

        return c - 1;
    }

    public void Test()
    {
        var x = 2147395599;
        var result = Solution(x);
        Console.WriteLine(result);

        x = 16;
        result = Solution(x);
        Console.WriteLine(result);
    }
}