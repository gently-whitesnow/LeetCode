using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

//Given an integer array nums where the elements are sorted in ascending order, convert it to a 
// height-balanced binary search tree.
public class ConvertSortedArrayToBinarySearchTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBSTRecursive(nums, 0, nums.Length - 1);

        TreeNode SortedArrayToBSTRecursive(int[] nums, int start, int end)
        {
            var range = end - start;
            if (range <= 1)
                return new TreeNode
                {
                    val = nums[end],
                    left = end == start ? null : SortedArrayToBSTRecursive(nums, start, start)
                };
            
            var median = CalculateBSTMedian(start, end);

            return new TreeNode
            {
                val = nums[median],
                left = SortedArrayToBSTRecursive(nums, start, median - 1),
                right = SortedArrayToBSTRecursive(nums, median + 1, end)
            };
        }

        int CalculateBSTMedian(int start, int end)
        {
            if ((end - start) % 2 != 0)
                return (start + end) / 2 + 1;
            return (start + end) / 2;
        }
    }

    public void Test()
    {
        var nums = new int[] {-10, -3, 0, 5, 9};
        PrintTree(SortedArrayToBST(nums));
    }

    public void PrintTree(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine("null");
            return;
        }

        PrintTree(root.left);
        Console.WriteLine(root.val);
        PrintTree(root.right);
    }
}