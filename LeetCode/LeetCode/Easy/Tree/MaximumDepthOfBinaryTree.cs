using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

//Given the root of a binary tree, return its maximum depth.
// A binary tree's maximum depth is the number of nodes along the longest path
// from the root node down to the farthest leaf node.

public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        int maxHeight = 0;

        InorderTraversal(root, 0);
        
        return maxHeight;

        void InorderTraversal(TreeNode root, int currentHeight)
        {
            if (root == null)
            {
                maxHeight = System.Math.Max(maxHeight, currentHeight);
                return;
            }
                
            
            InorderTraversal(root.left,currentHeight+1);
            InorderTraversal(root.right,currentHeight+1);
        }
    }
    
    
    public int MaxDepthBetterSolve(TreeNode root)
    {
        if (root == null)
            return 0;
        var leftHeight = MaxDepthBetterSolve(root.left);
        var rightHeight = MaxDepthBetterSolve(root.right);
        return System.Math.Max(leftHeight, rightHeight) + 1;
    }
    
    public void Test()
    {
        var root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);
        
        Console.WriteLine(MaxDepth(root));
    }
}