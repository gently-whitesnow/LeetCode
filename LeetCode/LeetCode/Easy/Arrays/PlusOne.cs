using System;

namespace LeetCode.Easy.Arrays;

public class PlusOne
{
    public int[] Solution(int[] digits)
    {
        if (digits.Length == 0)
            return new[] {1};
        
        var index = digits.Length-1;

        return RecursivelyPlus();
        
        int[] RecursivelyPlus()
        {
            if (digits[index] != 9)
            {
                digits[index]++;
                return digits;
            }
            
            digits[index] = 0;
            index -= 1;
            if (index >=0)
            {
                return RecursivelyPlus();
            }

            var newArray = new int[digits.Length + 1];
            newArray[0] = 1;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = digits[i - 1];
            }
            return newArray;
        }
    }

    public void Test()
    {
        var result = Solution(new int[] { 8, 9, 9 });
        Console.WriteLine(string.Join(",", result));
        
        result = Solution(new int[] { 9, 9, 9 });
        Console.WriteLine(string.Join(",", result));
    }
}