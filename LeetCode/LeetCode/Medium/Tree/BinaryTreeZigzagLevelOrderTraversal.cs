using System;
using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Medium.Tree;

public class BinaryTreeZigzagLevelOrderTraversal
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var resultList = new List<IList<int>>();
        if (root == null)
            return resultList;
        resultList.Add(new List<int> {root.val});
        var stack = new Stack<(TreeNode, int level)>();
        stack.Push((root, 1));

        while (stack.Count != 0)
        {
            var (node, level) = stack.Pop();
            if (node.left != null)
            {
                if (level >= resultList.Count)
                    resultList.Add(new List<int>());
                if (level % 2 == 1)
                    resultList[level].Insert(0, node.left.val);
                else
                    resultList[level].Add(node.left.val);
            }

            if (node.right != null)
            {
                stack.Push((node.right, level + 1));
                if (level >= resultList.Count)
                    resultList.Add(new List<int>());

                if (level % 2 == 1)
                    resultList[level].Insert(0, node.right.val);
                else
                    resultList[level].Add(node.right.val);
            }

            if (node.left != null)
                stack.Push((node.left, level + 1));
        }

        return resultList;
    }

    // ex [[0],[4,2],[1,3,-1],[8,6,1,5]]
    // 0 | 42 | 13-1 | 6815 | 
    //0 | 42 | 13-1 | 1586 | 
    public void Test()
    {
        //[0,2,4,1,null,3,-1,5,1,null,6,null,8]
        var root = new TreeNode(0)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(1)
                }
            },
            right = new TreeNode(4)
            {
                left = new TreeNode(3)
                {
                    right = new TreeNode(6)
                },
                right = new TreeNode(-1)
                {
                    right = new TreeNode(8)
                }
            },
        };
        var result = ZigzagLevelOrder(root);
        foreach (var list in result)
        {
            foreach (var l in list)
            {
                Console.Write(l);
            }

            Console.Write(" | ");
        }
    }
}