using System;

namespace LeetCode.Easy;

public class SearchInsert
{
    public int Solve(int[] nums, int target)
    {
        return BinarySearch(0, nums.Length-1);
        int BinarySearch(int start, int end)
        {
            if (end - start <= 1)
            {
                if (target <= nums[start])
                    return start;
                if (target < nums[end])
                    return end;
                return end+1;
            }
                
            var median = (start + end) / 2;

            if (nums[median] == target)
                return median;
            
            if (nums[median] > target)
                return BinarySearch(start, median-1);
            
            return BinarySearch(median+1, end);
        }
    }

    public void Test()
    {
        var nums = new[] {1, 3, 5, 6};
        var target = 5;
        var result = Solve(nums, target);
        Console.WriteLine(result);
        
        
        
    }
}