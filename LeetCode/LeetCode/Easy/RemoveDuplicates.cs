using System;
using System.Collections.Generic;

namespace LeetCode.Easy;

public class RemoveDuplicates
{
    // [1,1,2]
    public int Solution(int[] nums)
    {
        var set = new HashSet<int>();
        var c = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            if (!set.Contains(n))
            {
                set.Add(n);
                nums[c] = n;
                c++;
            }
        }

        return c;
    }

    public void Test()
    {
        var nums = new[] {1, 1, 2};
        var result = Solution(nums);
        Console.WriteLine(result);
        foreach (var n in nums)
        {
            Console.Write(n);
        }
    }

    int BestSolution(int[] nums)
    {
        int insertIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            // We skip to next index if we see a duplicate element
            if (nums[i - 1] != nums[i])
            {
                /* Storing the unique element at insertIndex index and incrementing
                   the insertIndex by 1 */
                nums[insertIndex] = nums[i];
                insertIndex++;
            }
        }

        return insertIndex;
    }
}