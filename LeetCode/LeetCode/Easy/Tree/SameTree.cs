using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
public class SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        
        if (p == null || q == null)
            return false;
        
        if (p.val != q.val)
            return false;

        if (!IsSameTree(p.left, q.left))
            return false;

        return IsSameTree(p.right, q.right);
    }

    public void Test()
    {
        var p = new TreeNode(1);
        p.left = new TreeNode(2);
        p.right = new TreeNode(3);

        var q = new TreeNode(1);
        q.left = new TreeNode(2);
        q.right = new TreeNode(3);

        Console.WriteLine(IsSameTree(p, q));
    }
    
    
}