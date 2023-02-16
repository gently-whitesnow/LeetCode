using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

public class PathSum
{
    // Given the root of a binary tree and an integer targetSum,
    // return true if the tree has a root-to-leaf path such that adding up all
    // the values along the path equals targetSum.
    // A leaf is a node with no children.
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;
        if (targetSum - root.val == 0 && root.left == null && root.right == null)
            return true;

        var hasLeft = root.left != null && HasPathSum(root.left, targetSum - root.val);
        var hasRight = root.right != null && HasPathSum(root.right, targetSum - root.val);
        return hasLeft || hasRight;
    }

    public void Test()
    {
        var root = new TreeNode(5)
        {
            left = new TreeNode(4)
            {
                left = new TreeNode(11)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(2),
                }
            },
            right = new TreeNode(8)
        };
        Console.WriteLine(HasPathSum(root, 22));
    }
}