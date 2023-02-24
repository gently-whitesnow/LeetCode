using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Easy.Tree;

public class BinaryTreePostorderTraversal
{
    public IList<int> PostorderTraversal(TreeNode root) {
        var resultList = new List<int>();
        if (root == null)
            return resultList;
        Traversal(root);
        return resultList;
        
        void Traversal(TreeNode root)
        {
            if (root == null)
                return;
            Traversal(root.left);
            Traversal(root.right);
            resultList.Add(root.val);
        }
    }

    public void Test()
    {
        
    }
}