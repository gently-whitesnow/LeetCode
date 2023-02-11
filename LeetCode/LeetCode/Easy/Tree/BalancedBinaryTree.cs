using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

public class BalancedBinaryTree
{
    // n^2 solution
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;
        
        if (Math.Abs(InorderTraversal(root.left) - InorderTraversal(root.right)) > 1)
            return false;
        
        return IsBalanced(root.left) && IsBalanced(root.right);
        
        int InorderTraversal(TreeNode head)
        {
            if (head == null)
                return 0;

            return Math.Max(InorderTraversal(head.left) ,InorderTraversal(head.right)) + 1;
        }
    }
    
    // n^1 solution
    public bool IsBalancedBetter(TreeNode root)
    {
        if (root == null)
            return true;

        return DFSTraversal(root) != -1;
        
        int DFSTraversal(TreeNode head)
        {
            if (head == null)
                return 0;

            var leftHeight = DFSTraversal(head.left);
            if (leftHeight == -1)
                return -1;
            var rightHeight = DFSTraversal(head.right);
            if (rightHeight == -1)
                return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            return Math.Max(leftHeight,rightHeight) + 1;
        }
    }
    
    public void Test()
    {
        var root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);
        
        Console.WriteLine(IsBalancedBetter(root));
        
        root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(3);
        root.left.left.left = new TreeNode(4);
        root.left.left.right = new TreeNode(4);
        Console.WriteLine(IsBalancedBetter(root));
    }
}