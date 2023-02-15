using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

public class MinimumDepthOfBinaryTree
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        var left = MinDepth(root.left);
        var right = MinDepth(root.right);
        if (left == 0)
            return right+1;
        if (right == 0)
            return left+1;
        
        return Math.Min(left, right) + 1;
    }

    public void Test()
    {
        var root = new TreeNode(3)
        {
            left = new TreeNode(9),
            right = new TreeNode(20)
            {
                left = new TreeNode(15),
                right = new TreeNode(7)
            }
        };
        Console.WriteLine(MinDepth(root));
    }
}