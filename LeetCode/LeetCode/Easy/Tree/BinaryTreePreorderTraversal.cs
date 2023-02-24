using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

public class BinaryTreePreorderTraversal
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var resultList = new List<int>();
        if (root == null)
            return resultList;
        Traversal(root);
        return resultList;
        
        void Traversal(TreeNode root)
        {
            if (root == null)
                return;
            resultList.Add(root.val);
            Traversal(root.left);
            Traversal(root.right);
        }
    }
    
    public IList<int> PreorderTraversalIteratively(TreeNode root)
    {
        var resultList = new List<int>();
        if (root == null)
            return resultList;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count!=0)
        {
            var node = stack.Pop();
            resultList.Add(node.val);
            if(node.right!=null)
                stack.Push(node.right);
            if(node.left!=null)
                stack.Push(node.left);
        }

        return resultList;
    }

    public void Test()
    {
        
    }
}