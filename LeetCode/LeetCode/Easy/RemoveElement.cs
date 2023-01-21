namespace LeetCode.Easy;

public class RemoveElement
{
    public int Solution(int[] nums, int val)
    {
        var index = 0;

        foreach (var n in nums)
        {
            if (n != val)
            {
                nums[index] = n;
                index++;
            }
        }

        return index;
    }

    public void Test()
    {
        
    }
    
}