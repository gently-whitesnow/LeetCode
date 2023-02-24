using System;

namespace LeetCode.Easy.Arrays;

//Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times.
// You may assume that the majority element always exists in the array.
// Follow-up: Could you solve the problem in linear time and in O(1) space?
public class MajorityElementTask
{
    //[3,2,3]
    public int MajorityElement(int[] nums)
    {
        
        short count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[0] == nums[i])
                count++;
            else
                count--;

            if (count < 0){
                count = 0;
                nums[0] = nums[i];
            }
                
        }

        return nums[0];
    }


    public void Test()
    {
        Console.WriteLine(MajorityElement(new []{2,2,1,1,1,2,2}));
    }
}