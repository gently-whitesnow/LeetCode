using System;

namespace LeetCode.Easy.Arrays;

public class TwoSum
{
    public int[] TwoSumSolution(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new[] {0, 0};
    }
    
    
    public void Test()
    {
        int[] nums = new int[] {2, 7, 11, 15};
        int target = 9;
        int[] result = TwoSumSolution(nums, target);
        Console.WriteLine(result[0] + " " + result[1]);
        
        // second test
        nums = new int[] {3, 2, 4};
        target = 6;
        result = TwoSumSolution(nums, target);
        Console.WriteLine(result[0] + " " + result[1]);
        
        // third test
        nums = new int[] {3, 3};
        target = 6;
        result = TwoSumSolution(nums, target);
        Console.WriteLine(result[0] + " " + result[1]);

    }
}