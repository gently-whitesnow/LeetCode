using System.Collections.Generic;

namespace LeetCode.Easy.Tree;

// Неупорядоченный обход двоичного дерева
public class BinaryTreeInorderTraversal
{
    public IList<int> Solve(TreeNode root)
    {
        var resultList = new List<int>();
        
        InorderTraversal(root);
        return resultList;

        void InorderTraversal(TreeNode root)
        {
            if (root == null)
                return;
            
            InorderTraversal(root.left);
            resultList.Add(root.val);
            InorderTraversal(root.right);
        }
    }

    public void Test()
    {
        var root = new TreeNode(1)
        {
            right = new TreeNode(2)
            {
                left = new TreeNode(3)
            }
        };
        var result = Solve(root);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}