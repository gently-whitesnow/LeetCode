using System;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

//Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsIsSymmetricTree(root.left, root.right);
        
        bool IsIsSymmetricTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
        
            if (p == null || q == null)
                return false;
        
            if (p.val != q.val)
                return false;

            if (!IsIsSymmetricTree(p.left, q.right))
                return false;

            return IsIsSymmetricTree(p.right, q.left);
        }
    }
    
    public void Test()
    {
        var root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);
        
        Console.WriteLine(IsSymmetric(root));
    }
}